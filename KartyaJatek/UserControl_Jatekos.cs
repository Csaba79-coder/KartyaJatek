using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KartyaJatek
{
    public partial class UserControl_Jatekos : UserControl
    {
        List<string> lapok;
        int jatekos;

        public UserControl_Jatekos(List<string> in_lapok, int in_jatekos)
        {
            InitializeComponent();

            lapok = in_lapok;
            jatekos = in_jatekos;
        }

        private void UserControl_Jatekos_Load(object sender, EventArgs e)
        {
            label_username.Text = "Jatekos " + jatekos;

            foreach (var lap in lapok)
            {
                richTextBox_lapok.Text += lap + "\n";
            }
            richTextBox_lapok.SelectAll();
            richTextBox_lapok.SelectionAlignment = HorizontalAlignment.Center;            
        }
    }
}
