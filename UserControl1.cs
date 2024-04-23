using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.Models;

namespace WinFormsApp2
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1(Order orders)
        {
            InitializeComponent();
            InitOrder(orders);
        }
        public void InitOrder(Order orders)
        {
            using (var db = new ServisDBContext())
            {
                lblNumber.Text = orders.Idnumber.ToString();
                lblDate.Text = orders.DateCreate.ToString();
                var vid = db.TypeBtTechns.FirstOrDefault(x => x.Id == orders.TypeBtTechnId);
                lblVid.Text = vid.Titel;
                var modelTech = db.ModelTechns.FirstOrDefault(x => x.Id == orders.ModelId);
                lblModel.Text = modelTech.Titel;
                lblProblemDesc.Text = orders.Descr;
                var client = db.Users.FirstOrDefault(x => x.Id == orders.IdClient);
                lblFio.Text = client.Fio;
                lblPhone.Text = orders.PhoneNumber;
                var statReq = db.Statuses.FirstOrDefault(x => x.Id == orders.StatusId);
                lblStatus.Text = statReq.Titel;
                //var master = db.Users.FirstOrDefault(x => x.Id == orders.IdWorcker);
                //lblMaster.Text = master.Fio;
                var typeProblem = db.TypeProblems.FirstOrDefault(x => x.Id == orders.TypeProblem);
                lblTypeProblem.Text = typeProblem.Title;



            }
        }
    }
}
