using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace GOOUploader.Controllers
{
    /// <summary>
    /// Controller to upload / download data from Bee
    /// </summary>
    [ApiController]
    //[Route("[controller]")]
    [Route("GOOCS")]
    public class GOOCSUploaderController : ControllerBase
    {
        /// <summary>
        /// Specify bee location
        /// </summary>
        const string beeUri = "http://localhost:1633";
        /// <summary>
        /// Cancelation Statement version
        /// </summary>
        const string version = "1.0";
        /// <summary>
        /// Development swarm batchId
        /// </summary>
        const string batchId = "45c2dc7aea66e11fd7de02b34bf89c63f9370b148b6d93e856685d553c10514d"; 

        private readonly ILogger<GOOCSUploaderController> _logger;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="logger"></param>
        public GOOCSUploaderController(ILogger<GOOCSUploaderController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get contents of file as string name=FILENAME&file=URLENCODED_STRING
        /// </summary>
        /// <param name="reference"></param>
        /// <returns></returns>
        [HttpGet("GetContentsFor")]
        public async Task<string> GetContentsFromReference(string reference)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(beeUri + "/bzz/" + reference);
            this.HttpContext.Response.StatusCode = (int)response.StatusCode;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return await response.Content.ReadAsStringAsync();
            }
            
            return null;
        }

        /// <summary>
        /// Test Upload data to Bee, with default batchId (will not work outside test environment)
        /// </summary>
        /// <param name="textData"></param>
        /// <returns>content location</returns>
        [HttpPut("Test")]
        public async Task<string> Put(string text) 
        {
            var name = "test.json";
            return await UploadFileData(name, text, batchId);
        }


        /// <summary>
        /// Download GOO Cancelation statement from Bee
        /// </summary>
        /// <param name="hash"></param>
        /// <returns>CancelationStatement
        /// and Return Code of Request</returns>
        [HttpGet("Get")]
        public async Task<GOO_Model.CancelationStatement> GetGOOCS(string reference)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(beeUri + "/bzz/" + reference);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string data = await response.Content.ReadAsStringAsync(); // serialize to object from hash -- 8644bd7012eb6c14e43a8cd365da0d78d11b58e1773ba83ca441108de98a36b7 
                int idx = data.IndexOf("&file=");
                string fileContents = data.Remove(0, idx + 6);
                var contents = System.Web.HttpUtility.UrlDecode(fileContents);
                Console.WriteLine(contents);

                return JsonSerializer.Deserialize<GOO_Model.CancelationStatement>(contents);
            }

            this.HttpContext.Response.StatusCode = (int)response.StatusCode;
            Console.Write(response.Content);
            return null;
        }


        /// <summary>
        /// Upload GOO Cancelation Statement to bee
        /// </summary>
        /// <param name="cancelationStatement"></param>
        /// <param name="swarmBatchId"></param>
        /// <returns>reference</returns>
        [HttpPost("Post")]
        public async Task<string> PostGOOCS(GOO_Model.CancelationStatement cancelationStatement, string swarmBatchId)
        {
            DateTime now = DateTime.UtcNow;
            long unixTimeMilliseconds = new DateTimeOffset(now).ToUnixTimeMilliseconds();
            var name = "EX.GOOCS." + unixTimeMilliseconds + ".v" + version + ".json";

            var data = JsonSerializer.Serialize(cancelationStatement);

            return await UploadFileData(name, data, swarmBatchId);
        }


        /// <summary>
        /// Upload text to bee with filename and batchId
        /// </summary>
        /// <param name="name">Filename to be used</param>
        /// <param name="data">Contents of text file</param>
        /// <param name="swarmBatchId">Batch Id</param>
        /// <returns></returns>
        [HttpPost("UploadFile")]
        public async Task<string> UploadFileData(string name, string data, string swarmBatchId) 
        {
            HttpClient client = new HttpClient();

            var form = new List<KeyValuePair<string, string>>();
            form.Add(new KeyValuePair<string, string>("name", name));
            form.Add(new KeyValuePair<string, string>("file", data));
            client.DefaultRequestHeaders.Add("swarm-postage-batch-id", swarmBatchId);

            var formContent = new FormUrlEncodedContent(form);

            var response = await client.PostAsync(beeUri + "/bzz", formContent);

            this.HttpContext.Response.StatusCode = (int)response.StatusCode;
            if (response.StatusCode == System.Net.HttpStatusCode.Created)
            {
                return response.Headers.ETag.Tag.Replace("\"",""); // return ETag.Tag only (double qouted)
            }

            return null; // failure
        }
    }
}
