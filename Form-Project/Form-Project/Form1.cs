namespace Form_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Click happened");
            button1.BackColor = Color.LightPink;
            new Form1().ShowDialog();
        }
    }
}
