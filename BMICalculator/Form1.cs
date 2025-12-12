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
            MessageBox.Show("โปรแกรมคำนวนค่าดัชนีมวลกาย - BMI");
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
                ResultDetailBMI.Text = "น้ำหนักน้อยกว่าปกติก็ไม่ค่อยดี หากคุณสูงมากแต่น้ำหนักน้อยเกินไป อาจเสี่ยงต่อการได้รับสารอาหารไม่เพียงพอหรือได้รับพลังงานไม่เพียงพอ ส่งผลให้ร่างกายอ่อนเพลียง่าย การรับประทานอาหารให้เพียงพอ และการออกกำลังกายเพื่อเสริมสร้างกล้ามเนื้อสามารถช่วยเพิ่มค่า BMI ให้อยู่ในเกณฑ์ปกติได้"
            }
            else if (bmi > 18.5 && bmi < 25)
            {
                ResultTextBMI.Text = "น้ำหนักปกติ เหมาะสม";
                ResultDetailBMI.Text = "น้ำหนักที่เหมาะสมสำหรับคนไทยคือค่า BMI ระหว่าง 18.5-24 จัดอยู่ในเกณฑ์ปกติ ห่างไกลโรคที่เกิดจากความอ้วน และมีความเสี่ยงต่อการเกิดโรคต่าง ๆ น้อยที่สุด ควรพยายามรักษาระดับค่า BMI ให้อยู่ในระดับนี้ให้นานที่สุด และควรตรวจสุขภาพทุกปี"
            }
            else if (bmi > 25 && bmi < 30)
            {
                ResultTextBMI.Text = "อ้วน";
                ResultDetailBMI.Text = "อ้วนในระดับหนึ่ง ถึงแม้จะไม่ถึงเกณฑ์ที่ถือว่าอ้วนมาก ๆ แต่ก็ยังมีความเสี่ยงต่อการเกิดโรคที่มากับความอ้วนได้เช่นกัน ทั้งโรคเบาหวาน และความดันโลหิตสูง ควรปรับพฤติกรรมการทานอาหาร ออกกำลังกาย และตรวจสุขภาพ"
            }
            else
            {
                ResultTextBMI.Text = "อ้วนมาก";
                ResultDetailBMI.Text = "ค่อนข้างอันตราย เสี่ยงต่อการเกิดโรคร้ายแรงที่แฝงมากับความอ้วน หากค่า BMI อยู่ในระดับนี้ จะต้องปรับพฤติกรรมการทานอาหาร และควรเริ่มออกกำลังกาย และหากเลขยิ่งสูงกว่า 40.0 ยิ่งแสดงถึงความอ้วนที่มากขึ้น ควรไปตรวจสุขภาพ และปรึกษาแพทย์"
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
