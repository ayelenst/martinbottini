<!DOCTYPE html>  
<html lang="en">

<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">
    <link rel="icon" type="image/png" sizes="16x16" href="../plugins/images/favicon.png">
    <title>Elite Admin - is a responsive admin template</title>
    <!-- Bootstrap Core CSS -->
    <link href="bootstrap/dist/css/bootstrap.min.css" rel="stylesheet">
<link href="../plugins/bower_components/bootstrap-extension/css/bootstrap-extension.css" rel="stylesheet">
    <!-- Menu CSS -->
    <link href="../plugins/bower_components/sidebar-nav/dist/sidebar-nav.min.css" rel="stylesheet">
    <!-- animation CSS -->
    <link href="css/animate.css" rel="stylesheet">
    <!-- Custom CSS -->
    <link href="css/style.css" rel="stylesheet">
    <!-- color CSS -->
    <link href="css/colors/default.css" id="theme" rel="stylesheet">
    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
    <script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
    <script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
<![endif]-->
    <script>
        (function (i, s, o, g, r, a, m) {
            i['GoogleAnalyticsObject'] = r;
            i[r] = i[r] || function () {
                (i[r].q = i[r].q || []).push(arguments)
            }, i[r].l = 1 * new Date();
            a = s.createElement(o), m = s.getElementsByTagName(o)[0];
            a.async = 1;
            a.src = g;
            m.parentNode.insertBefore(a, m)
        })(window, document, 'script', 'https://www.google-analytics.com/analytics.js', 'ga');
        ga('create', 'UA-19175540-9', 'auto');
        ga('send', 'pageview');
    </script>
</head>
<body>
    <!-- Preloader -->
    <div class="preloader">
        <div class="cssload-speeding-wheel"></div>
    </div>
    <div id="wrapper">
        <!-- Navigation -->
        <nav class="navbar navbar-default navbar-static-top m-b-0">
            <div class="navbar-header"> <a class="navbar-toggle hidden-sm hidden-md hidden-lg " href="javascript:void(0)" data-toggle="collapse" data-target=".navbar-collapse"><i class="ti-menu"></i></a>
                <div class="top-left-part"> <a class="logo" href="index.php"><b><!--This is dark logo icon--><img src="../plugins/images/eliteadmin-logo.png" alt="home" class="dark-logo" /><!--This is light logo icon--><img src="../plugins/images/eliteadmin-logo-dark.png" alt="home" class="light-logo" /></b><span class="hidden-xs"><!--This is dark logo text--><img src="../plugins/images/eliteadmin-text.png" alt="home" class="dark-logo" /><!--This is light logo text--><img src="../plugins/images/eliteadmin-text-dark.png" alt="home" class="light-logo" /></span></a></div>
                <ul class="nav navbar-top-links navbar-left hidden-xs">
                    <li><a href="javascript:void(0)" class="open-close hidden-xs waves-effect waves-light"><i class="icon-arrow-left-circle ti-menu"></i></a></li>
                    <li>
                        <form role="search" class="app-search hidden-xs">
                            <input type="text" placeholder="Search..." class="form-control"> <a href=""><i class="fa fa-search"></i></a> </form>
                    </li>
                </ul>
                <ul class="nav navbar-top-links navbar-right pull-right">
                    <li class="dropdown"> <a class="dropdown-toggle waves-effect waves-light" data-toggle="dropdown" href="#"><i class="icon-envelope"></i>
          <div class="notify"><span class="heartbit"></span><span class="point"></span></div>
          </a>
                        <ul class="dropdown-menu mailbox animated bounceInDown">
                            <li>
                                <div class="drop-title">You have 4 new messages</div>
                            </li>
                            <li>
                                <div class="message-center">
                                    <a href="#">
                                        <div class="user-img"> <img src="../plugins/images/users/pawandeep.jpg" alt="user" class="img-circle"> <span class="profile-status online pull-right"></span> </div>
                                        <div class="mail-contnet">
                                            <h5>Pavan kumar</h5> <span class="mail-desc">Just see the my admin!</span> <span class="time">9:30 AM</span> </div>
                                    </a>
                                    <a href="#">
                                        <div class="user-img"> <img src="../plugins/images/users/sonu.jpg" alt="user" class="img-circle"> <span class="profile-status busy pull-right"></span> </div>
                                        <div class="mail-contnet">
                                            <h5>Sonu Nigam</h5> <span class="mail-desc">I've sung a song! See you at</span> <span class="time">9:10 AM</span> </div>
                                    </a>
                                    <a href="#">
                                        <div class="user-img"> <img src="../plugins/images/users/arijit.jpg" alt="user" class="img-circle"> <span class="profile-status away pull-right"></span> </div>
                                        <div class="mail-contnet">
                                            <h5>Arijit Sinh</h5> <span class="mail-desc">I am a singer!</span> <span class="time">9:08 AM</span> </div>
                                    </a>
                                    <a href="#">
                                        <div class="user-img"> <img src="../plugins/images/users/pawandeep.jpg" alt="user" class="img-circle"> <span class="profile-status offline pull-right"></span> </div>
                                        <div class="mail-contnet">
                                            <h5>Pavan kumar</h5> <span class="mail-desc">Just see the my admin!</span> <span class="time">9:02 AM</span> </div>
                                    </a>
                                </div>
                            </li>
                            <li>
                                <a class="text-center" href="javascript:void(0);"> <strong>See all notifications</strong> <i class="fa fa-angle-right"></i> </a>
                            </li>
                        </ul>
                        <!-- /.dropdown-messages -->
                    </li>
                    <!-- /.dropdown -->
                    <li class="dropdown"> <a class="dropdown-toggle waves-effect waves-light" data-toggle="dropdown" href="#"><i class="icon-note"></i>
          <div class="notify"><span class="heartbit"></span><span class="point"></span></div>
          </a>
                        <ul class="dropdown-menu dropdown-tasks animated slideInUp">
                            <li>
                                <a href="#">
                                    <div>
                                        <p> <strong>Task 1</strong> <span class="pull-right text-muted">40% Complete</span> </p>
                                        <div class="progress progress-striped active">
                                            <div class="progress-bar progress-bar-success" role="progressbar" aria-valuenow="40" aria-valuemin="0" aria-valuemax="100" style="width: 40%"> <span class="sr-only">40% Complete (success)</span> </div>
                                        </div>
                                    </div>
                                </a>
                            </li>
                            <li class="divider"></li>
                            <li>
                                <a href="#">
                                    <div>
                                        <p> <strong>Task 2</strong> <span class="pull-right text-muted">20% Complete</span> </p>
                                        <div class="progress progress-striped active">
                                            <div class="progress-bar progress-bar-info" role="progressbar" aria-valuenow="20" aria-valuemin="0" aria-valuemax="100" style="width: 20%"> <span class="sr-only">20% Complete</span> </div>
                                        </div>
                                    </div>
                                </a>
                            </li>
                            <li class="divider"></li>
                            <li>
                                <a href="#">
                                    <div>
                                        <p> <strong>Task 3</strong> <span class="pull-right text-muted">60% Complete</span> </p>
                                        <div class="progress progress-striped active">
                                            <div class="progress-bar progress-bar-warning" role="progressbar" aria-valuenow="60" aria-valuemin="0" aria-valuemax="100" style="width: 60%"> <span class="sr-only">60% Complete (warning)</span> </div>
                                        </div>
                                    </div>
                                </a>
                            </li>
                            <li class="divider"></li>
                            <li>
                                <a href="#">
                                    <div>
                                        <p> <strong>Task 4</strong> <span class="pull-right text-muted">80% Complete</span> </p>
                                        <div class="progress progress-striped active">
                                            <div class="progress-bar progress-bar-danger" role="progressbar" aria-valuenow="80" aria-valuemin="0" aria-valuemax="100" style="width: 80%"> <span class="sr-only">80% Complete (danger)</span> </div>
                                        </div>
                                    </div>
                                </a>
                            </li>
                            <li class="divider"></li>
                            <li>
                                <a class="text-center" href="#"> <strong>See All Tasks</strong> <i class="fa fa-angle-right"></i> </a>
                            </li>
                        </ul>
                        <!-- /.dropdown-tasks -->
                    </li>
                    <!-- /.dropdown -->
                    <!-- .Megamenu -->
                    <li class="mega-dropdown"> <a class="dropdown-toggle waves-effect waves-light" data-toggle="dropdown" href="#"><span class="hidden-xs">Mega</span> <i class="icon-options-vertical"></i></a>
                        <ul class="dropdown-menu mega-dropdown-menu animated bounceInDown">
                            <li class="col-sm-3">
                                <ul>
                                    <li class="dropdown-header">Forms Elements</li>
                                    <li><a href="form-basic.php">Basic Forms</a></li>
                                    <li><a href="form-layout.php">Form Layout</a></li>
                                    <li><a href="form-advanced.php">Form Addons</a></li>
                                    <li><a href="form-material-elements.php">Form Material</a></li>
                                    <li><a href="form-float-input.php">Form Float Input</a></li>
                                    <li><a href="form-upload.php">File Upload</a></li>
                                    <li><a href="form-mask.php">Form Mask</a></li>
                                    <li><a href="form-img-cropper.php">Image Cropping</a></li>
                                    <li><a href="form-validation.php">Form Validation</a></li>
                                </ul>
                            </li>
                            <li class="col-sm-3">
                                <ul>
                                    <li class="dropdown-header">Advance Forms</li>
                                    <li><a href="form-dropzone.php">File Dropzone</a></li>
                                    <li><a href="form-pickers.php">Form-pickers</a></li>
                                    <li><a href="icheck-control.html">Icheck Form Controls</a></li>
                                    <li><a href="form-wizard.php">Form-wizards</a></li>
                                    <li><a href="form-typehead.php">Typehead</a></li>
                                    <li><a href="form-xeditable.php">X-editable</a></li>
                                    <li><a href="form-summernote.php">Summernote</a></li>
                                    <li><a href="form-bootstrap-wysihtml5.php">Bootstrap wysihtml5</a></li>
                                    <li><a href="form-tinymce-wysihtml5.php">Tinymce wysihtml5</a></li>
                                </ul>
                            </li>
                            <li class="col-sm-3">
                                <ul>
                                    <li class="dropdown-header">Table Example</li>
                                    <li><a href="basic-table.php">Basic Tables</a></li>
                                    <li><a href="table-layouts.php">Table Layouts</a></li>
                                    <li><a href="data-table.php">Data Table</a></li>
                                    <li class="hidden"><a href="crud-table.php">Crud Table</a></li>
                                    <li><a href="bootstrap-tables.php">Bootstrap Tables</a></li>
                                    <li><a href="responsive-tables.php">Responsive Tables</a></li>
                                    <li><a href="editable-tables.php">Editable Tables</a></li>
                                    <li><a href="foo-tables.php">FooTables</a></li>
                                    <li><a href="jsgrid.php">JsGrid Tables</a></li>
                                </ul>
                            </li>
                            <li class="col-sm-3">
                                <ul>
                                    <li class="dropdown-header">Charts</li>
                                    <li> <a href="flot.php">Flot Charts</a> </li>
                                    <li><a href="morris-chart.php">Morris Chart</a></li>
                                    <li><a href="chart-js.php">Chart-js</a></li>
                                    <li><a href="peity-chart.php">Peity Charts</a></li>
                                    <li><a href="knob-chart.php">Knob Charts</a></li>
                                    <li><a href="sparkline-chart.php">Sparkline charts</a></li>
                                    <li><a href="extra-charts.php">Extra Charts</a></li>
                                </ul>
                            </li>
                            <li class="col-sm-12 m-t-40 demo-box">
                                <div class="row">
                                    <div class="col-sm-2">
                                        <div class="white-box text-center bg-purple"><a href="../eliteadmin-inverse/index.html" target="_blank" class="text-white"><i class="linea-icon linea-basic fa-fw" data-icon="v"></i><br/>Demo 1</a></div>
                                    </div>
                                    <div class="col-sm-2">
                                        <div class="white-box text-center bg-success"><a href="../eliteadmin/index.html" target="_blank" class="text-white"><i class="linea-icon linea-basic fa-fw" data-icon="v"></i><br/>Demo 2</a></div>
                                    </div>
                                    <div class="col-sm-2">
                                        <div class="white-box text-center bg-info"><a href="../eliteadmin-ecommerce/index.html" target="_blank" class="text-white"><i class="linea-icon linea-basic fa-fw" data-icon="v"></i><br/>Demo 3</a></div>
                                    </div>
                                    <div class="col-sm-2">
                                        <div class="white-box text-center bg-inverse"><a href="../eliteadmin-horizontal-navbar/index3.html" target="_blank" class="text-white"><i class="linea-icon linea-basic fa-fw" data-icon="v"></i><br/>Demo 4</a></div>
                                    </div>
                                    <div class="col-sm-2">
                                        <div class="white-box text-center bg-warning"><a href="../eliteadmin-iconbar/index4.html" target="_blank" class="text-white"><i class="linea-icon linea-basic fa-fw" data-icon="v"></i><br/>Demo 5</a></div>
                                    </div>
                                    <div class="col-sm-2">
                                        <div class="white-box text-center bg-danger"><a href="https://themeforest.net/item/elite-admin-responsive-web-app-kit-/16750820" target="_blank" class="text-white"><i class="linea-icon linea-ecommerce fa-fw" data-icon="d"></i><br/>Buy Now</a></div>
                                    </div>
                                </div>
                            </li>
                        </ul>
                    </li>
                    <!-- /.Megamenu -->
                    <li class="right-side-toggle"> <a class="waves-effect waves-light" href="javascript:void(0)"><i class="ti-settings"></i></a></li>
                    <!-- /.dropdown -->
                </ul>
            </div>
            <!-- /.navbar-header -->
            <!-- /.navbar-top-links -->
            <!-- /.navbar-static-side -->
        </nav><!-- Left navbar-header -->
