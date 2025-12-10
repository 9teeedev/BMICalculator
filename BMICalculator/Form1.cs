namespace BMICalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string? weightText = WeightInput.Text;
            string? heightText = HeightInput.Text;

            double weightDouble = Convert.ToDouble(weightText);
            double heightDouble = Convert.ToDouble(heightText);
            double bmi = CalculateBMI(weightDouble, heightDouble);
            ResultBMI.Text = bmi.ToString("0.00");
            if (bmi < 18.5)
            {
                ResultTextBMI.Text = "ผอมเกินไป";
            }
            else if (bmi > 18.5 && bmi < 25)
            {
                ResultTextBMI.Text = "น้ำหนักปกติ เหมาะสม";
            }
            else if (bmi > 25 && bmi < 30)
            {
                ResultTextBMI.Text = "อ้วน";
            }
            else
            {
                ResultTextBMI.Text = "อ้วนมาก";

            }
        }
        static double CalculateBMI(double weight, double height)
        {
            double heightInMeters = height / 100;
            double bmi = weight / Math.Pow(heightInMeters, 2);
            return bmi;
        }
    }
}
