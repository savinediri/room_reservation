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
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        } 
    }
}