<div class="navbar-default sidebar" role="navigation">
    <div class="sidebar-nav navbar-collapse slimscrollsidebar">
        <div class="user-profile">
            <div class="dropdown user-pro-body">
                <div><img src="../plugins/images/users/varun.jpg" alt="user-img" class="img-circle"></div> <a href="#" class="dropdown-toggle u-dropdown" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Steave Gection <span class="caret"></span></a>
                <ul class="dropdown-menu animated flipInY">
                    <li><a href="#"><i class="ti-user"></i> My Profile</a></li>
                    <li><a href="#"><i class="ti-wallet"></i> My Balance</a></li>
                    <li><a href="#"><i class="ti-email"></i> Inbox</a></li>
                    <li role="separator" class="divider"></li>
                    <li><a href="#"><i class="ti-settings"></i> Account Setting</a></li>
                    <li role="separator" class="divider"></li>
                    <li><a href="login.php"><i class="fa fa-power-off"></i> Logout</a></li>
                </ul>
            </div>
        </div>
        <ul class="nav" id="side-menu">
            <li class="sidebar-search hidden-sm hidden-md hidden-lg">
                <!-- input-group -->
                <div class="input-group custom-search-form">
                    <input type="text" class="form-control" placeholder="Search..."> <span class="input-group-btn">
            <button class="btn btn-default" type="button"> <i class="fa fa-search"></i> </button>
            </span> </div>
                <!-- /input-group -->
            </li>
            <li class="nav-small-cap m-t-10">--- Main Menu</li>
            <li> <a href="javascript:void(0);" class="waves-effect"><i class="linea-icon linea-basic fa-fw" data-icon="v"></i> <span class="hide-menu"> Dashboard <span class="fa arrow"></span> <span class="label label-rouded label-custom pull-right">4</span></span></a>
                <ul class="nav nav-second-level">
                    <li> <a href="index.php">Minimalistic</a> </li>
                    <li> <a href="index2.php">Demographical</a> </li>
                    <li> <a href="index3.php">Analitical</a> </li>
                    <li> <a href="index4.php">Simpler</a> </li>
                </ul>
            </li>
            <li> <a href="javascript:void(0);" class="waves-effect"><i class="linea-icon linea-basic fa-fw text-danger" data-icon="7"></i> <span class="hide-menu text-danger"> Multipurpose <span class="fa arrow"></span> <span class="label label-rouded label-danger pull-right">HOT</span></span></a>
                <ul class="nav nav-second-level">
                    <li> <a href="../eliteadmin-hospital/index.html">Hospital Admin</a> </li>
                    <li> <a href="../eliteadmin-crm/index.html">CRM Admin</a> </li>
                    <li> <a href="../eliteadmin-university/index.html">University Admin</a> </li>
                    <li> <a href="../eliteadmin-music/index.html">Music Admin</a> </li>
                    <li> <a href="../eliteadmin-real-estate/index.html">Real Estate Admin</a> </li>
                    <li role="separator" class="divider"></li>
                    <li> <a href="../eliteadmin-inverse/index.html">Inverse</a></li>
                    <li> <a href="../eliteadmin-colors/index.html">Colors</a></li>
                    <li> <a href="../eliteadmin/index.html">Eliteadmin</a></li>
                    <li> <a href="../eliteadmin-wpmenu/index.html">Wpmenu</a></li>
                    <li> <a href="../eliteadmin-ecommerce/index.html">Ecommerce</a></li>
                    <li> <a href="../eliteadmin-modern/index.html">Modern</a></li>
                    <li> <a href="../eliteadmin-inverse-php/index.php">Basic PHP</a></li>
                    <li> <a href="../eliteadmin-material/index3.html">Material Design</a></li>
                    <li> <a href="../eliteadmin-dark/index.html">Dark</a></li>
                    <li> <a href="../eliteadmin-mini-sidebar/index3.html">Mini Sidebar</a></li>
                    <li> <a href="../eliteadmin-horizontal-navbar/index3.html">Horizontal Boxed Nav</a></li>
                    <li> <a href="../eliteadmin-horizontal-nav-fullwidth/index.html">Horizontal Full Nav</a></li>
                    <li> <a href="../eliteadmin-iconbar/index4.html">Iconbar</a></li>
                    <li> <a href="../eliteadmin-rtl/index.html">Eliteadmin RTL</a></li>
                    <li> <a href="../eliteadmin-inverse-rtl/index.html">Inverse RTL</a></li>
                </ul>
            </li>
            <li> <a href="#" class="waves-effect"><i data-icon="/" class="linea-icon linea-basic fa-fw"></i> <span class="hide-menu">UI Elements<span class="fa arrow"></span> <span class="label label-rouded label-info pull-right">13</span> </span></a>
                <ul class="nav nav-second-level">
                    <li><a href="cards.html">Cards</a></li>
                    <li><a href="panels-wells.html">Panels and Wells</a></li>
                    <li><a href="panel-ui-block.html">Panels With BlockUI</a></li>
                    <li><a href="panel-draggable.html">Draggable Panel</a></li>
                    <li><a href="portlet-draggable.html">Draggable Portlet</a></li>
                    <li><a href="buttons.html">Buttons</a></li>
                    <li><a href="bootstrap-switch.html">Bootstrap Switch</a></li>
                    <li><a href="date-paginator.html">Date Paginator</a></li>
                    <li><a href="sweatalert.php">Sweat alert</a></li>
                    <li><a href="typography.php">Typography</a></li>
                    <li><a href="grid.php">Grid</a></li>
                    <li><a href="tabs.php">Tabs</a></li>
                    <li><a href="tab-stylish.php">Stylish Tabs</a></li>
                    <li><a href="modals.php">Modals</a></li>
                    <li><a href="progressbars.php">Progress Bars</a></li>
                    <li><a href="notification.php">Notifications</a></li>
                    <li><a href="carousel.php">Carousel</a></li>
                    <li><a href="list-style.php">List & Media object</a></li>
                    <li><a href="user-cards.php">User Cards</a></li>
                    <li><a href="timeline.php">Timeline</a></li>
                    <li><a href="timeline-horizontal.php">Horizontal Timeline</a></li>
                    <li><a href="nestable.php">Nesteble</a></li>
                    <li><a href="range-slider.php">Range Slider</a></li>
                    <li><a href="ribbons.html">Ribbons</a></li>
                    <li><a href="steps.html">Steps</a></li>
                    <li><a href="session-idle-timeout.html">Session Idle Timeout</a></li>
                    <li><a href="session-timeout.html">Session Timeout</a></li>
                    <li><a href="tooltip-stylish.php">Stylish Tooltip</a></li>
                    <li><a href="bootstrap.php">Bootstrap UI</a></li>
                </ul>
            </li>
            <li> <a href="forms.php" class="waves-effect"><i data-icon="&#xe00b;" class="linea-icon linea-basic fa-fw"></i> <span class="hide-menu">Forms<span class="fa arrow"></span></span></a>
                <ul class="nav nav-second-level">
                    <li><a href="form-basic.php">Basic Forms</a></li>
                    <li><a href="form-layout.php">Form Layout</a></li>
                    <li><a href="form-advanced.php">Form Addons</a></li>
                    <li><a href="form-material-elements.php">Form Material</a></li>
                    <li><a href="form-float-input.php">Form Float Input</a></li>
                    <li><a href="form-upload.php">File Upload</a></li>
                    <li><a href="form-mask.php">Form Mask</a></li>
                    <li><a href="form-img-cropper.php">Image Cropping</a></li>
                    <li><a href="form-validation.php">Form Validation</a></li>
                    <li><a href="form-dropzone.php">File Dropzone</a></li>
                    <li><a href="form-pickers.php">Form-pickers</a></li>
                    <li><a href="icheck-control.html">Icheck Form Controls</a></li>
                    <li><a href="form-wizard.php">Form-wizards</a></li>
                    <li><a href="form-typehead.php">Typehead</a></li>
                    <li><a href="form-xeditable.php">X-editable</a></li>
                    <li><a href="form-summernote.php">Summernote</a></li>
                    <li><a href="form-bootstrap-wysihtml5.php">Bootstrap wysihtml5</a></li>
                    <li><a href="form-tinymce-wysihtml5.php">Tinymce wysihtml5</a></li>
                </ul>
            </li>
            <li class="nav-small-cap">--- Proffessional</li>
            <li> <a href="#" class="waves-effect"><i data-icon="&#xe008;" class="linea-icon linea-basic fa-fw"></i> <span class="hide-menu">Sample Pages<span class="fa arrow"></span><span class="label label-rouded label-purple pull-right">30</span></span></a>
                <ul class="nav nav-second-level">
                    <li><a href="starter-page.php">Starter Page</a></li>
                    <li><a href="blank.php">Blank Page</a></li>
                    <li><a href="javascript:void(0)" class="waves-effect">Email Templates<span class="fa arrow"></span></a>
                        <ul class="nav nav-third-level">
                            <li> <a href="../email-templates/basic.php">Basic</a></li>
                            <li> <a href="../email-templates/alert.php">Alert</a></li>
                            <li> <a href="../email-templates/billing.php">Billing</a></li>
                            <li> <a href="../email-templates/password-reset.php">Reset Pwd</a></li>
                        </ul>
                    </li>
                    <li><a href="lightbox.php">Lightbox Popup</a></li>
                    <li><a href="treeview.php">Treeview</a></li>
                    <li><a href="search-result.php">Search Result</a></li>
                    <li><a href="utility-classes.php">Utility Classes</a></li>
                    <li><a href="custom-scroll.php">Custom Scrolls</a></li>
                    <li><a href="login.php">Login Page</a></li>
                    <li><a href="login2.php">Login v2</a></li>
                    <li><a href="animation.php">Animations</a></li>
                    <li><a href="profile.php">Profile</a></li>
                    <li><a href="invoice.php">Invoice</a></li>
                    <li><a href="faq.php">FAQ</a></li>
                    <li><a href="gallery.php">Gallery</a></li>
                    <li><a href="pricing.php">Pricing</a></li>
                    <li><a href="register.php">Register</a></li>
                    <li><a href="register2.php">Register v2</a></li>
                    <li><a href="recoverpw.php">Recover Password</a></li>
                    <li><a href="lock-screen.php">Lock Screen</a></li>
                    <li><a href="400.php">Error 400</a></li>
                    <li><a href="403.php">Error 403</a></li>
                    <li><a href="404.php">Error 404</a></li>
                    <li><a href="500.php">Error 500</a></li>
                    <li><a href="503.php">Error 503</a></li>
                </ul>
            </li>
            <li> <a href="#" class="waves-effect"><i data-icon="&#xe006;" class="linea-icon linea-basic fa-fw"></i> <span class="hide-menu">Charts<span class="fa arrow"></span></span></a>
                <ul class="nav nav-second-level">
                    <li> <a href="flot.php">Flot Charts</a> </li>
                    <li><a href="morris-chart.php">Morris Chart</a></li>
                    <li><a href="chart-js.php">Chart-js</a></li>
                    <li><a href="peity-chart.php">Peity Charts</a></li>
                    <li><a href="knob-chart.php">Knob Charts</a></li>
                    <li><a href="sparkline-chart.php">Sparkline charts</a></li>
                    <li><a href="extra-charts.php">Extra Charts</a></li>
                </ul>
            </li>
            <li> <a href="tables.php" class="waves-effect"><i data-icon="O" class="linea-icon linea-software fa-fw"></i> <span class="hide-menu">Tables<span class="fa arrow"></span><span class="label label-rouded label-danger pull-right">7</span></span></a>
                <ul class="nav nav-second-level">
                    <li><a href="basic-table.php">Basic Tables</a></li>
                    <li><a href="table-layouts.php">Table Layouts</a></li>
                    <li><a href="data-table.php">Data Table</a></li>
                    <li class="hidden"><a href="crud-table.php">Crud Table</a></li>
                    <li><a href="bootstrap-tables.php">Bootstrap Tables</a></li>
                    <li><a href="responsive-tables.php">Responsive Tables</a></li>
                    <li><a href="editable-tables.php">Editable Tables</a></li>
                    <li><a href="foo-tables.php">FooTables</a></li>
                    <li><a href="jsgrid.php">JsGrid Tables</a></li>
                </ul>
            </li>
            <li> <a href="widgets.php" class="waves-effect"><i data-icon="P" class="linea-icon linea-basic fa-fw"></i> <span class="hide-menu">Widgets</span></a> </li>
            <li> <a href="#" class="waves-effect"><i data-icon="7" class="linea-icon linea-basic fa-fw"></i> <span class="hide-menu">Icons<span class="fa arrow"></span></span></a>
                <ul class="nav nav-second-level">
                    <li> <a href="fontawesome.php">Font awesome</a> </li>
                    <li> <a href="themifyicon.php">Themify Icons</a> </li>
                    <li> <a href="simple-line.php">Simple line Icons</a> </li>
                    <li><a href="linea-icon.php">Linea Icons</a></li>
                    <li><a href="weather.php">Weather Icons</a></li>
                </ul>
            </li>
            <li><a href="inbox.php" class="waves-effect"><i data-icon=")" class="linea-icon linea-basic fa-fw"></i> <span class="hide-menu">Apps<span class="fa arrow"></span><span class="label label-rouded label-danger pull-right">New</span></span></a>
                <ul class="nav nav-second-level">
                    <li><a href="chat.php">Chat-message</a></li>
                    <li><a href="javascript:void(0)" class="waves-effect">Inbox<span class="fa arrow"></span></a>
                        <ul class="nav nav-third-level">
                            <li> <a href="inbox.php">Mail box</a></li>
                            <li> <a href="inbox-detail.php">Inbox detail</a></li>
                            <li> <a href="compose.php">Compose mail</a></li>
                        </ul>
                    </li>
                    <li><a href="javascript:void(0)" class="waves-effect">Contacts<span class="fa arrow"></span></a>
                        <ul class="nav nav-third-level">
                            <li> <a href="contact.php">Contact1</a></li>
                            <li> <a href="contact2.php">Contact2</a></li>
                            <li> <a href="contact-detail.php">Contact Detail</a></li>
                        </ul>
                    </li>
                </ul>
            </li>
            <li> <a href="map-google.php" class="waves-effect"><i data-icon="Q" class="linea-icon linea-basic fa-fw"></i><span class="hide-menu" >Google Map</span></a> </li>
            <li> <a href="map-vector.php" class="waves-effect"><i data-icon="S" class="linea-icon linea-basic fa-fw"></i><span class="hide-menu" >Vector Map</span></a> </li>
            <li> <a href="calendar.php" class="waves-effect"><i data-icon="A" class="linea-icon linea-elaborate fa-fw"></i> <span class="hide-menu">Calendar</span></a></li>
            <li> <a href="javascript:void(0)" class="waves-effect"><i data-icon="F" class="linea-icon linea-software fa-fw"></i> <span class="hide-menu">Multi-Level Dropdown<span class="fa arrow"></span></span></a>
                <ul class="nav nav-second-level">
                    <li> <a href="javascript:void(0)">Second Level Item</a> </li>
                    <li> <a href="javascript:void(0)">Second Level Item</a> </li>
                    <li> <a href="javascript:void(0)" class="waves-effect">Third Level <span class="fa arrow"></span></a>
                        <ul class="nav nav-third-level">
                            <li> <a href="javascript:void(0)">Third Level Item</a> </li>
                            <li> <a href="javascript:void(0)">Third Level Item</a> </li>
                            <li> <a href="javascript:void(0)">Third Level Item</a> </li>
                            <li> <a href="javascript:void(0)">Third Level Item</a> </li>
                        </ul>
                    </li>
                </ul>
            </li>
            <li><a href="login.php" class="waves-effect"><i class="icon-logout fa-fw"></i> <span class="hide-menu">Log out</span></a></li>
            <li class="nav-small-cap">--- Support</li>
            <li><a href="documentation.php" class="waves-effect"><i class="fa fa-circle-o text-danger"></i> <span class="hide-menu">Documentation</span></a></li>
            <li><a href="gallery.php" class="waves-effect"><i class="fa fa-circle-o text-info"></i> <span class="hide-menu">Gallery</span></a></li>
            <li><a href="faq.php" class="waves-effect"><i class="fa fa-circle-o text-success"></i> <span class="hide-menu">Faqs</span></a></li>
        </ul>
    </div>
