using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegister
{
    public class RestClient
    {
        public enum HttpMethod
        {
            GET,
            POST, 
            PUT,
            DELETE
        }

        public string URL { get; set; }
        public HttpMethod Method { get; set; }

        //constructor
        public RestClient()
        {
            URL = string.Empty;
            Method = HttpMethod.POST;
        }

        public string MakeRequest()
        {
            string strResponse = string.Empty;
            HttpWebResponse response = null;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
                request.Method = Method.ToString();
                using (response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        throw new ApplicationException("Error: " +
                            response.StatusCode);
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
                strResponse = "{\"errorMessages\":[\"" + ex.Message.ToString()
                     + "\"],\"errors\":{}}";
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
