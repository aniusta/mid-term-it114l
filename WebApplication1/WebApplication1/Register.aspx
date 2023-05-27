<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication1.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <div class="labelpopup-control">
            <label for="username">Username:</label>
            <asp:TextBox ID="username" class="form-control" placeholder="Enter Username" runat="server"></asp:TextBox>
        </div>
        <div class="labelpopup-control">
            <label for="password">Password:</label>
            <asp:TextBox ID="password" class="form-control" placeholder="Enter Password" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <asp:Button ID="register" class="btn btn-primary"  runat="server" Text="Register" OnClick="register_Click"/>
        <asp:Label ID="errorLabel" runat="server" Text="" Visible="false"></asp:Label>
    </main>
</asp:Content>
