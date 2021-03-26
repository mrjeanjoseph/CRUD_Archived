﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bookstore.Web
{
    public partial class Userprofile : System.Web.UI.Page
    {
        readonly string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["FullName"].ToString() == "" || Session["FullName"] == null)
                {
                    Response.Write("<script>alert('Session expired. Please login again');</script>");
                    //Response.Redirect("UserLogin.aspx");
                }
                else
                {
                    GetBooksDetails();
                    if (!Page.IsPostBack)
                    {
                        GetUserDetails();
                    }
                }
            }
            catch (Exception)
            {
                Response.Write("<script>alert('Session expired. Please login again');</script>");
                Response.Redirect("UserLogin.aspx");
            }
        }

        protected void UpdateBtn_Click(object sender, EventArgs e)
        {
            
        }


        //User Defined Function

        private void GetUserDetails()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * FROM UserDetails WHERE FullName = '" + Session["FullName"].ToString() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                fullNameTxtBx.Text = dt.Rows[0]["FullName"].ToString().Trim();
                birthDateTxtBx.Text = dt.Rows[0]["BirthDate"].ToString().Trim();
                phoneNumberTxtBx.Text = dt.Rows[0]["ContactNumber"].ToString().Trim();
                emailTxtBx.Text = dt.Rows[0]["Email"].ToString().Trim();
                addressTxtBx1.Text = dt.Rows[0]["StreetAddress1"].ToString().Trim();
                addressTxtBx2.Text = dt.Rows[0]["StreetAddress2"].ToString().Trim();
                stateDDL.SelectedValue = dt.Rows[0]["State"].ToString().Trim();
                cityTxtBx.Text = dt.Rows[0]["City"].ToString().Trim();
                zipcodeTxtBx.Text = dt.Rows[0]["ZipCode"].ToString().Trim();

                userNameTxtBx.Text = dt.Rows[0]["Username"].ToString().Trim();
                passwordTxtBx.Text = dt.Rows[0]["Password"].ToString().Trim();
                confirmPassTxtBx.Text = dt.Rows[0]["ConfirmPass"].ToString().Trim();

                accountStatusLbl.Text = dt.Rows[0]["AccountStatus"].ToString().Trim();

                if (dt.Rows[0]["AccountStatus"].ToString().Trim() == "Active")
                {
                    accountStatusLbl.Attributes.Add("class", "badge badge-bill badge-success");
                }
                else if (dt.Rows[0]["AccountStatus"].ToString().Trim() == "Pending")
                {
                    accountStatusLbl.Attributes.Add("class", "badge badge-bill badge-warning");
                }
                else if (dt.Rows[0]["AccountStatus"].ToString().Trim() == "Inactive")
                {
                    accountStatusLbl.Attributes.Add("class", "badge badge-bill badge-danger");
                }
                else
                {
                    accountStatusLbl.Attributes.Add("class", "badge badge-bill badge-danger");
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Getting user date Error!');</script>");
                //Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        private void GetBooksDetails()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * FROM BookStatus WHERE MemberName = '" + Session["FullName"].ToString() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                UserDetailsGV.DataSource = dt;
                UserDetailsGV.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Getting user date Error!');</script>");
                //Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        private void UserDetailsGV_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            // MORE BUGS HERE - DO NOT WRITE BUGS, WRITE CUB
            try
            {
                if (e.Row.RowType == DataControlRowType.DataRow)
                {
                    DateTime dt = Convert.ToDateTime(e.Row.Cells[5].Text);
                    DateTime today = DateTime.Today;
                    if (today > dt)
                    {
                        e.Row.BackColor = Color.Red;
                    }
                }
            }
            catch (Exception ex)
            {
                //Response.Write("<script>alert('Error from the UserDetailsGV_RowDataBound');</script>");
                //Response.Write("<script>alert('" + ex.Message + "');</script>");
                //Response.Redirect("UserLogin.aspx");
            }
        }        
    }
}