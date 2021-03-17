using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bookstore.Web
{
    public partial class booksinventory : System.Web.UI.Page
    {
        readonly string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            inventoryDetailGV.DataBind();
            FillValues();
        }

        protected void SearchBooksLBtn_Click(object sender, EventArgs e)
        {

        }

        protected void AddBooksPBtn_Click(object sender, EventArgs e)
        {
            if (CheckBookExists())
            {
                Response.Write("<script>alert('This book Id already exist. Please try a different id.');</script>");
            }
            else
            {
                GetNewBooks();
            }
        }

        protected void UpdateBooksPBtn_Click(object sender, EventArgs e)
        {

        }

        protected void DeleteBooksPBtn_Click(object sender, EventArgs e)
        {

        }


        private void FillValues()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT AuthorName FROM AuthorDetails;", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                authorNameDDL.DataSource = dt;
                authorNameDDL.DataValueField = "AuthorName";
                authorNameDDL.DataBind();

                cmd = new SqlCommand("SELECT PublisherName FROM PublisherDetails;", con);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);

                publisherNameDDL.DataSource = dt;
                publisherNameDDL.DataValueField = "PublisherName";
                publisherNameDDL.DataBind();
            }
            catch (Exception ex)
            {

            }
        } //User Defined functions


        void GetNewBooks()
        {
            try
            {
                string genres = "";
                foreach (int item in genreLBx.GetSelectedIndices())
                {
                    genres += genreLBx.Items[item] + "\n"; // inside of the double quotes should be a comma - let's see what happens.
                }
                genres = genres.Remove(genres.Length - 1);


                string filePath = "~/InventoryBooks/book1.png",
                fileName = Path.GetFileName(uploadBooks.PostedFile.FileName);
                uploadBooks.SaveAs(Server.MapPath("inventoryBooks/" + fileName));
                filePath = "~/inventoryBooks/" + fileName;

                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO InventoryDetails (BookId, BookName, Genre, AuthorName, PublisherName, PublishedDate, Language, Edition, UnitPrice, NumberOfPages, BookDescription, Quantity, QtyAvailable, QtyCheckedOut, BookImgLink) values (@BookId, @BookName, @Genre, @AuthorName, @PublisherName, @PublishedDate, @Language, @Edition, @UnitPrice, @NumberOfPages, @BookDescription, @Quantity, @QtyAvailable, @QtyCheckedOut, @BookImgLink)", con);

                cmd.Parameters.AddWithValue("@BookId", bookIdTxtBx.Text.Trim());
                cmd.Parameters.AddWithValue("@BookName", bookNameTxtBx.Text.Trim());
                cmd.Parameters.AddWithValue("@Genre", genres);
                cmd.Parameters.AddWithValue("@AuthorName", authorNameDDL.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@PublisherName", publisherNameDDL.SelectedItem.Value);

                cmd.Parameters.AddWithValue("@PublishedDate", publishedDateBx.Text.Trim());
                cmd.Parameters.AddWithValue("@Language", languageDDL.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@Edition", editionTxtBx.Text.Trim());
                cmd.Parameters.AddWithValue("@UnitPrice", priceTxtBx.Text.Trim());
                cmd.Parameters.AddWithValue("@NumberOfPages", numOfPages.Text.Trim());

                cmd.Parameters.AddWithValue("@BookDescription", descriptionTxtBx.Text.Trim());
                cmd.Parameters.AddWithValue("@Quantity", QtyTxtBx.Text.Trim());
                cmd.Parameters.AddWithValue("@QtyAvailable", QtyTxtBx.Text.Trim());
                cmd.Parameters.AddWithValue("@QtyCheckedOut", "0");
                cmd.Parameters.AddWithValue("@BookImgLink", filePath);

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Book detail added successfully.');</script>");
                inventoryDetailGV.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        } //User Defined functions


        bool CheckBookExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * from InventoryDetails where BookId = '" + bookIdTxtBx.Text.Trim() + "' OR BookName = '" + bookNameTxtBx.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;

                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }
        } //User Defined functions
    }
}