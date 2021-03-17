<%@ Page Title="Book Details" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="InventoryDetails.aspx.cs" Inherits="Bookstore.Web.booksinventory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">

        function readURL(input) {
            if (input.files && input.files[0]) {
                var reader = new FileReader();

                reader.onload = function (e) {
                    $('#imgview').attr('src', e.target.result);
                };
                reader.readAsDataURL(input.files[0]);
            }
        }
    </script>


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
                                <img id="imgview"  height="150" width="100" src="InventoryBooks/book2.png" />
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
                                <asp:FileUpload onchange="readURL(this);" class="form-control" ID="uploadBooks" runat="server" />
                                <br />
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-3">
                                <label>Book Id</label>
                                <div class="form-group center">
                                    <div class="input-group">
                                        <asp:TextBox class="form-control" ID="bookIdTxtBx" placeholder="Book Id" runat="server"></asp:TextBox>
                                        <asp:LinkButton ID="searchBooksLBtn" CssClass="btn btn-primary" runat="server" OnClick="SearchBooksLBtn_Click"><i class="fas fa-search"></i></asp:LinkButton>
                                    </div>
                                </div>
                                <br />
                            </div>
                            <div class="col-md-9">
                                <label>Book Name</label>
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
                                        <asp:ListItem Text="--Select--" Value="--Select--" />
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
                                    <asp:DropDownList class="form-control" ID="publisherNameDDL" runat="server">
                                        <asp:ListItem Text="--Select--" Value="--Select--" Selected="True" />
                                    </asp:DropDownList>
                                </div>
                                <br />
                            </div>

                            <div class="col-md-4">
                                <label>Author Name</label>
                                <div class="form-group center">
                                    <asp:DropDownList class="form-control" ID="authorNameDDL" runat="server">
                                        <asp:ListItem Text="--Select--" Value="--Select--" />
                                    </asp:DropDownList>
                                </div>
                                <br />

                                <label>Publisher Date</label>
                                <div class="form-group center">
                                    <asp:TextBox class="form-control" ID="publishedDateBx" runat="server" TextMode="Date"></asp:TextBox>
                                </div>
                                <br />
                            </div>

                            <div class="col-md-4">
                                <label>Genre</label>
                                <div class="form-group center">
                                    <asp:ListBox ID="genreLBx" class="form-control" runat="server" SelectionMode="Multiple" Rows="4">
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
                                        <asp:TextBox class="form-control" ID="editionTxtBx" placeholder="Edition" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                                <br />
                            </div>
                            <div class="col-md-4">
                                <label>Unit Price</label>
                                <div class="form-group center">
                                    <div class="input-group">
                                        <asp:TextBox class="form-control" ID="priceTxtBx" placeholder="0" runat="server" SelectionMode="Single" TextMode="Number"></asp:TextBox>
                                    </div>
                                </div>
                                <br />
                            </div>
                            <div class="col-md-4">
                                <label>No. of Pages</label>
                                <div class="form-group center">
                                    <div class="input-group">
                                        <asp:TextBox class="form-control" ID="numOfPages" placeholder="0" runat="server" TextMode="Number"></asp:TextBox>
                                    </div>
                                </div>
                                <br />
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-4">
                                <label>Total Quantity</label>
                                <div class="form-group center">
                                    <div class="input-group">
                                        <asp:TextBox class="form-control" ID="QtyTxtBx" placeholder="0" runat="server" TextMode="Number"></asp:TextBox>
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
                                        <asp:TextBox class="form-control" ID="descriptionTxtBx" placeholder="Description here!" runat="server" TextMode="MultiLine" Rows="4"></asp:TextBox>
                                    </div>
                                </div>
                                <br />
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-4">
                                <asp:Button ID="addBooksPBtn" class="btn btn-success w-100" runat="server" Text="Add" OnClick="AddBooksPBtn_Click" />
                            </div>
                            <div class="col-4">
                                <asp:Button ID="updateBooksPBtn" class="btn btn-warning w-100" runat="server" Text="Update" OnClick="UpdateBooksPBtn_Click" />
                            </div>
                            <div class="col-4">
                                <asp:Button ID="deleteBooksPBtn" class="btn btn-danger w-100" runat="server" Text="Delete" OnClick="DeleteBooksPBtn_Click" />
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
                                <img width="100" src="img/bunchofBook2.png" />
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
                                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:eLibraryDBConnectionString %>" SelectCommand="SELECT * FROM [InventoryDetails]"></asp:SqlDataSource>
                                <asp:GridView class="table table-striped table-bordered" ID="inventoryDetailGV" runat="server" AutoGenerateColumns="False" DataKeyNames="BookId" DataSourceID="SqlDataSource1">
                                    <Columns>
                                        <asp:BoundField DataField="BookId" HeaderText="Id" ReadOnly="True" SortExpression="BookId" />
                                        <asp:BoundField DataField="BookName" HeaderText="Book Name" SortExpression="BookName" />
                                        <asp:BoundField DataField="Genre" HeaderText="Genre" SortExpression="Genre" />
                                        <asp:BoundField DataField="AuthorName" HeaderText="Author Name" SortExpression="AuthorName" />
                                        <asp:BoundField DataField="PublisherName" HeaderText="Publisher Name" SortExpression="PublisherName" />
                                        <asp:BoundField DataField="PublishedDate" HeaderText="Published Date" SortExpression="PublishedDate" />
                                        <asp:BoundField DataField="Language" HeaderText="Language" SortExpression="Language" />
                                        <asp:BoundField DataField="Edition" HeaderText="Edition" SortExpression="Edition" />
                                        <asp:BoundField DataField="UnitPrice" HeaderText="Price" SortExpression="UnitPrice" />
                                        <asp:BoundField DataField="NumberOfPages" HeaderText="# of Pages" SortExpression="NumberOfPages" />
                                        <asp:BoundField DataField="BookDescription" HeaderText="Description" SortExpression="BookDescription" />
                                        <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
                                        <asp:BoundField DataField="QtyAvailable" HeaderText="Qty Available" SortExpression="QtyAvailable" />
                                        <asp:BoundField DataField="QtyCheckedOut" HeaderText="Qty Checked out" SortExpression="QtyCheckedOut" />
                                        <asp:BoundField DataField="BookImgLink" HeaderText="Book Img" SortExpression="BookImgLink" />
                                    </Columns>
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
