//http://www.asp.net/ajaxlibrary/act_AutoComplete_Simple.ashx
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

namespace Fired.Input
{
    public partial class Salary : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            #region Populate Month list and select Month
            for (int i = 1; i <= 12; i++)
            {
                ddlMonth.Items.Add(new ListItem(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i), i.ToString()));

            }

            int month = System.DateTime.Now.Month;
            ddlMonth.SelectedIndex = ddlMonth.Items.IndexOf(ddlMonth.Items.FindByValue(month.ToString()));
            #endregion


        }


        [System.Web.Services.WebMethodAttribute(), System.Web.Script.Services.ScriptMethodAttribute()]
        public static string[] GetCompletionListForCompany(string prefixText, int count, string contextKey)
        {
            // Create array of movies
            string[] movies = { "Luxoft", "GlobalLogic", "EPAM", "Celenia", "Ciclum" };

            // Return matching movies
            return (from m in movies where m.StartsWith(prefixText, StringComparison.CurrentCultureIgnoreCase) select m).Take(count).ToArray();
        }

        [System.Web.Services.WebMethodAttribute(), System.Web.Script.Services.ScriptMethodAttribute()]
        public static string[] GetCompletionListForPosition(string prefixText, int count, string contextKey)
        {
            // Create array of movies
            string[] movies = { "Developer", "QA", "Tester", "Tester Senior", "Test Engineer" };

            // Return matching movies
            return (from m in movies where m.StartsWith(prefixText, StringComparison.CurrentCultureIgnoreCase) select m).Take(count).ToArray();
        }


    }
}