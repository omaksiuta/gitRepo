using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Xml;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Catalog : System.Web.UI.Page
{
    private void BindCheckBoxListFromXmlDataSource(CheckBoxList checkboxlist, string xmlfilepath, string DataMember)
    {
        DataSet ds = new DataSet();

        try
        {

            ds.ReadXml(xmlfilepath);
            checkboxlist.DataSource = ds;

            //checkboxlist.DataMember = "dev";
            checkboxlist.DataMember = DataMember;
            checkboxlist.DataTextField = "name";
            checkboxlist.DataValueField = "id";

            checkboxlist.DataBind();




        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (this.IsPostBack == false)
        {
            string xmlfilepath;

            xmlfilepath = Server.MapPath("~//Data//Compomemts.xml");
            BindCheckBoxListFromXmlDataSource(CheckBoxList_Components, xmlfilepath, "comp");

            xmlfilepath = Server.MapPath("~//Data//Developers.xml");
            BindCheckBoxListFromXmlDataSource(CheckBoxList_Developer, xmlfilepath, "dev");



            //foreach (ListItem lstItem in CheckBoxList_Developer.Items)
            //{
            //    if (lstItem.Selected == true)
            //    {
            //        // Add text to label.

            //    }
            //}


        }


    }

    protected void CheckBoxList_Developer_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}