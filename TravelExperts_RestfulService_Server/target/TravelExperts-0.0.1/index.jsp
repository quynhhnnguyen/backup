<html>
<head>
<title>The Travel Experts</title>

<link href="css/bootstrap.min.css" rel="stylesheet" type="text/css">
<script src="js/jquery-3.3.1.js"></script>
</head>
<body>

	<div align="center">

		<div id="banner"></div>

		<div id="body">
			<p>&nbsp;</p>
			<table width="760" align='center' border='0'>
				<tr>
					<td colspan="3">
						<h4>Welcome to Travel Experts Restful
							API.</h4>
					</td>
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
					<td>Form Params:</td>
					<td><textarea rows="20" cols="50" id="formParams"></textarea>
					</td>
				</tr>
				<tr>
					<td>Result:</td>
					<td><textarea rows="20" cols="50" id="result"></textarea></td>

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
		
		if($formParams == "" || $formParams == null) {
			$formParams = {};
		} 
		$.ajax({
			url : $apiURL,
			type : $apiMethod,
			data: $formParams,
			dataType : 'json',
			success : function(data) {

				$("#result").empty();
				
				$.map(data, function(item){
					$("#result").append("{");
					$.each(item,function(key,val){
			        	$("#result").append(key + " " + val + ", ");
			        });
					$("#result").append("} \n");
				}); 

				
			}
		});
	});
});

</script>
</html>