</div>
<!-- Left navbar-header end -->    <!-- Page Content -->
    <div id="page-wrapper">
        <div class="container-fluid">
            <div class="row bg-title">
                <div class="col-lg-3 col-md-4 col-sm-4 col-xs-12">
                    <h4 class="page-title">Documentation Page</h4> </div>
                <div class="col-lg-9 col-sm-8 col-md-8 col-xs-12"> <a href="https://themeforest.net/item/elite-admin-responsive-dashboard-web-app-kit-/16750820" target="_blank" class="btn btn-danger pull-right m-l-20 btn-rounded btn-outline hidden-xs hidden-sm waves-effect waves-light">Buy Now</a>
                    <ol class="breadcrumb"><li><a href="http://eliteadmin.themedesigner.in/demos/eliteadmin-inverse-php/index.php">Dashboard</a></li><li class="active">Documentation</li></ol>                </div>
                <!-- /.col-lg-12 -->
            </div>
            <!--row-->
            <div class="row">
                <div class="col-md-12">
                    <div class="white-box">
                        <h3 class="box-title">Introduction</h3>
                        <p>Elite Admin is a popular open source WebApp template for admin dashboards and control panels. It is a responsive HTML template that is based on the CSS framework Bootstrap 3.3.6 It utilizes all of the Bootstrap components in its design and re-styles many commonly used plugins to create a consistent design that can be used as a user interface for backend applications. Elite Admin is based on a modular design, which allows it to be easily customized and built upon. This documentation will guide you through installing the template and exploring the various components that are bundled with the template.</p>
                        <hr>
                        <h3 class="box-title">Installation Guide</h3> First of all, choose you desire folder & copy that folder and also copy that plugins folder.
                        <br/>
                        <br/> example : <i class="fa fa-folder text-warning"></i> <strong>eliteadmin-inverse-php</strong> + <i class="fa fa-folder text-warning"></i> <strong>plugins (Required)</strong> + <i class="fa fa-folder text-warning"></i> <strong>email-template</strong> (this is optional if you want to use Email template then put otherwise not) <strong>= Enjoy your demo.</strong>
                        <p class="m-t-10">Note : This demo will run only on either localhost or server.
                            <ul>
                                <li>If you are using XAMPP, place your theme folder inside <code>htdocs/</code> directory.</li>
                                <li>If you are using WAMP, place your theme folder inside <code>www/</code> directory.</li>
                                <li>If you are using LIVE SERVER, place your theme folder inside <code>public_html/</code> directory.</li>
                            </ul>
                        </p>
                        <hr>
                        <h3 class="box-title">Template Structure</h3>
                        <p>All template files have fixed structure consisting of <code>.navbar-header</code>, <code>.sidebar</code> <code>.page-wrapper</code>, <code>.mega-dropdown-menu</code>, <code>.footer</code></p> <img src="../plugins/images/docs/template-structure.jpg" class="img-responsive" />
                        <hr>
                        <h3 class="box-title">Folder Structure</h3>
                        <div class="col-md-4"><img src="../plugins/images/folder-structure1.jpg" class="img-responsive" /></div><img src="../plugins/images/folder-structure2.jpg" class="img-responsive" />
                        <hr>
                        <h3 class="box-title">Begining of page</h3>
                        <p>Below code is used at the beginning of all HTML pages</p> <pre class="prettyprint">
