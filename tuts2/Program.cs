using System;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

namespace tuts2
{
    class Program
    {
        static void Main(string[] args)
        {
            string pars;
            WebClient web = new WebClient();
            web.Encoding = Encoding.UTF8;
            string page = web.DownloadString("https://orakul.com/");
            string name = "<span class=\"name\">(.*?)</span>";
            string page1 = web.DownloadString("https://www.horoscope.com/us/horoscopes/general/horoscope-general-daily-today.aspx?sign=8");
            string name1 = "</strong>(.*?)</p>";
            foreach (Match match in Regex.Matches(page, name))
            {
                pars = match.Groups[1].Value;
                Console.WriteLine(pars);
            }
            foreach (Match match in Regex.Matches(page1, name1))
            {
                pars = match.Groups[1].Value;
                Console.WriteLine(pars);
            }
        }
    }
}
