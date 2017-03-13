using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataDowload
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_dowload_Click(object sender, EventArgs e)
        {
            if (tbx_query.Text != "")
            {
                if (tbx_queryCity.Text != "")
                {
                    if (path_text.Text != "")
                    {
                        string city = tbx_queryCity.Text;
                        string url = "http://api.map.baidu.com/place/v2/search?q=" + tbx_query.Text + "&region=" + city + "&scope=1&output=json&ak=93wScOqxtFuBgBoLItMtsj2q&page_size=1&page_num=0&coord_type=1";
                        WebClient wc = new WebClient();
                        byte[] bResponse = wc.DownloadData(url);
                        string strResponse = Encoding.UTF8.GetString(bResponse);
                        //去除中括号，使其成为标准的json格式
                        string strResponse2 = strResponse.Replace("[", "").Replace("]", "");
                        Info jobInfoList = JsonConvert.DeserializeObject<Info>(strResponse2);
                        //计算总数
                        int totalnum = jobInfoList.total;
                        //循环提取
                        rtb_result.Text = totalnum + "\n";

                        FileStream fs = new FileStream(path_text.Text + "/" + tbx_query.Text + ".txt", FileMode.Append, FileAccess.Write);
                        StreamWriter sr = new StreamWriter(fs);

                        for (int i = 0; i < totalnum; i++)
                        {
                            string i_url = "http://api.map.baidu.com/place/v2/search?q=" + tbx_query.Text + "&region=" + city + "&scope=1&output=json&ak=93wScOqxtFuBgBoLItMtsj2q&page_size=1&page_num=" + i + "&coord_type=1";
                            byte[] i_bResponse = wc.DownloadData(i_url);
                            string i_strResponse = Encoding.UTF8.GetString(i_bResponse);
                            string i_strResponse2 = i_strResponse.Replace("[", "").Replace("]", "");
                            try
                            {
                                Info jobInfo = JsonConvert.DeserializeObject<Info>(i_strResponse2);
                                string result = (i + 1) + ". " + jobInfo.results.name + ":" + jobInfo.results.location.lat + "," + jobInfo.results.location.lng + "\n";
                                sr.WriteLine(result);//开始写入值

                                rtb_result.Text += result;
                                rtb_result.SelectionStart = rtb_result.TextLength;
                                rtb_result.ScrollToCaret();
                            }
                            catch
                            {
                                rtb_result.Text += (i + 1) + "\n";
                                sr.WriteLine((i + 1));//开始写入值
                                rtb_result.SelectionStart = rtb_result.TextLength;
                                rtb_result.ScrollToCaret();
                            }
                        }
                        sr.Close();
                        fs.Close();
                    }
                    else
                    {
                        MessageBox.Show("文件夹路径不能为空！");
                    }
                }
                else
                {
                    MessageBox.Show("查询城市不能为空！");
                }
            }
            else
            {
                MessageBox.Show("查询内容不能为空！");
            }
        }

        void writeFile(string s)
        {
            FileStream fs = new FileStream(path_text.Text + "/" + tbx_query.Text + ".txt", FileMode.Append, FileAccess.Write);
            StreamWriter sr = new StreamWriter(fs);
            sr.WriteLine(s);//开始写入值
            sr.Close();
            fs.Close();
        }
        private void btn_file_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog mFolderBrowserDialog = new FolderBrowserDialog();
            if (mFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                path_text.Text = mFolderBrowserDialog.SelectedPath;
            }


        }

        private void rtb_result_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("先设置保存结果的文件夹，再点击下载按钮", "帮助");
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("作者：文聪聪\n版权所有", "CC");
        }

        private void 设置保存文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog mFolderBrowserDialog = new FolderBrowserDialog();
            if (mFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                path_text.Text = mFolderBrowserDialog.SelectedPath;
            }
        }
    }


    public class Info
    {
        public int status { get; set; }
        public string message { get; set; }
        public int total { get; set; }
        public data results { get; set; }

    }

    public class data
    {
        public string name { get; set; }
        public loc location { get; set; }
        public string address { get; set; }
        public string street_id { get; set; }
        public string telephone { get; set; }
        public string datail { get; set; }
        public string uid { get; set; }
    }

    public class loc
    {
        public string lat { get; set; }
        public string lng { get; set; }
    }
}
