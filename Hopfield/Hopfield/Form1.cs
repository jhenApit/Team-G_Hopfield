using Hopfield.Classes;
using System.Diagnostics;

namespace Hopfield
{
    public partial class Form1 : Form
    {
        public Network network;
        int[] pattern = new int[9];

        public Form1()
        {
            InitializeComponent();

            network = new Network(new int[] { 0, 0, 2, -2, -2, -2, 2, 0, 2 },
                                  new int[] { 0, 0, 0, 0, 0, 0, 0, 2, 0 },
                                  new int[] { 2, 0, 0, -2, -2, -2, 2, 0, 2 },
                                  new int[] { 2, 0, -2, 0, 2, 2, -2, 0, -2 },
                                  new int[] { 2, 0, -2, 2, 0, 2, -2, 0, -2 },
                                  new int[] { 2, 0, -2, 2, 2, 0, -2, 0, -2 },
                                  new int[] { 2, 0, 2, -2, -2, -2, 0, 0, 2 },
                                  new int[] { 0, 2, 0, 0, 0, 0, 0, 0, 0 },
                                  new int[] { 2, 0, 2, -2, -2, -2, 2, 0, 0 }
                                  );

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            pattern[0] = I00.BackColor == Color.Maroon ? 1 : -1;
            pattern[1] = I01.BackColor == Color.Maroon ? 1 : -1;
            pattern[2] = I02.BackColor == Color.Maroon ? 1 : -1;
            pattern[3] = I03.BackColor == Color.Maroon ? 1 : -1;
            pattern[4] = I04.BackColor == Color.Maroon ? 1 : -1;
            pattern[5] = I05.BackColor == Color.Maroon ? 1 : -1;
            pattern[6] = I06.BackColor == Color.Maroon ? 1 : -1;
            pattern[7] = I07.BackColor == Color.Maroon ? 1 : -1;
            pattern[8] = I08.BackColor == Color.Maroon ? 1 : -1;

            //print pattern
            string str = "";
            for (int i = 0; i < 9; i++)
            {
                str += pattern[i].ToString() + " ";
            }
            
            ni.Text = str;

            //print network.Activation(pattern)
            str = "";

            network.Activation(pattern);

            for (int i = 0; i < 9; i++)
            {
                str += network.output[i].ToString() + " ";
            }
            
            o.Text = str;

            str = "";

            for (int i = 0; i < 9; i++)
            {
                str += network.threshold[i].ToString() + " ";
            }
            t.Text = str;



            Control[] controls = new Control[] { O00, O01, O02, O03, O04, O05, O06, O07, O08 };
            for (int i = 0; i < controls.Length; i++)
            {
                controls[i].BackColor = (network.threshold[i] == 1) ? Color.Maroon : Color.WhiteSmoke;
            }

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            I00.BackColor = SystemColors.Control;
            I01.BackColor = SystemColors.Control;
            I02.BackColor = SystemColors.Control;
            I03.BackColor = SystemColors.Control;
            I04.BackColor = SystemColors.Control;
            I05.BackColor = SystemColors.Control;
            I06.BackColor = SystemColors.Control;
            I07.BackColor = SystemColors.Control;
            I08.BackColor = SystemColors.Control;
            
            O00.BackColor = SystemColors.Control;
            O01.BackColor = SystemColors.Control;
            O02.BackColor = SystemColors.Control;
            O03.BackColor = SystemColors.Control;
            O04.BackColor = SystemColors.Control;
            O05.BackColor = SystemColors.Control;
            O06.BackColor = SystemColors.Control;
            O07.BackColor = SystemColors.Control;
            O08.BackColor = SystemColors.Control;

            ni.ResetText();
            o.ResetText();
            t.ResetText();
        }

        private void I00_Click(object sender, EventArgs e)
        {
            I00.BackColor = (I00.BackColor == Color.WhiteSmoke) ? Color.Maroon : Color.WhiteSmoke;
        }

        private void I01_Click(object sender, EventArgs e)
        {
            I01.BackColor = (I01.BackColor == Color.WhiteSmoke) ? Color.Maroon : Color.WhiteSmoke;
        }

        private void I02_Click(object sender, EventArgs e)
        {
            I02.BackColor = (I02.BackColor == Color.WhiteSmoke) ? Color.Maroon : Color.WhiteSmoke;
        }

        private void I03_Click(object sender, EventArgs e)
        {
            I03.BackColor = (I03.BackColor == Color.WhiteSmoke) ? Color.Maroon : Color.WhiteSmoke;
        }

        private void I04_Click(object sender, EventArgs e)
        {
            I04.BackColor = (I04.BackColor == Color.WhiteSmoke) ? Color.Maroon : Color.WhiteSmoke;
        }

        private void I05_Click(object sender, EventArgs e)
        {
            I05.BackColor = (I05.BackColor == Color.WhiteSmoke) ? Color.Maroon : Color.WhiteSmoke;
        }

        private void I06_Click(object sender, EventArgs e)
        {
            I06.BackColor = (I06.BackColor == Color.WhiteSmoke) ? Color.Maroon : Color.WhiteSmoke;
        }

        private void I07_Click(object sender, EventArgs e)
        {
            I07.BackColor = (I07.BackColor == Color.WhiteSmoke) ? Color.Maroon : Color.WhiteSmoke;
        }

        private void I08_Click(object sender, EventArgs e)
        {
            I08.BackColor = (I08.BackColor == Color.WhiteSmoke) ? Color.Maroon : Color.WhiteSmoke;
        }

        private void t_Click(object sender, EventArgs e)
        {

        }
    }
}