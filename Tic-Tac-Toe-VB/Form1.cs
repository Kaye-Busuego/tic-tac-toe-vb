namespace Tic_Tac_Toe_VB
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        bool turnq = true;// true = X turn; false = Y turn
        int turn_count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turnq)
                b.Text = "X";
            else
                b.Text = "O";

            turnq = !turnq;
            b.Enabled = false;
        }
    }
}