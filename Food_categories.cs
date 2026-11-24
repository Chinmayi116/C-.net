<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master"
AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="treeview_example._Default" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
 
 <h2>Food Categories</h2>
 <asp:TreeView ID="TreeView1" runat="server" ShowLines="true">
 <Nodes>
 <asp:TreeNode Text="Food">
 <asp:TreeNode Text="Fruits">
 <asp:TreeNode Text="Apple"/>
 <asp:TreeNode Text="Mango"/>
 <asp:TreeNode Text="Banana"/>
 </asp:TreeNode>
 <asp:TreeNode Text="Vegetables">
 <asp:TreeNode Text="Carrot"/>
 <asp:TreeNode Text="Potato"/>
 <asp:TreeNode Text="Tomato"/>
 </asp:TreeNode>
 </asp:TreeNode>
 </Nodes>
 </asp:TreeView>
</asp:Conten
