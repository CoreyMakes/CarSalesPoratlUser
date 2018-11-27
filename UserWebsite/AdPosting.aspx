<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdPosting.aspx.cs" Inherits="UserWebsite.AdPosting" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
<script type="text/javascript">
        function validate()
        {
            var name = document.getElementById("ContentPlaceHolder1_TextBox1").value;
            var mob = document.getElementById("ContentPlaceHolder1_TextBox2").value;
            var company = document.getElementById("ContentPlaceHolder1_TextBox3").value;
            var model = document.getElementById("ContentPlaceHolder1_TextBox4").value;
            var submodel = document.getElementById("ContentPlaceHolder1_TextBox5").value;
            var fuel = document.getElementById("ContentPlaceHolder1_TextBox6").value;
            var year = document.getElementById("ContentPlaceHolder1_TextBox7").value;
            var kilometer = document.getElementById("ContentPlaceHolder1_TextBox8").value;
            var price = document.getElementById("ContentPlaceHolder1_TextBox9").value;
            

            var img1 = document.getElementById("ContentPlaceHolder1_FileUpload1").value;
            var img2 = document.getElementById("ContentPlaceHolder1_FileUpload2").value;

            if(name.trim()=="")
            {
                document.getElementById("ContentPlaceHolder1_TextBox1").focus();
                alert("Name Field Is Mandatory");
                return false;
            }
            if(mob.trim()=="")
            {
                document.getElementById("ContentPlaceHolder1_TextBox2").focus();
                alert("Mobile Number Is Mandatory");
                return false;
            }
            if (ContentPlaceHolder1_TextBox2.value.length != 10)
            {
                mob_number.value = "";
                document.getElementById("ContentPlaceHolder1_TextBox2").focus();
                alert("Invalid Mobile Number");
                return false;
            }
            if(company.trim()=="")
            {
                document.getElementById("ContentPlaceHolder1_TextBox3").focus();
                alert("Company Name Is Mandatory");
                return false;
            }
            if(model.trim()=="")
            {
                document.getElementById("ContentPlaceHolder1_TextBox4").focus();
                alert("Model Name Is Mandatory");
                return false;
            }
            if(submodel.trim()=="")
            {
                document.getElementById("ContentPlaceHolder1_TextBox5").focus();
                alert("Sub Model Name Is Mandatory");
                return false;
            }
            if(fuel.trim()=="")
            {
                document.getElementById("ContentPlaceHolder1_TextBox6").focus();
                alert("Fule Type Is Mandatory");
                return false;
            }
            if(year.trim()==""||ContentPlaceHolder1_TextBox7.value.length != 4)
            {
                document.getElementById("ContentPlaceHolder1_TextBox7").focus();
                alert(" Invalid Manufacturing Year");
                return false;
            }
            if(kilometer.trim()=="")
            {
                document.getElementById("ContentPlaceHolder1_TextBox8").focus();
                alert("KiloMeter Is Mandatory");
                return false;
            }
            if(price.trim()=="")
            {
                document.getElementById("ContentPlaceHolder1_TextBox9").focus();
                alert("Expected Price Is Mandatory");
                return false;
            }
            if(img1=="")
            {
                alert("Insert First Image");
                return false;
            }
            if (img1 != "") {
                function ValidateExtension() {
                    var allowedFiles = [".png", ".jpeg", ".jpg"];
                    var fileUpload = document.getElementById("ContentPlaceHolder1_FileUpload1");
                    var regex = new RegExp("([a-zA-Z0-9\s_\\.\-:\(\)])+(" + allowedFiles.join('|') + ")$");
                    if (!regex.test(fileUpload.value.toLowerCase())) {
                        return false;
                    }
                }
                var b = ValidateExtension();
                if (b == false) {
                    alert("Invalid File");
                    return false;
                }
            }

            if (img2 == "") {
                alert("Insert Second Image");
                return false;
            }
            if (img2 != "") {
                function ValidateExtension() {
                    var allowedFiles = [".png", ".jpeg", ".jpg"];
                    var fileUpload = document.getElementById("ContentPlaceHolder1_FileUpload2");
                    var regex = new RegExp("([a-zA-Z0-9\s_\\.\-:\(\)])+(" + allowedFiles.join('|') + ")$");
                    if (!regex.test(fileUpload.value.toLowerCase())) {
                        return false;
                    }
                }
                var b = ValidateExtension();
                if (b == false) {
                    alert("Invalid File");
                    return false;
                }
            }


        }
