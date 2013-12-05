<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>Untitled Document</title>



<?php 

//error_reporting(E_ALL);
//$con=mysqli_connect("localhost","root","", "opdracht2");

//$sql = ("INSERT INTO klanten (Naam, Adres, Postnr, Gemeente, InteresseBoeken, InteresseCD, InteresseDVD) VALUES ('$_POST[naam]','$_POST[adres]','$_POST[postnr]','$_POST[gemeente]','$_POST[boekenliefhebber]','$_POST[dvdliefhebber]','$_POST[cdliefhebber]')"); 

//mysqli_query($con,$sql);

//echo "<h1> Uw gegevens zijn succesvol toegevoegd. </h1>" ;  

//mysqli_close($con);

?>
</head>

<body>
<div>

<form method="post">
<pre>
<input type="text" name="Naam"> Naam

<input type="text" name="Adres"> Adres

<input type="text" name="Txt_Postnr"> Postnr

<input type="text" name="Txt_Gemeente"> Gemeente

<input type="checkbox" name="Cb_Boeken"> Interesse boeken
<input type="checkbox" name="Cb_DVD"> Interesse DVDs
<input type="checkbox" name="Cb_CD"> Interesse CDs

<input type="submit">
</pre>
</form>
Welcome <?php echo $_POST["Naam"]; ?><br>
Your email address is: <?php echo $_POST["Adres"]; ?>
</div>
</body>
</html>
