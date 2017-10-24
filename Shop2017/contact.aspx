<%@ Page Title="" Language="C#" MasterPageFile="~/default.Master" AutoEventWireup="true" CodeBehind="contact.aspx.cs" Inherits="Shop2017.Contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p><asp:Label ID="NameLbl" runat="server" Text="Enter Your Name"></asp:Label></p>
    <p><asp:TextBox ID="NameTxt" runat="server"></asp:TextBox></p>
    <p><asp:Label ID="EmailLbl" runat="server" Text="Enter Your Email Address"></asp:Label></p>
    <p><asp:TextBox ID="ToTxt" runat="server"></asp:TextBox></p>
    <p><asp:Label ID="SubjectLbl" runat="server" Text="What is the subject of your message?"></asp:Label></p>
    <p><asp:TextBox ID="SubjectTxt" runat="server"></asp:TextBox></p>
    <p><asp:Label ID="MessageLbl" runat="server" Text="Enter Your Message"></asp:Label></p>
    <p><asp:TextBox ID="MessageTxt" runat="server"></asp:TextBox></p>
    <p><asp:Button ID="SendBtn" runat="server" Text="Send" OnClick="SendBtn_Click1" /></p>
    <p><asp:Literal ID="SendLit" runat="server"></asp:Literal></p>
</asp:Content>
