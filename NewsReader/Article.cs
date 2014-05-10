using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsReader
{
    class Article
    {
        public Article()
        {
        }
        public Article(string title, string url)
        {
            this.title = title;
            this.url = url;
        }
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string url;

        public string Url
        {
            get { return url; }
            set { url = value; }
        }
    }
}
