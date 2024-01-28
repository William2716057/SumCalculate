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

    }
}