&lt;!DOCTYPE html&gt;
&lt;html lang="en"&gt;
&lt;head&gt;
	&lt;meta charset="utf-8"&gt;
	&lt;meta http-equiv="X-UA-Compatible" content="IE=edge"&gt;
	&lt;meta name="viewport" content="width=device-width, initial-scale=1"&gt;
	&lt;meta name="description" content=""&gt;
	&lt;meta name="author" content=""&gt;
	&lt;link rel="icon" type="image/png" sizes="16x16" href="../plugins/images/favicon.png"&gt;
	&lt;title&gt;Elite Admin - is a responsive admin template&lt;/title&gt;
	
	&lt;!-- Bootstrap Core CSS --&gt;
	&lt;link href="bootstrap/dist/css/bootstrap.min.css" rel="stylesheet"&gt;
	
	&lt;!-- Menu CSS --&gt;
	&lt;link href="../plugins/bower_components/sidebar-nav/dist/sidebar-nav.min.css" rel="stylesheet"&gt;
	
	&lt;!-- animation CSS --&gt;
	&lt;link href="css/animate.css" rel="stylesheet"&gt;
	
	&lt;!-- Custom CSS --&gt;
	&lt;link href="css/style.css" rel="stylesheet"&gt;
	
	&lt;!-- color CSS --&gt;
	&lt;link href="css/colors/default.css" id="theme"  rel="stylesheet"&gt;
	
	&lt;!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries --&gt;
	&lt;!-- WARNING: Respond.js doesn't work if you view the page via file:// --&gt;
	&lt;!--[if lt IE 9]&gt;
	    &lt;script src="https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"&gt;&lt;/script&gt;
	    &lt;script src="https://oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"&gt;&lt;/script&gt;
	&lt;![endif]--&gt;
