<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">Mid Term Exam</h1>
            <p class="lead">Transaction Website where only registered customer can buy</p>
            
        </section>
        <asp:Button ID="login" class="btn btn-primary"  runat="server" Text="Click To Login" OnClick="login_Click"/>
        <div class="row">
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">

            </section>
        </div>
    </main>

</asp:Content>
