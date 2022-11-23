namespace LB2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.textBoxEmployee = new System.Windows.Forms.TextBox();
            this.textBoxTrackPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxTrackTime = new System.Windows.Forms.TextBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.textBoxInstruments = new System.Windows.Forms.TextBox();
            this.textBoxRooms = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.currentStudio = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxName.Location = new System.Drawing.Point(13, 36);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PlaceholderText = "Назва";
            this.textBoxName.Size = new System.Drawing.Size(251, 23);
            this.textBoxName.TabIndex = 9;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxAdress.Location = new System.Drawing.Point(13, 65);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.PlaceholderText = "Адреса";
            this.textBoxAdress.Size = new System.Drawing.Size(251, 23);
            this.textBoxAdress.TabIndex = 10;
            // 
            // textBoxEmployee
            // 
            this.textBoxEmployee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxEmployee.Location = new System.Drawing.Point(13, 96);
            this.textBoxEmployee.Name = "textBoxEmployee";
            this.textBoxEmployee.PlaceholderText = "К-сть співробітників";
            this.textBoxEmployee.Size = new System.Drawing.Size(251, 23);
            this.textBoxEmployee.TabIndex = 11;
            // 
            // textBoxTrackPrice
            // 
            this.textBoxTrackPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxTrackPrice.Location = new System.Drawing.Point(12, 126);
            this.textBoxTrackPrice.Name = "textBoxTrackPrice";
            this.textBoxTrackPrice.PlaceholderText = "Вартість одного треку";
            this.textBoxTrackPrice.Size = new System.Drawing.Size(251, 23);
            this.textBoxTrackPrice.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label9.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(234, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Студія звукозапису";
            // 
            // textBoxTrackTime
            // 
            this.textBoxTrackTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxTrackTime.Location = new System.Drawing.Point(13, 156);
            this.textBoxTrackTime.Name = "textBoxTrackTime";
            this.textBoxTrackTime.PlaceholderText = "Час створення треку(у днях)";
            this.textBoxTrackTime.Size = new System.Drawing.Size(251, 23);
            this.textBoxTrackTime.TabIndex = 14;
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxSalary.Location = new System.Drawing.Point(13, 185);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.PlaceholderText = "ЗП одного співробітника";
            this.textBoxSalary.Size = new System.Drawing.Size(251, 23);
            this.textBoxSalary.TabIndex = 15;
            // 
            // textBoxInstruments
            // 
            this.textBoxInstruments.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxInstruments.Location = new System.Drawing.Point(13, 214);
            this.textBoxInstruments.Name = "textBoxInstruments";
            this.textBoxInstruments.PlaceholderText = "К-сть інструментів";
            this.textBoxInstruments.Size = new System.Drawing.Size(251, 23);
            this.textBoxInstruments.TabIndex = 16;
            // 
            // textBoxRooms
            // 
            this.textBoxRooms.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxRooms.Location = new System.Drawing.Point(12, 243);
            this.textBoxRooms.Name = "textBoxRooms";
            this.textBoxRooms.PlaceholderText = "К-сть кімнат";
            this.textBoxRooms.Size = new System.Drawing.Size(251, 23);
            this.textBoxRooms.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Створти студію";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.BackColor = System.Drawing.Color.White;
            this.resultLabel.ForeColor = System.Drawing.Color.Green;
            this.resultLabel.Location = new System.Drawing.Point(305, 361);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(158, 15);
            this.resultLabel.TabIndex = 19;
            this.resultLabel.Text = "Уведіть дані для нової студії";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Додати кімнату";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(126, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Видалити кімнату";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 341);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(275, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "Додати кімнату з інструментами за гроші";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(255, 312);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(171, 23);
            this.button5.TabIndex = 23;
            this.button5.Text = "Найняти співробітника";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(432, 312);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(158, 23);
            this.button6.TabIndex = 24;
            this.button6.Text = "Звільнити співробітника";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(16, 370);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(271, 23);
            this.button7.TabIndex = 25;
            this.button7.Text = "Видалити кімнату із співробітниками";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(596, 312);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 26;
            this.button8.Text = "Копіювати студію";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(305, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.Tag = "";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // currentStudio
            // 
            this.currentStudio.AutoSize = true;
            this.currentStudio.Location = new System.Drawing.Point(6, 22);
            this.currentStudio.Name = "currentStudio";
            this.currentStudio.Size = new System.Drawing.Size(0, 15);
            this.currentStudio.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.currentStudio);
            this.groupBox1.Location = new System.Drawing.Point(305, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 201);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Інформація про студію";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 403);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxRooms);
            this.Controls.Add(this.textBoxInstruments);
            this.Controls.Add(this.textBoxSalary);
            this.Controls.Add(this.textBoxTrackTime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxTrackPrice);
            this.Controls.Add(this.textBoxEmployee);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.textBoxName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private TextBox textBoxName;
        private TextBox textBoxAdress;
        private TextBox textBoxEmployee;
        private TextBox textBoxTrackPrice;
        private Label label9;
        private TextBox textBoxTrackTime;
        private TextBox textBoxSalary;
        private TextBox textBoxInstruments;
        private TextBox textBoxRooms;
        private Button button1;
        private Label resultLabel;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private ComboBox comboBox1;
        private Label currentStudio;
        private GroupBox groupBox1;
    }
}