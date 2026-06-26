using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane.View
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            //Anasayfa page = new Anasayfa();
            //var sonuc = page.ShowDialog(this);
            //if (sonuc == DialogResult.OK)
            //{
            //    page.Close();
            //}
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
