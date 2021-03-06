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
    <title>Gravity Cash Wallet</title>

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

    <!-- Main CSS-->
    <link href="css/theme.css" rel="stylesheet" media="all">

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

            <!-- BREADCRUMB-->
            <section class="au-breadcrumb m-t-75">
                <div class="section__content section__content--p30">
                    <div class="container-fluid">
                        <div class="row">
                            <div class="col-md-12">
                                <div class="au-breadcrumb-content">
                                    <div class="au-breadcrumb-left">
                                        <span class="au-breadcrumb-span">You are here:</span>
                                        <ul class="list-unstyled list-inline au-breadcrumb__list">
                                            <li class="list-inline-item active">
                                                <a href="#">Wallet</a>
                                            </li>
                                            <li class="list-inline-item seprate">
                                                <span>/</span>
                                            </li>
                                            <li class="list-inline-item">Profile</li>
                                        </ul>
                                    </div>
                                   
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
            <!-- END BREADCRUMB-->

          
            <section>
                <div class="section__content section__content--p30">
                    <div class="container-fluid">
                        <div class="row">
							
							<div class="col-lg-9">
                                <div class="card">
                                    <div class="card-header">
                                        <strong>Profile Update</strong>
                                    </div>
                                    <div class="card-body card-block">
                                        <form action="" method="post" enctype="multipart/form-data" class="form-horizontal">
                                            
                                            <div class="row form-group">
                                                <div class="col col-md-3">
                                                    <label for="text-input" class=" form-control-label">First Name</label>
                                                </div>
                                                <div class="col-12 col-md-9">
                                                    <input type="text" id="text-input" name="first_name" placeholder="First Name" class="form-control">
                                                  
                                                </div>
                                            </div>
                                            <div class="row form-group">
                                                <div class="col col-md-3">
                                                    <label for="email-input" class=" form-control-label">Last Name</label>
                                                </div>
                                                <div class="col-12 col-md-9">
                                                    <input type="text" id="email-input" name="last_name" placeholder="Last Name" class="form-control">
                                                  
                                                </div>
                                            </div>
											
												     <div class="row form-group">
                                                <div class="col col-md-3">
                                                    <label for="email-input" class=" form-control-label">Country</label>
                                                </div>
                                                <div class="col-12 col-md-9">
                                                     <select name="select" id="select" class="form-control">
                                                       <option value="">Select here..</option>              <option value="Afghanistan"> Afghanistan</option> 
 <option value="Albania"> Albania</option> 
 <option value="Algeria"> Algeria</option> 
 <option value="Andorra"> Andorra</option> 
 <option value="Angola"> Angola</option> 
 <option value="Antigua and Barbuda"> Antigua and Barbuda</option> 
 <option value="Argentina"> Argentina</option> 
 <option value="Armenia"> Armenia</option> 
 <option value="Aruba"> Aruba</option> 
 <option value="Australia"> Australia</option> 
 <option value="Austria"> Austria</option> 
 <option value="Azerbaijan"> Azerbaijan</option> 
 <option value="Bahamas"> Bahamas</option> 
 <option value="Bahrain"> Bahrain</option> 
 <option value="Bangladesh"> Bangladesh</option> 
 <option value="Barbados"> Barbados</option> 
 <option value="Belarus"> Belarus</option> 
 <option value="Belgium"> Belgium</option> 
 <option value="Belize"> Belize</option> 
 <option value="Benin"> Benin</option> 
 <option value="Bhutan"> Bhutan</option> 
 <option value="Bolivia"> Bolivia</option> 
 <option value="Bosnia and Herzegovina"> Bosnia and Herzegovina</option> 
 <option value="Botswana"> Botswana</option> 
 <option value="Brazil"> Brazil</option> 
 <option value="Brunei"> Brunei</option> 
 <option value="Bulgaria"> Bulgaria</option> 
 <option value="Burkina Faso"> Burkina Faso</option> 
 <option value="Burma"> Burma</option> 
 <option value="Burundi"> Burundi</option> 
 <option value="Burundi"> Burundi</option> 
 <option value="Cabo Verde"> Cabo Verde</option> 
 <option value="Cambodia"> Cambodia</option> 
 <option value="Cameroon"> Cameroon</option> 
 <option value="Canada"> Canada</option> 
 <option value="Central African Republic"> Central African Republic</option> 
 <option value="Chad"> Chad</option> 
 <option value="China"> China</option> 
 <option value="Colombia"> Colombia</option> 
 <option value="Comoros"> Comoros</option> 
 <option value="Congo - Democratic Republic of the"> Congo - Democratic Republic of the</option> 
 <option value="Congo - Republic of the"> Congo - Republic of the</option> 
 <option value="Costa Rica"> Costa Rica</option> 
 <option value="Cote d Ivoire"> Cote d Ivoire</option> 
 <option value="Croatia"> Croatia</option> 
 <option value="Cuba"> Cuba</option> 
 <option value="Curacao"> Curacao</option> 
 <option value="Cyprus"> Cyprus</option> 
 <option value="Czech Republic"> Czech Republic</option> 
 <option value="Denmark"> Denmark</option> 
 <option value="Djibouti"> Djibouti</option> 
 <option value="Dominica"> Dominica</option> 
 <option value="Dominican Republic"> Dominican Republic</option> 
 <option value="East Timor"> East Timor</option> 
 <option value="Ecuador"> Ecuador</option> 
 <option value="Egypt"> Egypt</option> 
 <option value="El Salvador"> El Salvador</option> 
 <option value="Equatorial Guinea"> Equatorial Guinea</option> 
 <option value="Eritrea"> Eritrea</option> 
 <option value="Estonia"> Estonia</option> 
 <option value="Ethiopia"> Ethiopia</option> 
 <option value="Fiji"> Fiji</option> 
 <option value="Finland"> Finland</option> 
 <option value="France"> France</option> 
 <option value="Gabon"> Gabon</option> 
 <option value="Gambia"> Gambia</option> 
 <option value="Georgia"> Georgia</option> 
 <option value="Germany"> Germany</option> 
 <option value="Ghana"> Ghana</option> 
 <option value="Greece"> Greece</option> 
 <option value="Grenada"> Grenada</option> 
 <option value="Guatemala"> Guatemala</option> 
 <option value="Guinea"> Guinea</option> 
 <option value="Guinea-Bissau"> Guinea-Bissau</option> 
 <option value="Guyana"> Guyana</option> 
 <option value="Haiti"> Haiti</option> 
 <option value="Holy See"> Holy See</option> 
 <option value="Honduras"> Honduras</option> 
 <option value="Hong Kong"> Hong Kong</option> 
 <option value="Hungary"> Hungary</option> 
 <option value="Iceland"> Iceland</option> 
 <option value="India"> India</option> 
 <option value="Indonesia"> Indonesia</option> 
 <option value="Iran"> Iran</option> 
 <option value="Iraq"> Iraq</option> 
 <option value="Ireland"> Ireland</option> 
 <option value="Israel"> Israel</option> 
 <option value="Italy"> Italy</option> 
 <option value="Jamaica"> Jamaica</option> 
 <option value="Japan"> Japan</option> 
 <option value="Jordan"> Jordan</option> 
 <option value="Kazakhstan"> Kazakhstan</option> 
 <option value="Kenya"> Kenya</option> 
 <option value="Kiribati"> Kiribati</option> 
 <option value="Korea North"> Korea North</option> 
 <option value="Korea South"> Korea South</option> 
 <option value="Kosovo"> Kosovo</option> 
 <option value="Kuwait"> Kuwait</option> 
 <option value="Kyrgyzstan"> Kyrgyzstan</option> 
 <option value="Laos"> Laos</option> 
 <option value="Latvia"> Latvia</option> 
 <option value="Lebanon"> Lebanon</option> 
 <option value="Lesotho"> Lesotho</option> 
 <option value="Liberia"> Liberia</option> 
 <option value="Libya"> Libya</option> 
 <option value="Liechtenstein"> Liechtenstein</option> 
 <option value="Lithuania"> Lithuania</option> 
 <option value="Luxembourg"> Luxembourg</option> 
 <option value="Macau"> Macau</option> 
 <option value="Macedonia"> Macedonia</option> 
 <option value="Madagascar"> Madagascar</option> 
 <option value="Malawi"> Malawi</option> 
 <option value="Malaysia"> Malaysia</option> 
 <option value="Maldives"> Maldives</option> 
 <option value="Mali"> Mali</option> 
 <option value="Malta"> Malta</option> 
 <option value="Marshall Islands"> Marshall Islands</option> 
 <option value="Mauritania"> Mauritania</option> 
 <option value="Mauritius"> Mauritius</option> 
 <option value="Mexico"> Mexico</option> 
 <option value="Micronesia"> Micronesia</option> 
 <option value="Moldova"> Moldova</option> 
 <option value="Monaco"> Monaco</option> 
 <option value="Mongolia"> Mongolia</option> 
 <option value="Montenegro"> Montenegro</option> 
 <option value="Morocco"> Morocco</option> 
 <option value="Mozambique"> Mozambique</option> 
 <option value="Namibia"> Namibia</option> 
 <option value="Nauru"> Nauru</option> 
 <option value="Nepal"> Nepal</option> 
 <option value="Netherlands"> Netherlands</option> 
 <option value="Netherlands Antilles"> Netherlands Antilles</option> 
 <option value="New Zealand"> New Zealand</option> 
 <option value="Nicaragua"> Nicaragua</option> 
 <option value="Niger"> Niger</option> 
 <option value="Nigeria"> Nigeria</option> 
 <option value="North Korea"> North Korea</option> 
 <option value="Norway"> Norway</option> 
 <option value="Oman"> Oman</option> 
 <option value="Pakistan"> Pakistan</option> 
 <option value="Palau"> Palau</option> 
 <option value="Palestinian Territories"> Palestinian Territories</option> 
 <option value="Panama"> Panama</option> 
 <option value="Papua New Guinea"> Papua New Guinea</option> 
 <option value="Paraguay"> Paraguay</option> 
 <option value="Peru"> Peru</option> 
 <option value="Philippines"> Philippines</option> 
 <option value="Poland"> Poland</option> 
 <option value="Portugal"> Portugal</option> 
 <option value="Qatar"> Qatar</option> 
 <option value="Romania"> Romania</option> 
 <option value="Russia"> Russia</option> 
 <option value="Rwanda"> Rwanda</option> 
 <option value="Saint Kitts and Nevis"> Saint Kitts and Nevis</option> 
 <option value="Saint Lucia"> Saint Lucia</option> 
 <option value="Saint Vincent and the Grenadines"> Saint Vincent and the Grenadines</option> 
 <option value="Samoa"> Samoa</option> 
 <option value="San Marino"> San Marino</option> 
 <option value="Sao Tome and Principe"> Sao Tome and Principe</option> 
 <option value="Saudi Arabia"> Saudi Arabia</option> 
 <option value="Senegal"> Senegal</option> 
 <option value="Serbia"> Serbia</option> 
 <option value="Seychelles"> Seychelles</option> 
 <option value="Sierra Leone"> Sierra Leone</option> 
 <option value="Singapore"> Singapore</option> 
 <option value="Sint Maarten"> Sint Maarten</option> 
 <option value="Slovakia"> Slovakia</option> 
 <option value="Slovenia"> Slovenia</option> 
 <option value="Solomon Islands"> Solomon Islands</option> 
 <option value="Somalia"> Somalia</option> 
 <option value="South Africa"> South Africa</option> 
 <option value="South Korea"> South Korea</option> 
 <option value="South Sudan"> South Sudan</option> 
 <option value="Spain"> Spain</option> 
 <option value="Sri Lanka"> Sri Lanka</option> 
 <option value="Sudan"> Sudan</option> 
 <option value="Suriname"> Suriname</option> 
 <option value="Swaziland"> Swaziland</option> 
 <option value="Sweden"> Sweden</option> 
 <option value="Switzerland"> Switzerland</option> 
 <option value="Syria"> Syria</option> 
 <option value="Taiwan"> Taiwan</option> 
 <option value="Tajikistan"> Tajikistan</option> 
 <option value="Tanzania"> Tanzania</option> 
 <option value="Thailand"> Thailand</option> 
 <option value="Timor-Leste"> Timor-Leste</option> 
 <option value="Togo"> Togo</option> 
 <option value="Tonga"> Tonga</option> 
 <option value="Trinidad and Tobago"> Trinidad and Tobago</option> 
 <option value="Tunisia"> Tunisia</option> 
 <option value="Turkey"> Turkey</option> 
 <option value="Turkmenistan"> Turkmenistan</option> 
 <option value="Tuvalu"> Tuvalu</option> 
 <option value="Uganda"> Uganda</option> 
 <option value="Ukraine"> Ukraine</option> 
 <option value="United Arab Emirates"> United Arab Emirates</option> 
 <option value="United Kingdom"> United Kingdom</option> 
 <option value="United States of America"> United States of America</option> 
 <option value="Uruguay"> Uruguay</option> 
 <option value="Uzbekistan"> Uzbekistan</option> 
 <option value="Vanuatu"> Vanuatu</option> 
 <option value="Venezuela"> Venezuela</option> 
 <option value="Vietnam"> Vietnam</option> 
 <option value="Yemen"> Yemen</option> 
 <option value="Zambia"> Zambia</option> 
 <option value="Zimbabwe"> Zimbabwe</option> 
														 
                                      
                                                    </select>
                                                  
                                                </div>
                                            </div>
											
											
											<div class="row form-group">
                                                <div class="col col-md-3">
                                                    <label class=" form-control-label">Sex </label>
                                                </div>
                                                <div class="col col-md-9">
                                                    <div class="form-check-inline form-check">
                                                        <label for="inline-radio1" class="form-check-label ">
                                                            <input type="radio" id="inline-radio1" name="inline-radios" value="option1" class="form-check-input">Male  &nbsp;
                                                        </label>
														
                                                        <label for="inline-radio2" class="form-check-label ">
                                                            <input type="radio" id="inline-radio2" name="inline-radios" value="option2" class="form-check-input">Female
                                                        </label>
                                                       
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="row form-group">
                                                <div class="col col-md-3">
                                                    <label for="password-input" class=" form-control-label">Email Address</label>
                                                </div>
                                                <div class="col-12 col-md-9">
                                                    <input type="email" id="password-input" name="email" placeholder="Email" disabled="" class="form-control">
                                                  
                                                </div>
                                            </div>
											
											<div class="row form-group">
                                                <div class="col col-md-3">
                                                    <label for="email-input" class=" form-control-label">Address</label>
                                                </div>
                                                <div class="col-12 col-md-9">
                                                    <input type="text" id="email-input" name="address" placeholder="Address" class="form-control">
                                                    
                                                </div>
                                            </div>
											
											<div class="row form-group">
                                                <div class="col col-md-3">
                                                    <label for="email-input" class=" form-control-label">Mobile No</label>
                                                </div>
                                                <div class="col-12 col-md-9">
                                                    <input type="text" id="email-input" name="address" placeholder="Mobile" class="form-control">
                                                   
                                                </div>
                                            </div>
											<div class="row form-group">
                                                <div class="col col-md-3">
                                                  
                                                </div>
                                                <div class="col-12 col-md-9">
                                        <button type="submit" class="btn btn-success">
                                            <i class="fa fa-save"></i>  Update
                                        </button>
                                                </div>
                                            </div>
                                           
                                            
                                   
                                        
                                 
                                </div>
                                
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

</body>

</html>
<!-- end document-->