<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Testing.aspx.cs" Inherits="Bookstore.Web.Testing" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="container">
        <div class="row center">
            <div class="col-lg-5">
                <div class="card border-dark mb-1" style="max-width: 35rem;">
                    <div class="card-header">Header</div>
                    <div class="card-body">

                        <div>

                            User Name:-<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                            <br />
                            Password  :-<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                            <br />
                            <asp:Button ID="SubmitNowBtn" runat="server" Text="Submit" OnClick="SubmitNowBtn_Click" />
                            <asp:Button ID="RestoreBtn" runat="server" Text="Restore" OnClick="RestoreBtn_Click" />
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
