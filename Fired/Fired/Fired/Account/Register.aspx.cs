using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Fired.Account
{
    public partial class Register : System.Web.UI.Page
    {
        private void ResetInputData()
        {
            LabelErrorMsg.Text = null;
            TextBoxPassword.Text = null;
            TextBoxConfirmPassword.Text = null;
            TextBoxEmail.Text = null;
            TextBoxTuringCode.Text = null;

        }

        protected void Page_Init(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                ResetInputData();
            }
        }

        protected void CheckBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (!CheckBoxShowPassword.Checked)
            {
                TextBoxPassword.TextMode = TextBoxMode.Password;
                TextBoxConfirmPassword.TextMode = TextBoxMode.Password;
            }
            else
            {
                TextBoxPassword.TextMode = TextBoxMode.SingleLine;
                TextBoxConfirmPassword.TextMode = TextBoxMode.SingleLine;
            }
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {

            #region Adding User to DB"
            string email, password, ipAddress;

            email = TextBoxEmail.Text.Trim();
            password = TextBoxPassword.Text.Trim();
            ipAddress = UserManager.GetUserIP();

            string userCreationResult = UserManager.RegisterUser(email, password, ipAddress);

            LabelErrorMsg.Text = userCreationResult;

            if (userCreationResult == null)
            {
                Response.Redirect("RegisterSuccess.aspx", true);
            }


            #endregion




        }

    }
}