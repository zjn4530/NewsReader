using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewsReader
{
    public partial class Form1 : Form
    {
        RssFeed news;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            news = new RssFeed("搜索", "w3c.com");
            news.FillArticles();
            treeView1.Nodes.Clear();
            for (int i = 0; i < news.Articles.Length; i++)
            {
                treeView1.Nodes.Add(news.Articles[i].Title);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int index = treeView1.SelectedNode.Index;
            webBrowser1.Navigate(news.Articles[index].Url);
        }
    }
}
