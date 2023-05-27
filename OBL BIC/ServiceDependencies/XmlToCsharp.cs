
using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace OBL.BIC.ServiceDependencies
{
    [XmlRoot(ElementName = "element", Namespace = "http://www.w3.org/2001/XMLSchema")]
    public class Element
    {
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "minOccurs")]
        public string MinOccurs { get; set; }
    }

    [XmlRoot(ElementName = "sequence", Namespace = "http://www.w3.org/2001/XMLSchema")]
    public class Sequence
    {
        [XmlElement(ElementName = "element", Namespace = "http://www.w3.org/2001/XMLSchema")]
        public List<Element> Element { get; set; }
    }

    [XmlRoot(ElementName = "complexType", Namespace = "http://www.w3.org/2001/XMLSchema")]
    public class ComplexType
    {
        [XmlElement(ElementName = "sequence", Namespace = "http://www.w3.org/2001/XMLSchema")]
        public Sequence Sequence { get; set; }
    }

    [XmlRoot(ElementName = "choice", Namespace = "http://www.w3.org/2001/XMLSchema")]
    public class Choice
    {
        [XmlElement(ElementName = "element", Namespace = "http://www.w3.org/2001/XMLSchema")]
        public Element Element { get; set; }
        [XmlAttribute(AttributeName = "minOccurs")]
        public string MinOccurs { get; set; }
        [XmlAttribute(AttributeName = "maxOccurs")]
        public string MaxOccurs { get; set; }
    }

    [XmlRoot(ElementName = "schema", Namespace = "http://www.w3.org/2001/XMLSchema")]
    public class Schema
    {
        [XmlElement(ElementName = "element", Namespace = "http://www.w3.org/2001/XMLSchema")]
        public Element Element { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlAttribute(AttributeName = "xs", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xs { get; set; }
        [XmlAttribute(AttributeName = "msdata", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Msdata { get; set; }
    }

    [XmlRoot(ElementName = "DT")]
    public class DT
    {
        [XmlElement(ElementName = "appId")]
        public string AppId { get; set; }
        [XmlElement(ElementName = "Id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "id", Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1")]
        public string _Id { get; set; }
        [XmlElement(ElementName = "UserID")]
        public string UserID { get; set; }
        [XmlElement(ElementName = "Name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "Type")]
        public string Type { get; set; }
        [XmlElement(ElementName = "BranchID")]
        public string BranchID { get; set; }
        [XmlElement(ElementName = "EmployeeID")]
        public string EmployeeID { get; set; }
        [XmlElement(ElementName = "JobTitle")]
        public string JobTitle { get; set; }
        [XmlElement(ElementName = "MobilePhone")]
        public string MobilePhone { get; set; }
        [XmlElement(ElementName = "EMAIL")]
        public string EMAIL { get; set; }
        [XmlElement(ElementName = "CreatedOn")]
        public string CreatedOn { get; set; }
        [XmlElement(ElementName = "CreatedBy")]
        public string CreatedBy { get; set; }
        [XmlElement(ElementName = "ModifiedOn")]
        public string ModifiedOn { get; set; }
        [XmlElement(ElementName = "ModifiedBy")]
        public string ModifiedBy { get; set; }
        [XmlElement(ElementName = "IsActive")]
        public string IsActive { get; set; }
        [XmlElement(ElementName = "PreDept")]
        public string PreDept { get; set; }
        [XmlElement(ElementName = "PreDeptName")]
        public string PreDeptName { get; set; }
        [XmlElement(ElementName = "PreDesignation")]
        public string PreDesignation { get; set; }
        [XmlElement(ElementName = "Password")]
        public string Password { get; set; }
        [XmlElement(ElementName = "PreDesgName")]
        public string PreDesgName { get; set; }
        [XmlElement(ElementName = "BranchName")]
        public string BranchName { get; set; }
        [XmlElement(ElementName = "BranchCode")]
        public string BranchCode { get; set; }
        [XmlAttribute(AttributeName = "rowOrder", Namespace = "urn:schemas-microsoft-com:xml-msdata")]
        public string RowOrder { get; set; }
    }

    [XmlRoot(ElementName = "DocumentElement")]
    public class DocumentElement
    {
        [XmlElement(ElementName = "DT")]
        public DT DT { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }

    [XmlRoot(ElementName = "diffgram", Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1")]
    public class Diffgram
    {
        [XmlElement(ElementName = "DocumentElement")]
        public DocumentElement DocumentElement { get; set; }
        [XmlAttribute(AttributeName = "msdata", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Msdata { get; set; }
        [XmlAttribute(AttributeName = "diffgr", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Diffgr { get; set; }
    }

    [XmlRoot(ElementName = "GetAllUserResult", Namespace = "http://onebank.com.bd/")]
    public class GetAllUserResult
    {
        [XmlElement(ElementName = "schema", Namespace = "http://www.w3.org/2001/XMLSchema")]
        public Schema Schema { get; set; }
        [XmlElement(ElementName = "diffgram", Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1")]
        public Diffgram Diffgram { get; set; }
    }

    [XmlRoot(ElementName = "GetAllUserResponse", Namespace = "http://onebank.com.bd/")]
    public class GetAllUserResponse
    {
        [XmlElement(ElementName = "GetAllUserResult", Namespace = "http://onebank.com.bd/")]
        public GetAllUserResult GetAllUserResult { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
    }

    [XmlRoot(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class Body
    {
        [XmlElement(ElementName = "GetAllUserResponse", Namespace = "http://onebank.com.bd/")]
        public GetAllUserResponse GetAllUserResponse { get; set; }
    }

    [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class Envelope
    {
        [XmlElement(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public Body Body { get; set; }
        [XmlAttribute(AttributeName = "soap", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Soap { get; set; }
        [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsi { get; set; }
        [XmlAttribute(AttributeName = "xsd", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsd { get; set; }
    }

}

