<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm8.aspx.cs" Inherits="UserWebsite.WebForm8" %>
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
    <asp:DataList ID="DataList1" runat="server" RepeatColumns="3" RepeatLayout="Flow" RepeatDirection="Horizontal">
        <HeaderTemplate>
              <div class="row">

        </HeaderTemplate>
        <ItemTemplate>
          
                <div class="col-md-4 text-center col-sm-6 col-xs-6">
                    <div class="thumbnail product-box">
                          <asp:Image ID="Image1" ImageUrl='<%# "http://localhost:49447/Images/"+Eval("PICTURE").ToString() %>' Height="200px" runat="server" />
                        <div class="caption">
                            <h3><a href="#"><%# Eval("MODEL_NAME") %> </a></h3>
                            <%--<p>Price : <strong>$ 3,45,900</strong>  </p>--%>
                            <%--<p><a href="#">Ptional dismiss button </a></p>
                            <p>Ptional dismiss button in tional dismiss button in   </p>--%>
                            <%--<p><a href="#" class="btn btn-success" role="button">Add To Cart</a> <a href="#" class="btn btn-primary" role="button">See Details</a></p>--%>
                            <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server"  CommandArgument='<%# Eval("SUBMODEL_ID") %>' Text="View Details" OnClick="Button1_Click"/>
                        </div>
                    </div>
                </div>
          
            <%--  <div class="col-md-4 text-center col-sm-6 col-xs-6">
                        <div class="thumbnail product-box">
                        
                            <div class="caption">
                                <h3><a href="#"></a></h3>
                                <%--<p>Price : <strong><%# Eval("SUBMODEL_DETAILS.PRICE") %></strong>  </p>--%>
         <%--   <p><a href="#" class="btn btn-success" role="button">Add To Cart</a> <a href="#" class="btn btn-primary" role="button">See Details</a></p>
            </div>
                        </div>
                    </div>--%>
        </ItemTemplate>
        <FooterTemplate>
  
            </div>
        </FooterTemplate>
    </asp:DataList>

    <script src="assets/js/jquery-1.10.2.js"></script>
    <!--bootstrap JavaScript file  -->
    <script src="assets/js/bootstrap.js"></script>
    <!--Slider JavaScript file  -->
    <script src="assets/ItemSlider/js/modernizr.custom.63321.js"></script>
    <script src="assets/ItemSlider/js/jquery.catslider.js"></script>
</asp:Content>
