<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Untitled Document</title>

<link href="style.css" rel="stylesheet" type="text/css" />
</head>
 <?php 
 $dbCon=mysqli_connect("localhost", "root", "simpel") or die(mysql_error()) ; 
 mysqli_select_db($dbCon,"circant") or die(mysqli_error()) ;
 for ($x=1; $x<=16; $x++)
  {
	  $dbCon=mysqli_connect("localhost", "root", "simpel") or die(mysql_error()) ; 
	  mysqli_select_db($dbCon,"circant") or die(mysqli_error()) ;
  	  $rs = mysqli_query($dbCon,"CALL sp_programma(".$x.")");
	  $tmp='row'.$x;
	  $$tmp = mysqli_fetch_array($rs);
  } 
 ?>
<body>



<div id="schoten">
<div class="plaats">Schoten</div>
<div class="dag">Maandag
<div class="les" id="S1"><?php echo $row1['Uur']; echo '</br>'; echo $row1['Omschrijving']; echo '</br>'; echo $row1['Omschrijving_grpnaam'] ?></div>
<div class="les" id="S2"><?php echo $row2['Uur']; echo '</br>'; echo $row2['Omschrijving']; echo '</br>'; echo $row2['Omschrijving_grpnaam'] ?></div>
<div class="les" id="S3"><?php echo $row3['Uur']; echo '</br>'; echo $row3['Omschrijving']; echo '</br>'; echo $row3['Omschrijving_grpnaam'] ?></div>
<div class="les" id="S4"><?php echo $row4['Uur']; echo '</br>'; echo $row4['Omschrijving']; echo '</br>'; echo $row4['Omschrijving_grpnaam'] ?></div>
<div class="les" id="S5"><?php echo $row5['Uur']; echo '</br>'; echo $row5['Omschrijving']; echo '</br>'; echo $row5['Omschrijving_grpnaam'] ?></div>
</div>
</div>
<div id="kalmthout">
<div class="plaats">Kalmthout</div>
<div class="dag">Donderdag
<div class="les" id="K1"><?php echo $row6['Uur']; echo '</br>'; echo $row6['Omschrijving']; echo '</br>'; echo $row6['Omschrijving_grpnaam'] ?></div>
<div class="les" id="K2"><?php echo $row7['Uur']; echo '</br>'; echo $row7['Omschrijving']; echo '</br>'; echo $row7['Omschrijving_grpnaam'] ?></div>
<div class="les" id="K3"></div>
<div class="les" id="K4"></div>
<div class="les" id="K5"></div>
</div>
</div>
<div id="borgerhout">
<div class="plaats">Borgerhout</div>
<div class="dag">Dinsdag
<div class="les" id="B1"><?php echo $row8['Uur']; echo '</br>'; echo $row8['Omschrijving']; echo '</br>'; echo $row8['Omschrijving_grpnaam'] ?></div>
<div class="les" id="B2"><?php echo $row9['Uur']; echo '</br>'; echo $row9['Omschrijving']; echo '</br>'; echo $row9['Omschrijving_grpnaam'] ?></div>
<div class="les" id="B3"><?php echo $row10['Uur']; echo '</br>'; echo $row10['Omschrijving']; echo '</br>'; echo $row10['Omschrijving_grpnaam'] ?></div>
<div class="les" id="B4"></div>
<div class="les" id="B5"></div>
</div>
<div class="dag">Woensdag
<div class="les" id="B6"><?php echo $row11['Uur']; echo '</br>'; echo $row11['Omschrijving']; echo '</br>'; echo $row11['Omschrijving_grpnaam'] ?></div>
<div class="les" id="B7"><?php echo $row12['Uur']; echo '</br>'; echo $row12['Omschrijving']; echo '</br>'; echo $row12['Omschrijving_grpnaam'] ?></div>
<div class="les" id="B8"></div>
<div class="les" id="B9"></div>
<div class="les" id="B10"></div>
</div>
<div class="dag">Zaterdag
<div class="les" id="B11"><?php echo $row13['Uur']; echo '</br>'; echo $row13['Omschrijving']; echo '</br>'; echo $row13['Omschrijving_grpnaam'] ?></div>
<div class="les" id="B12"><?php echo $row14['Uur']; echo '</br>'; echo $row14['Omschrijving']; echo '</br>'; echo $row14['Omschrijving_grpnaam'] ?></div>
<div class="les" id="B13"><?php echo $row15['Uur']; echo '</br>'; echo $row15['Omschrijving']; echo '</br>'; echo $row15['Omschrijving_grpnaam'] ?></div>
<div class="les" id="B14"><?php echo $row16['Uur']; echo '</br>'; echo $row16['Omschrijving']; echo '</br>'; echo $row16['Omschrijving_grpnaam'] ?></div>
<div class="les" id="B15"></div>
</div>
</div>
</body>
</html>
