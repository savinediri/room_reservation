using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace RoomRes_SecA
{

    public partial class room_A01 : Form
    {
        //this is variables
        public static string roomida01;
        public room_A01()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B5JHROD\SQLEXPRESS;Initial Catalog=hotelMan;Integrated Security=True");
        SqlDataAdapter sqlda = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();

       
        private void btnup_Click(object sender, EventArgs e)
        {
            try
            {
                
                roomida01 = textBox2.Text;
                string int_que = "INSERT INTO RoomRes VALUES('" + txtcusid.Text + "','" + txtname.Text + "','" + txtnic.Text + "','" + txtconno.Text + "','" + txtadrs.Text + "', '" + "" + "' ,          '" + "" + "','" + dateTimePicker1.Value.ToString() + "')";
               
                cmd = new SqlCommand (int_que, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                string int_que_cus = "INSERT INTO Cusdetails VALUES('" + txtcusid.Text + "','" + roomida01 +   "','" + txtname.Text + "','" + txtnic.Text + "','" + txtconno.Text + "','" + txtadrs.Text + "',          '" + "" + "',          '" + "" + "','" + dateTimePicker1.Value.ToString() + "')";

                cmd = new SqlCommand(int_que_cus, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("ROOM A-01 Reserved Succesfully", "Update Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            { MessageBox.Show("Error Updating Details..." + Environment.NewLine + Environment.NewLine + ex); }
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            txtcusid.Clear();
            txtname.Clear();
            txtnic.Clear();
            txtconno.Clear();
            txtadrs.Clear();
            
            txtcusid.Focus();
        }

		private void button1_Click(object sender, EventArgs e)
        {
            roomida01 = textBox2.Text;
            string del_que = "DELETE  FROM Cusdetails WHERE RoomNo='" + roomida01 + "' ";
             cmd = new SqlCommand(del_que, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("ROOM A-01 Details Deleted Succesfully", "Delete Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            RoomRes_secA frm1 = new RoomRes_secA();
            this.Hide();
            frm1.Show();
        }
    }
}
