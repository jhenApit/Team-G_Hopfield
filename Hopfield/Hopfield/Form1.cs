using Hopfield.Classes;

namespace Hopfield
{
    public partial class Form1 : Form
    {
        public Network network;
        
        public Form1()
        {
            InitializeComponent();
            network = new Network(new int[] { 1, 1, 1, -1, -1, -1, 1, 1, 1 },
                                  new int[] { -1, -1, 1, -1, -1, 1, -1, -1, 1 },
                                  new int[] { 1, 1, 1, -1, -1, 1, 1, 1, 1 },
                                  new int[] { 1, 1, 1, -1, -1, 1, 1, 1, 1 },
                                  new int[] { -1, -1, 1, -1, 1, 1, 1, 1, 1 },
                                  new int[] { 1, 1, 1, 1, -1, -1, 1, 1, 1 },
                                  new int[] { 1, 1, 1, 1, -1, -1, 1, 1, 1 },
                                  new int[] { 1, 1, 1, -1, -1, 1, -1, -1, 1 },
                                  new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1 });
        }

        private void I00_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Maroon;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            ni.Text = "diri ang pattern";
        } 
    }
}