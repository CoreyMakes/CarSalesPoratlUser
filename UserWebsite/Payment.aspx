<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="UserWebsite.Payment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        function validate()
        {
            var name = document.getElementById("ContentPlaceHolder1_TextBox4").value;
            var mob_number = document.getElementById("ContentPlaceHolder1_TextBox5").value;
            var email = document.getElementById("ContentPlaceHolder1_TextBox6").value;
            var opt1 = document.getElementById("ContentPlaceHolder1_RadioButtonList1_0");
            var opt2 = document.getElementById("ContentPlaceHolder1_RadioButtonList1_1");
           

            if(name.trim()=="")
            {
                document.getElementById("ContentPlaceHolder1_TextBox4").focus();
                alert("Name Field Is Mandatory");
                return false;
            }
            if(mob_number.trim()=="")
            {
                document.getElementById("ContentPlaceHolder1_TextBox5").focus();
                alert("Mob Number Is Mandatory");
                return false;
            }
            if (isNaN(mob_number)) {
                mob_number.value = "";
                document.getElementById("ContentPlaceHolder1_TextBox5").focus();
                alert("Invalid Mobile Number");
                return false;
            }
            if (ContentPlaceHolder1_TextBox5.value.length != 10) {
                mob_number.value = "";
                document.getElementById("ContentPlaceHolder1_TextBox5").focus();
                alert("Invalid Mobile Number");
                return false;
            }
            if (email.trim() == "") {
                document.getElementById("ContentPlaceHolder1_TextBox6").focus();
                alert("Email Address Is Mandatory");
                return false;
            }
            if(opt1.checked==false && opt2.checked==false)
            {
                alert("Select Payment Method");
                return false;
            }
            if(opt1.checked==true)
            {
                var cardname = document.getElementById("ContentPlaceHolder1_TextBox1").value;
                var cardnumber = document.getElementById("ContentPlaceHolder1_TextBox2").value;
                var cardno = /^(?:4[0-9]{12}(?:[0-9]{3})?)$/;
                var year = document.getElementById("ContentPlaceHolder1_DropDownList1");
                var year_value=year.options[year.selectedIndex].text;
                var cvv = document.getElementById("ContentPlaceHolder1_TextBox3").value;

                if(cardname.trim()=="")
                {
                    document.getElementById("ContentPlaceHolder1_TextBox1").focus();
                    alert("Card Name Is Mandatory");
                    return false;
                }
                if(cardnumber.trim()=="")
                {
                    document.getElementById("ContentPlaceHolder1_TextBox2").focus();
                    alert("Card Number Is Mandatory");
                    return false;
                }
                if (cardnumber.match(cardno))
                {
                    
                }
                else
                {
                    alert("Not a valid Visa credit card number!");
                    return false;
                }
                if(year_value=="select")
                {
                    alert("Select Month of Expiry");
                    return false;
                }
                if(cvv.trim()=="")
                {
                    document.getElementById("ContentPlaceHolder1_TextBox3").focus();
                    alert("Enter CVV");
                    return false;
                }
                if (ContentPlaceHolder1_TextBox3.value.length != 3) {
                    cvv.value = "";
                    document.getElementById("ContentPlaceHolder1_TextBox3").focus();
                    alert("Invalid CVV");
                    return false;
                }
                
            }
            if(opt2.checked==true)
            {
                var bank1 = document.getElementById("ContentPlaceHolder1_RadioButtonList2_0");
                var bank2 = document.getElementById("ContentPlaceHolder1_RadioButtonList2_1");
                var bank3 = document.getElementById("ContentPlaceHolder1_RadioButtonList2_2");
                var bank4 = document.getElementById("ContentPlaceHolder1_RadioButtonList2_3");
                var bank5 = document.getElementById("ContentPlaceHolder1_RadioButtonList2_4");
                var bank6 = document.getElementById("ContentPlaceHolder1_RadioButtonList2_5");
                if(bank1.checked==false&&bank2.checked==false&&bank3.checked==false&&bank4.checked==false&&bank5.checked==false&&bank6.checked==false)
                {
                    alert("Select Your Bank");
                    return false;
                }
            }
        }
    </script>


    <style type="text/css">
        .auto-style3 {
            width: 136px;
            height: 42px;
        }
        .auto-style4 {
            width: 285px;
            height: 42px;
        }
        .auto-style5 {
            width: 136px;
            height: 39px;
        }
        .auto-style6 {
            width: 285px;
            height: 39px;
        }
        .auto-style7 {
            width: 136px;
            height: 38px;
        }
        .auto-style8 {
            width: 285px;
            height: 38px;
        }
    </style>
    <link href="assets/css/bootstrap.css" rel="stylesheet">
    <!-- Fontawesome core CSS -->
    <link href="assets/css/font-awesome.min.css" rel="stylesheet" />
    <!--GOOGLE FONT -->
    <link href='http://fonts.googleapis.com/css?family=Open+Sans' rel='stylesheet' type='text/css'>
    <!--Slide Show Css -->
    <link href="assets/ItemSlider/css/main-style.css" rel="stylesheet" />
    <!-- custom CSS here -->
    <link href="assets/css/style.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type = "text/javascript" >
        function preventBack() { window.history.forward(); }
        setTimeout("preventBack()", 0);
        window.onunload = function () { null };
