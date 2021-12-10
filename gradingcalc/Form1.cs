// Mac Armstrong
// Grade Calculator App
// 12/14/21

using System;
using System.Windows.Forms;

/* TODO
* tb for points got and point possible X
* calc total X
* display subject , points got , points possible , total on listbox X
* make data base to store data for subject, points scored, points possible, total X
* apply db to program X
*/

namespace gradingcalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool isRounded = false;


        public void btnCalc_Click(object sender, EventArgs e)
        {
            LBItms.Items.Clear(); // clears list box so that items dont stack after every click 

            // if user did not fill a box, error message will show up 
            if (TBSubj.Text == "" || TBRec.Text == "" || TBPoss.Text == "")
            {
                MessageBox.Show("One or more of the textboxes have not been filled out\nPlease try again", "Invalid Inputs",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // the program will run as intended
            {
                double Rec, Poss, Total; // inputs and total 
                string Subject = TBSubj.Text; // just stores the subject name

                Rec = Convert.ToDouble(TBRec.Text); // converts the user input to a double
                Poss = Convert.ToDouble(TBPoss.Text); // converts the user input to a double

                Total = Rec / Poss; // uses user inputs to calculate total 

                Total = Math.Round(Total * 100, 2); // puts total into % format 

                // if the "round" checkbox is true, round total, if not, do not round 
                if (CBRound.Checked)
                {
                    Total = Math.Round(Total);
                    isRounded = true;
                }

                // writes all inputted values in console
                Console.WriteLine(Subject + "\n"
                    + Rec + "\n"
                    + Poss + "\n"
                    + Total);

                // adds all vlues to list box on screen
                Convert.ToString(Total);
                LBItms.Items.Add("Subject: " + TBSubj.Text);
                LBItms.Items.Add("Score: " + (TBRec.Text + " / " + TBPoss.Text));
                LBItms.Items.Add("Final Total: " + (Total) + "%");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // saves all calculated elements to db 

            // if user did not fill a box, error message will show up 
            if (TBSubj.Text == "" || TBRec.Text == "" || TBPoss.Text == "")
            {
                MessageBox.Show("One or more of the textboxes have not been filled out\nPlease try again", "Invalid Inputs",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else // the program will run as intended
            {
                PersonModel p = new PersonModel();

                p.Subject = TBSubj.Text;
                p.Achieved = Convert.ToDouble(TBRec.Text);
                p.bTotal = Convert.ToDouble(TBPoss.Text);
                { 
                    if (isRounded == false) // saves rounded total based on if rounded or not 
                    { // not rounded
                        p.rTotal = (Convert.ToDouble(TBRec.Text) / Convert.ToDouble(TBPoss.Text)) * 100;
                    }
                    else
                    { // rounded
                        p.rTotal = (Math.Round(Convert.ToDouble(TBRec.Text) / Convert.ToDouble(TBPoss.Text), 2)) * 100;
                    }
                }
                p.isRound = isRounded.ToString();

                SqliteDataAccess.SavePerson(p);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        { // "easter egg" just ingore this 
            MessageBox.Show("Bruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\nBruh\n ", "Bruh",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
