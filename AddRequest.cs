using WinFormsApp2.Models;

namespace WinFormsApp2
{
    public partial class AddRequest : Form
    {
        public static Order order;
        public AddRequest()
        {
            InitializeComponent();
            using (var db = new ServisDBContext()) {
                comboBoxVid.DisplayMember = nameof(TypeBtTechn.Titel);
                comboBoxVid.ValueMember = nameof(TypeBtTechn.Id);
                comboBoxVid.Items.AddRange(db.TypeBtTechns.ToArray());

                comboBoxModel.DisplayMember = nameof(ModelTechn.Titel);
                comboBoxModel.ValueMember = nameof(ModelTechn.Id);
                comboBoxModel.Items.AddRange(db.ModelTechns.ToArray());

                comboBoxStatus.DisplayMember = nameof(Status.Titel);
                comboBoxStatus.ValueMember = nameof(Status.Id);
                comboBoxStatus.Items.AddRange(db.Statuses.ToArray());

                comboBoxTypeProblem.DisplayMember = nameof(TypeProblem.Title);
                comboBoxTypeProblem.ValueMember = nameof(TypeProblem.Id);
                comboBoxTypeProblem.Items.AddRange(db.TypeProblems.ToArray());

                //comboBoxWorker.DisplayMember = nameof(Models.User.Fio);
                //comboBoxWorker.ValueMember = nameof(Models.User.Id);
                //var worker = db.Users.Where((x) => x.RoleId == 3).ToArray();
                //comboBoxWorker.Items.AddRange(worker);

                comboBoxFio.DisplayMember = nameof(Models.User.Fio);
                comboBoxFio.ValueMember = nameof(Models.User.Id);
                comboBoxFio.Items.AddRange(db.Users.ToArray());
            }
        }

        private void AddRequest_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            order = new Order
            {
                Idnumber = Convert.ToInt32(textBoxNumber.Text),
                DateCreate = dateTimePicker1.Value,
                TypeBtTechnId = comboBoxVid.SelectedIndex+1,
                ModelId = comboBoxModel.SelectedIndex +1,
                Descr = textBoxDesc.Text,
                Comment = textBoxComment.Text,
                IdClient = comboBoxFio.SelectedIndex+1,
                PhoneNumber = textBoxPhone.Text,
                StatusId = comboBoxStatus.SelectedIndex +1,
                TypeProblem = comboBoxTypeProblem.SelectedIndex +1,
            };
            
        }
    }
}
