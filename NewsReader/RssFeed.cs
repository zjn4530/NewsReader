using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsReader
{
    class RssFeed
    {
        public RssFeed()
        {
        }
        public RssFeed(string displayName, string url)
        {
            this.displayName = displayName;
            this.url = url;
            articles = new Article[2];
        }
        private string displayName;

        public string DisplayName
        {
            get { return displayName; }
            set { displayName = value; }
        }
        private string url;

        public string Url
        {
            get { return url; }
            set { url = value; }
        }
        private Article[] articles;

        internal Article[] Articles
        {
            get { return articles; }
           
        }
        public void FillArticles()
        {
            articles[0] = new Article(
                "百度",
                "baidu.com"
            );
            articles[1] = new Article(
                "谷歌",
                "google.com.hk"
            );
        }
    }
}
