using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZJS.EDI.Business.HttpUtility;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string baseURL = "http://scs.chinacloudsites.cn/";
        private string syncURL = "Handler/Sync/RecSyncDataHandler.ashx";
        private string loginURL = "Handler/LoginHandler.ashx?AType=UserLogin";

        public Form1()
        {
            InitializeComponent();
        }
        bool isLoadFinished = false;
        private void webKitBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            isLoadFinished = true;
            if(this.webKitBrowser1.Url.AbsolutePath.ToLower() == "/login.aspx")
            {
                string strScript = string.Format("$('#loginID').val('{0}@{1}');$('#loginPsw').val('{0}');", "zzcy", "zzcy");
                string scriptResult = webKitBrowser1.StringByEvaluatingJavaScriptFromString(strScript);
                WebKit.DOM.Element element =  webKitBrowser1.Document.GetElementById("loginID");
                string temp = element.NodeValue;
                temp = element.TextContent;
                temp = element.ToString();

                //MessageBox.Show(this.webKitBrowser1.DocumentText);
                // object objResult =   webKitBrowser1.Document.InvokeScriptMethod("SFXTLogin");

            }
            if(this.webKitBrowser1.Url.AbsolutePath.ToLower() == "/test.html")
            {
                //string[] param = { " and UserID like \'%0337%\'" };
                //webKitBrowser1.Document.InvokeScriptMethod("Test", param);
                string strScript = string.Format("var param = \"{0}\";Test(param);", " and UserID like \'%0337%\'");
                webKitBrowser1.StringByEvaluatingJavaScriptFromString(strScript);
            }

            if(this.webKitBrowser1.Url.AbsolutePath.ToLower() == "/iotm/sfxt/payment.html")
            {
                StringBuilder sbScript = new StringBuilder();
                sbScript.Append(string.Format("var userId=\"{0}\";", "2017120337"));
                sbScript.Append(string.Format("var meterNo=\"{0}\";", "13526487308001"));
                sbScript.Append(string.Format("var meterId=\"{0}\";", "2171"));
                sbScript.Append(string.Format("var amount=\"{0}\";", "100"));
                string strScript = string.Format("{0} ChongZhi(userId, meterNo, meterId, amount);", sbScript.ToString());
                webKitBrowser1.StringByEvaluatingJavaScriptFromString(strScript);

            }
            //MessageBox.Show(e.Url.AbsolutePath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebKit.DOM.Element element = webKitBrowser1.Document.GetElementById("loginID");
            string temp = element.NodeValue;
            temp = element.TextContent;
            temp = element.ToString();

            //string strScript = string.Format("$('#loginID').val('{0}@{1}');$('#loginPsw').val('{0}');", "zzcy", "zzcy");
            //webKitBrowser1.StringByEvaluatingJavaScriptFromString(strScript);
            ////MessageBox.Show(this.webKitBrowser1.DocumentText);
            object objResult = webKitBrowser1.Document.InvokeScriptMethod("Test");
            MessageBox.Show("click:" + objResult.ToString());
            ////webKitBrowser1.StringByEvaluatingJavaScriptFromString("var _elm = document.getElementById('youidname'); var _evt = document.createEvent('MouseEvents'); _evt.initEvent('click', true, true); _elm.dispatchEvent(_evt);");
        }

        private string Login()
        {

            StringBuilder sbRequestData =new StringBuilder ();//请求参数  
            sbRequestData.Append("LoginID=00000@00000");
            sbRequestData.Append("&LoginPsw=00000");
            // 发送请求  
            StringBuilder sbUrl = new StringBuilder(); // 请求URL内容  
            sbUrl.Append(baseURL);
            sbUrl.Append(loginURL);


            String strUrl = sbUrl.ToString();
            //解析xml文件  
            return HttpWebResponseUtility.GetResultXML(sbUrl.ToString(), sbRequestData.ToString(), null);


    //        /*
    //             data.IsYzm = false;
    //             data.YZM = '';*/
    //        object loginData = new { LoginID = "00000", LoginPsw = "00000", IsYzm = false, YZM = "" };
    //        var client = new RestClient(baseURL);

    //        var request = new RestRequest(loginURL, Method.POST);
    //        request.AddParameter("LoginID", $"{"00000"}@{"00000"}"); // adds to POST or URL querystring based on Method
    //        request.AddParameter("LoginPsw", "00000"); // adds to POST or URL querystring based on Method

    //        IRestResponse response = client.Execute(request);
    //        var content = response.Content; // raw content as string
    //        CY.Iot.Common.Message msg = JsonConvert.DeserializeObject<CY.Iot.Common.Message>(content);
    //        if (msg.Result)
    //        {       
    //            return "";
    //        }
    //        else
    //            return msg.Data.ToString();
        }

        private void webKitBrowser1_Load(object sender, EventArgs e)
        {

        }

        private void webKitBrowser1_DocumentTitleChanged(object sender, EventArgs e)
        {
            this.richTextBox1.Text = this.webKitBrowser1.DocumentTitle;

            try
            {
                Message msg = JsonConvert.DeserializeObject<Message>(this.webKitBrowser1.DocumentTitle);
                if (msg.Result)
                {
                    this.richTextBox1.Text = "充值成功\r\n返回信息如下：\r\n";
                    this.richTextBox1.Text += msg.TxtMessage;

                }
            }
            catch
            {

            }
            //MessageBox.Show(this.webKitBrowser1.DocumentTitle);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strURL = string.Format("http://localhost:4656/Test.html");
            Uri url = new System.Uri(strURL, System.UriKind.Absolute);
            isLoadFinished = false;
            this.webKitBrowser1.Url = url;// '  AND  UserID  like \'%' + $("#select_UserID").val() + '%\'';
            this.webKitBrowser1.Navigate(strURL);
            //while (!isLoadFinished) ;
            //object[] param = { " and UserID like \'%0337%\'" };
            //webKitBrowser1.Document.InvokeScriptMethod("QueryUserInfo",param);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strURL = string.Format("http://localhost:4656/IotM/SFXT/Payment.html");
            isLoadFinished = false;
            this.webKitBrowser1.Navigate(strURL);
        }

        public class Message
        {
            public bool Result
            {
                get;
                set;
            }
            public string TxtMessage
            {
                get;
                set;
            }
        }
    }
}
