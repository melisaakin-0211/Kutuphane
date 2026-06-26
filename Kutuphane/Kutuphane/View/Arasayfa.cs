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
    public partial class Arasayfa : Form
    {
        public Arasayfa()
        {
            InitializeComponent();
            this.Visible = false;
        }

        private void Arasayfa_Load(object sender, EventArgs e)
        {
            LoginPage page = new LoginPage();
            Anasayfa page1 = new Anasayfa();

            page1.Show();
            

            page.ShowDialog(page1);
           this.Visible = false;
        }
    }
}
