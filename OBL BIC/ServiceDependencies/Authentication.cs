
using System;
using System.Data;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using Newtonsoft.Json;
using OBL.BIC.ServiceDependencies;

namespace OBL.BIC.ServiceDependencies
{
    public class Authentication
    {
        #region ***** Private variable and instance declaration *****
        private readonly WebUtility webUtility = new WebUtility();
        private readonly string userSearchString = @"<?xml version=""1.0"" encoding=""utf-8""?>
                                    <soap:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">
                                      <soap:Body>
                                        <GetByUserID xmlns =""http://onebank.com.bd/"">
                                          <UserID>{0}</UserID>
                                        </GetByUserID>
                                      </soap:Body>
                                    </soap:Envelope>";
        private readonly string userAuthenticationString = @"<?xml version=""1.0"" encoding=""utf-8""?>
                                    <soap:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">
                                      <soap:Body>
                                            <GetByUserIDCheck xmlns=""http://onebank.com.bd/"">
                                              <UserID>{0}</UserID>
                                              <password>{1}</password>
                                            </GetByUserIDCheck>
                                          </soap:Body>
                                    </soap:Envelope>";
        private readonly string apiWebAddress = string.Empty;
        private readonly string userSearchByEmail = @"<?xml version=""1.0"" encoding=""utf-8""?>
                                    <soap:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">
                                      <soap:Body>
                                            <GetByUserEMailID xmlns=""http://onebank.com.bd/"">                                                                                            
                                              <EMailID>{0}</EMailID>
                                            </GetByUserEMailID>
                                          </soap:Body>
                                    </soap:Envelope>";
        private readonly string getAllUserDetails = @"<?xml version=""1.0"" encoding=""utf-8""?>
                                    <soap:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soap=""http://schemas.xmlsoap.org/soap/envelope/"">
                                      <soap:Body>
                                            <GetAllUser xmlns=""http://onebank.com.bd/"" />                                                                                            
                                          </soap:Body>
                                    </soap:Envelope>";

        private readonly string GetAllEmailIdDetails = @"<?xml version=""1.0"" encoding=""utf-8""?>
                                                        <soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:tem=""http://tempuri.org/"">
                                                           <soapenv:Header/>
                                                           <soapenv:Body>
                                                              <tem:GetAllEmailId/>
                                                           </soapenv:Body>
                                                        </soapenv:Envelope>";

        private readonly string userEmailString = @"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:oneb=""http://onebank.com.bd/"">
                                                   <soapenv:Header/>
                                                   <soapenv:Body>
                                                      <oneb:GetAllEmailId/>
                                                   </soapenv:Body>
                                                </soapenv:Envelope>";


        #endregion

        #region ***** Constructor *****
        public Authentication(string WebAddress)
        {
            apiWebAddress = WebAddress;
        }
        #endregion

        #region ***** Public Methods *****

        public List<OBLAllEmpEmail> GetAllEmpEmail()
        {
            try
            {
                OBLAllEmpEmail oOBLAllEmpEmail = new OBLAllEmpEmail();
                string replayString = string.Empty;
                string message = string.Format(userEmailString, "", "");
                string profileXMLString = webUtility.WebAPIRequest(apiWebAddress, message, ref replayString);
                var doc = XDocument.Parse(profileXMLString);
                XmlDocument docfinal = new XmlDocument();
                //docfinal.LoadXml(doc);
                docfinal.LoadXml(profileXMLString);
                string json = JsonConvert.SerializeXmlNode(docfinal);
                json = json.Substring(json.IndexOf('[') + 1);
                json = json.Substring(json.IndexOf('[') + 1);
                json = json.Substring(0, json.LastIndexOf("]"));
                json = "[" + json + "]";

                List<OBLAllEmpEmailRoot> oOblAllEmailList = JsonConvert.DeserializeObject<List<OBLAllEmpEmailRoot>>(json);

                List<OBLAllEmpEmail> allformattedUser = new List<OBLAllEmpEmail>();
                foreach (var item in oOblAllEmailList)
                {
                    if (item.Email != null && item.Email != "")
                    {
                        allformattedUser.Add(new OBLAllEmpEmail
                        {
                            Code = item.EmployeeID,
                            Name = item.Name,
                            Designation = item.Designation,
                            Oblemail = item.Email
                        }


                        );
                    }
                }

                return allformattedUser;

            }
            catch (Exception errorExection)
            {
                return null;
                throw errorExection;
            }

        }


