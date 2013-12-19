using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AsynchronousProgrammingPattern
{
    public partial class Form1 : Form
    {
        SynchronizationContext syncContext;

        public Form1()
        {
            InitializeComponent();

            syncContext = SynchronizationContext.Current;

            //http://download.microsoft.com/download/1/B/E/1BE39E79-7E39-46A3-96FF-047F95396215/dotNetFx40_Full_setup.exe
        }

        //使用WebRequest内置的异步方法
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string url = textBox1.Text;

                // Initialize an HttpWebRequest object
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(url);

                myHttpWebRequest.BeginGetResponse(delegate(IAsyncResult result)
                {
                    HttpWebRequest request = result.AsyncState as HttpWebRequest;

                    // assign HttpWebRequest instance to its request field.
                    using (HttpWebResponse response = (HttpWebResponse)request.EndGetResponse(result))
                    {
                        int totalLenght = ReadResponseLength(response);

                        string message  =  string.Format("方法1获取文件长度: {0}", totalLenght);
                        updateUI(message);
                    }


                }, myHttpWebRequest);
            }
            catch (Exception err)
            {
                string message = string.Format("方法1获取文件长度发生错误:{0}", err.Message);
                updateUI(message);
            }
        }
        
        //将同步方法封装为Delegate后异步调用
        private void button2_Click(object sender, EventArgs e)
        {
            Func<string, int> fun = delegate(string url)
            {
                HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(url);

                using (HttpWebResponse response = (HttpWebResponse)myHttpWebRequest.GetResponse())
                {
                    int totalLenght = ReadResponseLength(response);

                    return totalLenght;
                }
            };

            fun.BeginInvoke(textBox1.Text, delegate(IAsyncResult result)
            {
                AsyncResult ar = result as AsyncResult;
                Func<string, int> dele = ar.AsyncDelegate as Func<string, int>;
                int length = dele.EndInvoke(result);

                string message = string.Format("方法2获取文件长度: {0}", length);
                updateUI(message);
            }, null);
        }


        private static int ReadResponseLength(HttpWebResponse response)
        {
            using (Stream streamResponse = response.GetResponseStream())
            {

                int totalLenght = 0;
                int bufferSize = 1024;
                byte[] bufferRead = new byte[bufferSize];

                int readSize = streamResponse.Read(bufferRead, 0, bufferSize);
                while (readSize > 0)
                {
                    totalLenght += readSize;
                    readSize = streamResponse.Read(bufferRead, 0, bufferSize);
                }
                return totalLenght;
            }
        }

        private void updateUI(string length)
        {
            syncContext.Post(delegate(object state)
            {
                richTextBox1.Text += length + "\n";
            }, null);
        }

    }
}
