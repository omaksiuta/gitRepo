using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;

namespace Fired.Account
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void subMemberLogin(object sender, EventArgs e)
        {

        }

        protected void ButtonRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx", true);
        }

        protected void LinkButtonForgotPassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("RemindPassword.aspx", true);
        }
    }
}