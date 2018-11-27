<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="UserWebsite.WebForm2" %>

<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="assets/css/bootstrap.css" rel="stylesheet">
    <!-- Fontawesome core CSS -->
    <link href="assets/css/font-awesome.min.css" rel="stylesheet" />
    <!--GOOGLE FONT -->
    <link href='http://fonts.googleapis.com/css?family=Open+Sans' rel='stylesheet' type='text/css'>
    <!--Slide Show Css -->
    <link href="assets/ItemSlider/css/main-style.css" rel="stylesheet" />
    <!-- custom CSS here -->
    <link href="assets/css/style.css" rel="stylesheet" />
    
</asp:Content>--%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="assets/css/bootstrap.css" rel="stylesheet">
    <!-- Fontawesome core CSS -->
    <link href="assets/css/font-awesome.min.css" rel="stylesheet" />
    <!--GOOGLE FONT -->
    <link href='http://fonts.googleapis.com/css?family=Open+Sans' rel='stylesheet' type='text/css'>
    <link href="assets/css/style.css" rel="stylesheet" />
    <!--New-->
    <meta name="viewport" content="width=device-width,initial-scale=1">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />

  <link rel="stylesheet" href="slider/responsiveslides.css">
  <script src="slider/jquery.min.js"></script>
  <script src="slider/responsiveslides.min.js"></script>
  <script src="slider/responsiveslides.js"></script>
  <script>
      // You can also use "$(window).load(function() {"
      $(function () {

          // Slideshow 1
          $("#slider1").responsiveSlides({
              maxwidth: 800,
              speed: 800
          });

          // Slideshow 2
          $("#slider2").responsiveSlides({
              auto: false,
              pager: true,
              speed: 300,
              maxwidth: 540
          });

          // Slideshow 3
          $("#slider3").responsiveSlides({
              manualControls: '#slider3-pager',
              maxwidth: 540
          });

          // Slideshow 4
          $("#slider4").responsiveSlides({
              auto: false,
              pager: false,
              nav: true,
              speed: 500,
              namespace: "callbacks",
              before: function () {
                  $('.events').append("<li>before event fired.</li>");
              },
              after: function () {
                  $('.events').append("<li>after event fired.</li>");
              }
          });

      });
  </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="slideshow">
			<ul class="rslides" id="slider1">
								<li><img id="img1" runat="server"  alt=""></li>
								<li><img id="img2" runat="server"  alt=""></li>
								<li><img id="img3" runat="server"  alt=""></li>
                                <li><img id="img4" runat="server"  alt=""></li>
			</ul>				
    </div>
    <div class="about_wrapper">
        <i>Choose Your Model.....</i>
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
                        <h3><a href="#"><%# Eval("MODEL_NAME") %> </a></h3>
                        <asp:Button ID="Button1" CssClass="btn btn-primary" CommandName='<%# Eval("MODEL_ID") %>' runat="server" Text="View Details" OnClick="Button1_Click" />
                    </div>
                </div>
            </div>
        </ItemTemplate>
        <FooterTemplate>
            </div>
        </FooterTemplate>
    </asp:DataList>
    <div >
        <iframe src="https://www.youtube.com/embed/XxUnl9ievV8" width="820" height="315" runat="server" id="videoplayer"></iframe>
    </div>
    </asp:Content>
