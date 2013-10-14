$(document).ready(function()
	{				
		$('.first').click(function(){
		$('#content').load('text.html #' + $(this).attr('href'));
		return false;
	});
	$('.aanbod').click(function(){
		$('#content').load('aanbod.html #' + $(this).attr('href'));
	$('#LeftSide').attr("class","aanbod");	
		$('#link1').html('<a class="aanbod" href="lessen">Lessen</a>');
		$('#link2').html('<a href="stages">Stages</a>');
		$('#link3').html('<a href="Specialisatielessen"> Specialisaties</a>');
		$('#link4').hide();
		return false;
	});	
	$('.initiaties').click(function(){
		$('#content').load('initiaties.html #' + $(this).attr('href'));
		$('#link1').html('Open Piste');
		$('#link2').html('Workshop');
		$('#link3').html('Animaties');
		$('#link4').html('Materiaal Verhuur');
		return false;
	});
	$(function() {
    changeWidth(1058);
 
    function changeWidth(menuWidth){
        var menuItems = $('#wrapper li').size();
        var itemWidth = (menuWidth/menuItems)-2;
 
        $('#wrapper').css({'width': menuWidth +'px'});
        //$('#wrapper a').css({'width': itemWidth +'px'});
    }
});			
});
  