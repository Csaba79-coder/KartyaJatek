namespace KartyaJatek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOsztas_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_jatekosok.Controls.Clear();

            Kartya kartyak = new Kartya(); 

            int jatekosok = int.Parse(numericUpDownJatekosok.Value.ToString());
            int lapok = int.Parse(numericUpDownLapok.Value.ToString());

            if (jatekosok * lapok > kartyak.MAX_KARTYA)
            {
                MessageBox.Show("Hiba! Ennyi kartyat nem lehet kiosztani!", "Kartya feladat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 1; i < jatekosok + 1; i++)
            {
                UserControl_Jatekos uc_jatekos = new UserControl_Jatekos(kartyak.Osztas(lapok), i);

                flowLayoutPanel_jatekosok.Controls.Add(uc_jatekos);
            }
        }
    }
}