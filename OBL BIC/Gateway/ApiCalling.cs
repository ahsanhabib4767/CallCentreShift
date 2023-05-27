using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using static OBL.BIC.Entity.BICCustomerDetail;

namespace OBL.BIC.Gateway
{
    public class ApiCalling
    {
        //this code is for Bearer Authorization 2022
        public static dynamic Get<T>(string apiUrl, dynamic entity, string token)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiUrl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("Authorization", token);
                    var jsonString = JsonConvert.SerializeObject(entity);
                    var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
                    var response = client.GetAsync(apiUrl + "/" + entity);
                    if (response.Result.IsSuccessStatusCode)
                    {
                        var datar = response.Result.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<Root>(datar.Result);
                        return result;
                    }


                }
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }

        //this code is for Basic Authorization 2023 ~Ahsan
        public static dynamic GetBasic<T>(string apiUrl, dynamic entity, string token)
        {
            try
            {
                var httpClientHandler = new HttpClientHandler()
                {
                    Proxy = new WebProxy("http://10.156.2.18:8080", true),
                    UseProxy = false,
                    UseDefaultCredentials = true
                };
                httpClientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
                using (var client = new HttpClient(httpClientHandler))
                {
                    client.BaseAddress = new Uri(apiUrl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("token",token);
                    var jsonString = JsonConvert.SerializeObject(entity);
                    var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
                    var response = client.GetAsync(apiUrl);
                    if (response.Result.IsSuccessStatusCode)
                    {
                        var datar = response.Result.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<Root>(datar.Result);
                        return result;
                    }


                }
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }
        //this code is for Bearer Authorization 2022 ~Ahsan
        public static dynamic GetAll<T>(string apiUrl, string token = null)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiUrl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var response = client.GetAsync(apiUrl);
                    if (response.Result.IsSuccessStatusCode)
                    {
                        var data = response.Result.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<IEnumerable<T>>(data.Result);
                        return result;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }
        //This code is for Bearer Auth 2023 ~Ahsan
        public static dynamic PostResponse(string apiUrl, dynamic entity, string token = null)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiUrl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var jsonString = JsonConvert.SerializeObject(entity);
                    var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

                    var response = client.PostAsync(apiUrl, content);
                    if (response.Result.IsSuccessStatusCode)
                    {
                        var data = response.Result.Content.ReadAsStringAsync();
                        var result = data.Result;
                        return result;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }
        //this code is for Bearer Authorization 2022 ~Ahsan
        public static dynamic PostAuth<T>(string apiUrl, dynamic entity, string token = null)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(apiUrl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    if (!string.IsNullOrEmpty(token))
                    {
                        client.DefaultRequestHeaders.Add("Authorization", token);
                    }

                    var jsonString = JsonConvert.SerializeObject(entity);
                    var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

                    var response = client.PostAsync(apiUrl, content);
                    if (response.Result.IsSuccessStatusCode)
                    {
                        var data = response.Result.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<T>(data.Result);
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                string er = ex.Message.ToString();
                throw;
            }
            var res = typeof(T).Name;
            if (res == "Boolean")
            {
                return false;
            }
            return null;
        }

        //this code is for Basic Auth 2023 ~Ahsan
        public static dynamic Post<T>(string apiUrl, dynamic entity, string token = null)
        {
            try
            {
                var httpClientHandler = new HttpClientHandler()
                {
                    Proxy = new WebProxy("http://10.156.2.18:8080", true),
                    UseProxy = false,
                    UseDefaultCredentials = true
                };
                httpClientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
                using (var client = new HttpClient(httpClientHandler))
                {
                    client.BaseAddress = new Uri(apiUrl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var authHeader = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.ASCII.GetBytes($"{entity.UserName}:{entity.Password}")));
                    client.DefaultRequestHeaders.Authorization = authHeader;


                    var jsonString = JsonConvert.SerializeObject(authHeader);
                    var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

                    var response = client.PostAsync(apiUrl, content);
                    if (response.Result.IsSuccessStatusCode)
                    {
                        token = response.Result.Headers.GetValues("Token").FirstOrDefault().ToString();
                        return token;
                    }
                }
            }
            catch (Exception ex)
            {
                string er = ex.Message.ToString();
                throw;
            }
            var res = typeof(T).Name;
            if (res == "Boolean")
            {
                return false;
            }
            return null;
        }
        public static dynamic PostAll<T>(string apiUrl, dynamic entity, string token = null)
        {
            try { 
                    var httpClientHandler = new HttpClientHandler()
                    {
                        Proxy = new WebProxy("http://10.156.2.18:8080", true),
                        UseProxy = false,
                        UseDefaultCredentials = true
                    };
                    httpClientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
                    using (var client = new HttpClient(httpClientHandler))
                    {
                    client.BaseAddress = new Uri(apiUrl);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("token", token);
                    var jsonString = JsonConvert.SerializeObject(entity);
                    var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
                    var response = client.PostAsync(apiUrl, content);
                    if (response.Result.IsSuccessStatusCode)
                    {
                        var data = response.Result.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<Root>(data.Result);
                        return result;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            var res = typeof(T).Name;
            if (res == "Boolean")
            {
                return false;
            }
            return null;
        }

    }
}
