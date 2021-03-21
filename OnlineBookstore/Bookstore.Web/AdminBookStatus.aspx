<%@ Page Title="Book Checkout Status" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminBookStatus.aspx.cs" Inherits="Bookstore.Web.issuedbooks" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">

        <div class="container-fluid">
        <div class="row">
            <div class="col-md-5">
                <div class="card">
                    <div class="card-body">

                        <div class="row">
                            <div class="col center">
                                <h3>Book Details</h3>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col center">
                                <img width="75" src="img/book.png" />
                            </div>
                        </div>

                        <div class="row">
                            <div class="col center">
                                <hr />
                                <br />
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-6">
                                <div class="form-group center">
                                    <asp:TextBox class="form-control" ID="memberIdTxtBx" placeholder="Member Id"
                                        runat="server"></asp:TextBox>
                                </div>
                                <br />
                            </div>
                            <div class="col-md-6">
                                <div class="form-group center">
                                    <div class="input-group">
                                        <asp:TextBox class="form-control" ID="bookIdTxtBx" placeholder="Book Id" runat="server"></asp:TextBox>
                                        <asp:Button ID="searchBtn" class="btn btn-primary" runat="server" Text="Search" />
                                    </div>
                                </div>
                                <br />
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-6">
                                <div class="form-group center">
                                    <asp:TextBox class="form-control" ID="membernameTxtBx" placeholder="Member Name"
                                        runat="server" ReadOnly="True"></asp:TextBox>
                                </div>
                                <br />
                            </div>
                            <div class="col-md-6">
                                <div class="form-group center">
                                    <div class="input-group">
                                        <asp:TextBox class="form-control" ID="bookNameTxtBx" placeholder="Book Name" runat="server" ReadOnly="True"></asp:TextBox>
                                    </div>
                                </div>
                                <br />
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-6">
                                <div class="form-group center">
                                    <asp:TextBox class="form-control" ID="startDateTxtBx" placeholder="Start Date" runat="server" TextMode="Date"></asp:TextBox>
                                </div>
                                <br />
                            </div>
                            <div class="col-md-6">
                                <div class="form-group center">
                                    <div class="input-group">
                                    <asp:TextBox class="form-control" ID="endDateTxtBx" placeholder="End Date" runat="server" TextMode="Date"></asp:TextBox>
                                    </div>
                                </div>
                                <br />
                            </div>
                        </div>

                        <div class="row mr-auto">
                            <div class="col center">
                                <asp:Button ID="issuedBtn" class="btn btn-success w-75" runat="server" Text="Issued" />
                            </div>
                            <div class="col center">
                                <asp:Button ID="returnBtn" class="btn btn-success w-75" runat="server" Text="Return" />
                            </div>
                        </div>
                    </div>
                    <a href="homepage.aspx"><< Back to Home</a>
                </div>
                <br />
            </div>
            <div class="col-md-7">

                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col center">
                                <img width="100" src="img/bunchofBook.png" />
                            </div>
                        </div>

                        <div class="row">
                            <div class="col center">
                                <h3>Issued Book List</h3>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col center">
                                <hr />
                            </div>
                        </div>

                        <div class="row">
                            <div class="col center">
                                <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server">
                                </asp:GridView>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <br />
        </div>
    </div>


</asp:Content>
