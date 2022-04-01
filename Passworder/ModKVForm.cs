namespace Passworder
{
    public partial class ModKVForm : Form
    {
        public ModKVForm(string title, string passwordHint)
        {
            InitializeComponent(title, passwordHint);
            this.originTitle = title;
            this.originPasswordHint = passwordHint;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newTitle = this.titleTextBox.Text;
            string newPasswordHint = this.passwordHintTextBox.Text;
            Main main = (Main) this.Owner;

            if (!main.UpdatePasswordData(this.originTitle, newTitle, newPasswordHint))
            {
                MessageBox.Show("Unknown error: update password data failed.");
                return;
            }
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private string originTitle;
        private string originPasswordHint;
    }
}
