<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Forgot_Password.aspx.cs" Inherits="UserWebsite.Forgot_Password" %>

<!DOCTYPE html>

<%--<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>--%>
<html>
<head>
<title>Reset Password Form  Responsive Widget Template | Home :: w3layouts</title>
<link href="css/style3.css" rel="stylesheet" type="text/css" media="all"/>
<!-- Custom Theme files -->
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" /> 
<meta name="keywords" content="Reset Password Form Responsive, Login form web template, Sign up Web Templates, Flat Web Templates, Login signup Responsive web template, Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyEricsson, Motorola web design" />
<!--google fonts-->
<link href='//fonts.googleapis.com/css?family=Roboto:400,100,300,500,700,900' rel='stylesheet' type='text/css'>
</head>
<body>
    <form id="frm1" runat="server">
<!--element start here-->
<div class="elelment">
	<h2>Reset Password Form</h2>
	<div class="element-main">
		<h1>Forgot Password</h1>
		<p> Please Enter Your Email Address</p>
            <asp:TextBox ID="TextBox1" placeholder="Your e-mail address" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Your e-mail address';}" runat="server"></asp:TextBox>
			<%--<input type="text" value="Your e-mail address" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = 'Your e-mail address';}">--%>
			<%--<input type="submit" value="Reset my Password">--%>
            <asp:Button ID="Button1" runat="server" Text="Reset my Password" OnClick="Button1_Click" />
	</div>
</div>
<div class="copy-right">
			<p>© 2017 Reset Password Form. All rights reserved | Designed by  Noel Toy</p>
</div>

<!--element end here-->
</form>
</body>
</html>