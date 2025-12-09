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

            // ตรวจสอบว่ากรอกข้อมูลครบหรือไม่
            if (string.IsNullOrWhiteSpace(weightText) || string.IsNullOrWhiteSpace(heightText))
            {
                MessageBox.Show("กรุณากรอกข้อมูลน้ำหนักและส่วนสูงให้ครบถ้วน", "ข้อมูลไม่ครบ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ตรวจสอบว่าเป็นตัวเลขหรือไม่
            if (!double.TryParse(weightText, out double weightDouble) || !double.TryParse(heightText, out double heightDouble))
            {
                MessageBox.Show("กรุณากรอกข้อมูลเป็นตัวเลขเท่านั้น", "ข้อมูลไม่ถูกต้อง", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ตรวจสอบค่าที่เป็นบวก
            if (weightDouble <= 0 || heightDouble <= 0)
            {
                MessageBox.Show("น้ำหนักและส่วนสูงต้องเป็นค่าที่มากกว่าศูนย์", "ข้อมูลไม่ถูกต้อง", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double bmi = CalculateBMI(weightDouble, heightDouble);
            ResultBMI.Text = bmi.ToString("0.00");

            // รีเซ็ตสีปุ่มก่อนกำหนดค่าใหม่
            button1.BackColor = SystemColors.GradientActiveCaption;

            if (bmi < 18.5)
            {
                ResultTextBMI.Text = "ผอมเกินไป";
                ResultDetailBMI.Text = "น้ำหนักน้อยกว่าปกติก็ไม่ค่อยดี หากคุณสูงมากแต่น้ำหนักน้อยเกินไป อาจเสี่ยงต่อการได้รับสารอาหารไม่เพียงพอหรือได้รับพลังงานไม่เพียงพอ ส่งผลให้ร่างกายอ่อนเพลียง่าย การรับประทานอาหารให้เพียงพอ และการออกกำลังกายเพื่อเสริมสร้างกล้ามเนื้อสามารถช่วยเพิ่มค่า BMI ให้อยู่ในเกณฑ์ปกติได้";
                button1.BackColor = Color.Yellow;
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                ResultTextBMI.Text = "น้ำหนักปกติ เหมาะสม";
                ResultDetailBMI.Text = "น้ำหนักที่เหมาะสมสำหรับคนไทยคือค่า BMI ระหว่าง 18.5-24 จัดอยู่ในเกณฑ์ปกติ ห่างไกลโรคที่เกิดจากความอ้วน และมีความเสี่ยงต่อการเกิดโรคต่าง ๆ น้อยที่สุด ควรพยายามรักษาระดับค่า BMI ให้อยู่ในระดับนี้ให้นานที่สุด และควรตรวจสุขภาพทุกปี";
                button1.BackColor = Color.LightGreen;
            }
            else if (bmi >= 25 && bmi < 30)
            {
                ResultTextBMI.Text = "อ้วน";
                ResultDetailBMI.Text = "อ้วนในระดับหนึ่ง ถึงแม้จะไม่ถึงเกณฑ์ที่ถือว่าอ้วนมาก ๆ แต่ก็ยังมีความเสี่ยงต่อการเกิดโรคที่มากับความอ้วนได้เช่นกัน ทั้งโรคเบาหวาน และความดันโลหิตสูง ควรปรับพฤติกรรมการทานอาหาร ออกกำลังกาย และตรวจสุขภาพ";
                button1.BackColor = Color.Yellow;
            }
            else
            {
                ResultTextBMI.Text = "อ้วนมาก";
                ResultDetailBMI.Text = "ค่อนข้างอันตราย เสี่ยงต่อการเกิดโรคร้ายแรงที่แฝงมากับความอ้วน หากค่า BMI อยู่ในระดับนี้ จะต้องปรับพฤติกรรมการทานอาหาร และควรเริ่มออกกำลังกาย และหากเลขยิ่งสูงกว่า 40.0 ยิ่งแสดงถึงความอ้วนที่มากขึ้น ควรไปตรวจสุขภาพ และปรึกษาแพทย์";
                button1.BackColor = Color.Red;
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
