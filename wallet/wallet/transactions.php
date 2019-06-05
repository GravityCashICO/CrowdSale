<!doctype html>
<html class="no-js" lang="en">
    

<head>
        <meta charset="utf-8">
        <meta http-equiv="x-ua-compatible" content="ie=edge">
        <?php include("includes/title.php");?>
        <meta name="description" content="">
        <meta name="keywords" content="">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        
         <link rel="icon" href="img/favicon.png" type="image/x-icon" />

        <link href="https://fonts.googleapis.com/css?family=Nunito+Sans:300,400,600,700,800" rel="stylesheet">
        
        <link rel="stylesheet" href="node_modules/bootstrap/dist/css/bootstrap.min.css">
        <link rel="stylesheet" href="node_modules/%40fortawesome/fontawesome-free/css/all.min.css">
        <link rel="stylesheet" href="node_modules/ionicons/dist/css/ionicons.min.css">
        <link rel="stylesheet" href="node_modules/icon-kit/dist/css/iconkit.min.css">
        <link rel="stylesheet" href="node_modules/perfect-scrollbar/css/perfect-scrollbar.css">
        <link rel="stylesheet" href="node_modules/datatables.net-bs4/css/dataTables.bootstrap4.min.css">
        <link rel="stylesheet" href="dist/css/theme.min.css">
	 <link rel="stylesheet" href="dist/css/custom.css">
        <script src="src/js/vendor/modernizr-2.8.3.min.js"></script>
	<?php include("includes/head.php");?>
    </head>

    <body>


        <div class="wrapper">
            	<header class="header-top" header-theme="light">
            <?php  include("includes/header.php");?>
            </header>

            <div class="page-wrap">
                <div class="app-sidebar colored">
                    <div class="sidebar-header">
                        <a class="header-brand" href="index.html">
                            <div class="logo-img">
                               <img src="img/logo/logo-white.png" class="header-brand-img" alt="Gravity Cash"> 
                            </div>
                            <span class="text"></span>
                        </a>
                       <?php /*  <button type="button" class="nav-toggle"><i data-toggle="expanded" class="ik ik-toggle-right toggle-icon"></i></button>
                    */?>   <button id="sidebarClose" class="nav-close"><i class="ik ik-x"></i></button> 
                    </div>
                    
                   <div class="sidebar-content">
                       <?php  include("includes/side_menu.php");?> 
                    </div>
                </div>
                <div class="main-content">
                    <div class="container-fluid">
                        <div class="page-header">
							
							
							
							
							
							
							
							
                            <div class="row align-items-end">
                                <div class="col-lg-8">
                                    <div class="page-header-title">
                                        <i class="ik ik-file-text bg-dark"></i>
                                        <div class="d-inline">
                                            <h5> Transactions (GVCH)</h5>
                                            <span>Gravity Cash Transactions History</span>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-lg-4">
                                    <nav class="breadcrumb-container" aria-label="breadcrumb">
                                        <ol class="breadcrumb">
                                           
                                            <li class="breadcrumb-item">
                                                              
                                            </li>
                                            
                                        </ol>
                                    </nav>
                                </div>
                            </div>
								
                        </div>
							
							
							<!--Account Balance --><div class="row clearfix">
                            <div class="col-lg-6 col-md-6 col-sm-12">
                                <div class="widget bg-dark">
                                    <div class="widget-body">
                                        <div class="d-flex justify-content-between align-items-center">
                                            <div class="state">
                                                <h6>Account Balance</h6>
                                                <h2>250.47678 GVCH</h2>
                                            </div>
                                            <div class="icon">
                                                <i class="ik ik-file-text"></i>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            
                            
                            
                        </div>
							
					<!--Account Balance End -->		
							
							
							
							
							
							
						


                         <div class="row">
                            <div class="col-sm-12">
                                <div class="card">
                                    <div class="card-header d-block">
                                        <h3>GVCH Transactions</h3>
                                    </div>
                                    <div class="card-body">
                                        <div class="dt-responsive">
                                            <table  id="data_table" class="table table-responsive">
                                                <thead>
                                                <tr>
                                                    <th>SN</th>
													<th>Date</th>
													<th>Type</th>
                                                    <th>Address</th>
                                                    <th>Amount (GVCH)</th>
                                                    <th>Fee(GVCH)</th>
                                                 
                                                    <th>Status</th>
                                                </tr>
                                                </thead>
                                                <tbody>
                                                    <tr>
                                                  <td>1</td>
													<td>2018-09-29 05:57</td>
													<td class="text-left"><span class="badge badge-pill badge-primary">Processed</span></td>
													<td><a href="hash.php?id=0xde0b295669a9fd93d5f28d9ec85e40f4cb697bae">0xde0b295669a9fd93d5f28d9ec85e40f4cb697bae</a></td>
													<td class="text-right">55.20</td>
														<td class="text-right">0.01</td>
													<td class="text-right">
													<button type="button" class="btn btn-outline-secondary btn-rounded">
