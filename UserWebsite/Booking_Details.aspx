<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Booking_Details.aspx.cs" Inherits="UserWebsite.Booking_Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 169px;
            height: 39px;
        }

        .auto-style3 {
            height: 39px;
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
    <script src="js/jquery.min.js"></script>
    <script src="js/script.js" type="text/javascript"></script>
    <script src="js/superfish.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="slideshow">
							<ul class="slides">
						    	<li><canvas ></canvas> <asp:Image ID="Image1" runat="server" /> </li>
						        <li><canvas></canvas> <asp:Image ID="Image2" runat="server" /> </li>
						        <%--<li><canvas></canvas><img src="images/banner3.jpg" alt="Power Station" ></li>
						        <li><canvas></canvas><img src="images/banner1.jpg" alt="Colors of Nature" ></li>--%>
						    </ul>
						    <span class="arrow previous"></span>
						    <span class="arrow next"></span>
    </div>
    <div class="about_wrapper">
        <i><asp:Label ID="Label9" runat="server" Text="Booking Details......"></asp:Label></i>
    </div>
    
        <table class="span_2_of_c">
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;&nbsp;&nbsp;<b>Model</b>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="Label1" runat="server" Text="Label" Font-Italic="True"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;&nbsp;&nbsp;<b>Sub Model</b>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="Label2" runat="server" Text="Label" Font-Italic="True"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;&nbsp;&nbsp;<b>Fuel Type</b>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="Label3" runat="server" Text="Label" Font-Italic="True"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;&nbsp;&nbsp;<b>Total Amount</b>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="Label4" runat="server" Text="Label" Font-Italic="True"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;&nbsp;&nbsp;<b>Amount Paid</b>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="Label5" runat="server" Text="Label" Font-Italic="True"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;&nbsp;&nbsp;<b>Balance Amount</b>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="Label6" runat="server" Text="Label" Font-Italic="True"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;&nbsp;&nbsp;<b>Date Of Booking</b>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="Label7" runat="server" Text="Label" Font-Italic="True"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;&nbsp;&nbsp;<b>Delivery/Issued Date</b>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="Label8" runat="server" Text="Label" Font-Italic="True"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;&nbsp;&nbsp;<b>Booking Status</b>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="Label10" runat="server" Text="Label" Font-Italic="True"></asp:Label>
                </td>
            </tr>
             <tr>
                <td class="auto-style2">&nbsp;&nbsp;&nbsp;<b>Cancel Your Order</b>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="Button1" CssClass="btn btn-danger" runat="server" Text="Cancel" />
                </td>
            </tr>
        </table>
     <script src="assets/js/jquery-1.10.2.js"></script>
    <!--bootstrap JavaScript file  -->
    <script src="assets/js/bootstrap.js"></script>
    <!--Slider JavaScript file  -->
    <script src="assets/ItemSlider/js/modernizr.custom.63321.js"></script>
    <script src="assets/ItemSlider/js/jquery.catslider.js"></script>
</asp:Content>
