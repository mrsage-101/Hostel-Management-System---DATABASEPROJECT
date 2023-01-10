using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace DBFINALPROJ
{
    public partial class GYMSTUinfo : Form
    {
        public static string SetValueForText3 = "";
        public static string SetValueForText4 = "";
        OracleConnection con;
        public GYMSTUinfo()
        {
            InitializeComponent();
        }

        private void GYMSTUinfo_Load(object sender, EventArgs e)
        {
            string conStr = @"DATA SOURCE = localhost:1521/xe; USER ID=abubakar; PASSWORD=abc";
            con = new OracleConnection(conStr);
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            SetValueForText3 = FormSTUDENT.SetValueForText1;
            SetValueForText4 = FormSTUDENT.SetValueForText2;
            updateGrid();
        }

        private void updateGrid()
        {
            con.Open();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Here i am first identifying the user the user who logged in only his info will 
            // visible to him 
            OracleCommand cmd = new OracleCommand();
            OracleCommand cmd1 = new OracleCommand();
            cmd = new OracleCommand("SELECT BATCH,ROLLNO FROM SDNT_INFO WHERE BATCH=:bax AND ROLLNO=:rn", con);
            cmd.Parameters.Add(new OracleParameter("bax", SetValueForText3));
            cmd.Parameters.Add(new OracleParameter("rn", SetValueForText4));
            cmd1 = new OracleCommand("SELECT DOB,PAYMENT FROM GYMREG WHERE BATCH=:bax AND ROLLNO=:rn", con);
            cmd1.Parameters.Add(new OracleParameter("bax", SetValueForText3));
            cmd1.Parameters.Add(new OracleParameter("rn", SetValueForText4));
            OracleDataReader r = cmd.ExecuteReader();
            OracleDataReader r1 = cmd1.ExecuteReader();
            string[] feilds = new string[3];

            if (r.Read() && r.GetValue(0).ToString() == SetValueForText3 && r.GetValue(1).ToString() == SetValueForText4)
            {
                cmd = new OracleCommand("SELECT SDNT_INFO.NAME, SDNT_INFO.BATCH, SDNT_INFO.ROLLNO, SDNT_INFO.GENDER, SDNT_INFO.CONTACT_NO, GYMREG.DOB, GYMREG.PAYMENT FROM SDNT_INFO INNER JOIN GYMREG ON SDNT_INFO.BATCH = GYMREG.BATCH AND SDNT_INFO.ROLLNO = GYMREG.ROLLNO AND SDNT_INFO.BATCH=:bax AND SDNT_INFO.ROLLNO=:rn", con);
                cmd.Parameters.Add(new OracleParameter("bax", SetValueForText3));
                cmd.Parameters.Add(new OracleParameter("rn", SetValueForText4));
                OracleDataReader empDr1 = cmd.ExecuteReader();

                if (empDr1.Read())
                {
                    textName.Text = empDr1.GetValue(0).ToString();
                    textBATCH.Text = empDr1.GetValue(1).ToString();
                    textROLL.Text = empDr1.GetValue(2).ToString();
                    textGender.Text = empDr1.GetValue(3).ToString();
                    textContact.Text = empDr1.GetValue(4).ToString();
                    DataTable HINFO = new DataTable();
                    HINFO.Load(r1);
                    dataGridView1.DataSource = HINFO;
                }
            }
            con.Close();
        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Hide();
            FormPersonalSTU FPS = new FormPersonalSTU();
            FPS.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
