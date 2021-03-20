<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ViewBooks.aspx.cs" Inherits="Bookstore.Web.ViewBooks" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">

        $(document).ready(function () {
            $(".table").prepend($("<thead></thead>").append($(this).find
                ("tr:first"))).dataTable();
        });
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">

    <div class="container-fluid">
        <div class="row">
            <div class="row">
                <div class="col center">
                    <h3>Inventory</h3>
                </div>
            </div>
            <div class="col-sm-12 col-md-12">
                <asp:Panel class="alert alert-success" role="alert" ID="Panel1" runat="server" Visible="False">
                    <asp:Label Text="Label" runat="server"></asp:Label>
                </asp:Panel>
            </div>
            <br />
        </div>
    </div>

</asp:Content>
