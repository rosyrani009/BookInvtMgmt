using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
    public partial class _Default : System.Web.UI.Page
    {
        string constr;
      
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            constr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
            SqlConnection conn = new SqlConnection(constr);
            //*************************************
            SqlCommand cd = new SqlCommand("SELECT ISBN FROM BooksList WHERE ISBN='" + txtIsbn.Text + "' ", conn);
            conn.Open();
            if (Convert.ToInt32(cd.ExecuteScalar()).Equals (0))
            {
                SqlCommand cmd = new SqlCommand("insert into BooksList values('" + txtTtl.Text + "','" + txtAuthr.Text + "','" + txtIsbn.Text + "','" + txtPublsr.Text + "','" + txtYr.Text + "')", conn);
                cmd.CommandType = CommandType.Text;
              
                int k = cmd.ExecuteNonQuery();
                lblMsg.Visible = true;
                lblMsg.Text = "Record inserted successfully";
            }
            else
            {
                lblMsg.Visible = true;
                lblMsg.Text = "ISBN already exist";
            }
            //********************************************
            ////SqlCommand cmd = new SqlCommand("insert into BooksList values('" + txtTtl.Text + "','" + txtAuthr.Text + "','" + txtIsbn.Text + "','" + txtPublsr.Text + "','" + txtYr.Text + "')", conn);
            ////cmd.CommandType = CommandType.Text;
            ////conn.Open();
            ////int k = cmd.ExecuteNonQuery();
            ////if (k != 0)
            ////{
            ////    lblMsg.Visible = true;
            ////    lblMsg.Text = "Record inserted successfully";
            ////}
            ////else
            ////{
            ////    lblMsg.Visible = true;
            ////    lblMsg.Text = "Record not inserted";
            ////}
            conn.Close();

            txtTtl.Text = "";
            txtTtl.Focus();
            txtAuthr.Text = "";
            txtIsbn.Text = "";
            txtPublsr.Text = "";
            txtYr.Text = "";
            
        }

        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    //Add(sender,e );
        //}
        //protected void Add(object sender, EventArgs e)
        //{
        //    //string country = (((this.Master) as MasterPage).FindControl("ddlOprtn") as DropDownList).SelectedItem.Text;
            
        //}
                
    }
}
