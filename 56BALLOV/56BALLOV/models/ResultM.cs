using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace _56BALLOV.models
{
    public class ResultM
    {
        private string url;
        private int SearchPar;
        private int SearchConfig;
        public HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

        public async static Task<List<string>> ParseSyte(string url, int SearchPar, int SearchConfig, bool IsFirstStep)
        {
            List<string> list = new List<string>();
            if (IsFirstStep)
            {
                IsFirstStep = false;
                list.Add(url);
            }

            if (list != null && SearchPar < 0)
            {
                SearchPar--;
                foreach (string url1 in list)
                { 
                    await Task.Run(() => list = (List<string>) list.Union( (Parse(url, SearchConfig, list))));
                }
                
            }
            ParseSyte(url, SearchPar, SearchConfig, IsFirstStep);
            return list;


        }

        private static List<string> Parse(string url, int Config, List<string> list)
        {
            HtmlWeb hw = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc = hw.Load(url);
            var linkCollection = doc.DocumentNode.SelectNodes("//a[@href]");
            foreach (var node in linkCollection)
            {
                if (Config < 1)
                {
                    break;
                }
                string link = node.Attributes["href"].Value;
                Config--;
                if ( link == list.Find(x => x == link))
                {
                    continue;
                }
                list.Add(link);
                
            }

            return list;
        }
        
    }

    
}