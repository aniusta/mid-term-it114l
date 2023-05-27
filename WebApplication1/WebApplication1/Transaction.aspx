<%@ Page Title="Transaction" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Transaction.aspx.cs" Inherits="WebApplication1.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <link rel="stylesheet" href="styles.css" />
        <div class="modalBackground" id="mymodal" role="dialog" runat="server" style="display:block;">
            <div class="modalPopup">
                <div class="modal-content">
                    <div class="modalHeader">
                        <h2 class="modal-title">Login</h2>
                    </div>
                    <asp:HiddenField ID="userID" runat="server" /> 
                    <div class="modalContent">
                        <fieldset>
                            <div class="labelpopup-control">
                                <label for="username">Username:</label>
                                <asp:TextBox ID="username" class="form-control" placeholder="Enter Username" runat="server"></asp:TextBox>
                            </div>
                            <div class="labelpopup-control">
                                <label for="password">Password:</label>
                                <asp:TextBox ID="password" class="form-control" placeholder="Enter Password" runat="server" TextMode="Password"></asp:TextBox>
                            </div>
                        </fieldset>
                        <asp:Button ID="submit" class="btn btn-primary"  runat="server" Text="Login" OnClick="submit_Click"/>
                        <asp:Button ID="Register" class="btn btn-primary"  runat="server" Text="Register" OnClick="register_Click"/>
                    </div>
                </div>
            </div>
        </div>
        <asp:DropDownList ID="DBlist" runat="server"></asp:DropDownList>
        <asp:Button ID="add" class="btn btn-secondary"  runat="server" Text="Add" OnClick="add_Click"/>
        <asp:Table ID="myTable" class="table-control" runat="server"></asp:Table>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <asp:Button ID="buy" class="btn btn-secondary"  runat="server" Text="Buy" OnClick="buy_Click"/>
    </main>
</asp:Content>
