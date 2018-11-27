<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Contacts.aspx.cs" Inherits="UserWebsite.Contacts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        /*.auto-style1 {
            width: 100%;
            border-style: solid;
            border-width: 1px;
        }*/
        .auto-style2 {
            height: 19px;
        }
        .auto-style3 {
            height: 15px;
        }
        .auto-style4 {
            height: 16px;
        }
        .auto-style5 {
            height: 14px;
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
    <table border="0">
        <tr>
            <td class="auto-style2">
                <i><asp:Label ID="Label2" runat="server" ></asp:Label></i>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <i><asp:Label ID="Label3" runat="server" ></asp:Label></i>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">
                <i><asp:Label ID="Label4" runat="server" ></asp:Label></i>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">
                <i><asp:Label ID="Label5" runat="server" ></asp:Label></i>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
               <i><asp:Label ID="Label6" runat="server" ></asp:Label></i>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <i><asp:Label ID="Label7" runat="server" ></asp:Label></i>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
        </tr>
    </table>

    <div >
        <iframe src="https://www.youtube.com/embed/XxUnl9ievV8" width="820" height="315" runat="server" id="videoplayer"></iframe>
    </div>
</asp:Content>
