using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialManagementApplication
{
    public partial class FinancialPredictionView : Form
    {
        public FinancialPredictionView()
        {
            InitializeComponent();
        }

        private void prediction_Click(object sender, EventArgs e)
        {
            DateTime fDate = futureDate.Value;
            Controllers.PredictFinanceController pf = new Controllers.PredictFinanceController();
            List<decimal> prediction = pf.predictStatus(fDate);

            if (prediction != null) {
                recurrentIncomeAmount.Text = "Rs." + prediction[0].ToString();
                oneOfIncomeAmount.Text = "Rs." + prediction[1].ToString();
                recurrentExpenseAmount.Text = "Rs." + prediction[2].ToString();
                oneOfExpenseAmount.Text = "Rs." + prediction[3].ToString();
                avgIncomeAmount.Text = "Rs." + prediction[4].ToString();
                avgExpenseAmount.Text = "Rs." + prediction[5].ToString();
                statusAmount.Text = "Rs." + prediction[6].ToString();
                if (prediction[6] < 0)
                {
                    statusSummery.ForeColor = Color.Red;
                    statusSummery.Text = "Your predicted future status is not good. " +
                        "You will be ended up with depts in future.";
                }
                else
                {
                    statusSummery.ForeColor = Color.Blue;
                    statusSummery.Text = "Your predicted future status is good. ";
                }
            }
            else
            {
                if (MessageBox.Show("The status prediction operation couldn't be completed, Please try again", "Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK) { }
            }
        }

        private void backToMenu_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            Hide();
            mainMenu.ShowDialog();
        }
    }
}
