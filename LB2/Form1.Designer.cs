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
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button10 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBoxTrackPrice = new System.Windows.Forms.TextBox();
            this.textBoxTrackTime = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxName.Location = new System.Drawing.Point(15, 48);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PlaceholderText = "Назва";
            this.textBoxName.Size = new System.Drawing.Size(286, 27);
            this.textBoxName.TabIndex = 9;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxAdress.Location = new System.Drawing.Point(15, 87);
            this.textBoxAdress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.PlaceholderText = "Адреса";
            this.textBoxAdress.Size = new System.Drawing.Size(286, 27);
            this.textBoxAdress.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.label9.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(267, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(254, 32);
            this.label9.TabIndex = 13;
            this.label9.Text = "Студія звукозапису";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 203);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 31);
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
            this.resultLabel.Location = new System.Drawing.Point(494, 427);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(204, 20);
            this.resultLabel.TabIndex = 19;
            this.resultLabel.Text = "Уведіть дані для нової студії";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(71, 341);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 28);
            this.button2.TabIndex = 20;
            this.button2.Text = "Створити кімнату";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(75, 416);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(192, 31);
            this.button4.TabIndex = 22;
            this.button4.Text = "Створити інструмент ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(72, 377);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(195, 31);
            this.button5.TabIndex = 23;
            this.button5.Text = "Створити співробітника";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(216, 280);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(86, 31);
            this.button8.TabIndex = 26;
            this.button8.Text = "Копіювати студію";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(349, 48);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 28);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.Tag = "";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(14, 241);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(160, 31);
            this.button10.TabIndex = 30;
            this.button10.Text = "Додати  інструмент";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Працівники",
            "Інструменти",
            "Кімнати"});
            this.comboBox2.Location = new System.Drawing.Point(494, 48);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(138, 28);
            this.comboBox2.TabIndex = 31;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(330, 87);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(500, 320);
            this.richTextBox1.TabIndex = 32;
            this.richTextBox1.Text = "";
            // 
            // textBoxTrackPrice
            // 
            this.textBoxTrackPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxTrackPrice.Location = new System.Drawing.Point(15, 125);
            this.textBoxTrackPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTrackPrice.Name = "textBoxTrackPrice";
            this.textBoxTrackPrice.PlaceholderText = "Вартість одного треку";
            this.textBoxTrackPrice.Size = new System.Drawing.Size(286, 27);
            this.textBoxTrackPrice.TabIndex = 12;
            // 
            // textBoxTrackTime
            // 
            this.textBoxTrackTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxTrackTime.Location = new System.Drawing.Point(15, 164);
            this.textBoxTrackTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTrackTime.Name = "textBoxTrackTime";
            this.textBoxTrackTime.PlaceholderText = "Час створення треку(у днях)";
            this.textBoxTrackTime.Size = new System.Drawing.Size(286, 27);
            this.textBoxTrackTime.TabIndex = 14;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(181, 241);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(143, 31);
            this.button7.TabIndex = 30;
            this.button7.Text = "Додати кімнату";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(16, 280);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(160, 31);
            this.button9.TabIndex = 30;
            this.button9.Text = "Додати  працівника";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 473);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxTrackTime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxTrackPrice);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.textBoxName);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private TextBox textBoxName;
        private TextBox textBoxAdress;
        private Label label9;
        private Button button1;
        private Label resultLabel;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button8;
        private ComboBox comboBox1;
        private Button button10;
        private ComboBox comboBox2;
        private RichTextBox richTextBox1;
        private TextBox textBoxTrackPrice;
        private TextBox textBoxTrackTime;
        private Button button7;
        private Button button9;
    }
}