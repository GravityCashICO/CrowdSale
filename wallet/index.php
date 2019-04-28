<!doctype html>
<html class="no-js" lang="en">
    

<head>
        <meta charset="utf-8">
        <meta http-equiv="x-ua-compatible" content="ie=edge">
         <?php include("wallet/includes/title.php");?>
        <meta name="description" content="">
        <meta name="keywords" content="">
        <meta name="viewport" content="width=device-width, initial-scale=1">
        
        <link rel="icon" href="wallet/img/favicon.png" type="image/x-icon" />

        <link href="https://fonts.googleapis.com/css?family=Nunito+Sans:300,400,600,700,800" rel="stylesheet">
        
        <link rel="stylesheet" href="wallet/node_modules/bootstrap/dist/css/bootstrap.min.css">
        <link rel="stylesheet" href="wallet/node_modules/%40fortawesome/fontawesome-free/css/all.min.css">
        <link rel="stylesheet" href="wallet/node_modules/ionicons/dist/css/ionicons.min.css">
        <link rel="stylesheet" href="wallet/node_modules/icon-kit/dist/css/iconkit.min.css">
        <link rel="stylesheet" href="wallet/node_modules/perfect-scrollbar/css/perfect-scrollbar.css">
        <link rel="stylesheet" href="wallet/dist/css/theme.min.css">
        <script src="wallet/src/js/vendor/modernizr-2.8.3.min.js"></script>
    </head>

    <body>
        

        <div class="auth-wrapper">
            <div class="container-fluid h-100">
                <div class="row flex-row h-100 bg-white">
                    <div class="col-xl-8 col-lg-6 col-md-5 p-0 d-md-block d-lg-block d-sm-none d-none">
                        <div class="lavalite-bg" style="background-image: url('wallet/img/auth/login-bg.jpg')">
                            <div class="lavalite-overlay"></div>
                        </div>
                    </div>
                    <div class="col-xl-4 col-lg-6 col-md-7 my-auto p-0">
                        <div class="authentication-form mx-auto">
                            <div class="logo-centered">
                                <a href="home/index.php"><img src="wallet/img/gch-black-logo.png" style="width: 80px;" alt=""></a>
                            </div>
                            <h3>Gravity Cash Login</h3>
                            <p>Sign in to GCH online wallet</p>
                            <form method="post" action="wallet/home.php">
                                <div class="form-group">
                                    <input type="text" class="form-control" placeholder="Email" required="" value="username@email.com">
                                    <i class="ik ik-user"></i>
                                </div>
                                <div class="form-group">
                                    <input type="password" class="form-control" placeholder="Password" required="" value="123456">
                                    <i class="ik ik-lock"></i>
                                </div>
                                <div class="row">
                                    <div class="col text-left">
                                        <label class="custom-control custom-checkbox">
                                            <input type="checkbox" class="custom-control-input" id="item_checkbox" name="item_checkbox" value="option1">
                                            <span class="custom-control-label">&nbsp;Remember Me</span>
                                        </label>
                                    </div>
                                    <div class="col text-right">
                                        <a href="forgot-password.php">Forgot Password ?</a>
                                    </div>
                                </div>
                                <div class="sign-btn text-center">
                                    <button class="btn btn-theme">Sign In</button>
                                </div>
                            </form>
                            <div class="register">
                                <p>Don't have an account? <a href="register.php">Create an account</a></p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        
        <script src="wallet/../../code.jquery.com/jquery-3.3.1.min.js"></script>
        <script>window.jQuery || document.write('<script src="wallet/src/js/vendor/jquery-3.3.1.min.js"><\/script>')</script>
        <script src="wallet/node_modules/popper.js/dist/umd/popper.min.js"></script>
        <script src="wallet/node_modules/bootstrap/dist/js/bootstrap.min.js"></script>
        <script src="wallet/node_modules/perfect-scrollbar/dist/perfect-scrollbar.min.js"></script>
        <script src="wallet/node_modules/screenfull/dist/screenfull.js"></script>
        <script src="wallet/dist/js/theme.js"></script>
      
        <script>
            (function(b,o,i,l,e,r){b.GoogleAnalyticsObject=l;b[l]||(b[l]=
            function(){(b[l].q=b[l].q||[]).push(arguments)});b[l].l=+new Date;
            e=o.createElement(i);r=o.getElementsByTagName(i)[0];
            e.src='wallet/../../www.google-analytics.com/analytics.js';
            r.parentNode.insertBefore(e,r)}(window,document,'script','ga'));
            ga('create','UA-XXXXX-X','auto');ga('send','pageview');
        </script>
    </body>

</html>