</script>
    <table class="span_2_of_c" border="15">
        <tr>
            <td class="auto-style3">Your Name</td>
            <td class="auto-style4">
                <asp:TextBox ID="TextBox4" placeholder="Name" runat="server" pattern="[a-zA-Z\s]+"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Contact Number</td>
            <td class="auto-style4">
                <asp:TextBox ID="TextBox5" placeholder="Eg:9656333250" runat="server" required ></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Email Address</td>
            <td class="auto-style4">
                <asp:TextBox ID="TextBox6" placeholder="Eg:jack@gmail.com" type="email" runat="server" required></asp:TextBox>
            </td>
        </tr>
    </table>
    <table class="span_2_of_c" border="15">
        <tr>
            <td class="auto-style3">Model Name</td>
            <td class="auto-style4">
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Sub Model</td>
            <td class="auto-style6">
                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Fuel Type</td>
            <td class="auto-style8">
                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Color</td>
            <td class="auto-style6">
                <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Total&nbsp; Amount</td>
            <td class="auto-style6">
                <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Advance Amount</td>
            <td class="auto-style6">
                <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Date Of Delivey(Expected)</td>
            <td class="auto-style6">
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>
    </table>
    <div class="caption">
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" AutoPostBack="True">
        </asp:RadioButtonList>
    </div>
    <asp:Panel ID="Panel1" runat="server">
       <table class="span_2_of_c" border="15">
           <tr>
               <td class="auto-style3">Card Holder Name</td>
               <td class="auto-style6">
                   <asp:TextBox ID="TextBox1" CssClass="payment" runat="server" pattern="[a-zA-Z\s]+"></asp:TextBox>
            </td>
           </tr>
           <tr>
               <td class="auto-style3">Card Number</td>
               <td class="auto-style6">
                   <asp:TextBox ID="TextBox2" CssClass="payment" runat="server" pattern="[0-9]+" ></asp:TextBox>
            </td>
           </tr>
           <tr>
               <td class="auto-style3"></td>
               <td class="auto-style6">
                   <asp:DropDownList ID="DropDownList1" CssClass="month" runat="server">
                                    <asp:ListItem Value="0">select</asp:ListItem>
                                    <asp:ListItem Value="1">Jan</asp:ListItem>
                                    <asp:ListItem Value="2">Feb</asp:ListItem>
                                    <asp:ListItem Value="3">Mar</asp:ListItem>
                                    <asp:ListItem Value="4">Apr</asp:ListItem>
                                    <asp:ListItem Value="5">May</asp:ListItem>
                                    <asp:ListItem Value="6">Jun</asp:ListItem>
                                    <asp:ListItem Value="7">Jul</asp:ListItem>
                                    <asp:ListItem Value="8">Aug</asp:ListItem>
                                    <asp:ListItem Value="9">Sep</asp:ListItem>
                                    <asp:ListItem Value="10">Oct</asp:ListItem>
                                    <asp:ListItem Value="11">Nov</asp:ListItem>
                                    <asp:ListItem Value="12">Dec</asp:ListItem>
                    </asp:DropDownList>
                   <asp:DropDownList ID="DropDownList2" CssClass="year" runat="server"></asp:DropDownList>
                   <asp:TextBox ID="TextBox3" type="password" placeholder="cvv" runat="server" Height="23px" Width="40px" required pattern="[0-9]+" ></asp:TextBox>
            </td>
           </tr>
       </table>
        
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server">
        <table class="span_2_of_c" border="15">
            <tr>
               <td class="auto-style3"><h4>Select the Bank</h4></td>
           </tr>
            <tr>
                <td class="auto-style3">
                    <asp:RadioButtonList ID="RadioButtonList2" runat="server">
                        <asp:ListItem Value="ICICI bank">ICICI bank</asp:ListItem>
                        <asp:ListItem Value="HDFC bank">HDFC bank</asp:ListItem>
                        <asp:ListItem Value="SBI bank">SBI bank</asp:ListItem>
                        <asp:ListItem Value="IDBI bank">IDBI bank</asp:ListItem>
                        <asp:ListItem Value="AXIS bank">AXIS bank</asp:ListItem>
                        <asp:ListItem Value="KOTAK bank">KOTAK bank</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
        </table>
        
    </asp:Panel>
    <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" Text="Make Payment" OnClick="Button1_Click" OnClientClick="return validate();" />
    <script src="assets/js/jquery-1.10.2.js"></script>
    <!--bootstrap JavaScript file  -->
    <script src="assets/js/bootstrap.js"></script>
    <!--Slider JavaScript file  -->
    <script src="assets/ItemSlider/js/modernizr.custom.63321.js"></script>
    <script src="assets/ItemSlider/js/jquery.catslider.js"></script>
</asp:Content>