        public List<OBLUserObjectView> userinfo()
        {
            List<OBLAllUserObjectView> userDet = new List<OBLAllUserObjectView>();
            string replayString = string.Empty;
            string message = string.Format(getAllUserDetails, "");
            var profileXMLString = webUtility.WebAPIRequest(apiWebAddress, message, ref replayString);
            var doc = XDocument.Parse(profileXMLString);
            //StreamReader readere = new StreamReader(profileXMLString);
            //string text = reader.ReadToEnd();

            XmlDocument docfinal = new XmlDocument();
            //docfinal.LoadXml(doc);
            docfinal.LoadXml(profileXMLString);
            string json = JsonConvert.SerializeXmlNode(docfinal);
            json = json.Substring(json.IndexOf('[') + 1);
            json = json.Substring(json.IndexOf('[') + 1);
            json = json.Substring(0, json.LastIndexOf("]"));
            json = "[" + json + "]";
            //var movies = (Root)Newtonsoft.Json.JsonConvert.DeserializeObject(json, typeof(Root));
            List<Root> userInfoDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(json);
            List<OBLUserObjectView> allformattedUser = new List<OBLUserObjectView>();

            foreach (var item in userInfoDeserializedClass)
            {
                if (!string.IsNullOrEmpty(item.Oblemail) && !string.IsNullOrEmpty(item.PreDept) && !string.IsNullOrEmpty(item.Department))
                {

                    allformattedUser.Add(new OBLUserObjectView
                    {

                        ID = "0",
                        UserID = item.Code.Trim(),
                        Name = item.Name.Trim(),
                        Type = item.Type.Trim(),
                        BranchID = item.BranchID.Trim(),
                        Code = item.Code.Trim(),
                        Designation = item.JobTitle.Trim(),
                        MobilePhone = " ",//item.MobilePhone.ToString().Trim(),
                        Oblemail = item.Oblemail.Trim(),
                        PreDept = " ",
                        Department = item.Department.Trim(),
                        PreDesignation = item.Designation.Trim(),
                        Branchcode = item.Branchcode.Trim(),
                        Branchname = item.Branchname.Trim(),
                        IsActive = item.IsActive.Trim(),
                        LastActivityDate = item.ModifiedOn
                    });
                }

            }


            return allformattedUser;

        }

        public OBLUserObjectView GetUserProfile(string userID)
        {
            try
            {
                OBLUserObjectView oBLUserObject = new OBLUserObjectView();
                string replayString = string.Empty;
                string message = string.Format(userSearchString, userID);
                string profileXMLString = webUtility.WebAPIRequest(apiWebAddress, message, ref replayString);
                if (!replayString.Contains("Error:"))
                {
                    string dataString = webUtility.GetValueFromXMLString(profileXMLString, "DocumentElement", ref replayString);
                    oBLUserObject.ID = webUtility.GetValueFromXMLString(dataString, "Id", ref replayString);
                    oBLUserObject.UserID = webUtility.GetValueFromXMLString(dataString, "UserID", ref replayString);
                    oBLUserObject.Name = webUtility.GetValueFromXMLString(dataString, "Name", ref replayString);
                    oBLUserObject.Type = webUtility.GetValueFromXMLString(dataString, "Type", ref replayString);
                    oBLUserObject.BranchID = webUtility.GetValueFromXMLString(dataString, "BranchID", ref replayString);
                    oBLUserObject.Code = webUtility.GetValueFromXMLString(dataString, "EmployeeID", ref replayString);
                    oBLUserObject.Designation = webUtility.GetValueFromXMLString(dataString, "PreDesgName", ref replayString);
                    oBLUserObject.MobilePhone = webUtility.GetValueFromXMLString(dataString, "MobilePhone", ref replayString);
                    oBLUserObject.Oblemail = webUtility.GetValueFromXMLString(dataString, "EMAIL", ref replayString);
                    oBLUserObject.PreDept = webUtility.GetValueFromXMLString(dataString, "PreDept", ref replayString);
                    oBLUserObject.Department = webUtility.GetValueFromXMLString(dataString, "PreDeptName", ref replayString);
                    oBLUserObject.PreDesignation = webUtility.GetValueFromXMLString(dataString, "PreDesignation", ref replayString);
                    oBLUserObject.Branchcode = webUtility.GetValueFromXMLString(dataString, "BranchCode", ref replayString);
                    oBLUserObject.Branchname = webUtility.GetValueFromXMLString(dataString, "BranchName", ref replayString);
                    oBLUserObject.IsActive = webUtility.GetValueFromXMLString(dataString, "IsActive", ref replayString);
                    string activeDate = webUtility.GetValueFromXMLString(dataString, "ModifiedOn", ref replayString);
                    oBLUserObject.LastActivityDate = Convert.ToDateTime(activeDate == "" ? "01/01/1900" : activeDate);

                }
                return oBLUserObject;

            }
            catch (Exception errorExection)
            {
                return null;
                throw errorExection;
            }

        }

