using System.Diagnostics.CodeAnalysis;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            // Adding Engineering Programs to ComboBox
            comboBox1.Items.Add("Bachelor of Science in Architecture");
            comboBox1.Items.Add("Bachelor of Science in Aeronautical Engineering");
            comboBox1.Items.Add("Bachelor of Science in Civil Engineering");
            comboBox1.Items.Add("Bachelor of Science in Computer Engineering");
            comboBox1.Items.Add("Bachelor of Science in Computer Science");
            comboBox1.Items.Add("Bachelor of Science in Electronics Engineering");
            comboBox1.Items.Add("Bachelor of Science in Electrical Engineering");
            comboBox1.Items.Add("Bachelor of Science in Industrial Engineering");
            comboBox1.Items.Add("Bachelor of Science in Information Technology");
            comboBox1.Items.Add("Bachelor of Library & Information Science");
            comboBox1.Items.Add("Bachelor of Science in Mechanical Engineering");
            comboBox1.Items.Add("Bachelor of Engineering Technology");

            textBox12.Enabled = false; // Credit Units
            textBox13.Enabled = false; // Total Number of Units
            textBox15.Enabled = false; // Total Tuition Fee
            textBox16.Enabled = false; // Total Miscellaneous Fee
            textBox18.Enabled = false; // Total Tuition Fee
            textBox19.Enabled = false; // Total Miscellaneous Fee
            textBox20.Enabled = false; // Total Tuition and Fee
            textBox21.Enabled = false; // Total Number of Units
            textBox22.Enabled = false; // Cisco Laboratory Fee
            textBox23.Enabled = false; // Laboratory Fee
            textBox24.Enabled = false; // Exam Booklet Fee
            textBox25.Enabled = false; // Total Other Fees
            textBox27.Enabled = false; // Total Tuition and Fee

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //code for navigating and uploading image
            OpenFileDialog openFileDialog = new OpenFileDialog();                           // opens file dialog
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";           // filters file type


            if (openFileDialog.ShowDialog() == DialogResult.OK)                             // user course
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);                // image location
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;                     // image sizing
            }
        }


        // Student Name
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Student Name TextBox
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Submit Button
        private void button2_Click(object sender, EventArgs e)
        {

            double lecture, lab, sum;
            lecture = Convert.ToDouble(textBox5.Text);
            lab = Convert.ToDouble(textBox7.Text);

            sum = lecture + lab;
            textBox12.Text = sum.ToString();    //Credit Units

            listBox1.Items.Add(textBox2.Text); // List Box for Student Name
            listBox2.Items.Add(textBox10.Text); // List Box for Course Code
            listBox3.Items.Add(textBox9.Text); // List Box for Course Desc
            listBox4.Items.Add(textBox5.Text); // List Box for Unit Lecture
            listBox5.Items.Add(textBox7.Text); // List Box for Unit Laboratory
            listBox6.Items.Add(textBox12.Text); // List Box for Credit Units
            listBox8.Items.Add(textBox8.Text); // List Box for Time 
            listBox7.Items.Add(textBox11.Text); // List Box for Day 
  




        }

        // # List Box
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Unit Lab List Box
        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Course Code Label
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox26.Clear();
            textBox27.Clear();


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }



         //Calculate Button
        private void button1_Click_1(object sender, EventArgs e)
        {

            double lecture, lab, LabFee, CiscoLab, ExamBook, sum, product;

            lecture = Convert.ToDouble(textBox5.Text);
            lab = Convert.ToDouble(textBox7.Text);
            LabFee = Convert.ToDouble(textBox14.Text);
            CiscoLab = Convert.ToDouble(textBox17.Text);
            ExamBook = Convert.ToDouble(textBox26.Text);


            sum = lecture + lab;
            textBox12.Text = sum.ToString();    //Credit Units
            textBox13.Text = textBox12.Text;    //Total Number of Units

            product = sum * 1500;
            textBox15.Text = product.ToString(); //Total Tuition Fee

            sum = LabFee + CiscoLab + ExamBook;
            textBox16.Text = sum.ToString();    //Total Other Fees
            textBox25.Text = sum.ToString();    //Total Other Fees

            sum = product + LabFee + CiscoLab + ExamBook;
            textBox27.Text = sum.ToString();    //Total Tuition and Fee
            textBox20.Text = sum.ToString();    //Total Tuition and Fee

            textBox18.Text = textBox15.Text; // textBox Total Tuition Fee to Text Box Total Tuition Fee
            textBox19.Text = textBox16.Text; // textBox Total Miscellaneous Fee to Text Box Total Miscellaneous Fee
            textBox21.Text = textBox13.Text; // textBox Total Number of Units to Text Box Total Number of Units
            textBox22.Text = textBox17.Text; // textBox Cisco Lab Fee to Text Box Cisco Laboratory Fee
            textBox23.Text = textBox14.Text; // textBox Laboratory Fee to Text Box Laboratory Fee
            textBox24.Text = textBox26.Text; // textBox Exam Booklet Fee to Text Box Exam Booklet Fee

   

        }
    }
}

