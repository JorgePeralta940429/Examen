<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Usuarios_Seleccionar.aspx.cs" Inherits="Usuarios_Seleccionar" %>

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
    
   
  

<table class="table">
  <thead class="thead-dark">
    <tr>
      <th scope="col">id</th>
      <th scope="col">Nombre</th>
      <th scope="col">Apellido Paterno</th>
      <th scope="col">Apellido Materno</th>
      <th scope="col">Edad</th>
      <th scope="col">Eliminar</th>
      <th scope="col">Modificar</th>
    </tr>
  </thead>
  <tbody >
    
    
    
    <asp:Literal ID="Literal1" runat="server"></asp:Literal></tbody></table>
   
   
   <br/>
    <br/>
     <br/>
   <center><asp:Button ID="Button1" runat="server" Text="Agregar Usuario" CssClass="btn btn-primary" OnClick="Button1_Click" /></center>
   
   
   </form>
    
    
   
 
        
    
    
        
    
    
    
       <script type="text/javascript">
    
    
    function alertar(mensaje){
    alert(mensaje);
    }
   
   
    function setfecha(){
    dcument.getElementById('HiddenField2').value=document.getElementById('nacimiento').value;
    }
    
    
    </script>
        
        
    
 
       
       
       
        
         
        
       
       
    <!-- end: Body Inner --><!-- Scroll top -->
    <a id="scrollTop"><i class="icon-chevron-up"></i><i class="icon-chevron-up"></i></a><!--Plugins-->
    <script src="js/jquery.js"></script>
    <script src="js/plugins.js"></script>
    <!--Template functions-->
    <script src="js/functions.js"></script>
    <!-- jQuery Validate plugin files-->
    <script src="plugins/validate/validate.min.js"></script>
    <script src="plugins/validate/valildate-rules.js"></script>
</body>

</html>