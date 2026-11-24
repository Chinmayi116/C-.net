
<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master"
AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="treeview_example._Default" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
 
<h2>Computer Parts</h2>
 <asp:TreeView ID="TreeView1" runat="server"
 ShowLines="true">
 <Nodes>
 <asp:TreeNode Text="Computer">
 <asp:TreeNode Text="Hardware">
 <asp:TreeNode Text="Keyboard"/>
 <asp:TreeNode Text="Mouse"/>
 <asp:TreeNode Text="Monitor"/>
 </asp:TreeNode>
 <asp:TreeNode Text="Software">
 <asp:TreeNode Text="Windows"/>
 <asp:TreeNode Text="Linux"/>
 </asp:TreeNode>
 </asp:TreeNode>
 </Nodes>
 </asp:TreeView>
</asp:Content>
