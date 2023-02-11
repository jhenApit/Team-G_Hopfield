using Hopfield.Classes;

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

        private void I00_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.WhiteSmoke)
            {
                btn.BackColor = Color.Maroon;
            } else
            {
                btn.BackColor = Color.WhiteSmoke;
            }

            btn.Enabled = true;

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            Button I00 = (Button)Controls.Find("I00", true)[0];
            Button I01 = (Button)Controls.Find("I01", true)[0];
            Button I02 = (Button)Controls.Find("I02", true)[0];
            Button I03 = (Button)Controls.Find("I03", true)[0];
            Button I04 = (Button)Controls.Find("I04", true)[0];
            Button I05 = (Button)Controls.Find("I05", true)[0];
            Button I06 = (Button)Controls.Find("I06", true)[0];
            Button I07 = (Button)Controls.Find("I07", true)[0];
            Button I08 = (Button)Controls.Find("I08", true)[0];


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

            //output matrix
            Button O00 = (Button)Controls.Find("O00", true)[0];
            Button O01 = (Button)Controls.Find("O01", true)[0];
            Button O02 = (Button)Controls.Find("O02", true)[0];
            Button O03 = (Button)Controls.Find("O03", true)[0];
            Button O04 = (Button)Controls.Find("O04", true)[0];
            Button O05 = (Button)Controls.Find("O05", true)[0];
            Button O06 = (Button)Controls.Find("O06", true)[0];
            Button O07 = (Button)Controls.Find("O07", true)[0];
            Button O08 = (Button)Controls.Find("O08", true)[0];


            O00.BackColor = (network.threshold[0] == 1) ? Color.Maroon : Color.WhiteSmoke;
            O01.BackColor = (network.threshold[1] == 1) ? Color.Maroon : Color.WhiteSmoke;
            O02.BackColor = (network.threshold[2] == 1) ? Color.Maroon : Color.WhiteSmoke;
            O03.BackColor = (network.threshold[3] == 1) ? Color.Maroon : Color.WhiteSmoke;
            O04.BackColor = (network.threshold[4] == 1) ? Color.Maroon : Color.WhiteSmoke;
            O05.BackColor = (network.threshold[5] == 1) ? Color.Maroon : Color.WhiteSmoke;
            O06.BackColor = (network.threshold[6] == 1) ? Color.Maroon : Color.WhiteSmoke;
            O07.BackColor = (network.threshold[7] == 1) ? Color.Maroon : Color.WhiteSmoke;
            O08.BackColor = (network.threshold[8] == 1) ? Color.Maroon : Color.WhiteSmoke;
        }

        private void Clear_Click(object sender, EventArgs e)
        {

        }

        private void t_Click(object sender, EventArgs e)
        {

        }
    }
}