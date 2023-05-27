using System;
using System.IO;
using System.Net;
using System.Text;
using System.Xml;

namespace OBL.BIC.ServiceDependencies
{
    public class WebUtility
    {
        #region ***** Private Methods *****
        private string DisplayInText(string XML)
        {
            string Result = "";
            MemoryStream MS = new MemoryStream();
            XmlTextWriter W = new XmlTextWriter(MS, Encoding.Unicode);
            XmlDocument D = new XmlDocument();

            try
            {
                // Load the XmlDocument with the XML.
                D.LoadXml(XML);
                W.Formatting = System.Xml.Formatting.Indented;

                // Write the XML into a formatting XmlTextWriter
                D.WriteContentTo(W);
                W.Flush();
                MS.Flush();

                // Have to rewind the MemoryStream in order to read
                // its contents.
                MS.Position = 0;

                // Read MemoryStream contents into a StreamReader.
                StreamReader SR = new StreamReader(MS);

                // Extract the text from the StreamReader.
                String FormattedXML = SR.ReadToEnd();

                Result = FormattedXML;
            }
            catch (XmlException)
            {
            }

            MS.Close();
            W.Close();

            return Result;
        }
        #endregion

        #region ***** Public Methods *****
        public string WebAPIRequest(string UrlString, string TransactionString, ref string ErrorDescription)
        {
            CookieContainer CookieCont = new CookieContainer();
            HttpWebRequest req;
            try
            {
                req = (HttpWebRequest)HttpWebRequest.Create(UrlString);
            }
            catch (Exception err)
            {
                ErrorDescription = "Error: " + err.Message;
                return null;
            }

            //   req.ProtocolVersion = HttpVersion.Version10;
            req.AllowAutoRedirect = true;
            req.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.0; .NET CLR 1.1.4322)";
            req.CookieContainer = CookieCont;
            req.Accept = "text/xml";
            req.Method = "POST";
            req.ContentType = "text/xml; charset=utf-8";
            //--------------addded------
            req.Credentials = CredentialCache.DefaultCredentials;

            // add any post variables
            byte[] postDataBytes = Encoding.UTF8.GetBytes(TransactionString);
            req.ContentLength = postDataBytes.Length;

            Stream postDataStream = req.GetRequestStream();
            postDataStream.Write(postDataBytes, 0, postDataBytes.Length);
            postDataStream.Close();

            string result;
            using (HttpWebResponse response = (HttpWebResponse)req.GetResponse())
            {
                using (StreamReader rd = new StreamReader(response.GetResponseStream()))
                {
                    result = rd.ReadToEnd();
                }
            }
            result = DisplayInText(result.ToString().Trim());
            return result;
        }
        public string WebAPIRequestGET(string UrlString, string TransactionString, ref string ErrorDescription)
        {
            CookieContainer CookieCont = new CookieContainer();
            HttpWebRequest req;
            try
            {
                req = (HttpWebRequest)HttpWebRequest.Create(UrlString);
            }
            catch (Exception err)
            {
                ErrorDescription = "Error: " + err.Message;
                return null;
            }

            //   req.ProtocolVersion = HttpVersion.Version10;
            req.AllowAutoRedirect = true;
            req.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.0; .NET CLR 1.1.4322)";
            req.CookieContainer = CookieCont;
            req.Accept = "text/xml";
            req.Method = "GET";
            req.ContentType = "text/xml; charset=utf-8";
            //--------------addded------
            req.Credentials = CredentialCache.DefaultCredentials;

            // add any post variables
            byte[] postDataBytes = Encoding.UTF8.GetBytes(TransactionString);
            req.ContentLength = postDataBytes.Length;

            //using (WebResponse response = request.GetResponse())
            //{
            //    using (Stream stream = response.GetResponseStream())
            //    {
            //        XmlTextReader reader = new XmlTextReader(stream);

            //    }

            Stream postDataStream = req.GetRequestStream();
            postDataStream.Write(postDataBytes, 0, postDataBytes.Length);
            postDataStream.Close();

            string result;
            using (HttpWebResponse response = (HttpWebResponse)req.GetResponse())
            {
                using (StreamReader rd = new StreamReader(response.GetResponseStream()))
                {
                    result = rd.ReadToEnd();
                }
            }
            result = DisplayInText(result.ToString().Trim());
            return result;
        }
        public string GetValueFromXMLString(string XMLString, string FieldName, ref string Message)
        {
            try
            {

                XmlDocument document = new XmlDocument();
                document.LoadXml(XMLString);
                string returnValue = "";
                returnValue = document.GetElementsByTagName(FieldName)[0].InnerXml;
                return returnValue; //<== writes out 9.
            }
            catch (Exception errorException)
            {
                if (errorException.Message.Contains("Object reference not set to an instance of an object."))
                    return "Error: Field Not found";
                else
                    return "Error : " + errorException.Message;
            }

        }
        #endregion
    }
}
