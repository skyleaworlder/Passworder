namespace Passworder
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            InitializeData();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewKVForm newKVForm = new NewKVForm();
            newKVForm.ShowDialog();
        }
    }
}