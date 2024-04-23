namespace WinFormsApp2
{
    partial class AddRequest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            textBoxNumber = new TextBox();
            textBoxDesc = new TextBox();
            textBoxPhone = new TextBox();
            textBoxComment = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBoxVid = new ComboBox();
            buttonAdd = new Button();
            textBoxWorker = new TextBox();
            comboBoxFio = new ComboBox();
            comboBoxTypeProblem = new ComboBox();
            comboBoxStatus = new ComboBox();
            comboBoxModel = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 28);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 0;
            label1.Text = "Номер заявки";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 67);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 1;
            label2.Text = "Дата добавления";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 115);
            label3.Name = "label3";
            label3.Size = new Size(159, 20);
            label3.TabIndex = 2;
            label3.Text = "Вид бытовой техники";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 164);
            label4.Name = "label4";
            label4.Size = new Size(187, 20);
            label4.TabIndex = 3;
            label4.Text = "Модель бытовой техники";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 215);
            label5.Name = "label5";
            label5.Size = new Size(157, 20);
            label5.TabIndex = 4;
            label5.Text = "Описание проблемы";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(60, 267);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 5;
            label6.Text = "ФИО клиента";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(60, 318);
            label7.Name = "label7";
            label7.Size = new Size(127, 20);
            label7.TabIndex = 6;
            label7.Text = "Номер телефона";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(645, 28);
            label8.Name = "label8";
            label8.Size = new Size(103, 20);
            label8.TabIndex = 7;
            label8.Text = "Статус заявки";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(645, 80);
            label9.Name = "label9";
            label9.Size = new Size(113, 20);
            label9.TabIndex = 8;
            label9.Text = "Тип проблемы";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(645, 267);
            label10.Name = "label10";
            label10.Size = new Size(226, 20);
            label10.TabIndex = 9;
            label10.Text = "Ответственный за выполнение";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(645, 334);
            label11.Name = "label11";
            label11.Size = new Size(107, 20);
            label11.TabIndex = 10;
            label11.Text = "Комментарии";
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(321, 25);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(125, 27);
            textBoxNumber.TabIndex = 11;
            // 
            // textBoxDesc
            // 
            textBoxDesc.Location = new Point(321, 212);
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.Size = new Size(125, 27);
            textBoxDesc.TabIndex = 12;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(321, 315);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(125, 27);
            textBoxPhone.TabIndex = 14;
            // 
            // textBoxComment
            // 
            textBoxComment.Location = new Point(758, 331);
            textBoxComment.Multiline = true;
            textBoxComment.Name = "textBoxComment";
            textBoxComment.Size = new Size(465, 157);
            textBoxComment.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(321, 62);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(229, 27);
            dateTimePicker1.TabIndex = 16;
            // 
            // comboBoxVid
            // 
            comboBoxVid.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxVid.FormattingEnabled = true;
            comboBoxVid.Location = new Point(321, 112);
            comboBoxVid.Name = "comboBoxVid";
            comboBoxVid.Size = new Size(151, 28);
            comboBoxVid.TabIndex = 17;
            // 
            // buttonAdd
            // 
            buttonAdd.DialogResult = DialogResult.OK;
            buttonAdd.Location = new Point(241, 414);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(231, 59);
            buttonAdd.TabIndex = 22;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxWorker
            // 
            textBoxWorker.Location = new Point(877, 264);
            textBoxWorker.Name = "textBoxWorker";
            textBoxWorker.Size = new Size(164, 27);
            textBoxWorker.TabIndex = 23;
            // 
            // comboBoxFio
            // 
            comboBoxFio.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFio.FormattingEnabled = true;
            comboBoxFio.Location = new Point(321, 259);
            comboBoxFio.Name = "comboBoxFio";
            comboBoxFio.Size = new Size(164, 28);
            comboBoxFio.TabIndex = 25;
            // 
            // comboBoxTypeProblem
            // 
            comboBoxTypeProblem.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTypeProblem.FormattingEnabled = true;
            comboBoxTypeProblem.Location = new Point(784, 77);
            comboBoxTypeProblem.Name = "comboBoxTypeProblem";
            comboBoxTypeProblem.Size = new Size(151, 28);
            comboBoxTypeProblem.TabIndex = 20;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(784, 25);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(151, 28);
            comboBoxStatus.TabIndex = 19;
            // 
            // comboBoxModel
            // 
            comboBoxModel.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxModel.FormattingEnabled = true;
            comboBoxModel.Location = new Point(321, 161);
            comboBoxModel.Name = "comboBoxModel";
            comboBoxModel.Size = new Size(151, 28);
            comboBoxModel.TabIndex = 18;
            // 
            // AddRequest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 515);
            Controls.Add(comboBoxFio);
            Controls.Add(textBoxWorker);
            Controls.Add(buttonAdd);
            Controls.Add(comboBoxTypeProblem);
            Controls.Add(comboBoxStatus);
            Controls.Add(comboBoxModel);
            Controls.Add(comboBoxVid);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBoxComment);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxDesc);
            Controls.Add(textBoxNumber);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddRequest";
            Text = "Добавление заявки";
            Load += AddRequest_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBoxNumber;
        private TextBox textBoxDesc;
        private TextBox textBoxPhone;
        private TextBox textBoxComment;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBoxVid;
        private Button buttonAdd;
        private TextBox textBoxWorker;
        private ComboBox comboBoxFio;
        private ComboBox comboBoxTypeProblem;
        private ComboBox comboBoxStatus;
        private ComboBox comboBoxModel;
    }
}