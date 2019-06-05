<!DOCTYPE html>
<html lang="en">
  <head>
    <!-- Required meta tags-->
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="Gravity Cash Wallet">
    <meta name="author" content="Gravity Cash Team">
    <meta name="keywords" content="Gravity Cash">

	 <link rel="shortcut icon" href="images/icon/favicon.png">

    <!-- Title Page-->
    <title>GVCH Token ICO Sale</title>

    <!-- Fontfaces CSS-->
    <link href="css/font-face.css" rel="stylesheet" media="all">
    <link href="vendor/font-awesome-4.7/css/font-awesome.min.css" rel="stylesheet" media="all">
    <link href="vendor/font-awesome-5/css/fontawesome-all.min.css" rel="stylesheet" media="all">
    <link href="vendor/mdi-font/css/material-design-iconic-font.min.css" rel="stylesheet" media="all">

    <!-- Bootstrap CSS-->
    <link href="vendor/bootstrap-4.1/bootstrap.min.css" rel="stylesheet" media="all">

    <!-- Vendor CSS-->
    <link href="vendor/animsition/animsition.min.css" rel="stylesheet" media="all">
    <link href="vendor/bootstrap-progressbar/bootstrap-progressbar-3.3.4.min.css" rel="stylesheet" media="all">
    <link href="vendor/wow/animate.css" rel="stylesheet" media="all">
    <link href="vendor/css-hamburgers/hamburgers.min.css" rel="stylesheet" media="all">
    <link href="vendor/slick/slick.css" rel="stylesheet" media="all">
    <link href="vendor/select2/select2.min.css" rel="stylesheet" media="all">
    <link href="vendor/perfect-scrollbar/perfect-scrollbar.css" rel="stylesheet" media="all">
    <link href="vendor/vector-map/jqvmap.min.css" rel="stylesheet" media="all">

	<link href="css/bootstrap.min.css" rel="stylesheet">
    <!-- Main CSS-->
    <link href="css/theme.css" rel="stylesheet" media="all">
    
    <!-- Bootstrap -->
    
  </head>
  <body class="animsition">
    <div class="page-wrapper">
        <!-- MENU SIDEBAR-->
        <aside class="menu-sidebar2">
            <div class="logo">
                <a href="#">
                    <img src="images/icon/logo-white.png" alt="Cool Admin" />
                </a>
            </div>
           <div class="menu-sidebar2__content js-scrollbar1">
            
                <nav class="navbar-sidebar2">
					
					<?php include("includes/menu.php") ; ?>
                 
                </nav>
            </div>
        </aside>
        <!-- END MENU SIDEBAR-->

        <!-- PAGE CONTAINER-->
        <div class="page-container2">
            <!-- HEADER DESKTOP-->
            <header class="header-desktop2">
                <div class="section__content section__content--p30">
                    <div class="container-fluid">
                        <div class="header-wrap2">
                            <div class="logo d-block d-lg-none">
                                <a href="#">
                                    <img src="images/icon/logo-white.png" alt="CoolAdmin" />
                                </a>
                            </div>
                          <?php include("includes/header_menu.php");?>                        </div>
                    </div>
                </div>
            </header>
            <aside class="menu-sidebar2 js-right-sidebar d-block d-lg-none">
                <div class="logo">
                    <a href="#">
                        <img src="images/icon/logo-white.png" alt="Cool Admin" />
                    </a>
                </div>
                <div class="menu-sidebar2__content js-scrollbar2">
                   
                    <nav class="navbar-sidebar2">
                  <?php include("includes/res_menu.php"); ?>
                    </nav>
                </div>
            </aside>
            <!-- END HEADER DESKTOP-->

   

            <section>
                <div class="container" style="width: 650px;">
      <div class="row">
        <div class="col-lg-12">
            <h1 class="text-center">GVCH TOKEN ICO SALE</h1>
            <h6 class="text-center">TOTAL TOKENS:(<b>42000000</b>). ADMIN CARRYING <b>50%</b> TOKENS AND 50% IS FOR SALE.</h6>
            <hr/>
            <br/>
        </div>
        <div id="loader">
          <p class="text-center">Loading...</p>
        </div>
        <div id="content" class="text-center" style="display: none;">
          <p>
            Introducing "GVCH Token" (GVCH)!
            Token price is <span class="token-price"></span> Ether. You currently have <span class="GVCH-balance"></span>&nbsp;GVCH.
          </p>
          <br/>
          <form onSubmit="App.buyTokens(); return false;" role="form">
            <div class="form-group">
              <div class="input-group">
                <input id="numberOfTokens" class="form-control input-lg" type="number" name="number" value="1" min="1" pattern="[0-9]">
                </input>
                <span class="input-group-btn">
                  <button type="submit" class="btn btn-primary btn-lg">Buy Tokens</button>
                </span>
              </div>
            </div>
          </form>
          <br>
           <div class="progress">
              <div id="progress" class="progress-bar progress-bar-striped active" aria-valuemin="0" aria-valuemax="100">
              </div>
            </div>
          <p><span class="tokens-sold"></span> / <span class="tokens-available"></span> tokens sold</p>
          <div class="alert alert-danger" role="alert"><span class="glyphicon glyphicon-info-sign"></span>&nbsp;<b>NOTICE:</b> This token sale uses the Rinkeby Test Network with fake ether. Use a browser extension like Metamask to connect to the test network and participate in the ICO. Please be patient if the test nework runs slowly.</div>
          <hr>
          <p id="accountAddress"></p>
        </div>
      </div>
    </div>
                    
                </div>
            </section>

            <section>
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-md-12">
                         <?php include("includes/footer.php");?>
                        </div>
                    </div>
                </div>
            </section>
            <!-- END PAGE CONTAINER-->
        </div>

    </div>

    <!-- Jquery JS-->
    <script src="vendor/jquery-3.2.1.min.js"></script>
    <!-- Bootstrap JS-->
    <script src="vendor/bootstrap-4.1/popper.min.js"></script>
    <script src="vendor/bootstrap-4.1/bootstrap.min.js"></script>
    <!-- Vendor JS       -->
    <script src="vendor/slick/slick.min.js">
    </script>
    <script src="vendor/wow/wow.min.js"></script>
    <script src="vendor/animsition/animsition.min.js"></script>
    <script src="vendor/bootstrap-progressbar/bootstrap-progressbar.min.js">
    </script>
    <script src="vendor/counter-up/jquery.waypoints.min.js"></script>
    <script src="vendor/counter-up/jquery.counterup.min.js">
    </script>
    <script src="vendor/circle-progress/circle-progress.min.js"></script>
    <script src="vendor/perfect-scrollbar/perfect-scrollbar.js"></script>
    <script src="vendor/chartjs/Chart.bundle.min.js"></script>
    <script src="vendor/select2/select2.min.js">
    </script>
    <script src="vendor/vector-map/jquery.vmap.js"></script>
    <script src="vendor/vector-map/jquery.vmap.min.js"></script>
    <script src="vendor/vector-map/jquery.vmap.sampledata.js"></script>
    <script src="vendor/vector-map/jquery.vmap.world.js"></script>
	
	

    <!-- Main JS-->
    <script src="js/main.js"></script>
	
	
<!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/web3.min.js"></script>
    <script src="js/truffle-contract.min.js"></script>
    <script src="js/app.js"></script>
</body>

  
  
    
  
</html>