        public List<OBLUserObjectView> GetUserProfileList(string userID)
        {
            try
            {
                OBLUserObjectView oBLUserObject = new OBLUserObjectView();
                List<OBLUserObjectView> oBLUserObjectsList = new List<OBLUserObjectView>();
                string replayString = string.Empty;
                string message = string.Format(userSearchString, userID);
                string profileXMLString = webUtility.WebAPIRequest(apiWebAddress, message, ref replayString);
                if (!replayString.Contains("Error:"))
                {

                    string dataString = webUtility.GetValueFromXMLString(profileXMLString, "DocumentElement", ref replayString);
                    oBLUserObject.ID = webUtility.GetValueFromXMLString(dataString, "Id", ref replayString);
                    oBLUserObject.UserID = webUtility.GetValueFromXMLString(dataString, "UserID", ref replayString);
                    oBLUserObject.Name = webUtility.GetValueFromXMLString(dataString, "Name", ref replayString);
                    oBLUserObject.Type = webUtility.GetValueFromXMLString(dataString, "Type", ref replayString);
                    oBLUserObject.BranchID = webUtility.GetValueFromXMLString(dataString, "BranchID", ref replayString);
                    oBLUserObject.Code = webUtility.GetValueFromXMLString(dataString, "EmployeeID", ref replayString);
                    oBLUserObject.Designation = webUtility.GetValueFromXMLString(dataString, "PreDesgName", ref replayString);
                    oBLUserObject.MobilePhone = webUtility.GetValueFromXMLString(dataString, "MobilePhone", ref replayString);
                    oBLUserObject.Oblemail = webUtility.GetValueFromXMLString(dataString, "EMAIL", ref replayString);
                    oBLUserObject.PreDept = webUtility.GetValueFromXMLString(dataString, "PreDept", ref replayString);
                    oBLUserObject.Department = webUtility.GetValueFromXMLString(dataString, "PreDeptName", ref replayString);
                    oBLUserObject.PreDesignation = webUtility.GetValueFromXMLString(dataString, "PreDesignation", ref replayString);
                    oBLUserObject.Branchcode = webUtility.GetValueFromXMLString(dataString, "BranchCode", ref replayString);
                    oBLUserObject.Branchname = webUtility.GetValueFromXMLString(dataString, "BranchName", ref replayString);
                    oBLUserObject.IsActive = webUtility.GetValueFromXMLString(dataString, "IsActive", ref replayString);
                    string activeDate = webUtility.GetValueFromXMLString(dataString, "ModifiedOn", ref replayString);
                    oBLUserObject.LastActivityDate = Convert.ToDateTime(activeDate == "" ? "01/01/1900" : activeDate);
                }

                if (oBLUserObject != null)
                {
                    oBLUserObjectsList.Add(oBLUserObject);


                }

                return oBLUserObjectsList;
            }
            catch (Exception errorExection)
            {
                return null;

                throw errorExection;
            }

        }

        public bool CheckUserAuthentication(string userID, string Password)
        {
            try
            {

                string replayString = string.Empty;
                string message = string.Format(userAuthenticationString, userID, Password);
                string profileXMLString = webUtility.WebAPIRequest(apiWebAddress, message, ref replayString);
                string authValue = webUtility.GetValueFromXMLString(profileXMLString, "GetByUserIDCheckResult", ref replayString);
                if (authValue == "Valid")
                    return true;
                else
                    return false;

            }
            catch (Exception errorExection)
            {

                throw errorExection;
            }

        }

