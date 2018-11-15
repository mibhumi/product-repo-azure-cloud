using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        String s = "Server=tcp:productserver.database.windows.net,1433;Initial Catalog=productDB;Persist Security Info=False;User ID=bhumi;Password=Amsterdam@143;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        SqlConnection conn = new SqlConnection(s);

        string pid = id.Text;
        string pname = name.Text;
        string file = image.FileName;

        String query = "INSERT INTO product (pid,pname,pimage) VALUES ('" + pid + "','" + pname + "','"  + file + "')";

        conn.Open();
        SqlCommand cmd = new SqlCommand(query, conn);
        int chk = cmd.ExecuteNonQuery();
        if (chk > 0)
        {
            id.Text = "";
            name.Text = "";

        }
        conn.Close();
    }
}