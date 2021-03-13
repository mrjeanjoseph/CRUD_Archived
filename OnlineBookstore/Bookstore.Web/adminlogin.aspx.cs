﻿using System;
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
    public partial class adminlogin : System.Web.UI.Page
    {
        readonly string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AdminLoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * FROM AdminDetails WHERE Username = '" + adminIdTxtBx.Text.Trim() + "' AND Password = '" + passwordTxtBx.Text.Trim() + "'", con);
                SqlDataReader readDB = cmd.ExecuteReader();
                if (readDB.HasRows)
                {
                    while (readDB.Read())
                    {
                        //Response.Write("<script>alert('Hello " + readDB.GetValue(2).ToString() + ", Welcome!');</script>");
                        Session["Username"] = readDB.GetValue(0).ToString();
                        Session["FullName"] = readDB.GetValue(2).ToString();
                        Session["Role"] = "Admin";
                    }
                    Response.Redirect("Homepage.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Username and password entered is invalid');</script>");
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error 405! Please try again later');</script>");
            }

        }
    }
}