</script>

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
    <script type="text/javascript">
        function showimagepreview(input) {
            if (input.files && input.files[0]) {
                var filerdr = new FileReader();
                filerdr.onload = function (e) {
                    $('#ContentPlaceHolder1_Image1').attr('src', e.target.result);
                }
                filerdr.readAsDataURL(input.files[0]);
            }
        }
        function showimagepreview1(input) {
            if (input.files && input.files[0]) {
                var filerdr = new FileReader();
                filerdr.onload = function (e) {
                    $('#ContentPlaceHolder1_Image2').attr('src', e.target.result);
                }
                filerdr.readAsDataURL(input.files[0]);
            }
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="about_wrapper">
        <i>Enter Details.....</i>
    </div>
    <table class="span_2_of_c">
        <tr>
            <td class="auto-style2">&nbsp;&nbsp;</td>
            <td class="auto-style3">&nbsp;&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;&nbsp;Your Name</td>
            <td class="auto-style3">
                <asp:TextBox ID="TextBox1" placeholder="Eg.John" runat="server" required pattern="[a-zA-Z\s]+"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;&nbsp;Contact Number</td>
            <td class="auto-style3">
                <asp:TextBox ID="TextBox2" placeholder="9656333250" runat="server" required pattern="[0-9]+"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;&nbsp;Company</td>
            <td class="auto-style3">
                <asp:TextBox ID="TextBox3" placeholder="Eg.Maruthi Suzuki" runat="server" required pattern="[a-zA-Z\s]+"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;&nbsp;Model</td>
            <td class="auto-style3">
                <asp:TextBox ID="TextBox4" placeholder="Eg.Swift" runat="server" required pattern="[a-zA-Z\s]+"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;&nbsp;Sub Model</td>
            <td class="auto-style3">
                <asp:TextBox ID="TextBox5" placeholder="Eg.VDI" runat="server" required pattern="[a-zA-Z\s]+"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;&nbsp;Fuel Type</td>
            <td class="auto-style3">
                <asp:TextBox ID="TextBox6" placeholder="Eg.Disel" runat="server" required pattern="[a-zA-Z\s]+"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;&nbsp;Manufacturing Year</td>
            <td class="auto-style3">
                <asp:TextBox ID="TextBox7" placeholder="Eg.2012" runat="server" required pattern="[0-9]+"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;&nbsp;Kilo Meters</td>
            <td class="auto-style3">
                <asp:TextBox ID="TextBox8" placeholder="Eg.11000" runat="server" required pattern="[0-9]+"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;&nbsp;Expected Price</td>
            <td class="auto-style3">
                <asp:TextBox ID="TextBox9" placeholder="Eg RS.320000" runat="server" required pattern="[0-9]+"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;&nbsp;Picture1</td>
            <td class="auto-style3">
                <asp:FileUpload ID="FileUpload1" onchange="showimagepreview(this)" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;&nbsp;Picture2</td>
            <td class="auto-style3">
                <asp:FileUpload ID="FileUpload2" onchange="showimagepreview1(this)" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;&nbsp;Preview</td>
            <td class="auto-style3">
                <asp:Image ID="Image1" runat="server" Width="83px" />
                <asp:Image ID="Image2" runat="server" Width="83px" />
            </td>
        </tr>
    </table>
    <asp:Button ID="Button1" runat="server" CssClass="btn btn-primary" Text="Submit" OnClick="Button1_Click" OnClientClick="return validate();"/>
    <script src="assets/js/jquery-1.10.2.js"></script>
    <!--bootstrap JavaScript file  -->
    <script src="assets/js/bootstrap.js"></script>
    <!--Slider JavaScript file  -->
    <script src="assets/ItemSlider/js/modernizr.custom.63321.js"></script>
    <script src="assets/ItemSlider/js/jquery.catslider.js"></script>
</asp:Content>
