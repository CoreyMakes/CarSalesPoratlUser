<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Booked.aspx.cs" Inherits="UserWebsite.Booked" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
    <div class="about_wrapper">
        <i> <asp:Label ID="Label1" runat="server"></asp:Label> </i>
    </div>
    <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" RepeatLayout="Flow" RepeatDirection="Horizontal">
        <HeaderTemplate>
            <div class="row">
        </HeaderTemplate>
        <ItemTemplate>

            <div class="col-md-4 text-center col-sm-6 col-xs-6">
                <div class="thumbnail product-box">
                    <asp:Image ID="Image1" ImageUrl='<%# "http://localhost:49447/Images/"+Eval("MODEL_PICTURE").ToString() %>' Height="200px" runat="server" />
                    <div class="caption">
                        <h3><%# Eval("MODEL_NAME") %></h3>
                        <asp:Button ID="Button1" CssClass="btn btn-primary" CommandName='<%# Eval("BOOKING_ID") %>' runat="server" Text="View Details" OnClick="Button1_Click"/>
                    </div>
                </div>
            </div>
        </ItemTemplate>
        <FooterTemplate>
            </div>
        </FooterTemplate>
    </asp:DataList>
</asp:Content>
