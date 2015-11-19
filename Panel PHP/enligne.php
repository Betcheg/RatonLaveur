<?php

include 'bdd.php';

$bdd->exec("DELETE FROM enligne WHERE nom = '".$_GET['nom']."'");
$bdd->exec("INSERT INTO enligne (nom,derniereCo) VALUES('".$_GET['nom']."',CURRENT_TIME())");


?>