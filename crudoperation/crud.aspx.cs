using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


namespace crudoperation
{
    public partial class crud : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=LAPTOP-1RTEK74K;database=GIC;integrated security=true;");
            SqlCommand com = new SqlCommand("select * from student", con);
            con.Open();
            SqlDataReader rdr = com.ExecuteReader();
            GridView1.DataSource = rdr;
            GridView1.DataBind();
            con.Close();




            //SqlConnection con = new SqlConnection("data source=LAPTOP-1RTEK74K;database=GIC;integrated security=true;");
            //SqlCommand com = new SqlCommand("update student set studentname='riya',where ID=1,con");
            //con.Open();
            //int i=com.ExecuteNonQuery();
            //GridView1.DataSource = i;
            //GridView1.DataBind();
            //con.Close();
            //Response.Write("record is updated");

            // SqlConnection con = new SqlConnection("data source=LAPTOP-1RTEK74K;database=GIC;integrated security=true;");
            //SqlCommand com = new SqlCommand("delete from student where ID=1",con);
            //con.Open();
            //int i=com.ExecuteNonQuery();
            //GridView1.DataSource = i;
            //GridView1.DataBind();
            //con.Close();
            //Response.Write("record is deleted");


        }

        //protected void Unnamed_Click(object sender, EventArgs e)
        //{
        //    SqlConnection con = new SqlConnection("data source=LAPTOP-1RTEK74K;database=GIC;integrated security=true;");
        //    SqlCommand com = new SqlCommand("insert into student(studentname) values(@name)", con);

        //    con.Open();
        //    //SqlCommand com = new SqlCommand("insert into student(ID,studentname) values(1, 'Ajay')",con);
        //    //com.Parameters.AddWithValue("ID", ID);
        //    com.Parameters.AddWithValue("@name", Nametxt.Text);


        //    int i = com.ExecuteNonQuery();
        //    //GridView1.DataSource = i;
        //    //GridView1.DataBind();
        //    con.Close();
        //    Response.Write("record is inserted");


        

        protected void Unnamed_Click1(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("data source=LAPTOP-1RTEK74K;database=GIC;integrated security=true;");
            SqlCommand com = new SqlCommand("update student set studentname=@name where ID=@ID", con);

            con.Open();
            //SqlCommand com = new SqlCommand("insert into student(ID,studentname) values(1, 'Ajay')",con);
            //com.Parameters.AddWithValue("ID", ID);
            com.Parameters.AddWithValue("@ID", IDtxt.Text);
            com.Parameters.AddWithValue("@name", Nametxt.Text);


            int i = com.ExecuteNonQuery();
            //GridView1.DataSource = i;
            //GridView1.DataBind();
            con.Close();
            Response.Write("record is updated");


        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=LAPTOP-1RTEK74K;database=GIC;integrated security=true;");
            SqlCommand com = new SqlCommand("delete student where ID=@ID", con);

            con.Open();
            //SqlCommand com = new SqlCommand("insert into student(ID,studentname) values(1, 'Ajay')",con);
            //com.Parameters.AddWithValue("ID", ID);
            com.Parameters.AddWithValue("@ID", IDtxt.Text);
           // com.Parameters.AddWithValue("@name", Nametxt.Text);


            int i = com.ExecuteNonQuery();
            //GridView1.DataSource = i;
            //GridView1.DataBind();
            con.Close();
            Response.Write("record is deleted");


        }
    }
}