<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" Inherits="UserWebsite.WebForm7" %>

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
<html >
<head>
  <meta charset="UTF-8">
  <title>Sign-Up/Login Form</title>
  <link href='http://fonts.googleapis.com/css?family=Titillium+Web:400,300,600' rel='stylesheet' type='text/css'>
  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/normalize/5.0.0/normalize.min.css">
  <link rel="stylesheet" href="css/style1.css">
   <script type="text/javascript">
       function validate()
       {
           var f_name = document.getElementById("TextBox6").value;
           var l_name = document.getElementById("TextBox5").value;
           var pass = document.getElementById("TextBox3").value;
           var user = document.getElementById("TextBox4").value;
           if (f_name == "") {
               document.getElementById("TextBox6").focus();
               alert("Enter First Name");
               return false;
           }
           if (l_name == "") {
               document.getElementById("TextBox5").focus();
               alert("Enter Last Name");
               return false;
           }
           if (user == "") {
               document.getElementById("TextBox4").focus();
               alert("Enter User Name");
               return false;
           }

           if (pass == "") {
               document.getElementById("TextBox3").focus();
               alert("Enter Password");
               return false;
           }
       }
       
   </script>
  
</head>

<body>
     <form  id="form1" runat="server">
  <div class="form">
      
      <ul class="tab-group">
        <li runat="server" id="sign" class="tab"><asp:LinkButton ID="LinkButton1" href="#signup" runat="server" OnClick="LinkButton1_Click">Sign Up</asp:LinkButton></li>
        <li  runat="server" id="login1"  class="tab"><asp:LinkButton ID="LinkButton2" href="#login" runat="server" OnClick="LinkButton2_Click">Log In</asp:LinkButton></li>
      </ul>
      
      <div class="tab-content">
        <div id="signup" runat="server"  >   
          <h1>Sign Up for Free</h1>
         
          
          <div class="top-row">
            <div class="field-wrap">
              <%--<label>
                First Name<span class="req">*</span>
              </label>--%>
                <asp:TextBox ID="TextBox6" type="text" CssClass="req" placeholder="First Name*" runat ="server"></asp:TextBox>
            </div>
        
            <div class="field-wrap">
              <%--<label>
                Last Name<span class="req">*</span>
              </label>--%>
                <asp:TextBox ID="TextBox5" type="text" CssClass="req" placeholder="Last Name*" runat="server" ></asp:TextBox>
            </div>
          </div>

          <div class="field-wrap">
            <%--<label>
              Email Address<span class="req">*</span>
            </label>--%>
              <asp:TextBox ID="TextBox4" type="email" CssClass="req" placeholder="Email Address*" runat ="server"></asp:TextBox>
          </div>
          
          <div class="field-wrap">
            <%--<label>
              Set A Password<span class="req">*</span>
            </label>--%>
              <asp:TextBox ID="TextBox3"  type="password" placeholder="Set A Password*" runat="server"></asp:TextBox>
          </div>       
            <asp:Button ID="Button2" runat="server" CssClass="button button-block" Text="GET STARTED" OnClick="Button2_Click" OnClientClick="return validate();" />

        </div>
        
        <div id="login" runat="server" >   
          <h1>Welcome Back!</h1>
          
      
          
            <div class="field-wrap">
            <%--<label>
              Email Address<span class="req">*</span>
            </label>--%>
                <asp:TextBox ID="TextBox2" type="email" CssClass="req" placeholder="Email Address*" runat ="server"></asp:TextBox>
          </div>
          
          <div class="field-wrap">
            <%--<label>
              Password<span class="req">*</span>
            </label>--%>
              <asp:TextBox ID="TextBox1" type="password" CssClass="req" placeholder="Password*" runat ="server"></asp:TextBox>
          </div>
            
          <p class="forgot"><asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">Forgot Password?</asp:LinkButton></p>
              <asp:Button ID="Button1" CssClass="button button-block" OnClick="Button1_Click" runat="server" Text="LOGIN" />
          <%--<button class="button button-block">Log In</button>--%>
         <%-- CssClass="button button-block--%>
        </div>
        
      </div><!-- tab-content -->
      
</div> <!-- /form -->
  <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>
  <script src="js/index1.js"></script>
</form>
</body>
</html>