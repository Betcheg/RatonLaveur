<?php
include 'bdd.php';

$infosMembre = $bdd->query("SELECT * FROM requete WHERE utilisateur = '".$_GET['nom']."' ORDER BY id ASC LIMIT 1"); 
		
		while($donnees = $infosMembre->fetch())
		{
			echo $donnees['type'].",".$donnees['param1'];
			if($donnees['param2'] !="")
			{
				echo ",".$donnees['param2'];
			}
		}
?>