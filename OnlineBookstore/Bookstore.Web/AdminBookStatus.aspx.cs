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
    public partial class issuedbooks : System.Web.UI.Page
    {
        readonly string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            BookStatusGV.DataBind();
        }

        protected void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchBooksByNameAndId();
        }

        protected void IssuedBtn_Click(object sender, EventArgs e)
        {

        }

        protected void ReturnBtn_Click(object sender, EventArgs e)
        {

        }

        //Custom User Defined Functions
        private void SearchBooksByNameAndId()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT BookName from InventoryDetails where BookId = '" + bookIdTxtBx.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    bookNameTxtBx.Text = dt.Rows[0]["BookName"].ToString();
                }
                else
                {
                    Response.Write("<script>alert('Book Id does not exist');</script>");
                }

                cmd = new SqlCommand("SELECT FullName from UserDetails where Username = '" + memberIdTxtBx.Text.Trim() + "';", con);
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    memberNameTxtBx.Text = dt.Rows[0]["FullName"].ToString();
                }
                else
                {
                    Response.Write("<script>alert('Member Id does not exist');</script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

    }
}