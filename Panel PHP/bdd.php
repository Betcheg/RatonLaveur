<?php
try
{
	$bdd = new PDO('mysql:host=$YOUR_HOST;dbname=$DB_NAME', $YOUR_LOGIN, $YOUR_PASS);
}
catch(Exception $e)
{
        die('Erreur : '.$e->getMessage());
}
?>