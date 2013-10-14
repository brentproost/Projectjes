<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Untitled Document</title>
</head>


<body>
<link href="css/smoothness/jquery-ui-1.10.1.custom.css" rel="stylesheet">
	<script src="js/jquery-1.9.1.js"></script>
	<script src="js/jquery-ui-1.10.1.custom.js"></script>
	<script>
$('#date').datepicker();
</script>
<input type="text" name="date" id="date">
<form method="post" action="update.php">
<p>Voornaam:<br />
  <input type="text" name="voornaam"  />
  <br>
  <br />
  </p>
<p>Achternaam:<br />
  <input type="text" name="achternaam"  />
  <br>
  <br />
  </p>
<p>straat:<br />
  <input type="text" name="straat" size="30" />
  <br>
  <br />
  </p>
<p>nr:<br />
  <input type="number" name="nr" size="30" />
  <br>
  <br />
  </p>
<p>gemeente:<br />
  <input type="text" name="gemeente" size="30" />
  <br>
  <br />
  </p>
<p>postcode:<br />
  <input type="number" name="postcode" size="30" />
  <br>
  <br />
  </p>
<p><br />
    <input type="submit" value="insert" />
  </p>
  
</form>
</body>
</html>