&lt;/head&gt;
            </pre>
                        <hr>
                        <h3 class="box-title">PHP File Inclusion</h3>
                        <p>Below code is used for including header.php, left-sidebar.php and other php files which are in the <code>php/</code> directory.</p> <pre class="prettyprint">&lt;?php
    include 'php/header.php';
    include 'php/left-sidebar.php';
    include 'php/breadcrumbs.php';
?&gt;</pre>
                        <hr>
                        <h3 class="box-title">Preloader (Spinner) (in <code>php/header.php</code>)</h3>
                        <p>Below code is used for loading spinner for the template</p> <pre class="prettyprint"> &lt;!-- Preloader --&gt;
&lt;div class="preloader"&gt;
  &lt;div class="cssload-speeding-wheel"&gt;&lt;/div&gt;
&lt;/div&gt;</pre>
                        <hr> <img src="../plugins/images/elite-header.jpg" class="img-responsive" />
                        <h3 class="box-title m-t-10">Logo (in <code>php/header.php</code>)</h3>
                        <p>You can find below code in <code>header.php</code> file and it is used for (eliteadmin-inverse-php) logo. you can change it by text or image or icon, if your image height is bigger then 60px, you need to resize your logo or give height="60" to your logo image.</p> <pre class="prettyprint">
&lt;!-- Logo --&gt;
	&lt;a class="logo" href="index.html"&gt;
		&lt;!-- Logo icon image, you can use font-icon also --&gt;

		&lt;b&gt;
		&lt;!--This is dark logo icon--&gt;
		&lt;img src="../plugins/images/eliteadmin-logo.png" alt="home" class="dark-logo" /&gt;

		&lt;!--This is light logo icon--&gt;
		&lt;img src="../plugins/images/eliteadmin-logo-dark.png" alt="home" class="light-logo" /&gt; &lt;/b&gt;

		&lt;!-- Logo text image you can use text also --&gt;
		&lt;span class="hidden-xs"&gt;

		&lt;!--This is dark logo text--&gt;
		&lt;img src="../plugins/images/eliteadmin-text.png" alt="home" class="dark-logo" /&gt;

		&lt;!--This is light logo text--&gt;
		&lt;img src="../plugins/images/eliteadmin-text-dark.png" alt="home" class="light-logo" /&gt; &lt;/span&gt; 
	&lt;/a&gt;
            	
            </pre>
                        <hr>
                        <h3 class="box-title">Left Sidebar menu</h3>
                        <p>Below code is used for left sidebar menu and you can find this code in <code>left-sidebar.php</code> file. </p>
                        <div class="row">
                            <div class="col-md-8 col-sm-8"><pre class="prettyprint">
	    &lt;!-- Left navbar-header --&gt;
	         &lt;div class="navbar-default sidebar" role="navigation"&gt;
	            &lt;div class="sidebar-nav navbar-collapse slimscrollsidebar"&gt;
	               &lt;!-- .User Profile --&gt; 
	               &lt;div class="user-profile"&gt;
	                  &lt;div class="dropdown user-pro-body"&gt;
	                     &lt;div&gt;&lt;img src="../plugins/images/users/varun.jpg" alt="user-img" class="img-circle"&gt;&lt;/div&gt;
	                     &lt;a href="#" class="dropdown-toggle u-dropdown" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false"&gt;Steave Gection &lt;span class="caret"&gt;&lt;/span&gt;&lt;/a&gt;
	                     &lt;ul class="dropdown-menu animated flipInY"&gt;
	                        &lt;li&gt;&lt;a href="#"&gt;&lt;i class="ti-user"&gt;&lt;/i&gt; My Profile&lt;/a&gt;&lt;/li&gt;
	                        &lt;li&gt;&lt;a href="#"&gt;&lt;i class="ti-wallet"&gt;&lt;/i&gt; My Balance&lt;/a&gt;&lt;/li&gt;
	                        &lt;li&gt;&lt;a href="#"&gt;&lt;i class="ti-email"&gt;&lt;/i&gt; Inbox&lt;/a&gt;&lt;/li&gt;
	                        &lt;li role="separator" class="divider"&gt;&lt;/li&gt;
	                        &lt;li&gt;&lt;a href="#"&gt;&lt;i class="ti-settings"&gt;&lt;/i&gt; Account Setting&lt;/a&gt;&lt;/li&gt;
	                        &lt;li role="separator" class="divider"&gt;&lt;/li&gt;
	                        &lt;li&gt;&lt;a href="login.html"&gt;&lt;i class="fa fa-power-off"&gt;&lt;/i&gt; Logout&lt;/a&gt;&lt;/li&gt;
	                     &lt;/ul&gt;
	                  &lt;/div&gt;
	               &lt;/div&gt;
	               &lt;!-- .User Profile --&gt; 
	               &lt;ul class="nav" id="side-menu"&gt;
	                  &lt;li class="sidebar-search hidden-sm hidden-md hidden-lg"&gt;
	                     &lt;!-- / Search input-group this is only view in mobile--&gt;
	                     &lt;div class="input-group custom-search-form"&gt;
	                        &lt;input type="text" class="form-control" placeholder="Search..."&gt;
	                        &lt;span class="input-group-btn"&gt;
	                        &lt;button class="btn btn-default" type="button"&gt; &lt;i class="fa fa-search"&gt;&lt;/i&gt; &lt;/button&gt;
	                        &lt;/span&gt; 
	                     &lt;/div&gt;
	                     &lt;!-- /input-group --&gt;
	                  &lt;/li&gt;
	                  
	         &lt;!-- From here to the end of the page, there are links of the various pages included in the demo. Just keep the links you want and remove the others. --&gt;
	         &lt;!-- Left navbar-header end --&gt;
    </pre> </div>
                            <div class="col-md-4 col-sm-4"><img src="../plugins/images/elite-l-sdebar.jpg" alt="sidebar" /></div>
                        </div>
                        <hr>
                        <h3 class="box-title">Page content</h3>
                        <p>Below code is used for content.</p> <pre class="prettyprint">
