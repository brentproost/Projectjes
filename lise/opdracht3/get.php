<?php 
$selected_radio = $_POST['grp_Provincie'];

$con=mysqli_connect("localhost","root","", "opdracht_3");
$Huidige_meterstand_ingave = $_POST['Txt_Huidige_meterstand'];

$sql = sprintf("SELECT Huidige_meterstand FROM tbl_klanten WHERE '$_POST[Txt_Klant_nummer]' = Klanten_nummer");

$result = mysqli_query($con,$sql);

while($row = mysqli_fetch_array($result))
  {
 	 $vorigemeterstand = $row['Huidige_meterstand'];
  }
  
$Huidige_meterstand = $Huidige_meterstand_ingave - $vorigemeterstand;

mysqli_close($con);
$gratis = $_POST['Txt_Aantal_gezinsleden'] * 15;
$te_verekenen = $Huidige_meterstand - $gratis;

if($selected_radio == 'WVL')
{
	$Vastevergoeding = 50.00;
	$Basisverbruik = 4.08;
}
else
if($selected_radio == 'OVL')
{
	$Vastevergoeding = 50.00;
	$Basisverbruik = 4.08;
}
else
if($selected_radio == 'VLB')
{
	$Vastevergoeding = 50.00;
	$Basisverbruik = 4.08;
}
else
if($selected_radio == 'LIM')
{
	$Vastevergoeding = 50.00;
	$Basisverbruik = 4.08;
}
else
{
	$Vastevergoeding = 0;
	$Basisverbruik = 0;
}

$Kostprijs = $Vastevergoeding + $te_verekenen * $Basisverbruik;
$btw = $Kostprijs * 0.06;
$tebetalen = $Kostprijs + $btw;
echo "<table border='1'>
  <tr>
    <th><table cellspacing='0' cellpadding='0'>
  <td width='116'>Provincie</td>
    </table></th>
    <th><table cellspacing='0' cellpadding='0'>
  <td width='81'>#    gezinsleden</td>
    </table></th>
    <th>Vorige meterstand</th>
    <th>Huidige meterstand</th>
    <th><table cellspacing='0' cellpadding='0'>
  <td width='64'>Verbruik</td>
    </table> 
    m³</th>
    <th><table cellspacing='0' cellpadding='0'>
  <td width='64'>Gratis</td>
    </table> 
    # m³</th>
    <th>te 
      <table cellspacing='0' cellpadding='0'>
  <td width='64'>verrekenen</td>
      </table></th>
    <th><table cellspacing='0' cellpadding='0'>
  <td width='64'>Kostprijs</td>
    </table> 
      euro</th>
    <th><table cellspacing='0' cellpadding='0'>
  <td width='64'>BTW</td>
    </table> 
    euro</th>
    <th>te 
      <table cellspacing='0' cellpadding='0'>
  <td width='64'>betalen</td>
      </table></th>
  </tr>
  <tr>
    <td>$selected_radio</td>
    <td>$_POST[Txt_Aantal_gezinsleden]</td>
    <td>$vorigemeterstand</td>
    <td>$Huidige_meterstand_ingave</td>
    <td>$Huidige_meterstand</td>
    <td>$gratis</td>
    <td>$te_verekenen</td>
    <td>$Kostprijs</td>
    <td>$btw</td>
    <td>$tebetalen</td>
  </tr>
</table>";
?>