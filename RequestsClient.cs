using System.Data;
using WinFormsApp2.Models;

namespace WinFormsApp2
{
    public partial class RequestsClient : Form
    {
        ServisDBContext db = new ServisDBContext();
        public RequestsClient()
        {
            InitializeComponent();
            LoadRequest();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void LoadRequest()
        {
            var user = Autorization.user;

            using (var db = new ServisDBContext())
            {
                var request = db.Orders.ToList();
                if (user.RoleId == 3)
                {
                    request = db.Orders.Where(x => x.IdWorcker == user.Id).ToList();
                }
                if (user.RoleId == 1)
                {
                    request = db.Orders.Where(x => x.IdClient == user.Id).ToList();
                }

                foreach (var order in request)
                {
                    var control = new UserControl1(order);
                    control.Parent = flowLayoutPanel1;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddRequest addRequest = new AddRequest();
            if (addRequest.ShowDialog() == DialogResult.OK)
            {
                db.Orders.Add(AddRequest.order);
                db.SaveChanges();
                var newOrder = new UserControl1(AddRequest.order);
                newOrder.Parent = flowLayoutPanel1;
            }
        }
    }
}