Unconfirmed</button>
													</td>
                                                    </tr>
													
													                 <tr>
                                                  <td>2</td>
													<td>2018-09-29 05:57</td>
													<td class="text-left"><span class="badge badge-pill badge-success">Receive</span></td>
													<td><a href="hash.php?id=0xde0b295669a9fd93d5f28d9ec85e40f4cb697bae">0xde0b295669a9fd93d5f28d9ec85e40f4cb697bae</a></td>
													<td class="text-right">55.20</td>
													<td class="text-right">0.01</td>
													<td class="text-right">
													<button type="button" class="btn btn-outline-success">Confirmed</button>
													</td>
                                                    </tr>
													
													                 <tr>
                                                  <td>3</td>
													<td>2018-09-29 05:57</td>
														<td class="text-left"><span class="badge badge-pill badge-success">Receive</span></td>
													<td><a href="hash.php?id=0xde0b295669a9fd93d5f28d9ec85e40f4cb697bae">0xde0b295669a9fd93d5f28d9ec85e40f4cb697bae</a></td>
													<td class="text-right">55.20</td>
													<td class="text-right">0.01</td>
													<td class="text-right">
													<button type="button" class="btn btn-outline-success">Confirmed</button>
													</td>
                                                    </tr>
													
													                 <tr>
                                                  <td>4</td>
													<td>2018-09-29 05:57</td>
														<td class="text-left"><span class="badge badge-pill badge-success">Receive</span></td>
													<td><a href="hash.php?id=0xde0b295669a9fd93d5f28d9ec85e40f4cb697bae">0xde0b295669a9fd93d5f28d9ec85e40f4cb697bae</a></td>
													<td class="text-right">55.20</td>
													<td class="text-right">0.01</td>
													<td class="text-right">
													<button type="button" class="btn btn-outline-success">Confirmed</button>
													</td>
                                                    </tr>
													
													                 <tr>
                                                  <td>5</td>
													<td>2018-09-29 05:57</td>
															<td class="text-left"><span class="badge badge-pill badge-danger">Send</span></td>
													<td><a href="hash.php?id=0xde0b295669a9fd93d5f28d9ec85e40f4cb697bae">0xde0b295669a9fd93d5f28d9ec85e40f4cb697bae</a></td>
													<td class="text-right">55.20</td>
													 <td class="text-right">0.01</td>
													<td class="text-right">
													<button type="button" class="btn btn-outline-success">Confirmed</button>
													</td>
                                                    </tr>
													
													                 <tr>
                                                  <td>6</td>
													<td>2018-09-29 05:57</td>
															<td class="text-left"><span class="badge badge-pill badge-danger">Send</span></td>
													<td><a href="hash.php?id=0xde0b295669a9fd93d5f28d9ec85e40f4cb697bae">0xde0b295669a9fd93d5f28d9ec85e40f4cb697bae</a></td>
													<td class="text-right">55.20</td>
													<td class="text-right">0.01</td>
													<td class="text-right">
												<button type="button" class="btn btn-outline-success">Confirmed</button>
													</td>
                                                    </tr>
													
													                 <tr>
                                                  <td>7</td>
													<td>2018-09-29 05:57</td>
														<td class="text-left"><span class="badge badge-pill badge-success">Receive</span></td>
													<td><a href="hash.php?id=0xde0b295669a9fd93d5f28d9ec85e40f4cb697bae">0xde0b295669a9fd93d5f28d9ec85e40f4cb697bae</a></td>
													<td class="text-right">55.20</td>
													<td class="text-right">0.01</td>
													<td class="text-right">
													<button type="button" class="btn btn-outline-success">Confirmed</button>
													</td>
                                                    </tr>
													
													                 <tr>
                                                  <td>8</td>
													<td>2018-09-29 05:57</td>
															<td class="text-left"><span class="badge badge-pill badge-danger">Send</span></td>
													<td><a href="hash.php?id=0xde0b295669a9fd93d5f28d9ec85e40f4cb697bae">0xde0b295669a9fd93d5f28d9ec85e40f4cb697bae</a></td>
													<td class="text-right">55.20</td>
													<td class="text-right">0.01</td>
													<td class="text-right">
													<button type="button" class="btn btn-outline-success">Confirmed</button>
													</td>
                                                    </tr>
													
													                 <tr>
                                                  <td>9</td>
													<td>2018-09-29 05:57</td>
														<td class="text-left"><span class="badge badge-pill badge-success">Receive</span></td>
													<td><a href="hash.php?id=0xde0b295669a9fd93d5f28d9ec85e40f4cb697bae">0xde0b295669a9fd93d5f28d9ec85e40f4cb697bae</a></td>
													<td class="text-right">55.20</td>
													<td class="text-right">0.01</td>
													<td class="text-right">
													<button type="button" class="btn btn-outline-success">Confirmed</button>
													</td>
                                                    </tr>
													
													                 <tr>
                                                  <td>10</td>
													<td>2018-09-29 05:57</td>
														<td class="text-left"><span class="badge badge-pill badge-danger">Send</span></td>
													<td><a href="hash.php?id=0xde0b295669a9fd93d5f28d9ec85e40f4cb697bae">0xde0b295669a9fd93d5f28d9ec85e40f4cb697bae</a></td>
													<td class="text-right">55.20</td>
													 <td class="text-right">0.01</td>
													<td class="text-right">
													<button type="button" class="btn btn-outline-success">Confirmed</button>
													</td>
                                                    </tr>
													
													                 <tr>
                                                  <td>11</td>
													<td>2018-09-29 05:57</td>
														<td class="text-left"><span class="badge badge-pill badge-success">Receive</span></td>
													<td><a href="hash.php?id=0xde0b295669a9fd93d5f28d9ec85e40f4cb697bae">0xde0b295669a9fd93d5f28d9ec85e40f4cb697bae</a></td>
													<td class="text-right">55.20</td>
													<td class="text-right">0.01</td>
													<td class="text-right">
												<button type="button" class="btn btn-outline-success">Confirmed</button>
													</td>
                                                    </tr>
													
													                 <tr>
                                                  <td>12</td>
													<td>2018-09-29 05:57</td>
														<td class="text-left"><span class="badge badge-pill badge-success">Receive</span></td>
													<td><a href="hash.php?id=0xde0b295669a9fd93d5f28d9ec85e40f4cb697bae">0xde0b295669a9fd93d5f28d9ec85e40f4cb697bae</a></td>
													<td class="text-right">55.20</td>
													<td class="text-right">0.01</td>
													<td class="text-right">
													<button type="button" class="btn btn-outline-success">Confirmed</button>
													</td>
                                                    </tr>
													
													                 <tr>
                                                  <td>13</td>
													<td>2018-09-29 05:57</td>
														<td class="text-left"><span class="badge badge-pill badge-success">Receive</span></td>
													<td><a href="hash.php?id=0xde0b295669a9fd93d5f28d9ec85e40f4cb697bae">0xde0b295669a9fd93d5f28d9ec85e40f4cb697bae</a></td>
													<td class="text-right">55.20</td>
													<td class="text-right">0.01</td>
													<td class="text-right">
												<button type="button" class="btn btn-outline-success">Confirmed</button>
													</td>
                                                    </tr>
													
													                 <tr>
                                                  <td>14</td>
													<td>2018-09-29 05:57</td>
														<td class="text-left"><span class="badge badge-pill badge-success">Receive</span></td>
													<td><a href="hash.php?id=0xde0b295669a9fd93d5f28d9ec85e40f4cb697bae">0xde0b295669a9fd93d5f28d9ec85e40f4cb697bae</a></td>
													<td class="text-right">55.20</td>
													<td class="text-right">0.01</td>
													<td class="text-right">
													<button type="button" class="btn btn-outline-success">Confirmed</button>
													</td>
                                                    </tr>
                                                   
                                                </tbody>
                                 
                                            </table>
                                        </div>
                                    </div>
                                </div>
                               
            
                                <!-- Language - -->
                            </div>
                        </div>
                    </div>
                </div>
              
               <footer class="footer">
          <?php include("includes/footer.php");?>
                </footer>
            </div>
        </div>
        
        
        
