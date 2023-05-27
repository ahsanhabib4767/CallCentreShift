using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace OBL.BIC.ServiceDependencies
{
    //Further Extension For Service

    public class UsersObject
    {
        [Key]
        public string ID { get; set; }
        public string Name { get; set; }
        public string UserPassword { get; set; }
        public string UserProfileID { get; set; }
        public string UserGroupID { get; set; }
        public string BranchCode { get; set; }
        public bool Status { get; set; }
        public bool IsOnline { get; set; }
        public bool IsLocked { get; set; }
        public int LoginTryCounter { get; set; }
        public bool IsChangePassword { get; set; }
        public DateTime LastActivityDate { get; set; }
        public string Creator { get; set; }
        public DateTime CreationDate { get; set; }
        public string Modifier { get; set; }
        public string ModificationDate { get; set; }


    }
    public class UsersObjectView
    {
        [Key]
        public string ID { get; set; }
        public string Name { get; set; }
        public string UserPassword { get; set; }
        public string UserProfileID { get; set; }
        public string UserGroupID { get; set; }
        public string UserGroupName { get; set; }
        public bool Status { get; set; }
        public bool IsOnline { get; set; }
        public bool IsLocked { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public int LoginTryCounter { get; set; }
        public bool IsChangePassword { get; set; }
        public DateTime LastActivityDate { get; set; }
    }
    public class OBLUserObjectView
    {

        public string ID { get; set; }
        [Key]
        public string UserID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string BranchID { get; set; }
        public string Code { get; set; }
        public string Designation { get; set; }
        public string MobilePhone { get; set; }
        public string Oblemail { get; set; }

        public string PreDept { get; set; }
        public string Department { get; set; }
        public string PreDesignation { get; set; }
        public string Branchcode { get; set; }
        public string Branchname { get; set; }
        public string IsActive { get; set; }
        public DateTime LastActivityDate { get; set; }
    }




    public class OBLAllUserObjectView
    {

        public string Code { get; set; }
        public string Name { get; set; }
        public string Branchname { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string Oblemail { get; set; }
        public string Branchcode { get; set; }

        public string Isactive { get; set; }

    }

    //[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class Root
    {
        //[JsonProperty("@diffgr:id")]
        public string DiffgrId { get; set; }

        //[JsonProperty("@msdata:rowOrder")]
        public string MsdataRowOrder { get; set; }
        public string appId { get; set; }
        [JsonProperty("Id")]
        public string Id { get; set; }
        public string UserID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string BranchID { get; set; }
        [JsonProperty("EmployeeID")]
        public string Code { get; set; }
        public string JobTitle { get; set; }
        public object MobilePhone { get; set; }
        [JsonProperty("EMAIL")]
        public string Oblemail { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public string IsActive { get; set; }
        public string PreDept { get; set; }
        [JsonProperty("PreDeptName")]
        public string Department { get; set; }
        public string PreDesignation { get; set; }
        public string Password { get; set; }
        [JsonProperty("PreDesgName")]
        public string Designation { get; set; }
        [JsonProperty("BranchName")]
        public string Branchname { get; set; }
        [JsonProperty("BranchCode")]
        public string Branchcode { get; set; }
    }

    public class OBLAllEmpEmail
    {

        public string Code { get; set; }
        public string Name { get; set; }
        public string Oblemail { get; set; }
        public string Designation { get; set; }
    }

    public class OBLAllEmpEmailRoot
    {

        public string EmployeeID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Designation { get; set; }
    }

}
