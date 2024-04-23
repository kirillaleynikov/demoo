namespace WinFormsApp2
{
    partial class UserControl1
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            lblNumber = new Label();
            lblDate = new Label();
            lblVid = new Label();
            lblModel = new Label();
            lblProblemDesc = new Label();
            lblFio = new Label();
            lblPhone = new Label();
            lblStatus = new Label();
            lblMaster = new Label();
            lblTypeProblem = new Label();
            SuspendLayout();
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Location = new Point(3, 10);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(57, 20);
            lblNumber.TabIndex = 0;
            lblNumber.Text = "Номер";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(3, 41);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(41, 20);
            lblDate.TabIndex = 1;
            lblDate.Text = "Дата";
            // 
            // lblVid
            // 
            lblVid.AutoSize = true;
            lblVid.Location = new Point(3, 79);
            lblVid.Name = "lblVid";
            lblVid.Size = new Size(94, 20);
            lblVid.TabIndex = 2;
            lblVid.Text = "Вид техники";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(3, 114);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(122, 20);
            lblModel.TabIndex = 3;
            lblModel.Text = "Модель техники";
            // 
            // lblProblemDesc
            // 
            lblProblemDesc.AutoSize = true;
            lblProblemDesc.Location = new Point(3, 153);
            lblProblemDesc.Name = "lblProblemDesc";
            lblProblemDesc.Size = new Size(157, 20);
            lblProblemDesc.TabIndex = 4;
            lblProblemDesc.Text = "Описание проблемы";
            // 
            // lblFio
            // 
            lblFio.AutoSize = true;
            lblFio.Location = new Point(3, 190);
            lblFio.Name = "lblFio";
            lblFio.Size = new Size(101, 20);
            lblFio.TabIndex = 5;
            lblFio.Text = "ФИО клиента";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(574, 10);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(127, 20);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Номер телефона";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(574, 41);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(103, 20);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Статус заявки";
            // 
            // lblMaster
            // 
            lblMaster.AutoSize = true;
            lblMaster.Location = new Point(574, 79);
            lblMaster.Name = "lblMaster";
            lblMaster.Size = new Size(60, 20);
            lblMaster.TabIndex = 8;
            lblMaster.Text = "Мастер";
            // 
            // lblTypeProblem
            // 
            lblTypeProblem.AutoSize = true;
            lblTypeProblem.Location = new Point(574, 114);
            lblTypeProblem.Name = "lblTypeProblem";
            lblTypeProblem.Size = new Size(113, 20);
            lblTypeProblem.TabIndex = 9;
            lblTypeProblem.Text = "Тип проблемы";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTypeProblem);
            Controls.Add(lblMaster);
            Controls.Add(lblStatus);
            Controls.Add(lblPhone);
            Controls.Add(lblFio);
            Controls.Add(lblProblemDesc);
            Controls.Add(lblModel);
            Controls.Add(lblVid);
            Controls.Add(lblDate);
            Controls.Add(lblNumber);
            Name = "UserControl1";
            Size = new Size(1014, 265);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumber;
        private Label lblDate;
        private Label lblVid;
        private Label lblModel;
        private Label lblProblemDesc;
        private Label lblFio;
        private Label lblPhone;
        private Label lblStatus;
        private Label lblMaster;
        private Label lblTypeProblem;
    }
}
