
<%@ Page Language="C#" AutoEventWireup="true"
    CodeFile="FileUpload.aspx.cs" Inherits="FileUpload" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>FileUpload Control Example</title>
</head>
<body>
<form id="form1" runat="server">

    <h1>FileUpload Control Example</h1>

    Please Select a File to Upload<br /><br />

    <asp:FileUpload ID="FileUpload1"
        runat="server" />

    <br /><br />

    <asp:Button ID="Button1"
        runat="server"
        Text="Click To Upload"
        OnClick="Button1_Click" />

    <br /><br />

    <asp:Label ID="Label1"
        runat="server" />

</form>
</body>
</html>
