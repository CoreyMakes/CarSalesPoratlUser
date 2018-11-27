<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="UserWebsite.WebForm5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="about_wrapper">
        <i>Proceed To Payment.......</i>
    </div>
    <div class="text">
        <div class="grid_1_of_3 images_1_of_3">
            <div class="grid_1">
                <%--<a href="single.html"><img src="images/pic1.jpg" title="continue reading" alt=""></a>--%>
                <asp:Image ID="Image1" Height="200px" runat="server" />
                <div class="grid_desc">
                    <p> </p>
                    <p>
                    <asp:Label ID="Label3" runat="server" Text="Sub-Model: "></asp:Label>
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                    </p>
                    <p>
                        <asp:Label ID="Label5" runat="server" Text="Color:"></asp:Label><asp:Label ID="Label6" runat="server"></asp:Label>
                    </p>
                    <div class="price" style="height: 19px;">
                        <span class="reducedfrom">
                           <asp:Label ID="Label2" runat="server" Text="Adv-Amount Rs."></asp:Label><asp:Label ID="Label4" runat="server"></asp:Label>
                        </span>
                    </div>
                    <div class="cart-button">
                        <div class="cart">
                           <asp:Button ID="Button1" align="center" CssClass="button" runat="server" Text="Payment" OnClick="Button1_Click" /> 
                        </div>
                        <div class="clear"></div>
                    </div>
                </div>
            </div>
        </div>
        <div class="clear"></div>
    </div>
</asp:Content>
