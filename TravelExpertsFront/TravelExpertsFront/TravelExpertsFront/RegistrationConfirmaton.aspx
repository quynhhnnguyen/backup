<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationConfirmaton.aspx.cs" Inherits="TravelExpertsFront.RegistrationConfirmaton" %>

<%--Customer Registration Form
    Author:Muhammad islam
    Helper: Jeremiah Lobo
    Created:Jan, 2019--%>
<!doctype html>
<html lang="en">
<head>
  
	<meta charset="utf-8" />
	<link rel="apple-touch-icon" sizes="76x76" href="../../assets/img/apple-icon.png">
	<link rel="icon" type="image/png" sizes="96x96" href="../../assets/img/favicon.png">
	<meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />

	<title>Register</title>

	<meta content='width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0' name='viewport' />
    <meta name="viewport" content="width=device-width" />


     <!-- Bootstrap core CSS     -->
    <link href="../assets/css/bootstrap.min.css" rel="stylesheet" />

    <!--  Paper Dashboard core CSS    -->
    <link href="../assets/css/paper-dashboard.css" rel="stylesheet"/>


    <!--  CSS for Demo Purpose, don't include it in your project     -->
    <link href="../assets/css/demo.css" rel="stylesheet" />


    <!--  Fonts and icons     -->
    <link href="http://maxcdn.bootstrapcdn.com/font-awesome/latest/css/font-awesome.min.css" rel="stylesheet">
    <link href='https://fonts.googleapis.com/css?family=Muli:400,300' rel='stylesheet' type='text/css'>
    <link href="../assets/css/themify-icons.css" rel="stylesheet">
    <script src="../assets/js/jquery-3.1.1.min.js"></script>
    <style>
        .gap {
            padding-bottom: 160px;
        }
        </style>
</head>
<body>
    <nav class="navbar navbar-transparent navbar-absolute">
	    <div class="container">
	        <div class="navbar-header">
	            <button type="button" class="navbar-toggle navbar-toggle-black" data-toggle="collapse" data-target="#navigation-example-2">
	                <span class="sr-only">Toggle navigation</span>
	                <span class="icon-bar "></span>
	                <span class="icon-bar "></span>
	                <span class="icon-bar"></span>
	            </button>
	        </div>
	        <div class="collapse navbar-collapse">
	            <ul class="nav navbar-nav navbar-right">
	                <li>
	                   <a href="login.aspx" class="btn">
	                        Looking to login?
	                    </a>
	                </li>
	            </ul>
	        </div>
	    </div>
	</nav>
    <div class="wrapper wrapper-full-page">
    	<div class="full-page login-page" data-color="purple" data-image="../assets/img/background/background-2.jpg" >
		<!--   you can change the color of the filter page using: data-color="blue | azure | green | orange | red | purple" -->
        	<div class="content">
         <div class="container">
        <div class="row">
            <div class="col-md-4 col-sm-6 col-md-offset-4 col-sm-offset-3">
                <div class="gap"></div>
                    <div class="card ">
	                            <div class="card-header">
	                                <h4 class="card-title"> Thank you! ^ _ ^</h4>
	                            </div>
	                            <div class="card-content">
                                    <h1> Thanks For Registering!</h1>
                                </div>
	                        </div>
                    </div>
                </div>
            </div>
        </div>
       </div>
    </div>   

</body>
</html>
