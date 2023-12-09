namespace sayisalLotoProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int sayi1;
            int sayi2;
            int sayi3;
            int sayi4;
            sayi1 = rnd.Next(1, 6);
            sayi2 = rnd.Next(1, 6);
            sayi3 = rnd.Next(1, 6);
            sayi4 = rnd.Next(1, 6);
            label1.Text = sayi1.ToString();
            label2.Text = sayi2.ToString();
            label3.Text = sayi3.ToString();
            label4.Text = sayi4.ToString();

            if (textBox1.Text == label1.Text)
            {
                textBox1.BackColor = Color.Green;
            }
            else
            {
                textBox1.BackColor = Color.Red;
            }
            if (textBox2.Text == label2.Text)
            {
                textBox2.BackColor = Color.Green;
            }
            else
            {
                textBox2.BackColor = Color.Red;
            }
            if (textBox3.Text == label3.Text)
            {
                textBox3.BackColor = Color.Green;
            }
            else
            {
                textBox3.BackColor = Color.Red;
            }
            if (textBox4.Text == label4.Text)
            {
                textBox4.BackColor = Color.Green;
            }
            else
            {
                textBox4.BackColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] sembol1 = { "a", "b", "c", "d", "e", "f", "g" };
            string[] sembol2 = { "*", "+", "-", "x" };
            int s1,s2,s3;
            Random rnd = new Random();
            s1 = rnd.Next(0, 7);
            s2= rnd.Next(0, 4);
            s3 = rnd.Next(0, 70);
            label5.Text = sembol1[s1].ToString() + sembol2[s2].ToString()+s3.ToString();
        }
    }
}