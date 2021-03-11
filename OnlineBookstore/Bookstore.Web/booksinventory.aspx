﻿<%@ Page Title="Book Details" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="booksinventory.aspx.cs" Inherits="Bookstore.Web.booksinventory" %>

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
                                <h4>Books Details</h4>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col center">
                                <img width="100" src="img/bunchofBook.png" />
                            </div>
                        </div>

                        <div class="row">
                            <div class="col center">
                                <hr />
                                <br />
                            </div>
                        </div>

                        <div class="row">
                            <div class="col center">
                                <asp:FileUpload class="form-control" ID="FileUpload1" runat="server" />
                                <br />
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-3">
                                <div class="form-group center">
                                    <div class="input-group">
                                        <asp:TextBox class="form-control" ID="BookIdTxtBx" placeholder="Book Id" runat="server"></asp:TextBox><asp:LinkButton ID="searchLBtn" CssClass="btn btn-primary" runat="server"><i class="fas fa-search"></i></asp:LinkButton>
                                    </div>
                                </div>
                                <br />
                            </div>
                            <div class="col-md-9">
                                <div class="form-group center">
                                    <div class="input-group">
                                        <asp:TextBox class="form-control" ID="bookNameTxtBx" placeholder="Book Name" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <br />
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-4">
                                <label>Language</label>
                                <div class="form-group center">
                                    <asp:DropDownList class="form-control" ID="languageDDL" runat="server">
                                        <asp:ListItem Text="English" Value="English" />
                                        <asp:ListItem Text="Creole" Value="Creole" />
                                        <asp:ListItem Text="French" Value="French" />
                                        <asp:ListItem Text="Spanish" Value="Spanish" />
                                        <asp:ListItem Text="Chinese" Value="Chinese" />
                                    </asp:DropDownList>
                                </div>
                                <br />

                                <label>Publisher Name</label>
                                <div class="form-group center">
                                    <asp:DropDownList class="form-control" ID="publisherDDL" runat="server">
                                        <asp:ListItem Text="Publisher1" Value="Publisher1" />
                                        <asp:ListItem Text="Publisher2" Value="Publisher2" />
                                    </asp:DropDownList>
                                </div>
                                <br />
                            </div>

                            <div class="col-md-4">
                                <label>Authorname</label>
                                <div class="form-group center">
                                    <asp:DropDownList class="form-control" ID="authorNameDDL" runat="server">
                                        <asp:ListItem Text="Author1" Value="Author1" />
                                        <asp:ListItem Text="Author2" Value="Author2" />
                                    </asp:DropDownList>
                                </div>
                                <br />

                                <label>Publisher Date</label>
                                <div class="form-group center">
                                    <asp:TextBox class="form-control" ID="publisherDateTxtBx" runat="server" TextMode="Date"></asp:TextBox>
                                </div>
                                <br />
                            </div>

                            <div class="col-md-4">
                                <label>Publisher Date</label>
                                <div class="form-group center">
                                    <asp:ListBox ID="ListBox1" class="form-control" runat="server" SelectionMode="Multiple" Rows="4">
                                        <asp:ListItem Text="Adventure" Value="Adventure" />
                                        <asp:ListItem Text="Motivation" Value="Motivation" />
                                        <asp:ListItem Text="Self-help" Value="Self-help" />
                                        <asp:ListItem Text="Wellness" Value="Wellness" />
                                        <asp:ListItem Text="Crime" Value="Crime" />
                                        <asp:ListItem Text="Fantasy" Value="Fantasy" />
                                        <asp:ListItem Text="Thriller" Value="Thriller" />
                                        <asp:ListItem Text="Suspense" Value="Suspense" />
                                        <asp:ListItem Text="Autobiography" Value="Autobiography" />
                                        <asp:ListItem Text="Personal Dev" Value="Personal Dev" />
                                        <asp:ListItem Text="Motivation" Value="Motivation" />

                                    </asp:ListBox>

                                </div>
                                <br />
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-4">
                                <label>Edition</label>
                                <div class="form-group center">
                                    <div class="input-group">
                                        <asp:TextBox class="form-control" ID="editionTxtBx" placeholder="Edition" runat="server" ReadOnly="True"></asp:TextBox>
                                    </div>
                                </div>
                                <br />
                            </div>
                            <div class="col-md-4">
                                <label>Unit Price</label>
                                <div class="form-group center">
                                    <div class="input-group">
                                        <asp:TextBox class="form-control" ID="priceTxtBx" placeholder="0" runat="server" SelectionMode="Single" TextMode="Number" ReadOnly="True"></asp:TextBox>
                                    </div>
                                </div>
                                <br />
                            </div>
                            <div class="col-md-4">
                                <label>Pages</label>
                                <div class="form-group center">
                                    <div class="input-group">
                                        <asp:TextBox class="form-control" ID="pageQty" placeholder="0" runat="server" ReadOnly="True" TextMode="Number"></asp:TextBox>
                                    </div>
                                </div>
                                <br />
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-4">
                                <label>Quantity</label>
                                <div class="form-group center">
                                    <div class="input-group">
                                        <asp:TextBox class="form-control" ID="QtyTxtBx" placeholder="0" runat="server" TextMode="Number" ReadOnly="True"></asp:TextBox>
                                    </div>
                                </div>
                                <br />
                            </div>
                            <div class="col-md-4">
                                <label>Qty Available</label>
                                <div class="form-group center">
                                    <div class="input-group">
                                        <asp:TextBox class="form-control" ID="availableTxtBx" placeholder="0" runat="server" TextMode="Number" ReadOnly="True"></asp:TextBox>
                                    </div>
                                </div>
                                <br />
                            </div>
                            <div class="col-md-4">
                                <label>Qty Checked Out</label>
                                <div class="form-group center">
                                    <div class="input-group">
                                        <asp:TextBox class="form-control" ID="checkedOutTxtBx" placeholder="0" runat="server" TextMode="Number" ReadOnly="True"></asp:TextBox>
                                    </div>
                                </div>
                                <br />
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <label>Book Description</label>
                                <div class="form-group center">
                                    <div class="input-group">
                                        <asp:TextBox class="form-control" ID="addressTxtBx2" placeholder="Description here!" runat="server" ReadOnly="True" TextMode="MultiLine" Rows="3"></asp:TextBox>
                                    </div>
                                </div>
                                <br />
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-4">
                                <asp:Button ID="savePBtn" class="btn btn-success w-100" runat="server" Text="Add" />
                            </div>
                            <div class="col-4">
                                <asp:Button ID="updatePBtn" class="btn btn-warning w-100" runat="server" Text="Update" />
                            </div>
                            <div class="col-4">
                                <asp:Button ID="deletePBtn" class="btn btn-danger w-100" runat="server" Text="Delete" />
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
                                <img width="100" src="img/bunchofBook4.png" />
                            </div>
                        </div>

                        <div class="row">
                            <div class="col center">
                                <h3>Inventory</h3>
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
