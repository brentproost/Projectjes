

<html>
<head>
<style type="text/css">
#clearfooter{clear:both;height:70px;width:100%;} 
#footer { 
    width:70%; 
    height:50px; 
    padding-left: 0px; 
    padding-bottom:5px; 
    position:absolute; 
    bottom:0;
	font-size:14px;
	text-align:left;
}
</style></head>
<title>Untitled Document</title>
</head>

<body>
<?php
$voornaam = $_POST['voornaam'];
$achternaam = $_POST['achternaam']; 
$straat = $_POST['straat'];
$nr = $_POST['nr'];
$gemeente = $_POST['gemeente'];
$postcode = $_POST['postcode'];

mysql_connect ("localhost", "root", "simpel") or die ('error: ' . mysql_error());
mysql_select_db ("tennis") or die ('probleem: '. mysql_error());
$query="INSERT INTO users (ID, voornaam, achternaam, straat, nr, gemeente, postcode)VALUES ('NULL', '".$voornaam."', '".$achternaam."', '".$straat."', '".$nr."', '".$gemeente."', '".$postcode."')";

mysql_query($query) or die ('Error updating database<br /> Als u problemen blijft hebben gelieve mij dan te <A HREF="mailto:senne@kayfou.be">mailen</A>' .mysql_error());


?>

<div id="clearfooter">&nbsp;</div> 
  <div id="footer"> 
    <p>Site by sompie for Eliaerts <A HREF="javascript:newPopup('mail.php')">mail</A></p> 
 </div>

</body>
</html>
