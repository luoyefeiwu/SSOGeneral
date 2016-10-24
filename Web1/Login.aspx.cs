﻿using SSO.Helper;
using System;

namespace Web1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SSOCrossDomain cross = new SSOCrossDomain(this);
                cross.ValidationLogIn("CookieWeb1", new TimeSpan(0, 2, 0));
                //Response.End();
                //SSOSameDomain same = new SSOSameDomain(this);
                //same.LogIn("CookiesWeb1", new TimeSpan(0, 1, 0),"Chenxy");
            }
        }
    }
}