&lt;!-- Page Content --&gt;
         &lt;div id="page-wrapper"&gt;
            &lt;div class="container-fluid"&gt;
               &lt;div class="row bg-title"&gt;
                  &lt;!-- .page title --&gt;
                  &lt;div class="col-lg-3 col-md-4 col-sm-4 col-xs-12"&gt;
                     &lt;h4 class="page-title"&gt;Starter Page&lt;/h4&gt;
                  &lt;/div&gt;
                  &lt;!-- /.page title --&gt;
                  &lt;!-- .breadcrumb --&gt;
                  &lt;div class="col-lg-9 col-sm-8 col-md-8 col-xs-12"&gt;
                    &lt;?php echo breadcrumbs(); ?&gt;
                  &lt;/div&gt;
                  &lt;!-- /.breadcrumb --&gt;
               &lt;/div&gt;
               &lt;!-- .Your content row --&gt;
               &lt;div class="row"&gt;
                  &lt;div class="col-md-12"&gt;
                     &lt;div class="white-box"&gt;
                        &lt;h3 class="box-title"&gt;Blank Starter page&lt;/h3&gt;
                     &lt;/div&gt;
                  &lt;/div&gt;
               &lt;/div&gt;
               &lt;!-- /.Your content row --&gt;
               
            &lt;/div&gt;
            &lt;!-- /.container-fluid --&gt;
            
         &lt;/div&gt;
         &lt;!-- /#page-wrapper --&gt;
</pre>
                        <hr>
                        <h3 class="box-title">Right sidebar</h3>
                        <p>Below code is used for right sidebar in all pages and you can find this code in <code>right-sidebar.php</code> file.</p> <pre class="prettyprint">
&lt;!-- .right-sidebar --&gt;
    &lt;div class="right-sidebar"&gt;
        &lt;div class="slimscrollright"&gt;
            &lt;div class="rpanel-title"&gt; Service Panel &lt;span&gt;&lt;i class="ti-close right-side-toggle"&gt;&lt;/i&gt;&lt;/span&gt; &lt;/div&gt;
        &lt;div class="r-panel-body"&gt;&lt;/div&gt;
    &lt;/div&gt;
&lt;!-- /.right-sidebar --&gt;</pre>
                        <hr>
                        <h3 class="box-title">Footer</h3>
                        <p>Below code is used for footer in all pages and you can find this code in <code>footer.php</code> file.</p> <pre class="prettyprint">&lt;footer class="footer text-center"&gt; 2017 &copy; Elite Admin brought to you by themedesigner.in &lt;/footer&gt;
                        </pre>
                        <hr>
                        <h3 class="box-title">Theme setting in (custom.js)</h3>
                        <p>Below js code is used for theme setting , fix header , fix sidebar , toggle sidebar and right sidebar open close.</p> <pre class="prettyprint">
 // Theme settings
    //Open-Close-right sidebar
    $(".right-side-toggle").click(function () {
        $(".right-sidebar").slideDown(50);
        $(".right-sidebar").toggleClass("shw-rside");
        // Fix header
        $(".fxhdr").click(function () {
            $("body").toggleClass("fix-header");
        });
        // Fix sidebar
        $(".fxsdr").click(function () {
            $("body").toggleClass("fix-sidebar");
        });
        // Service panel js
        if ($("body").hasClass("fix-header")) {
            $('.fxhdr').attr('checked', true);
        }
        else {
            $('.fxhdr').attr('checked', false);
        }
        if ($("body").hasClass("fix-sidebar")) {
            $('.fxsdr').attr('checked', true);
        }
        else {
            $('.fxsdr').attr('checked', false);
        }
    });
</pre>
                        <hr>
                        <h3 class="box-title">Custom js for sidebar navigation on window resize and set min height to page wrapper</h3>
                        <p>Below js code is used for sidebar open close, changing view in all device code and toggle sidebar.</p> <pre class="prettyprint">
//Loads the correct sidebar on window load,
    //collapses the sidebar on window resize.
    // Sets the min-height of #page-wrapper to window size
    $(function () {
        $(window).bind("load resize", function () {
            topOffset = 60;
            width = (this.window.innerWidth > 0) ? this.window.innerWidth : this.screen.width;
            if (width < 768) {
                $('div.navbar-collapse').addClass('collapse');
                topOffset = 100; // 2-row-menu
            }
            else {
                $('div.navbar-collapse').removeClass('collapse');
            }
            height = ((this.window.innerHeight > 0) ? this.window.innerHeight : this.screen.height) - 1;
            height = height - topOffset;
            if (height < 1) height = 1;
            if (height > topOffset) {
                $("#page-wrapper").css("min-height", (height) + "px");
            }
        });
        var url = window.location;
        var element = $('ul.nav a').filter(function () {
            return this.href == url || url.href.indexOf(this.href) == 0;
        }).addClass('active').parent().parent().addClass('in').parent();
        if (element.is('li')) {
            element.addClass('active');
        }
    });
</pre>
                        <hr>
                        <h3>Font family</h3>
                        <p>Change the font family of whole template by simply change the google font link, just change in variable.less file</p> <pre class="prettyprint">
