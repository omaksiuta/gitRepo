using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fired.Account
{
    public partial class RemindPassword : System.Web.UI.Page
    {
        private WizardStep _redirectToWStep;

        private void ResetInputData()
        {
            TextBoxEmail.Text = null;
            TextBoxTuringCode.Text = null;
            LabelErrorMsgStep0.Text = null;
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                ResetInputData();
            }

        }

        protected void Page_PreRender(object sender, EventArgs e)
        {



            if (_redirectToWStep != null)
            {
                WizardChangePassword.MoveTo(_redirectToWStep);
            }
        }

        protected void WizardChangePassword_NextButtonClick(object sender, WizardNavigationEventArgs e)
        {

            string result = UserManager.EmailPasswordToUser(TextBoxEmail.Text.Trim());

            if (result == null)
            {
                ResetInputData();
                _redirectToWStep = wStepComplete;
            }
            else
            {
                ResetInputData();

                LabelErrorMsgStep0.Text = result;

                _redirectToWStep = wStepStart;


            }
        }






    }
}