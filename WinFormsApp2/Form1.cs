namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                var myForm = new Form2();
                myForm.Show();
            }

            if (radioButton2.Checked)
            {
                var myForm = new Form3();
                myForm.Show();
            }
            if (radioButton3.Checked)
            {
                var myForm = new Form4();
                myForm.Show();
            }
        }
    }
}