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
                                        <i class="ik ik-user bg-blue"></i>
                                        <div class="d-inline">
                                            <h5> Profile</h5>
                                            <span>User Profile</span>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-lg-4">
                                    <nav class="breadcrumb-container" aria-label="breadcrumb">
                                        <ol class="breadcrumb">
                                           
                                            <li class="breadcrumb-item">
                                                            <?php /*   <a href="index.html" class="btn btn-primary"><i class="ik ik-plus-circle"></i> Create Address</a> */?>
                                            </li>
                                            
                                        </ol>
                                    </nav>
                                </div>
                            </div>
                        </div>


                        <div class="row">
                            <div class="col-md-6">
                                <div class="card" style="min-height: 484px;">
                                    <div class="card-header"><h3>Change Password</h3></div>
									
									   <div class="card-body">
                                        <form class="forms-sample">
                                            
											
											 <div class="form-group">
                                                <label for="exampleInputName1">First Name</label>
                                                <input type="text" class="form-control" id="exampleInputName1" placeholder="First Name">
                                            </div>
											
											
											 <div class="form-group">
                                                <label for="exampleInputName1">Last Name</label>
                                                <input type="text" class="form-control" id="exampleInputName1" placeholder="Last Name">
                                            </div>
											
											<div class="form-group">
                                                        <label for="exampleInputEmail3">Email address</label>
                                                        <input type="email" class="form-control" id="exampleInputEmail3" placeholder="Email">
                                                    </div>
											
                                           <div class="form-group">
                                                        <label for="exampleSelectGender">Gender</label>
                                                        <select class="form-control" id="exampleSelectGender">
                                                            <option>Male</option>
                                                            <option>Female</option>
                                                        </select>
                                             </div>
											
											     <div class="form-group">
                                                        <label for="exampleSelectGender">Country</label>
                                                        <select class="form-control" id="exampleSelectGender">
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
											
											 <div class="form-group">
                                                <label for="exampleInputName1">Address</label>
                                                <input type="text" class="form-control" id="exampleInputName1" placeholder="Address">
                                            </div>
											
											 <div class="form-group">
                                                <label for="exampleInputName1">Mobile No</label>
                                                <input type="text" class="form-control" id="exampleInputName1" placeholder="Mobile No">
                                            </div>
                                          
                                           
                                            <div class="form-group">
                                                
                                            </div>
                                            <button type="submit" class="btn btn-primary mr-2">Save</button>
                                           
                                          </form>
                                    </div>
                                    
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
