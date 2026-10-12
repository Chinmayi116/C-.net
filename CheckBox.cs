
<%@ Page Language="C#" %>

<script runat="server">
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ListBox1.Items.Add("Chocolate");
            ListBox1.Items.Add("Vanilla");
            ListBox1.Items.Add("Mango");
            ListBox1.Items.Add("Pista");
        }
    }
</script>

<!DOCTYPE html>
<html>
<body>
<form runat="server">
    <h3>Select your favourite Ice-cream Flavour</h3>

    <asp:CheckBox ID="CheckBox1" runat="server"
        Text="Chocolate" /><br />

    <asp:CheckBox ID="CheckBox2" runat="server"
        Text="Vanilla" /><br />

    <asp:CheckBox ID="CheckBox3" runat="server"
        Text="Mango" /><br />

    <asp:CheckBox ID="CheckBox4" runat="server"
        Text="Pista" /><br /><br />

    <asp:ListBox ID="ListBox1" runat="server"
        SelectionMode="Multiple"></asp:ListBox>
</form>
</body>
</html>
