﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bookstore.Web
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.AppendHeader("Refresh", "10");
            try
            {
                if (Session["ROLE"].Equals("user"))
                {
                    logoutLBtn.Visible = true;
                    helloUserLBtn.Visible = true;
                    helloUserLBtn.Text = $"Hello { Session["FullName"] }";
                    viewBooksLBtn.Visible = true;

                    //userSignUpLBtn.Visible = false;
                    //userLoginLBtn.Visible = false;

                    //adminLoginLBtn.Visible = false;
                    //authorDetailsLBtn.Visible = false;
                    //publisherDetailsLBtn.Visible = false;
                    //inventoryDetailsLBtn.Visible = false;
                    //bookDetailsLBtn.Visible = false;
                    //userDetailsLBtn.Visible = false;
                }

                else if (Session["ROLE"].Equals("admin"))
                {
                    logoutLBtn.Visible = true;
                    helloUserLBtn.Visible = true;
                    helloUserLBtn.Text = $"Hello Admin"; // add a time stamp here!
                    viewBooksLBtn.Visible = true;


                    //userSignUpLBtn.Visible = false;
                    //userLoginLBtn.Visible = false;
                    //adminLoginLBtn.Visible = false;

                    authorDetailsLBtn.Visible = true;
                    publisherDetailsLBtn.Visible = true;
                    inventoryDetailsLBtn.Visible = true;
                    bookDetailsLBtn.Visible = true;
                    userDetailsLBtn.Visible = true;
                }

                else if (Session["ROLE"].Equals(""))
                {
                    userSignUpLBtn.Visible = true;
                    userLoginLBtn.Visible = true;
                    adminLoginLBtn.Visible = true;
                    viewBooksLBtn.Visible = true;

                    //logoutLBtn.Visible = false;
                    //helloUserLBtn.Visible = false;
                    //authorDetailsLBtn.Visible = false;
                    //publisherDetailsLBtn.Visible = false;
                    //inventoryDetailsLBtn.Visible = false;
                    //bookDetailsLBtn.Visible = false;
                    //userDetailsLBtn.Visible = false;
                }
            }
            catch (Exception ex)
            {
                //Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        protected void AdminLoginLBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminLogin.aspx");
        }

        protected void AuthorDetailsLBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminAuthorDetails.aspx");
        }

        protected void PublisherDetailsLBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminPublisherDetails.aspx");
        }

        protected void InventoryDetailsLBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("InventoryDetails.aspx");
        }

        protected void BookDetailsLBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminBookStatus.aspx");
        }

        protected void UserDetailsLBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminUserDetails.aspx");
        }

        protected void ViewBooksLBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewBooks.aspx");
        }

        protected void UserLoginLBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserLogin.aspx");
        }

        protected void UserSignUpLBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserSignup.aspx");
        }

        protected void LogoutLBtn_Click(object sender, EventArgs e)
        {
            Session["Username"] = "";
            Session["FullName"] = "";
            Session["AccountStatus"] = "";
            Session["role"] = "";

            userSignUpLBtn.Visible = true;
            userLoginLBtn.Visible = true;
            adminLoginLBtn.Visible = true;
            viewBooksLBtn.Visible = true;

            Response.Redirect("Homepage.aspx");
        }
    }
}