<?php include("includes/footer_down.php");?>
        
        
        <script src="../../code.jquery.com/jquery-3.3.1.min.js"></script>
        <script>window.jQuery || document.write('<script src="src/js/vendor/jquery-3.3.1.min.js"><\/script>')</script>
        <script src="node_modules/popper.js/dist/umd/popper.min.js"></script>
        <script src="node_modules/bootstrap/dist/js/bootstrap.min.js"></script>
        <script src="node_modules/perfect-scrollbar/dist/perfect-scrollbar.min.js"></script>
        <script src="node_modules/screenfull/dist/screenfull.js"></script>
        <script src="node_modules/datatables.net/js/jquery.dataTables.min.js"></script>
        <script src="node_modules/datatables.net-bs4/js/dataTables.bootstrap4.min.js"></script>
        <script src="dist/js/theme.min.js"></script>
        <script src="js/tables.js"></script>
    
        <script>
            (function(b,o,i,l,e,r){b.GoogleAnalyticsObject=l;b[l]||(b[l]=
            function(){(b[l].q=b[l].q||[]).push(arguments)});b[l].l=+new Date;
            e=o.createElement(i);r=o.getElementsByTagName(i)[0];
            e.src='../../www.google-analytics.com/analytics.js';
            r.parentNode.insertBefore(e,r)}(window,document,'script','ga'));
            ga('create','UA-XXXXX-X','auto');ga('send','pageview');
        </script>
    </body>


</html>
