using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace CY.Iot.InterfacePlus
{
    public class HttpClient
    {
        private string url;
        private HttpRequest request;

        public HttpClient(string url)
        {
            this.url = url;
        }

        public string Execute(HttpRequest request)
        {
            StringBuilder sbRequestData = new StringBuilder();//请求参数  
            int i = 0;
            foreach(Parameter par in request.Parameters)
            {
                if (i == 0)
                {
                    i++;
                    sbRequestData.Append(string.Format("{0}={1}",par.Name,par.Value));
                }
                else
                {
                    sbRequestData.Append(string.Format("&{0}={1}", par.Name, par.Value));
                }
            }

            // 发送请求  
            StringBuilder sbUrl = new StringBuilder(); // 请求URL内容  
            sbUrl.Append(this.url);
            sbUrl.Append(request.Resuource);


            String strUrl = sbUrl.ToString();
            //解析xml文件  
            if (request.Method == Method.POST)
            {
                return HttpWebResponseUtility.GetResultXML(sbUrl.ToString(), sbRequestData.ToString(), null);
            }else
            {
                return HttpWebResponseUtility.OpenReadWithHttps(HttpWebResponseUtility.CreateGetHttpResponse(url, 6000, null,null));
            }            
        }

        public void AddParameter(string name, object value)
        {
            if (this.request == null)
            {
                this.request = new HttpRequest("", Method.POST);
            }
            this.request.AddParameter(name, value);
        }
    }

    /// <summary>
    /// HTTP method to use when making requests
    /// </summary>
    public enum Method
    {
        GET,
        POST,
        PUT,
        DELETE,
        HEAD,
        OPTIONS,
        PATCH,
        MERGE,
    }

    public class HttpRequest
    {
        private string resource;
        private Method method = Method.POST;
        public List<Parameter> Parameters { get; private set; }

        public HttpRequest(string resource, Method method)
        {
            this.Parameters = new List<Parameter>();
            this.resource = resource;
            this.method = method;
        }

        public void AddParameter(string name, object value)
        {
            this.Parameters.Add(new Parameter()
            {
                Name = name,
                Value = value
            });
        }

        public string Resuource { get { return this.resource; } }

        public Method Method { get { return this.method; } }
    }

    public class Parameter
    {
        /// <summary>
        /// Name of the parameter
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Value of the parameter
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// Return a human-readable representation of this parameter
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            return string.Format("{0}={1}", this.Name, this.Value);
        }
    }

}
