<?php
	include '../database_connection.php';
	
	$PlayerID = $_GET["pid"];
	
	//http://localhost/Database/read/player_login.php?pid=5
	$query = "SELECT `PlayerID`,`Username`,`Password` From `player` WHERE `PlayerID` = '$PlayerID'";
	$result = mysqli_query($conn,$query);
	if(mysqli_num_rows($result) > 0){
		while($row = mysqli_fetch_assoc($result)){
			foreach($row as $key => $value){
				echo $key . ":" .$value . "|";
			}
		}
	}
?>