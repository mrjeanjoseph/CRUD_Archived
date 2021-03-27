﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bookstore.Web
{
    public partial class Site1 : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {            
            try
            {
                if (Session["ROLE"].Equals("user"))
                {
                    logoutLBtn.Visible = true;
                    greetUserLBtn.Visible = true;
                    greetUserLBtn.Text = $"Hello { Session["FullName"] }";
                    viewBooksLBtn.Visible = true;

                    userSignUpLBtn.Visible = false;
                    userLoginLBtn.Visible = false;

                    adminLoginLBtn.Visible = false;
                    authorDetailsLBtn.Visible = false;
                    publisherDetailsLBtn.Visible = false;
                    inventoryDetailsLBtn.Visible = false;
                    bookDetailsLBtn.Visible = false;
                    userDetailsLBtn.Visible = false;
                }

                else if (Session["ROLE"].Equals("admin"))
                {
                    logoutLBtn.Visible = true;
                    greetUserLBtn.Visible = true;
                    greetUserLBtn.Text = $"Hello Admin"; // add a time stamp here!
                    greetUserLBtn.Enabled = false;
                    viewBooksLBtn.Visible = true;


                    userSignUpLBtn.Visible = false;
                    userLoginLBtn.Visible = false;
                    adminLoginLBtn.Visible = false;

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
            //Response.AppendHeader("Refresh", "10");
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

        protected void GreetUserLBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserProfile.aspx");
        }
    }
}