        //25-August-2022
        public OBLUserObjectView GetUserProfileByEmail(string userID)
        {
            try
            {
                OBLUserObjectView oBLUserObject = new OBLUserObjectView();
                string replayString = string.Empty;
                string message = string.Format(userSearchByEmail, userID);
                string profileXMLString = webUtility.WebAPIRequest(apiWebAddress, message, ref replayString);
                if (!replayString.Contains("Error:"))
                {
                    string dataString = webUtility.GetValueFromXMLString(profileXMLString, "DocumentElement", ref replayString);
                    oBLUserObject.ID = webUtility.GetValueFromXMLString(dataString, "Id", ref replayString);
                    oBLUserObject.UserID = webUtility.GetValueFromXMLString(dataString, "UserID", ref replayString);
                    oBLUserObject.Name = webUtility.GetValueFromXMLString(dataString, "Name", ref replayString);
                    oBLUserObject.Type = webUtility.GetValueFromXMLString(dataString, "Type", ref replayString);
                    oBLUserObject.BranchID = webUtility.GetValueFromXMLString(dataString, "BranchID", ref replayString);
                    oBLUserObject.Code = webUtility.GetValueFromXMLString(dataString, "EmployeeID", ref replayString);
                    oBLUserObject.Designation = webUtility.GetValueFromXMLString(dataString, "PreDesgName", ref replayString);
                    oBLUserObject.MobilePhone = webUtility.GetValueFromXMLString(dataString, "MobilePhone", ref replayString);
                    oBLUserObject.Oblemail = webUtility.GetValueFromXMLString(dataString, "EMAIL", ref replayString);
                    oBLUserObject.PreDept = webUtility.GetValueFromXMLString(dataString, "PreDept", ref replayString);
                    oBLUserObject.Department = webUtility.GetValueFromXMLString(dataString, "PreDeptName", ref replayString);
                    oBLUserObject.PreDesignation = webUtility.GetValueFromXMLString(dataString, "PreDesignation", ref replayString);
                    oBLUserObject.Branchcode = webUtility.GetValueFromXMLString(dataString, "BranchCode", ref replayString);
                    oBLUserObject.Branchname = webUtility.GetValueFromXMLString(dataString, "BranchName", ref replayString);
                    oBLUserObject.IsActive = webUtility.GetValueFromXMLString(dataString, "IsActive", ref replayString);
                    string activeDate = webUtility.GetValueFromXMLString(dataString, "ModifiedOn", ref replayString);
                    oBLUserObject.LastActivityDate = Convert.ToDateTime(activeDate == "" ? "01/01/1900" : activeDate);
                }
                return oBLUserObject;

            }
            catch (Exception errorExection)
            {

                throw errorExection;
            }

        }


        public List<OBLUserObjectView> GetUserProfileByEmailList(string userID)
        {
            try
            {
                OBLUserObjectView oBLUserObject = new OBLUserObjectView();

                List<OBLUserObjectView> oBLUserObjectsList = new List<OBLUserObjectView>();

                string replayString = string.Empty;
                string message = string.Format(userSearchByEmail, userID);
                string profileXMLString = webUtility.WebAPIRequest(apiWebAddress, message, ref replayString);
                if (!replayString.Contains("Error:"))
                {
                    string dataString = webUtility.GetValueFromXMLString(profileXMLString, "DocumentElement", ref replayString);
                    oBLUserObject.ID = webUtility.GetValueFromXMLString(dataString, "Id", ref replayString);
                    oBLUserObject.UserID = webUtility.GetValueFromXMLString(dataString, "UserID", ref replayString);
                    oBLUserObject.Name = webUtility.GetValueFromXMLString(dataString, "Name", ref replayString);
                    oBLUserObject.Type = webUtility.GetValueFromXMLString(dataString, "Type", ref replayString);
                    oBLUserObject.BranchID = webUtility.GetValueFromXMLString(dataString, "BranchID", ref replayString);
                    oBLUserObject.Code = webUtility.GetValueFromXMLString(dataString, "EmployeeID", ref replayString);
                    oBLUserObject.Designation = webUtility.GetValueFromXMLString(dataString, "PreDesgName", ref replayString);
                    oBLUserObject.MobilePhone = webUtility.GetValueFromXMLString(dataString, "MobilePhone", ref replayString);
                    oBLUserObject.Oblemail = webUtility.GetValueFromXMLString(dataString, "EMAIL", ref replayString);
                    oBLUserObject.PreDept = webUtility.GetValueFromXMLString(dataString, "PreDept", ref replayString);
                    oBLUserObject.Department = webUtility.GetValueFromXMLString(dataString, "PreDeptName", ref replayString);
                    oBLUserObject.PreDesignation = webUtility.GetValueFromXMLString(dataString, "PreDesignation", ref replayString);
                    oBLUserObject.Branchcode = webUtility.GetValueFromXMLString(dataString, "BranchCode", ref replayString);
                    oBLUserObject.Branchname = webUtility.GetValueFromXMLString(dataString, "BranchName", ref replayString);
                    oBLUserObject.IsActive = webUtility.GetValueFromXMLString(dataString, "IsActive", ref replayString);
                    string activeDate = webUtility.GetValueFromXMLString(dataString, "ModifiedOn", ref replayString);
                    oBLUserObject.LastActivityDate = Convert.ToDateTime(activeDate == "" ? "01/01/1900" : activeDate);
                }

                //list return
                if (oBLUserObject != null)
                {
                    oBLUserObjectsList.Add(oBLUserObject);
                }
                return oBLUserObjectsList;

            }
            catch (Exception errorExection)
            {

                throw errorExection;
            }

        }


        public bool CheckUserRegistration(string UserName)
        {
            try
            {
                bool replayValue = false;
                replayValue = true;
                return replayValue;

            }
            catch (Exception errorExection)
            {

                throw errorExection;
            }

        }
        #endregion

    }


}
