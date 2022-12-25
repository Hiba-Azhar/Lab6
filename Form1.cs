namespace SplashScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 form2 = new Form2();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.progressBar1.Minimum = 1;
            this.progressBar1.Maximum = 100;
            this.progressBar1.Value = 1;
            for (int i = 1; i < 100; i++)

            {
                this.progressBar1.Value++;
            }


            if (progressBar1.Value == 100)
            {
                form2.Show();
                this.Hide();
                
            }
        }
    }
}