using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using INFS3204_Prac4.Models;

namespace INFS3204_Prac4.Controllers
{
    public class PlayerController : ApiController
    {
        List<Player> allPlayers = ReadFile();

        public static List<Player> ReadFile()
        {
            List<Player> players = new List<Player>();
            try
            {
                using (System.IO.StreamReader sr = new System.IO.StreamReader("C:\\Users\\Shidi\\Documents\\Visual Studio 2015\\Projects\\INFS3204_Prac4\\players.txt"))
                {
                    while (sr.Peek() > -1)
                    {
                        string playerLine = sr.ReadLine();
                        string[] playerInfo = playerLine.Split(',');

                        Player player = new Player();
                        player.Registration_ID = playerInfo[0];
                        player.Player_name = playerInfo[1];
                        player.Team_name = playerInfo[2];
                        player.Date_of_birth = Convert.ToDateTime(playerInfo[3]);
                   
                        players.Add(player);
                    }
                }

                return players;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }

        public IHttpActionResult GetAllPlayers()
        {
            return Ok(allPlayers);
        }

        [HttpGet]
        public IHttpActionResult GetPlayerInfo(string option, string value)
        {
            switch (option)
            {
                case "id":
                    List<Player> playerById = allPlayers.FindAll(p => p.Registration_ID == value);
                    if (playerById == null)
                    {
                        return NotFound();
                    }
                    return Ok(playerById);

                case "name":
                    List<Player> playerByName = allPlayers.FindAll(p => p.Player_name.ToLower().Contains(value.ToLower()));
                    if (playerByName == null)
                    {
                        return NotFound();
                    }
                    return Ok(playerByName);

                default:
                    return NotFound();
            }
        }

        [Route("api/Player/DeletePlayer/{option}/{value}")]
        [HttpDelete]
        public IHttpActionResult DeletePlayer(string option, string value)
        {
            switch (option)
            {
                case "id":
                    Player pById = allPlayers.FirstOrDefault(p => p.Registration_ID == value);
                    if (pById == null)
                    {
                        return NotFound();
                    }
                    else {
                        allPlayers.Remove(pById);
                        UpdateFile(allPlayers);
                        return Ok(allPlayers);
                    }

                case "name":
                    Player pByName = allPlayers.FirstOrDefault(p => p.Player_name.ToLower().Contains(value.ToLower()));
                    if (pByName == null)
                    {
                        return NotFound();
                    }
                    else {
                        allPlayers.Remove(pByName);
                        UpdateFile(allPlayers);
                        return Ok(allPlayers);
                    }

                default:
                    return NotFound();
            }
        }

        private void UpdateFile(List<Player> allPlayers)
        {
            try
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter("C:\\Users\\Shidi\\Documents\\Visual Studio 2015\\Projects\\INFS3204_Prac4\\players.txt", false, System.Text.Encoding.Default);
                //False: Overwrite
                for (int i = 0; i < allPlayers.Count; i++)
                {
                    Player pla = allPlayers[i];
                    sw.WriteLine("{0},{1},{2},{3}", pla.Registration_ID, pla.Player_name, pla.Team_name, pla.Date_of_birth);
                }
                sw.Close();
            }
            catch { }
        }

        [HttpPost]
        public IHttpActionResult PostPlayer(Player pla)
        {
            if (pla == null)
            {
                return null;
            }
            else
            { 
                var player = allPlayers.FirstOrDefault((p) => p.Registration_ID == pla.Registration_ID);
                if (player != null)
                { 
                    allPlayers.Remove(player);
                    allPlayers.Add(pla);
                    UpdateFile(allPlayers);
                }
                else
                {
                    allPlayers.Add(pla);
                    UpdateFile(allPlayers);
                }
                return Ok(allPlayers);
            }
        }      
    } 
}
