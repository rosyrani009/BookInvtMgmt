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
using System.Data.SqlClient;

namespace LibMgmtSysApi
{
    public partial class Search : System.Web.UI.Page
    {
        //string constr = @"Data Source=.\SQLEXPRESS;AttachDbFilename=F:\nidhi\Mgnt_Brns Project\.Net internshipProjects\CoderTalent Proj\LibMgmtSysApi\LibMgmtSysApi\App_Data\BkInMgmt.mdf;Integrated Security=True;User Instance=True";
        string strsearch ;
        string constr;
        
        protected void srchGrd(string s)
        {
            Label1.Visible = true;
            constr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
            SqlConnection conn = new SqlConnection(constr);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM BooksList WHERE (Title = '" + s + "') OR (Author = '" + s + "') OR (ISBN = '" + s + "')", conn);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            conn.Open();
            da.Fill(dt);
              if (dt.Rows.Count > 0)
            {
                gdvBkLst.DataSource = dt;
                gdvBkLst.DataBind();
            }
            else
            {
                dt.Rows.Add(dt.NewRow());
                gdvBkLst.DataSource = dt;
                gdvBkLst.DataBind();
                int colcount = gdvBkLst.Rows[0].Cells.Count;
                gdvBkLst.Rows[0].Cells.Clear();
                gdvBkLst.Rows[0].Cells.Add(new TableCell());
                gdvBkLst.Rows[0].Cells[0].ColumnSpan = colcount;
                gdvBkLst.Rows[0].Cells[0].Text = "No records found";
            }
            conn.Close();
        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
           
            Label1.Visible = true;
            //string strsearch = txtSearch.Text;
            //this.ShowGrd(strsearch);
            strsearch = txtSearch.Text;
            this.srchGrd(strsearch);
            
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false;
            if (IsPostBack  )
            {
                strsearch = txtSearch.Text;
                this.srchGrd(strsearch);
            }
        }

       

        

        ////protected void gdvBkLst_RowEditing(object sender, GridViewEditEventArgs e)
        ////{
        ////    gdvBkLst.EditIndex = e.NewEditIndex;
        ////    strsearch = txtSearch.Text;
        ////    this.srchGrd(strsearch);

        ////}

        ////protected void gdvBkLst_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        ////{
        ////    gdvBkLst.EditIndex = -1;
        ////    strsearch = txtSearch.Text;
        ////    this.srchGrd(strsearch);
        ////}

        ////protected void gdvBkLst_RowUpdating(object sender, GridViewUpdateEventArgs e)
        ////{
        ////    GridViewRow row = (GridViewRow)gdvBkLst.Rows[e.RowIndex];

        ////    string title = (row.Cells[1].Controls[0] as TextBox).Text;
        ////    string authr = (row.Cells[2].Controls[0] as TextBox).Text;
        ////    int isbn = Convert.ToInt32(gdvBkLst.DataKeys[e.RowIndex].Values["ISBN"]);
        ////    string pblsr = (row.Cells[4].Controls[0] as TextBox).Text;
        ////    string yr = (row.Cells[5].Controls[0] as TextBox).Text;

        ////    constr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
        ////    SqlConnection con = new SqlConnection(constr);
        ////    SqlCommand cmd = new SqlCommand("UPDATE BooksList SET Title=@Title,Author=@Author,Publisher=@Publisher,Year=@Year WHERE ISBN=@ISBN ", con);
        ////    con.Open();
        ////    cmd.Parameters.AddWithValue("@Title", title);
        ////    cmd.Parameters.AddWithValue("@Author", authr);
        ////    cmd.Parameters.AddWithValue("@ISBN", isbn);
        ////    cmd.Parameters.AddWithValue("@Publisher", pblsr);
        ////    cmd.Parameters.AddWithValue("@Year", yr);
        ////    cmd.CommandType = CommandType.Text;
        ////    cmd.ExecuteNonQuery();
        ////    con.Close();
        ////    gdvBkLst.EditIndex = -1;
        ////    strsearch = txtSearch.Text;
        ////    this.srchGrd(strsearch);
        ////}

        ////protected void gdvBkLst_RowDeleting(object sender, GridViewDeleteEventArgs e)
        ////{
        ////    int isbn = Convert.ToInt32(gdvBkLst.DataKeys[e.RowIndex].Values["ISBN"]);

        ////    constr = ConfigurationManager.ConnectionStrings["connstr"].ConnectionString;
        ////    using (SqlConnection con = new SqlConnection(constr))
        ////    {
        ////        using (SqlCommand cmd = new SqlCommand("DELETE FROM BooksList WHERE ISBN=@ISBN "))
        ////        {
        ////            cmd.Parameters.AddWithValue("@ISBN", isbn);
        ////            cmd.Connection = con;
        ////            con.Open();
        ////            cmd.ExecuteNonQuery();
        ////            con.Close();
        ////            strsearch = txtSearch.Text;
        ////            this.srchGrd(strsearch);
        ////        }
        ////    }
        ////}

       
    }
}
