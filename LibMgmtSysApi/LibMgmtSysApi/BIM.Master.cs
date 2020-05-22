using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace LibMgmtSysApi
{
    public partial class BIM : System.Web.UI.MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList ddl=ddlOprtn ;

            //ddl.Items.Insert(0, "Add Book");
            //ddl.Items.Insert(1, "Search Book");
            //ddl.Items.Insert(2, "Edit Book details");
            //ddl.Items.Insert(3, "Delete");
            if (ddl.SelectedValue == "Add book")
            {
                Response.Redirect("~/AddBk.aspx");
            }
            else if (ddl.SelectedValue == "Edit and Delete book details")
            {
                Response.Redirect("~/BkList.aspx");
            }
            else if (ddl.SelectedValue == "Search book")
            {
                Response.Redirect("~/Search.aspx");
            }
            
            else if(ddl.SelectedValue=="Select")
            {
                //Response.Redirect("~/BkList.aspx");
            }
        }

        
    }
}
