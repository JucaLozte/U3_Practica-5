namespace U3_Practica_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            while (a <= 20)
            {
                listBox1.Items.Add(a);
                a++;
            }
        }
    }
}