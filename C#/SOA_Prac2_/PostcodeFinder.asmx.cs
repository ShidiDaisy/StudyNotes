using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Services;

namespace INFS3204_Prac2
{
    /// <summary>
    /// Summary description for PostcodeFinder
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class PostcodeFinder : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string findPostcode(string suburb) {

            string postcode = "";

            Regex suburbIC = new Regex(suburb, RegexOptions.IgnoreCase);
            string suburb1 = suburbIC.ToString();

            try {
                //open the text file
                using (System.IO.StreamReader sr = new System.IO.StreamReader("C:\\Users\\Shidi\\Documents\\Visual Studio 2015\\Projects\\INFS3204_Prac2\\INFS3204_Prac2\\Postcodes.txt")) {

                    //Read the stream to a string
                    String[] postcodeFinder = sr.ReadToEnd().Split('\n');
                   
                    for (int i = 0; i < postcodeFinder.Length; i++) {

                        String[] splited = postcodeFinder[i].Split(',');

                      if (suburb1 == splited[0])
                        {
                            postcode = splited[1];
                            i = postcodeFinder.Length;
                        }
                        else {
                            postcode = "Invalid Input";
                        }
                    }

                    return postcode;
                }
            }
            catch (Exception e) {
                return "The file could not be read\n" + e.Message;
            }


    }
    }
}
