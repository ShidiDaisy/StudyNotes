using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace INFS3204_Prac2
{
    /// <summary>
    /// Summary description for ZodiacFinder
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ZodiacFinder : System.Web.Services.WebService
    {
        [WebMethod]
        public string ZodiacDate(string name) {

            switch (name.ToLower()) {
                case "aries":
                    return "03/21-04/20";
                    break;

                case "taurus":
                    return "04/21-05/21";
                    break;

                case "gemini":
                    return "05/22-06/21";
                    break;

                case "cancer":
                    return "06/22-07/22";
                    break;

                case "leo":
                    return "07/23-08/22";
                    break;

                case "virgo":
                    return "08/23-09/23";
                    break;

                case "libra":
                    return "09/24-10/23";
                    break;

                case "scorpio":
                    return "10/24-11/22";
                    break;

                case "sagittarius":
                    return "11/23-12/21";
                    break;

                case "capricon":
                    return "12/22-01/20";
                    break;

                case "aquarius":
                    return "01/21-02/19";
                    break;

                case "pisces":
                    return "02/20-03/20";
                    break;

                default:
                    return "Not found";
                    break;
            }
        }

        [WebMethod]
        public string ZodiacName(int date, int month){
            switch (month) {
                case 1:
                    if (date > 0 && date <= 20)
                    {
                        return "Capricorn";
                    }
                    else if (date > 20 && date <= 31)
                    {
                        return "Aquarius";
                    }
                    else {
                        return "Wrong Input Date";
                    }
                    break;

                case 2:
                    if (date > 0 && date <= 19)
                    {
                        return "Aquarius";
                    }
                    else if (date > 19 && date <= 29)
                    {
                        return "Pisces";
                    }
                    else {
                        return "Wrong Input Date";
                    }
                    break;

                case 3:
                    if (date > 0 && date <= 20)
                    {
                        return "Pisces";
                    }
                    else if (date > 20 && date <= 31)
                    {
                        return "Aries";
                    }
                    else {
                        return "Wrong Input Date";
                    }
                    break;

                case 4:
                    if (date > 0 && date <= 20)
                    {
                        return "Aries";
                    }
                    else if (date > 20 && date <= 30)
                    {
                        return "Taurus";
                    }
                    else {
                        return "Wrong Input Date";
                    }
                    break;

                case 5:
                    if (date > 0 && date <= 21)
                    {
                        return "Taurus";
                    }
                    else if (date > 21 && date <= 31)
                    {
                        return "Gemini";
                    }
                    else {
                        return "Wrong Input Date";
                    }
                    break;

                case 6:
                    if (date > 0 && date <= 21)
                    {
                        return "Gemini";
                    }
                    else if (date > 21 && date <= 30)
                    {
                        return "Cancer";
                    }
                    else {
                        return "Wrong Input Date";
                    }
                    break;

                case 7:
                    if (date > 0 && date <= 22)
                    {
                        return "Cancer";
                    }
                    else if (date > 22 && date <= 31)
                    {
                        return "Leo";
                    }
                    else {
                        return "Wrong Input Date";
                    }
                    break;

                case 8:
                    if (date > 0 && date <= 22)
                    {
                        return "Leo";
                    }
                    else if (date > 22 && date <= 31)
                    {
                        return "Virgo";
                    }
                    else {
                        return "Wrong Input Date";
                    }
                    break;

                case 9:
                    if (date > 0 && date <= 23)
                    {
                        return "Virgo";
                    }
                    else if (date > 23 && date <= 30)
                    {
                        return "Libra";
                    }
                    else {
                        return "Wrong Input Date";
                    }
                    break;

                case 10:
                    if (date > 0 && date <= 23)
                    {
                        return "Libra";
                    }
                    else if (date > 23 && date <= 31)
                    {
                        return "Scorpio";
                    }
                    else {
                        return "Wrong Input Date";
                    }
                    break;

                case 11:
                    if (date > 0 && date <= 22)
                    {
                        return "Scorpio";
                    }
                    else if (date > 22 && date <= 30)
                    {
                        return "Sagittarius";
                    }
                    else {
                        return "Wrong Input Date";
                    }
                    break;

                case 12:
                    if (date > 0 && date <= 21)
                    {
                        return "Sagittarius";
                    }
                    else if (date > 21 && date <= 31)
                    {
                        return "Capricon";
                    }
                    else {
                        return "Wrong Input Date";
                    }
                    break;

                default:
                    return "Wrong Input Date";
                    break; 
            }

            }

    }
}
