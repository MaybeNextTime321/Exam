using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labRybakov
{
    public partial class main : Form
    {
        db DB = new db();
        DataTable authRes = new DataTable();
 
        public main()
        {
            
            InitializeComponent();
        }

        private void passVisible_CheckedChanged(object sender, EventArgs e)
        {
            if (passVisible.Checked == true)
                InputPassword.UseSystemPasswordChar = false;
            if (passVisible.Checked == false)
                InputPassword.UseSystemPasswordChar = true;
        }

        private void sendDate_Click(object sender, EventArgs e)
        {
       
            int wrong = 0;
            try
            {
                MySqlDataAdapter adapterAdmin = new MySqlDataAdapter();
                MySqlCommand logAdmin = new MySqlCommand("select * from admin where login=@login and password =@password", DB.getConnection());
                logAdmin.Parameters.Add("@login", MySqlDbType.String).Value = InputLogin.Text;
                logAdmin.Parameters.Add("@password", MySqlDbType.String).Value = InputPassword.Text;
                adapterAdmin.SelectCommand = logAdmin;
                adapterAdmin.Fill(authRes);

                if (authRes.Rows.Count >= 1)
                {
                    
                    Form adm = new admin();
                    adm.Show();
                    authRes.Clear();
                    this.Hide();

                } //админ
                else {
                   
                }




                MySqlDataAdapter adapterUser = new MySqlDataAdapter();
                MySqlCommand logUser = new MySqlCommand("select * from pacienti where login=@login and password =@password", DB.getConnection());
                logUser.Parameters.Add("@login", MySqlDbType.String).Value = InputLogin.Text;
                logUser.Parameters.Add("@password", MySqlDbType.String).Value = InputPassword.Text;
                adapterUser.SelectCommand = logUser;
                adapterUser.Fill(authRes);

                if (authRes.Rows.Count >= 1)
                {
                    Form usr = new user();
                    usr.Show();
                    authRes.Clear();
                    this.Hide();
                } //юзер
                else {
                   
                }





                MySqlDataAdapter adapterBuhg = new MySqlDataAdapter();
                MySqlCommand logBuhg = new MySqlCommand("select * from buhg where login=@login and password =@password", DB.getConnection());
                logBuhg.Parameters.Add("@login", MySqlDbType.String).Value = InputLogin.Text;
                logBuhg.Parameters.Add("@password", MySqlDbType.String).Value = InputPassword.Text;
                adapterBuhg.SelectCommand = logBuhg;
                adapterBuhg.Fill(authRes);

                if (authRes.Rows.Count >= 1) {
                    Form bhg = new Buhg();
                    bhg.Show();
                    authRes.Clear();
                    this.Hide();
                } //бухгалтер
                else {  }




                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand logLaboranti = new MySqlCommand("select * from laboranti where login=@login and password =@password", DB.getConnection());
                logLaboranti.Parameters.Add("@login", MySqlDbType.String).Value = InputLogin.Text;
                logLaboranti.Parameters.Add("@password", MySqlDbType.String).Value = InputPassword.Text;
                adapter.SelectCommand = logLaboranti;
                adapter.Fill(authRes);

                if (authRes.Rows.Count >= 1) {
                    Form lab = new laborant_1();
                    lab.Show();
                    authRes.Clear();
                    this.Hide();
                } //это лаборант 
                else { }




                








                
            }
            catch
            {

            }
            
          


        }
    }
}
