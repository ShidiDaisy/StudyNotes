# NBA League REST API
The goal of this assignment is to explore REST API development. This assignments is developed with Microsoft Visual Studio 2015 using C# as the programming language. 
This assignment contains:
1. Player class
  * String Registration_ID
  * String Player_name
  * String Team_name
  * DateTime Date_of_birth
  
 2. RESTful APIs:
  * GetAllPlayers:
    Use RESTful approach to implement this operation on server side that supports Http GET method, and use Ajax to call this operation from a client side web page.
    This operation reads information about all players from players.txt and returns a list of players.
  * GetPlayerInfo:
    Use RESTful approach to implement this operation on server side that supports
Http GET method, and use Ajax to call this operation on client side.
This operation receives a field and a corresponding value of such field, and
returns a list of players that satisfy this condition. For example, when the field is
ID and the value is p2222, it displays all the players that match the condition (in
this case, the information about Tim Duncan). The supported fields include PlayerID and PlayerFullName
(Using a Dropdownlist in a web form). Input validation is included, and the input 
cannot be null. For Name, it support both upper and lower cases, and
you also need to support partial match.

  * DeletePlayer:
  Use RESTful approach to implement this operation on server side that supports
Http DELETE method, and use Ajax to call this operation on client side.
This operation receives a field and a corresponding value of such field. For
example, the field is ID, and the value is p2222. Then, it deletes all the players
that match the condition, and saves the rest of the players into the players.txt. The
supported fields include PlayerID and PlayerName. If the operation fails
due to deletion of an inexistent player, it report a NotFound error message.
Once you delete a player, the list of players will be updated on the
web page.

* PlayerRegistration
Use RESTful approach to implement this operation on server side that supports
Http POST method, and use Ajax to call this operation on client side.
This operation receives the information of a player and creates an instance of the
class Player. It will then add this player into the existing player list and saves into
the players.txt file.
If the ID of the player you want to register already exists, it will update this player’s information in the players.txt file instead.
The new or updated player list after this operation will be displayed on top of the page. Input validation is included.
    
