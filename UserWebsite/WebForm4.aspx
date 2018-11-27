<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="UserWebsite.WebForm4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
        function validate()
        {
            var  select= document.getElementById("ContentPlaceHolder1_DropDownList1");
            var select_name = select.options[select.selectedIndex].text;

            if(select_name=="<---Select---->")
            {
                alert("Select Your Color");
                return false;
            }
        }
    </script>
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
                    <asp:Label ID="Label4" runat="server" Text="Select Color: "></asp:Label>
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
                    </p>
                    <p>
                    <asp:Label ID="Label6" runat="server"></asp:Label>
                    </p>
                    <div class="price" style="height: 19px;">
                        <span class="reducedfrom">

                            <asp:Label ID="Label5" runat="server" Text="Price Rs. "></asp:Label><asp:Label ID="Label2" runat="server" Text="XXX"></asp:Label>
                        </span>
                        
                    </div>
                    <div class="cart-button">
                        <div class="cart">
                            <span> <asp:Button ID="Button1" CssClass="button" runat="server" Text="Book Now" OnClick="Button1_Click" OnClientClick="return validate();" /> </span>
                        </div>
                        <div class="clear"></div>
                    </div>
                </div>
            </div>
        </div>
        <div class="clear"></div>
  

    </div>


</asp:Content>
