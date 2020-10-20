﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegister
{
    public static class MyRestClient
    {

        public enum HttpMethod
        {
            GET,
            POST,
            PUT,
            DELETE
        }

        public static string GetAllStudents()
        {
            return GetRequest("https://localhost/samplerest/displaystudents.php");
        }

        public static string GetRequest(string URL)
        {
            string strResponse = string.Empty;
            HttpWebResponse response = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
                request.Method = HttpMethod.GET.ToString();

                using (response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        throw new ApplicationException("error code: " + response.StatusCode);

                    }

                    using (Stream responseStream = response.GetResponseStream())
                    {
                        if (responseStream != null)
                        {
                            using (StreamReader reader = new StreamReader(responseStream))
                            {
                                strResponse = reader.ReadToEnd();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                strResponse = "{\"errorMessages\":[\"" + ex.Message.ToString() + "\"],\"errors\":{}}";
            }
            finally
            {
                if (response != null)
                {
                    ((IDisposable)response).Dispose();
                }
            }
            return strResponse;
        }

        public static string InsertStudent(string URL)
        {
            string strResponse = string.Empty;
            HttpWebResponse response = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
                request.Method = HttpMethod.GET.ToString();

                using (response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        throw new ApplicationException("error code: " + response.StatusCode);

                    }

                    using (Stream responseStream = response.GetResponseStream())
                    {
                        if (responseStream != null)
                        {
                            using (StreamReader reader = new StreamReader(responseStream))
                            {
                                strResponse = reader.ReadToEnd();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                strResponse = "{\"errorMessages\":[\"" + ex.Message.ToString() + "\"],\"errors\":{}}";
            }
            finally
            {
                if (response != null)
                {
                    ((IDisposable)response).Dispose();
                }
            }
            return strResponse;
        }
    }
}