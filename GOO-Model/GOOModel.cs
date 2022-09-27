using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GOO_Model
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class AdditionalProperties
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("items")]
        public Items Items { get; set; }
    }

    public class CancelationStatement
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("properties")]
        public Properties Properties { get; set; }
    }

    public class Certificates
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("properties")]
        public Properties Properties { get; set; }
    }

    public class DateOfCommissioning
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("default")]
        public string Default { get; set; }

        [JsonPropertyName("format")]
        public string Format { get; set; }
    }

    public class DeviceName
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("default")]
        public string Default { get; set; }
    }

    public class Domain
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("default")]
        public string Default { get; set; }
    }

    public class EIP712
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("properties")]
        public Properties Properties { get; set; }

        [JsonPropertyName("required")]
        public List<string> Required { get; set; }
    }

    public class EIP712Domain
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }

    public class FromNumber
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("default")]
        public string Default { get; set; }
    }

    public class Fuel
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("default")]
        public string Default { get; set; }
    }

    public class GuaranteeIssuerIdentifier
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("default")]
        public string Default { get; set; }
    }

    public class GuaranteeIssuerName
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("default")]
        public string Default { get; set; }
    }

    public class GuaranteeIssuerValidator
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("default")]
        public string Default { get; set; }
    }

    public class GuaranteeOfOriginIssuer
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("properties")]
        public Properties Properties { get; set; }
    }

    public class InstalledCapacity
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("default")]
        public string Default { get; set; }
    }

    public class IssuingDate
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("format")]
        public string Format { get; set; }

        [JsonPropertyName("default")]
        public string Default { get; set; }
    }

    public class Items
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("properties")]
        public Properties Properties { get; set; }

        [JsonPropertyName("required")]
        public List<string> Required { get; set; }
    }

    public class LocationOfProductionDevice
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("default")]
        public string Default { get; set; }
    }

    public class Message
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }

    public class Name
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }

    public class OperatorAddress
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("default")]
        public string Default { get; set; }
    }

    public class OperatorName
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("default")]
        public string Default { get; set; }
    }

    public class PrimaryType
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }

    public class ProductionDevice
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("properties")]
        public Properties Properties { get; set; }
    }

    public class ProductionDeviceDomain
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("default")]
        public string Default { get; set; }
    }

    public class ProductionDeviceFuel
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("default")]
        public string Default { get; set; }
    }

    public class ProductionDeviceGSRN
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("default")]
        public string Default { get; set; }
    }

    public class ProductionDeviceTechnology
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("default")]
        public string Default { get; set; }
    }

    public class ProductionPeriodFrom
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("format")]
        public string Format { get; set; }

        [JsonPropertyName("default")]
        public string Default { get; set; }
    }

    public class ProductionPeriodTo
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("format")]
        public string Format { get; set; }

        [JsonPropertyName("default")]
        public string Default { get; set; }
    }

    public class Proof
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("format")]
        public string Format { get; set; }

        [JsonPropertyName("default")]
        public string Default { get; set; }
    }

    public class Properties
    {
        [JsonPropertyName("transactionDate")]
        public TransactionDate TransactionDate { get; set; }

        [JsonPropertyName("transactionNumber")]
        public TransactionNumber TransactionNumber { get; set; }

        [JsonPropertyName("transactionStatus")]
        public TransactionStatus TransactionStatus { get; set; }

        [JsonPropertyName("totalGO")]
        public TotalGO TotalGO { get; set; }

        [JsonPropertyName("totalAmount")]
        public TotalAmount TotalAmount { get; set; }

        [JsonPropertyName("Certificates")]
        public Certificates Certificates { get; set; }

        [JsonPropertyName("GuaranteeOfOriginIssuer")]
        public GuaranteeOfOriginIssuer GuaranteeOfOriginIssuer { get; set; }

        [JsonPropertyName("ProductionDevice")]
        public ProductionDevice ProductionDevice { get; set; }

        [JsonPropertyName("swarmHash")]
        public SwarmHash SwarmHash { get; set; }

        [JsonPropertyName("proof")]
        public Proof Proof { get; set; }

        [JsonPropertyName("signature")]
        public Signature Signature { get; set; }

        [JsonPropertyName("EIP712")]
        public EIP712 EIP712 { get; set; }

        [JsonPropertyName("fromNumber")]
        public FromNumber FromNumber { get; set; }

        [JsonPropertyName("toNumber")]
        public ToNumber ToNumber { get; set; }

        [JsonPropertyName("volume")]
        public Volume Volume { get; set; }

        [JsonPropertyName("domain")]
        public Domain Domain { get; set; }

        [JsonPropertyName("fuel")]
        public Fuel Fuel { get; set; }

        [JsonPropertyName("technology")]
        public Technology Technology { get; set; }

        [JsonPropertyName("issuingDate")]
        public IssuingDate IssuingDate { get; set; }

        [JsonPropertyName("productionPeriodFrom")]
        public ProductionPeriodFrom ProductionPeriodFrom { get; set; }

        [JsonPropertyName("productionPeriodTo")]
        public ProductionPeriodTo ProductionPeriodTo { get; set; }

        [JsonPropertyName("tradingScheme")]
        public TradingScheme TradingScheme { get; set; }

        [JsonPropertyName("supportScheme")]
        public SupportScheme SupportScheme { get; set; }

        [JsonPropertyName("guaranteeIssuerName")]
        public GuaranteeIssuerName GuaranteeIssuerName { get; set; }

        [JsonPropertyName("guaranteeIssuerIdentifier")]
        public GuaranteeIssuerIdentifier GuaranteeIssuerIdentifier { get; set; }

        [JsonPropertyName("guaranteeIssuerValidator")]
        public GuaranteeIssuerValidator GuaranteeIssuerValidator { get; set; }

        [JsonPropertyName("deviceName")]
        public DeviceName DeviceName { get; set; }

        [JsonPropertyName("productionDeviceGSRN")]
        public ProductionDeviceGSRN ProductionDeviceGSRN { get; set; }

        [JsonPropertyName("productionDeviceDomain")]
        public ProductionDeviceDomain ProductionDeviceDomain { get; set; }

        [JsonPropertyName("installedCapacity")]
        public InstalledCapacity InstalledCapacity { get; set; }

        [JsonPropertyName("dateOfCommissioning")]
        public DateOfCommissioning DateOfCommissioning { get; set; }

        [JsonPropertyName("locationOfProductionDevice")]
        public LocationOfProductionDevice LocationOfProductionDevice { get; set; }

        [JsonPropertyName("operatorName")]
        public OperatorName OperatorName { get; set; }

        [JsonPropertyName("operatorAddress")]
        public OperatorAddress OperatorAddress { get; set; }

        [JsonPropertyName("productionDeviceTechnology")]
        public ProductionDeviceTechnology ProductionDeviceTechnology { get; set; }

        [JsonPropertyName("productionDeviceFuel")]
        public ProductionDeviceFuel ProductionDeviceFuel { get; set; }

        [JsonPropertyName("types")]
        public Types Types { get; set; }

        [JsonPropertyName("primaryType")]
        public PrimaryType PrimaryType { get; set; }

        [JsonPropertyName("message")]
        public Message Message { get; set; }

        [JsonPropertyName("EIP712Domain")]
        public EIP712Domain EIP712Domain { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("type")]
        public Type Type { get; set; }
    }

    public class Root
    {
        [JsonPropertyName("CancelationStatement")]
        public CancelationStatement CancelationStatement { get; set; }
    }

    public class Signature
    {
        [JsonPropertyName("signatureOwner")]
        public SignatureOwner SignatureOwner { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("format")]
        public string Format { get; set; }

        [JsonPropertyName("default")]
        public string Default { get; set; }
    }

    public class SignatureOwner
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("default")]
        public string Default { get; set; }
    }

    public class SupportScheme
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("default")]
        public string Default { get; set; }
    }

    public class SwarmHash
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("default")]
        public string Default { get; set; }

        [JsonPropertyName("format")]
        public string Format { get; set; }
    }

    public class Technology
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("default")]
        public string Default { get; set; }
    }

    public class ToNumber
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("default")]
        public string Default { get; set; }
    }

    public class TotalAmount
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("default")]
        public string Default { get; set; }
    }

    public class TotalGO
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("default")]
        public string Default { get; set; }
    }

    public class TradingScheme
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("default")]
        public string Default { get; set; }
    }

    public class TransactionDate
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("format")]
        public string Format { get; set; }

        [JsonPropertyName("default")]
        public string Default { get; set; }
    }

    public class TransactionNumber
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("default")]
        public string Default { get; set; }
    }

    public class TransactionStatus
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("default")]
        public string Default { get; set; }
    }

    public class Type
    {
        [JsonPropertyName("type")]
        public string type { get; set; }
    }

    public class Types
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("properties")]
        public Properties Properties { get; set; }

        [JsonPropertyName("additionalProperties")]
        public AdditionalProperties AdditionalProperties { get; set; }

        [JsonPropertyName("required")]
        public List<string> Required { get; set; }
    }

    public class Volume
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("default")]
        public string Default { get; set; }
    }


}
