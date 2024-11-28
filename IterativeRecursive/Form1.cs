
namespace IterativeRecursive
{
    public partial class Form1 : Form
    {
        Factorial factorial = new Factorial();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIterative_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(txtNumber.Text, out number) && number >= 0)
            {
                int result = factorial.FactorialIterative(number);
                lblResult.Text = "Factorial Iterativo of " + number + " is " + result;
            }
            else
            {
                lblResult.Text = "Please enter a valid number.";
            }
        }

        private void btnRecursive_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(txtNumber.Text, out number) && number >= 0)
            {
                int result = factorial.FactorialRecursive(number);
                lblResult.Text = "Factorial Recursive of " + number + " is " + result;
            }
            else
            {
                lblResult.Text = "Please enter a valid number.";
            }
        }
    }
    
}
