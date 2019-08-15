using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cefSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitBrowser();
            this.FormBorderStyle = FormBorderStyle.None; //设置窗体为无边框样式
            this.WindowState = FormWindowState.Maximized; //最大化窗体 
        }


        public ChromiumWebBrowser browser;
        public void InitBrowser()
        {

            //设置参数
            var setting = new CefSettings();
            setting.Locale = "zh-CN";
            //缓存路径
            setting.CachePath = "/BrowserCache";
            //浏览器引擎的语言
            setting.AcceptLanguageList = "zh-CN,zh;q=0.8";
            setting.LocalesDirPath = "/localeDir";
            //日志文件
            setting.LogFile = "/LogData";
            setting.PersistSessionCookies = true;
            setting.UserAgent = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/55.0.2883.87 Safari/537.36";
            setting.UserDataPath = "/userData";
            CefSharp.Cef.Initialize(setting);



            //Cef.Initialize(new CefSettings());



            browser = new ChromiumWebBrowser("www.baidu.com");

            //using (StreamReader sr = new StreamReader("my.html"))
            //{
            //    string html = sr.ReadToEnd();
            //    browser.LoadHtml(html);
            //}
            browser.Dock = DockStyle.Fill;

            //browser.Dock = DockStyle.None;
            //browser.Width = 400;
            //browser.Height = 400;
            //browser.Top=200;
            //browser.Left = 100;
            this.Controls.Add(browser);

            //this.splitContainer1.Panel2.Controls.Add(browser);//这里有个问题，如果是放到splitContainer控件里面 是无法操作页面的


            CefSharpSettings.LegacyJavascriptBindingEnabled = true;//新cefsharp绑定需要优先申明

            browser.RegisterJsObject("bound", new BoundObject());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTarget_Click(object sender, EventArgs e)
        {
            //www.12306.cn/index/
            if (!string.IsNullOrEmpty(txtTargetUrl.Text.Trim()))
            {
                browser.Load(txtTargetUrl.Text.Trim());
            }
        }

        private void btnLoadLocalHtml_Click(object sender, EventArgs e)
        {
            browser.FrameLoadEnd += new EventHandler<FrameLoadEndEventArgs>(FrameEndFunc);
            using (StreamReader sr = new StreamReader("my.html"))
            {
                string html = sr.ReadToEnd();
                browser.LoadHtml(html);
            }
        }

        private void FrameEndFunc(object sender, FrameLoadEndEventArgs e)
        {
            MessageBox.Show("加载完毕");
            this.BeginInvoke(new Action(() => {
                String html = browser.GetSourceAsync().Result;
                MessageBox.Show(html);
            }));
        }


        private void btnShowDebug_Click(object sender, EventArgs e)
        {
            browser.GetBrowser().ShowDevTools();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //下一页
            browser.GetBrowser().GoForward();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //上一页
            browser.GetBrowser().GoBack();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //刷新
            browser.GetBrowser().Reload();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String script = "testfunc(99,1)";
            var result = browser.EvaluateScriptAsync(script).Result.Result;
            this.BeginInvoke(new Action(()=> {
                MessageBox.Show(result.ToString());
            }));
        }
    }

    public class BoundObject
    {
        public string MyProperty { get; set; }
        public void MyMethod()
        {
            MessageBox.Show($"哟？被js调用拉?参数是:{MyProperty}");
        }
    } 
}
