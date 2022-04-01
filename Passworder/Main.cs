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
            newKVForm.ShowDialog(this);
        }

        private void modifyPasswordBtn_Click(object sender, EventArgs e)
        {
            PasswordColumnData data = (PasswordColumnData) this.passwordDataGridView.CurrentRow.DataBoundItem;
            if (data == null)
            {
                MessageBox.Show("Unknown error: selected row of DataGridView is null.");
                return;
            }
            ModKVForm modKVForm = new ModKVForm(data.Title, data.PasswordHint);
            modKVForm.ShowDialog(this);
        }

        private void deletePasswordBtn_Click(object sender, EventArgs e)
        {
            PasswordColumnData data = (PasswordColumnData) this.passwordDataGridView.CurrentRow.DataBoundItem;
            if (data == null)
            {
                MessageBox.Show("Unknown error: selected row to delete of DataGridView is null.");
                return;
            }
            if (!this.DeletePasswordData(data))
            {
                MessageBox.Show("Unknown error: remove selected row failed.");
            }
        }
    }
}