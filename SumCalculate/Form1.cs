namespace SumCalculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private bool IsInputValid(int input)
        {
            return input.GetType() == typeof(int);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(inputA.Text, out int a) && int.TryParse(inputB.Text, out int b))
            {
                //Calculate Sum
                int result = CalculateSum(a, b);

                //Display result
                lblResult.Text = $"Sum of {a} and {b} = {result}";
            }
            else
            {
                // Handle invalid input
                MessageBox.Show("Valid integers please", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int CalculateSum(int a, int b)
        {
            // Calculate the sum of a and b
            return a + b;
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void ModCalc_Click(object sender, EventArgs e)
        {
            if (int.TryParse(inputA.Text, out int a) && int.TryParse(inputB.Text, out int b))
            {
                //Calculate Modulo
                int result = CalculateMod(a, b);

                //Display result
                lblResult.Text = $"Modulo of {a} and {b} = {result}";
            }
            else
            {
                // Handle invalid input
                MessageBox.Show("Valid integers please", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int CalculateMod(int a, int b)
        {
            // Calculate the sum of a and b
            return a % b;
        }
    }
}
