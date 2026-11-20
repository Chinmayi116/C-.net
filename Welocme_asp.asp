<script runat="server">
    void Display()
    {
        Response.Write("Welcome to ASP.NET");
    }
</script>

<html>
<body>
<form runat="server">
    <%
        Display();
    %>
</form>
</body>
</html>
