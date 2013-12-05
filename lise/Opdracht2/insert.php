<?php 

if(isset($_POST['Cb_Boeken']))
{
	$cbboeken = 'j';
}
else
{
	$cbboeken = 'n';
}

if(isset($_POST['Cb_DVD']))
{
	$cbDVD = 'j';
}
else
{
	$cbDVD = 'n';
}

if(isset($_POST['Cb_CD']))
{
	$cbCD = 'j';
}
else
{
	$cbCD = 'n';
}

error_reporting(E_ALL);
$con=mysqli_connect("localhost","root","", "opdracht_2");

$sql = ("INSERT INTO tbl_klanten (Naam, Adres, Postnr,Gemeente,InteresseBoeken,InteresseDVDs,InteresseCds)
VALUES ('$_POST[Txt_Naam]', '$_POST[Txt_Adres]', '$_POST[Txt_Postnr]', '$_POST[Txt_Gemeente]','$cbboeken','$cbDVD','$cbCD')"); 

mysqli_query($con,$sql);

echo "<h1> Uw gegevens zijn succesvol toegevoegd. </h1>" ;  

mysqli_close($con);

?>