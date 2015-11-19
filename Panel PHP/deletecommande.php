<?php
include 'bdd.php';

if(isset($_GET['param1']))
{
	$bdd->exec("DELETE FROM requete WHERE utilisateur = '".$_GET['nom']."' AND type = '".$_GET['type']."' AND param1 = '".$_GET['param1']."'");
}

else
{
	$bdd->exec("DELETE FROM requete WHERE utilisateur = '".$_GET['nom']."' AND type = '".$_GET['type']."'");
}?>