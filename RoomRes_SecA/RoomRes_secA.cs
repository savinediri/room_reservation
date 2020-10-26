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
    
    public partial class RoomRes_secA : Form
    {
        public RoomRes_secA()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B5JHROD\SQLEXPRESS;Initial Catalog=hotelMan;Integrated Security=True");
        SqlDataAdapter sqlda = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();


        
        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btna01_Click(object sender, EventArgs e)
        {
            room_A01 rma01= new room_A01();
            this.Hide();
            rma01.Show();
        }

        private void RoomRes_secA_Load(object sender, EventArgs e)
        {
            //A01-THIS IS FOR ROOM A01
            try
            {
                string roomida01;
                roomida01 = textBox1.Text;

                string checkA01 = "SELECT * FROM Cusdetails WHERE RoomNO='" + roomida01 + "'";
                con.Open();
                sqlda = new SqlDataAdapter(checkA01, con);
                con.Close();
                DataTable DTA01 = new DataTable();
                sqlda.Fill(DTA01);

                if(
                    DTA01.Rows.Count>0
                    ) { btna01.BackColor = Color.Red;
                    label4.Visible = true;
                    
                }
                else
                {
                    btna01.BackColor = Color.ForestGreen;
                    label4.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading..." + Environment.NewLine + Environment.NewLine + ex);
            }
            // A01-END OF ROOM A01

            //A02-THIS IS FOR ROOM A02
            try
            {
                string roomida02;
                roomida02 = textBox2.Text;

                string checkA02 = "SELECT * FROM Cusdetails WHERE RoomNO='" + roomida02 + "'";
                con.Open();
                sqlda = new SqlDataAdapter(checkA02, con);
                con.Close();
                DataTable DTA02 = new DataTable();
                sqlda.Fill(DTA02);

                if (
                    DTA02.Rows.Count > 0
                    )
                {
                    button3.BackColor = Color.Red;
                    label6.Visible = true;
                    button3.Enabled = false;
                }
                else
                {
                    button3.BackColor = Color.ForestGreen;
                    label6.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading..." + Environment.NewLine + Environment.NewLine + ex);
            }
            // A02-END OF ROOM A02
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        } 
    }
}
