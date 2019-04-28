<html>
<head>
<title>The Travel Experts</title>

<link href="css/bootstrap.min.css" rel="stylesheet" type="text/css">
<script src="js/jquery-3.3.1.js"></script>
</head>
<body>

	<div align="center" class="jumbotron">

		<div id="banner"></div>

		<div id="body">
			<p>&nbsp;</p>
			<table width="760" align='center' border='0'>
				<tr>
					<td colspan="2">
						<h4>Welcome to Travel Experts Restful
							API.</h4>
					</td>
					<td><a href="/doc/index.html">API Document</a></td>
				</tr>
				<tr>
					<td colspan="3">&nbsp;</td>
				</tr>
				<tr>
					<td align="left"><select id="apiMethod">
							<option value="GET">GET</option>
							<option value="POST">POST</option>
							<option value="DELETE">DELETE</option>
					</select></td>
					<td><input name='apiURL' type='text' id='apiURL' value=''>
					</td>
					<td>
						<button type='submit' name='submitAPI' id='submitAPI'
							value=''>SUBMIT</button>
					</td>
				</tr>
				<tr>
					<td><b>Form Params:</b></td>
					<td><textarea rows="10" cols="70" id="formParams"></textarea>
					</td>
				</tr>
				<tr>
					<td><b>Result:</b></td>
					<td><textarea rows="10" cols="70" id="result"></textarea></td>

				</tr>
			</table>

			<p>&nbsp;</p>

		</div>


		<div id="footer">

			<span>Copyright &copy; 2019</span>

		</div>

	</div>

</body>

<script>
$(document).ready(function() {
	
	$('#submitAPI').click(function() {
		$apiMethod = document.getElementById("apiMethod").value;
		$apiURL = document.getElementById("apiURL").value;
		$formParams = document.getElementById("formParams").value;
		$jsonObj = null;
		$("#result").empty();

		if($formParams == "" || $formParams == null) {
			$formParams = {};
		} else {
			//jsonObj = jQuery.parseJSON(str);
			//$formParams = jQuery.parseJSON($formParams);
		}
		$.ajax({
			url : $apiURL,
			contentType: "application/json",
			type : $apiMethod,
			data: $formParams,
			dataType : 'json',
			success : function(data) {

				if(data==true)
					$("#result").append("true");
				else if(data==false)
					$("#result").append("false");
				else {
					$("#result").empty();
					
					$.map(data, function(item){
						$("#result").append("{");
						$.each(item,function(key,val){
				        	$("#result").append(key + ": " + val + ", ");
				        });
						$("#result").append("} \n");
					}); 
				}

			},
			error: function(xhr, status, error){
		         var errorMessage = xhr.status + ': ' + xhr.statusText
		         //alert('Error - ' + errorMessage);
		         $("#result").append("ERROR: " + errorMessage);
		     }
		});
	});
});

</script>
</html>