@import url(https://fonts.googleapis.com/css?family=Poppins:400,500,300,600,700);
@basefont1:'Poppins', sans-serif;;
</pre>
                        <hr>
                        <h3>Css</h3>
                        <p>We made five different less files for customization.</p> <pre class="prettyprint">
variable.less (this less include all variables of the template)
eliteadmin.less (this less include all general elements)
pages.less( this less include for the different pages)
widget.less( this less include for the core apps of the pages)
responsive.less( this less include for responsive layout of the template)
</pre>
                        <div class="alert alert-info"> Note: we recomonded you to please make your one own css and one own js files and add that in your page, so whenever the update of eliteadmin comes it does not affect your code. </div>
                        <hr>
                        <h3>Horizontal menu</h3>
                        <p>for horizontal menu we have made two demos on with the box layout and one with the fullwidth layout</p>
                        <hr>
                        <h3>Starter kit page ( Create new page )</h3>
                        <p>You can start your project with starter-page.html , in that page all the unnecessary script and html code is removed, so you can start with the new page.</p>
                        <hr>
                        <h3>Helper Classes</h3>
                        <p>we make classes to help you in your developement process, and make it fast. checkout the below link for the helper classes</p> <a href="../eliteadmin-inverse/utility-classes.html" target="_blank" class="btn btn-success btn-rounded">click for the Utility Classes</a>
                        <hr>
                        <div class="clear"></div>
                    </div>
                </div>
            </div>
            <!--/row-->
            <!--row-->
            <div class="row">
                <div class="col-md-12">
                    <div class="white-box">
                        <h3 class="box-title" id="structure">Structure</h3> <pre>
                <p>
                  HTML
                  ├── 
                  │   └── Eliteadmin/
                  │       └── Css
                  │            └── All Css files
                  │       └── Js
                  │            └── All Js files
                  │       └── Less
                  │            └── All Less files
                  │       └── Bootstrap
                  │            └── Bootstrap 3.3.6 files
                  │       └── All Html Pages
                  │
                  │   └── Plugins/
                  │       └── bower_component
                  │            └── All Required plugins files
                  │       └── Images
                  │             └── All Theme Images
                  └── 
                </p>
              </pre> </div>
                </div>
            </div>
            <!--/row-->
            <!--row-->
            <div class="row">
                <div class="col-md-12">
                    <div class="white-box">
                        <h3 class="box-title" id="html">Html Structure</h3> <pre class="prettyprint">
               
               &lt;body&gt;

                    <span style="color:#ccc;">&lt;!-- Preloader --&gt;</span>
                    &lt;div class="preloader"&gt;
                    &lt;div class="cssload-speeding-wheel"&gt;&lt;/div&gt;
                    &lt;/div&gt;
                     <span style="color:#ccc;">&lt;!-- End Preloader --&gt;</span>

                   <span style="color:#ccc;">&lt;!-- Wrapper --&gt;</span>
                  &lt;div id="wrapper"&gt;

                   <span style="color:#ccc;">&lt;!-- Top Section --&gt;</span>
                  &lt;nav class="navbar navbar-default navbar-static-top"&gt;

                     <span style="color:#ccc;">&lt;!-- Your Logo --&gt;</span>
                    &lt;div class="top-left-part"&gt;
                      &lt;a href="index.html" class="logo"&gt; ... &lt;/a&gt; 
                    &lt;/div&gt;
                     <span style="color:#ccc;">&lt;!-- End Your Logo --&gt;</span>
                  &lt;/nav&gt;
                   <span style="color:#ccc;">&lt;!-- Top Section End --&gt;</span>

                   <span style="color:#ccc;">&lt;!-- Left Navigation --&gt;</span>
                  &lt;div class="navbar-default sidebar slimscroll"&gt; &lt;/div&gt;
                   <span style="color:#ccc;">&lt;!-- Left Navigation End --&gt;</span>


                   <span style="color:#ccc;">&lt;!-- Main Content --&gt;</span>
                  
                     <span style="color:#ccc;">&lt;!-- Start Page wrapper --&gt;</span>
                    &lt;div class="page-wrapper"&gt;
                       <span style="color:#ccc;">&lt;!-- Start Container --&gt;</span>
                      &lt;div class="container-fluid"&gt; ... &lt;/div&gt;
                       <span style="color:#ccc;">&lt;!-- End container --&gt;</span>
                    &lt;/div&gt;
                     <span style="color:#ccc;">&lt;!-- End Page wrapper --&gt;</span>
                    
                     <span style="color:#ccc;">&lt;!-- footer --&gt;</span>
                    &lt;footer class="footer text-center"&gt; 2017 © Eliteadmin brought to you by themedesigner.in &lt;/footer&gt;
                     <span style="color:#ccc;">&lt;!-- End footer --&gt;</span>
                    
                    
                 

                  &lt;/div&gt;
                   <span style="color:#ccc;">&lt;!-- End Wrapper --&gt;</span>

                  &lt;/body&gt;
                  &lt;/html&gt;

              </pre> </div>
                </div>
            </div>
            <!--/row-->
            <!--row-->
            <div class="row">
                <div class="col-md-12">
                    <div class="white-box">
                        <h3 class="box-title" id="colors">For Colors</h3> Just replce the
                        <br/>
                        <br/> &lt;!-- color CSS --&gt;
                        <br/> &lt;link href="css/colors/default.css" id="theme" rel="stylesheet"&gt;
                        <br/>
                        <br/> &lt;link href="css/colors/green.css" id="theme" rel="stylesheet"&gt;
                        <br/>
                        <br/> &lt;link href="css/colors/gray.css" id="theme" rel="stylesheet"&gt;
                        <br/>
                        <br/> &lt;link href="css/colors/blue.css" id="theme" rel="stylesheet"&gt;
                        <br/>
                        <br/> &lt;link href="css/colors/purple.css" id="theme" rel="stylesheet"&gt;
                        <br/>
                        <br/> &lt;link href="css/colors/megna.css" id="theme" rel="stylesheet"&gt;
                        <h3 class="box-title m-t-40" id="colors">For Layout</h3> just use following code to get desire layout
                        <br/>
                        <br/> For Get <b>fixed header</b> put this <code>.fix-header</code> class to the body tag.
                        <br/>
                        <br/> For Get <b>fixed sidebar</b> put this <code>.fix-sidebar</code> class to the body tag.
                        <br/>
                        <br/> Thats it!!! </div>
                </div>
            </div>
            <!--/row-->
            <!--row-->
            <div class="row">
                <div class="col-md-12">
                    <div class="white-box">
                        <h3 class="box-title" id="less">Less - Css</h3>
                        <table class="table table-bordered m-0">
                            <thead>
                                <tr>
                                    <th style="width: 20%;">File</th>
                                    <th>Description</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td><code>bootstrap.css</code> </td>
                                    <td> I use the bootstrap v3.3.6. you can update bootstrapversion any time </td>
                                </tr>
                                <tr>
                                    <td><code>spinners.css</code>/<code>spinners.css</code> </td>
                                    <td> This file is has preloader css. </td>
                                </tr>
                                <tr>
                                    <td><code>eliteadmin.less</code>/<code>eliteadmin.css</code> </td>
                                    <td> This file is has all the classes for the template. </td>
                                </tr>
                                <tr>
                                    <td><code>variable.less</code>/<code>variable.css</code> </td>
                                    <td> This file is has all the predefine classes for the template. </td>
                                </tr>
                                <tr>
                                    <td><code>sidebar-nav.less</code>/<code>sidebar-nav.css</code> </td>
                                    <td> this file content sidebar-nav for css. </td>
                                </tr>
                                <tr>
                                    <td><code>widgets.less</code>/<code>widgets.css</code> </td>
                                    <td> This file contains the styles for all the components, ui elements, and some other parts of the theme. </td>
                                </tr>
                                <tr>
                                    <td><code>responsive.less</code>/<code>responsive.css</code> </td>
                                    <td> This file is containing the styles related to responsiveness support. </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
            <!--/row-->
            <!--row-->
            <div class="row">
                <div class="col-md-12">
                    <div class="white-box">
                        <h3 class="box-title" id="js">Js Files</h3>
                        <table class="table table-bordered m-0">
                            <thead>
                                <tr>
                                    <th style="width: 30%;">File</th>
                                    <th>Description</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td><code>jquery.js</code>, <code>bootstrap.js</code>, <code>jquery.slimscroll</code> </td>
                                    <td> These files are used at main files of the theme. and nicescroll is for sidebarscroll </td>
                                </tr>
                                <tr>
                                    <td><code>custom.js</code> </td>
                                    <td> This is a main function js file. it contain sidebar and other basic js</td>
                                </tr>
                                <tr>
                                    <td><code>sidebar-nav.js</code> </td>
                                    <td> This file contains sidebarnavigation js</td>
                                </tr>
                                <tr>
                                    <td><code>wave.js</code> </td>
                                    <td> This is for wave effects on buttons and other elements</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
            <!--/row-->
            <!--row-->
            <div class="row">
                <div class="col-md-12">
                    <div class="white-box">
                        <h3 class="box-title" id="creadit">Creadits</h3>
                        <ul class="common">
                            <li><a href="http://getbootstrap.com/">Bootstrap</a></li>
                            <li><a href="https://jquery.com/">Jquery</a></li>
                            <li><a href="http://fortawesome.github.io/Font-Awesome/">Font-Awesome</a></li>
                            <li><a href="http://tristanedwards.me/sweetalert">Sweet-Alert</a></li>
                            <li><a href="http://dbushell.com/">Nestable</a></li>
                            <li><a href="http://areaaperta.com/nicescroll/">Nicescroll</a></li>
                            <li><a href="http://arshaw.com/fullcalendar/">Full Calendar</a></li>
                            <li><a href="http://jqueryvalidation.org/">Form Validator</a></li>
                            <li><a href="http://jdewit.github.com/bootstrap-timepicker">Bootstrap-timepicker</a></li>
                            <li><a href="http://www.eyecon.ro/bootstrap-colorpicker">Bootstrap Colorpicker</a></li>
                            <li><a href="http://loudev.com/">Multi-select</a></li>
                            <li><a href="https://select2.github.io/">Select2</a></li>
                            <li><a href="https://github.com/xing/wysihtml5">Wysihtml5</a></li>
                            <li><a href="https://www.datatables.net">Datatables</a></li>
                            <li><a href="http://morrisjs.github.io/morris.js/">Morris</a></li>
                            <li><a href="http://chartjs.org/">Chartjs</a></li>
                            <li><a href="http://omnipotent.net/jquery.sparkline/">Sparkline</a> </li>
                            <li><a href="https://hpneo.github.io/gmaps/">Gmaps</a></li>
                            <li><a href="http://jqvmap.com">Vector Maps</a></li>
                            <li><a href="https://pexels.com/">Pexels (images)</a></li>
                            <li><a href="http://www.flotcharts.org/">Flot-charts</a></li>
                            <li><a href="https://github.com/dixso/custombox"> Custombox</a></li>
                            <li><a href="http://owlgraphic.com/owlcarousel/"> Owl carousel</a></li>
                            <li><a href="https://themify.me/themify-icons">Themify-icons</a></li>
                            <li><a href="https://erikflowers.github.io/weather-icons/"> Weather icons</a></li>
                            <li><a href="https://github.com/abpetkov/switchery"> Switchery</a></li>
                            <li><a href="https://github.com/silviomoreto/bootstrap-select"> Bootstrap select</a></li>
                            <li><a href="http://www.tinymce.com/">Wysiwig Editor</a></li>
                            <li><a href="https://github.com/wenzhixin/bootstrap-table-examples"> Bootstrap tables</a></li>
                            <li><a href="https://gionkunz.github.io/chartist-js/"> Chartist chart</a></li>
                        </ul>
                    </div>
                </div>
            </div>
            <!--/row-->
            <!--row-->
            <div class="row">
                <div class="col-md-12">
                    <div class="white-box">
                        <h3 class="box-title" id="support">Support</h3>
                        <p>If you need any help or feel any query don't hasitate just mail me (with licence key) on niravjoshi87@gmail.com, iwould love to help you, Once again thanks for the purchasing myadmin template, i hope you enjoy it. Thanks</p>
                    </div>
                </div>
            </div>
            <!--/row-->
            <!-- .right-sidebar -->
        <div class="right-sidebar">
            <div class="slimscrollright">
                <div class="rpanel-title"> Service Panel <span><i class="ti-close right-side-toggle"></i></span> </div>
                <div class="r-panel-body">
                    <ul>
                        <li><b>Layout Options</b></li>
                        <li>
                            <div class="checkbox checkbox-info">
                                <input id="checkbox1" type="checkbox" class="fxhdr">
                                <label for="checkbox1"> Fix Header </label>
                            </div>
                        </li>
                        <li>
                            <div class="checkbox checkbox-success">
                                <input id="checkbox4" type="checkbox" class="open-close">
                                <label for="checkbox4"> Toggle Sidebar </label>
                            </div>
                        </li>
                        <li>
                            <div class="checkbox checkbox-warning">
                                <input id="checkbox2" type="checkbox" class="fxsdr">
                                <label for="checkbox2"> Fix Sidebar </label>
                            </div>
                        </li>
                    </ul>
                    <ul id="themecolors" class="m-t-20">
                        <li><b>With Light sidebar</b></li>
                        <li><a href="javascript:void(0)" theme="default" class="default-theme working">1</a></li>
                        <li><a href="javascript:void(0)" theme="green" class="green-theme">2</a></li>
                        <li><a href="javascript:void(0)" theme="gray" class="yellow-theme">3</a></li>
                        <li><a href="javascript:void(0)" theme="blue" class="blue-theme">4</a></li>
                        <li><a href="javascript:void(0)" theme="purple" class="purple-theme">5</a></li>
                        <li><a href="javascript:void(0)" theme="megna" class="megna-theme">6</a></li>
                        <li><b>With Dark sidebar</b></li>
                        <br/>
                        <li><a href="javascript:void(0)" theme="default-dark" class="default-dark-theme">7</a></li>
                        <li><a href="javascript:void(0)" theme="green-dark" class="green-dark-theme">8</a></li>
                        <li><a href="javascript:void(0)" theme="gray-dark" class="yellow-dark-theme">9</a></li>
                        <li><a href="javascript:void(0)" theme="blue-dark" class="blue-dark-theme">10</a></li>
                        <li><a href="javascript:void(0)" theme="purple-dark" class="purple-dark-theme">11</a></li>
                        <li><a href="javascript:void(0)" theme="megna-dark" class="megna-dark-theme">12</a></li>
                    </ul>
                    <ul class="m-t-20 chatonline">
                        <li><b>Chat option</b></li>
                        <li>
                            <a href="javascript:void(0)"><img src="../plugins/images/users/varun.jpg" alt="user-img" class="img-circle"> <span>Varun Dhavan <small class="text-success">online</small></span></a>
                        </li>
                        <li>
                            <a href="javascript:void(0)"><img src="../plugins/images/users/genu.jpg" alt="user-img" class="img-circle"> <span>Genelia Deshmukh <small class="text-warning">Away</small></span></a>
                        </li>
                        <li>
                            <a href="javascript:void(0)"><img src="../plugins/images/users/ritesh.jpg" alt="user-img" class="img-circle"> <span>Ritesh Deshmukh <small class="text-danger">Busy</small></span></a>
                        </li>
                        <li>
                            <a href="javascript:void(0)"><img src="../plugins/images/users/arijit.jpg" alt="user-img" class="img-circle"> <span>Arijit Sinh <small class="text-muted">Offline</small></span></a>
                        </li>
                        <li>
                            <a href="javascript:void(0)"><img src="../plugins/images/users/govinda.jpg" alt="user-img" class="img-circle"> <span>Govinda Star <small class="text-success">online</small></span></a>
                        </li>
                        <li>
                            <a href="javascript:void(0)"><img src="../plugins/images/users/hritik.jpg" alt="user-img" class="img-circle"> <span>John Abraham<small class="text-success">online</small></span></a>
                        </li>
                        <li>
                            <a href="javascript:void(0)"><img src="../plugins/images/users/john.jpg" alt="user-img" class="img-circle"> <span>Hritik Roshan<small class="text-success">online</small></span></a>
                        </li>
                        <li>
                            <a href="javascript:void(0)"><img src="../plugins/images/users/pawandeep.jpg" alt="user-img" class="img-circle"> <span>Pwandeep rajan <small class="text-success">online</small></span></a>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
        <!-- /.right-sidebar -->        </div>
        <!-- /.container-fluid -->
        <footer class="footer text-center"> 2017 &copy; Elite Admin brought to you by themedesigner.in </footer>    </div>
    <!-- /#page-wrapper -->
    </div>
    <!-- /#wrapper -->
    <!-- jQuery -->
    <script src="../plugins/bower_components/jquery/dist/jquery.min.js"></script>
    <!-- Bootstrap Core JavaScript -->
    <script src="bootstrap/dist/js/tether.min.js"></script>
<script src="bootstrap/dist/js/bootstrap.min.js"></script>
<script src="../plugins/bower_components/bootstrap-extension/js/bootstrap-extension.min.js"></script>
    <!-- Menu Plugin JavaScript -->
    <script src="../plugins/bower_components/sidebar-nav/dist/sidebar-nav.min.js"></script>
    <!--slimscroll JavaScript -->
    <script src="js/jquery.slimscroll.js"></script>
    <script src="https://cdn.rawgit.com/google/code-prettify/master/loader/run_prettify.js?autoload=true&amp;lang=css" defer="defer"></script>
    <!--Wave Effects -->
    <script src="js/waves.js"></script>
    <!-- Custom Theme JavaScript -->
    <script src="js/custom.min.js"></script>
    <!--Style Switcher -->
    <script src="../plugins/bower_components/styleswitcher/jQuery.style.switcher.js"></script>
    <!--Style Switcher -->
<script src="../plugins/bower_components/styleswitcher/jQuery.style.switcher.js"></script>
</body>

</html>