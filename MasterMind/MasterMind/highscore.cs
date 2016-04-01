using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;
using System.Net;
using System.IO;

namespace MasterMind
{
    class highscore
    {
        //this function return the php file.
        public string return_phpfile(String phpfile)
        {
            return "http://localhost/AO/SCHOOL/Vakken/CSHARP/" + phpfile;
        }

        //This function make connection with xampp(apache).
        public string SendRequest(string url)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    return client.DownloadString(new Uri(url));
                }
            }
            catch (WebException ex)
            {
                return null;
            }
        }

        //This function set scoredata in database
        public static bool set_in_database(String Namelabel, String Scorelabel, String Time, String URL)
        {
            WebClient webClient = new WebClient();
            NameValueCollection formData = new NameValueCollection();
            formData["name"] = Namelabel;
            formData["score"] = Scorelabel;
            formData["time"] = Time;
            try
            {
                byte[] responseBytes = webClient.UploadValues(URL, "POST", formData);
                string responsefromserver = Encoding.UTF8.GetString(responseBytes);
                Console.WriteLine(responsefromserver);
                webClient.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
