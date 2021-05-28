<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Usuario_Modificar.aspx.cs" Inherits="Usuario_Modificar" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta http-equiv="content-type" content="text/html; charset=UTF-8" />    <meta name="author" content="INSPIRO" />    
	<meta name="description" content="Themeforest Template Polo">
    <link rel="icon" type="image/png" href="images/favicon.png">   
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <!-- Document title -->
    <title>YIPEE</title>
    <!-- Stylesheets & Fonts -->
    <link href="css/plugins.css" rel="stylesheet">
    <link href="css/style.css" rel="stylesheet">
</head>

<body class="dark text-light">
<form id="form1" runat="server">
    <!-- Body Inner -->
    <div class="body-inner">
        <!-- Header -->
        <header id="header" class="dark text-light" data-fullwidth="true">
          
        </header>
        
        <!-- end: Header --><!-- Page title -->
		<section id="page-title bg-dark text-light">
            <div class="container">
                <div class="page-title bg-dark text-light">
                    <h1 class="text-center">Modificar Datos</h1>
                   
                
				
            
				
				</div>
                
                   
            </div>
        </section>
        
        <section id="page-content">
            <div class="container">
                <div class="row">
                
               
             
             
                
                
                    <div class="content col-lg-9">
                     
                         
                        
                        
                        
                        
                        
                        <div class="card bg-dark text-light">
                            <div class="card-header bg-dark text-light">
                                <span class="h4">Datos personales</span>
                               
                            </div>
                            <div class="card-body">
                                <form id="form2" class="form-validate">
                                    <div class="form-row">
                                        <div class="form-group col-md-6">
                                            
                                            
                                            <!-----username------->
                                            
                                            <label for="username">Nombre</label>
                                         <asp:TextBox ID="Txt_nombre" runat="server"  CssClass="form-control"  ></asp:TextBox>
                                       
                                       
                                       
                                       
                                        </div>
                                        <div class="form-group col-md-6">
                                        
                                            <label for="email">Apellido Paterno</label>
                                            <asp:TextBox ID="txt_paterno" runat="server" CssClass="form-control"  ></asp:TextBox>
                                            
                                            
                                        </div>
                                    </div>
                                    <div class="form-row">
                                        <div class="form-group col-md-6">
                                        
                                        
                                        <!-----password1--------->
                                        <!-----password1--------->
                                        <!-----password1--------->
                                        <!-----password1--------->
                                        <!-----password1--------->
                                            <label for="password">Apellido Materno</label>
                                            <div class="input-group show-hide-password">
                                             <asp:TextBox ID="txt_materno" runat="server" CssClass="form-control" ></asp:TextBox>
                                                
                                                
                                                
                                                
                                            </div>
                                        </div>
                                        <div class="form-group col-md-6">
                                        
                                        
                                        <!---------password2------->
                                        <!---------password2------->
                                        <!---------password2------->
                                            <label for="password2">Edad</label>
                                            <div class="input-group show-hide-password">
                                            <asp:TextBox ID="txt_edad" runat="server" CssClass="form-control" ></asp:TextBox>
                                               
                                               
                                               
                                               
                                            </div>
                                        </div>
                                    </div>
                              
                                   
                                   
                             <asp:Button ID="Btn_usuario_agrega" runat="server" CssClass="btn btn-primary" OnClick="Btn_usuario_agrega_Click" Text="Cambiar Datos"/>
                               
                             
                                </form>
                            </div>
                        </div>
                      
                    
                     
                       
                     
                       
                      
                     
                        
                       
                    
                       
                       
                    </div>
                    <!-- Sidebar-->
                    <div class="sidebar col-lg-3">
                        <div class="sidebar-menu">
                          
                        </div>
                    </div>
                    <!-- end: sidebar-->
                </div>
            </div>
        </section>
        
       
     </form>
    
    
   
 
        
    
    
        
    
    
    
       <script type="text/javascript">
    
    
    function alertar(mensaje){
    alert(mensaje);
    }
   
   
    function setfecha(){
    dcument.getElementById('HiddenField2').value=document.getElementById('nacimiento').value;
    }
    
    
    </script>
        
        
    
 
     
         
        
        
       
    <!-- end: Body Inner --><!-- Scroll top --><a id="scrollTop"><i class="icon-chevron-up"></i><i class="icon-chevron-up"></i></a><!--Plugins-->
    <script src="js/jquery.js"></script>
    <script src="js/plugins.js"></script>
    <!--Template functions-->
    <script src="js/functions.js"></script>
    <!-- jQuery Validate plugin files-->
    <script src="plugins/validate/validate.min.js"></script>
    <script src="plugins/validate/valildate-rules.js"></script>
</body>

</html>
