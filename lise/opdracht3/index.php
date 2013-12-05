<!doctype html>
<html>
<head>
<meta charset="utf-8">
<title>Untitled Document</title>
<link rel="stylesheet" href="Style.css" type="text/css" media="screen" charset="utf-8" />
</head>

<body>
<img src="vmm_rubriek_banner.jpg" alt="Cosmox">
<h1> Bereken hier je waterfactuur! </h1>
<h2> De VMM heeft als economisch toezichthouder een toepassing ontwikkeld waarmee u zelf kunt berekenen wat uw leidingwaterverbruik u kost.

De toepassing houdt ook rekening met de eventuele kosten die uw watermaatschappij aanrekent voor het afvoeren en/of zuiveren van het zelf gewonnen water op gemeentelijk vlak.

Met de berekeningstool kan u de factuur van uw watermaatschappij narekenen of een nieuwe factuur simuleren. Dat kan interessant zijn om bv. het effect van waterbesparende maatregelen in te schatten.

Om de factuur van uw watermaatschappij na te rekenen neemt u best de laatste eindafrekening bij de hand. Deze vermeldt alle gegevens nodig voor de juiste berekening (aantal gedomicilieerden, verbruiksperiode, waterverbruik en watermaatschappij). Daarnaast moet u ook aanduiden welk type verbruiker u bent en de aard van de lozingsituatie.</h2>
<br>
<br>
<form method="post" action="get.php">
<pre>
<input type="text" name="Txt_Klant_nummer"> Klantnummer

<input type="text" name="Txt_Huidige_meterstand"> Huidige meterstand

<input type="text" name="Txt_Aantal_gezinsleden"> Aantal gezinsleden

<input type="radio" name="grp_Provincie" value="WVL"> West-Vlaanderen
<input type="radio" name="grp_Provincie" value="OVL"> Oost-Vlaanderen
<input type="radio" name="grp_Provincie" value="VLB"> Vlaams-Brabant
<input type="radio" name="grp_Provincie" value="LIM"> Limburg 

<input type="submit">
</pre>
</form>
<footer> De prijzen zijn gebaseerd op de tarieven die van kracht zijn vanaf 1 januari 2013 http://www.iwm.be/index.php/klanteninformatie/tarieven </footer>
</body>
</html>
