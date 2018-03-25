using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace NewHIMS
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WebForm1 loc = new WebForm1();
            string aa = loc.GetIPAddress();
            Label2.Text = loc.GetUserCountryByIp(aa);
            Label1.Text = loc.GetIPAddress();
            Label6.Text = loc.GetCurrentTimezone();
            Label8.Text = loc.GetTime();
            Label10.Text = loc.GetTimeZone();
            Label12.Text = loc.CtToUtc();
            Label14.Text = loc.UtcToCt();
        }
        public string GetCurrentTimezone()
        {
            TimeZoneInfo timeZoneInfo;
            DateTime dateTime;
            //Set the time zone information to US Mountain Standard Time 
            timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            //Get date and time in US Mountain Standard Time 
            dateTime = TimeZoneInfo.ConvertTime(DateTime.Now, timeZoneInfo);

            //Print out the date and time
            return (dateTime.ToString("yyyy-MM-dd HH-mm-ss"));
        }

        public string GetTime()
        {
            //  TO get Currrent Time in current Time Zone of your System

            var dt = DateTime.Now;
            string c = dt.ToString();
            return c;
            //  Console.WriteLine(dt);
        }
        public string GetTimeZone()
        {
            // Display Time Zone of your System
            string d = TimeZoneInfo.Local.ToString();
            return d;
            // Console.WriteLine(TimeZoneInfo.Local);
        }

        public string CtToUtc()
        {
            // Convert Current Date Time to UTC Date Time
            var dt = DateTime.Now;
            var utc = TimeZoneInfo.ConvertTimeToUtc(dt, TimeZoneInfo.Local);
            string b = utc.ToString();
            return b;
            // Console.WriteLine(utc);
        }
        public string UtcToCt()
        {
            // Convert UTC Time to Current Time Zone
            var dt = DateTime.Now;
            var utc = TimeZoneInfo.ConvertTimeToUtc(dt, TimeZoneInfo.Local);
            DateTime pacific = TimeZoneInfo.ConvertTimeFromUtc(utc, TimeZoneInfo.Local);
            string a = pacific.ToString();
            return a;

            // Console.WriteLine(pacific);

            // Console.ReadLine();
        }




        /*  string sign;
          TimeZone currenttime = TimeZone.CurrentTimeZone;
          DateTime utc = DateTime.UtcNow;
          string CT = currenttime.ToString();
          string UTC = utc.ToString();
          return CT;
           
*/

        /*  TimeSpan offset = new TimeSpan();
          if (sign == "+")
          {
              DateTime newdatetime = utc + offset;
              Label8.Text = "current datetime is" + DateTime.Now + " " + "<br/>Converted datetime";

          }
          else if (sign == "-")
          {
              DateTime newdatetime = utc - offset;
              Label8.Text = "current datetime is" + DateTime.Now + " " + "<br/>Converted datetime";
         }
          */


        public string GetIPAddress()
        {
            String address = "";
            WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
            using (WebResponse response = request.GetResponse())
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                address = stream.ReadToEnd();
            }

            int first = address.IndexOf("Address: ") + 9;
            int last = address.LastIndexOf("</body>");
            address = address.Substring(first, last - first);

            return address;
        }
        public string GetUserCountryByIp(string ip)
        {
            IpInfo ipInfo = new IpInfo();
            try
            {
                string info = new WebClient().DownloadString("http://ipinfo.io/" + ip);
                ipInfo = JsonConvert.DeserializeObject<IpInfo>(info);
                RegionInfo myRI1 = new RegionInfo(ipInfo.Country);
                ipInfo.Country = myRI1.EnglishName;
            }
            catch (Exception)
            {
                ipInfo.Country = null;
            }

            return ipInfo.Country;
        }
    }
}