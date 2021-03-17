using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
            GridView1.DataBind();
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
                AddNewBooks();
            }
        }

        protected void UpdateBooksPBtn_Click(object sender, EventArgs e)
        {

        }

        protected void DeleteBooksPBtn_Click(object sender, EventArgs e)
        {

        }

        //User Defined functions
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
        }

        void AddNewBooks()
        {

        }

        //User Defined functions
        bool CheckBookExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * from InventoryDetail where BookId = '" + bookIdTxtBx.Text.Trim() + "' OR BookName = '" + bookNameTxtBx.Text.Trim() +"';", con);
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
        }


    }
}