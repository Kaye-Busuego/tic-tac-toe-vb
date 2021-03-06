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
            
            turn_count++;

            checkForWinner();
        }
        private void checkForWinner()
        {

            bool there_is_a_winner = false;

            //horizontal checks
            if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                there_is_a_winner = true;
            else if ((B4.Text == B5.Text) && (B5.Text == B6.Text) && (!B4.Enabled))
                there_is_a_winner = true;
            else if ((B7.Text == B8.Text) && (B8.Text == B9.Text) && (!B7.Enabled))
                there_is_a_winner = true;

            //vertical checks
            else if ((B1.Text == B4.Text) && (B4.Text == B7.Text) && (!B1.Enabled))
                there_is_a_winner = true;
            else if ((B2.Text == B5.Text) && (B5.Text == B8.Text) && (!B2.Enabled))
                there_is_a_winner = true;
            else if ((B3.Text == B6.Text) && (B6.Text == B9.Text) && (!B3.Enabled))
                there_is_a_winner = true;

            //diagonal checks
            else if ((B1.Text == B5.Text) && (B5.Text == B9.Text) && (!B1.Enabled))
                there_is_a_winner = true;
            else if ((B3.Text == B5.Text) && (B5.Text == B7.Text) && (!B7.Enabled))
                there_is_a_winner = true;
            



            if (there_is_a_winner)
            {
                disableButtons();

                String winner = "";
                if (turnq)
                    winner = "O";
                else
                    winner = "X";

                MessageBox.Show(winner + " Won!");
            }//end if

            else
            {
                if (turn_count == 9)
                    MessageBox.Show("Draw");
            }

        }//end checkForWinner

        private void disableButtons()
        {
            try
            {


                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }// end foreach
            }//end try
            catch { }
        }
        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turnq = true;
            turn_count = 0;

            try
            {


                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }// end foreach
            }//end try
            catch { }
        }
    }
}