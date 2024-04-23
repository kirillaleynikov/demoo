using WinFormsApp2.Models;

namespace WinFormsApp2
{
    public partial class Autorization : Form
    {
        public static User user;
        public Autorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new ServisDBContext())
            {
                if (db.Users.Any(x => x.LoginU == textBoxLogin.Text && x.PasswordU == textBoxPassword.Text))
                {
                    var users = db.Users.FirstOrDefault(x => x.LoginU == textBoxLogin.Text && x.PasswordU == textBoxPassword.Text);
                    user = users;
                    var req = new RequestsClient();
                    req.Show();
                }
                else
                {
                    MessageBox.Show("¬ведены неверные данные!","ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
