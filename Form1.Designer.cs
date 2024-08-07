namespace YtDlpGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            panel3 = new Panel();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label6 = new Label();
            textBox2 = new TextBox();
            groupBox2 = new GroupBox();
            panel5 = new Panel();
            label3 = new Label();
            button3 = new Button();
            panel4 = new Panel();
            checkBox1 = new CheckBox();
            label4 = new Label();
            textBox1 = new TextBox();
            panel6 = new Panel();
            label5 = new Label();
            button2 = new Button();
            textBox3 = new TextBox();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel3);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.ForeColor = Color.FromArgb(113, 113, 113);
            groupBox1.Location = new Point(14, 80);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(1, 1, 1, 2);
            groupBox1.Size = new Size(325, 325);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(1, 17);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(323, 306);
            panel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.FlatStyle = FlatStyle.Flat;
            label2.ForeColor = Color.FromArgb(113, 113, 113);
            label2.Location = new Point(21, 80);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 6;
            label2.Text = "Video";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Desktop;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.FromArgb(113, 113, 113);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(685, 31);
            panel1.TabIndex = 2;
            panel1.MouseDown += Form1_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 5;
            label1.Text = "> YtDlpGui";
            label1.MouseDown += Form1_MouseDown;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(15, 15, 15);
            button1.FlatAppearance.BorderColor = Color.FromArgb(39, 39, 39);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(241, 241, 241);
            button1.Location = new Point(656, 3);
            button1.Name = "button1";
            button1.Size = new Size(26, 25);
            button1.TabIndex = 4;
            button1.TabStop = false;
            button1.Text = "x";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(656, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 22);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(39, 39, 39);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(textBox2);
            panel2.Dock = DockStyle.Top;
            panel2.ForeColor = Color.FromArgb(113, 113, 113);
            panel2.Location = new Point(0, 31);
            panel2.Name = "panel2";
            panel2.Size = new Size(685, 34);
            panel2.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.FromArgb(113, 113, 113);
            label6.Location = new Point(9, 8);
            label6.Name = "label6";
            label6.Size = new Size(40, 18);
            label6.TabIndex = 9;
            label6.Text = "URL:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(39, 39, 39);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox2.ForeColor = Color.FromArgb(241, 241, 241);
            textBox2.Location = new Point(55, 8);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(594, 18);
            textBox2.TabIndex = 1;
            textBox2.TabStop = false;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panel5);
            groupBox2.FlatStyle = FlatStyle.Flat;
            groupBox2.ForeColor = Color.FromArgb(113, 113, 113);
            groupBox2.Location = new Point(347, 80);
            groupBox2.Margin = new Padding(0);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(1, 1, 1, 2);
            groupBox2.Size = new Size(325, 325);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // panel5
            // 
            panel5.AutoScroll = true;
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(1, 17);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(323, 306);
            panel5.TabIndex = 1;
            // 
            // label3
            // 
            label3.FlatStyle = FlatStyle.Flat;
            label3.ForeColor = Color.FromArgb(113, 113, 113);
            label3.Location = new Point(354, 80);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 7;
            label3.Text = "Audio";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.FlatAppearance.BorderColor = Color.FromArgb(39, 39, 39);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.FromArgb(241, 241, 241);
            button3.Location = new Point(284, 499);
            button3.Name = "button3";
            button3.Size = new Size(122, 25);
            button3.TabIndex = 8;
            button3.TabStop = false;
            button3.Text = "Download";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(39, 39, 39);
            panel4.Controls.Add(checkBox1);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(textBox1);
            panel4.ForeColor = Color.FromArgb(113, 113, 113);
            panel4.Location = new Point(0, 422);
            panel4.Name = "panel4";
            panel4.Size = new Size(685, 29);
            panel4.TabIndex = 4;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.FlatStyle = FlatStyle.Flat;
            checkBox1.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox1.ForeColor = Color.Silver;
            checkBox1.Location = new Point(10, 9);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(12, 11);
            checkBox1.TabIndex = 10;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label4
            // 
            label4.FlatStyle = FlatStyle.Flat;
            label4.ForeColor = Color.FromArgb(113, 113, 113);
            label4.Location = new Point(28, 7);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 9;
            label4.Text = "Proxy:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(39, 39, 39);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.ForeColor = Color.FromArgb(241, 241, 241);
            textBox1.Location = new Point(83, 7);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(591, 16);
            textBox1.TabIndex = 1;
            textBox1.TabStop = false;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(39, 39, 39);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(button2);
            panel6.Controls.Add(textBox3);
            panel6.ForeColor = Color.FromArgb(113, 113, 113);
            panel6.Location = new Point(0, 455);
            panel6.Name = "panel6";
            panel6.Size = new Size(685, 29);
            panel6.TabIndex = 9;
            // 
            // label5
            // 
            label5.FlatStyle = FlatStyle.Flat;
            label5.ForeColor = Color.FromArgb(113, 113, 113);
            label5.Location = new Point(7, 7);
            label5.Name = "label5";
            label5.Size = new Size(77, 15);
            label5.TabIndex = 9;
            label5.Text = "Save path:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(15, 15, 15);
            button2.Dock = DockStyle.Right;
            button2.FlatAppearance.BorderColor = Color.FromArgb(39, 39, 39);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.FromArgb(241, 241, 241);
            button2.Location = new Point(656, 0);
            button2.Name = "button2";
            button2.Size = new Size(29, 29);
            button2.TabIndex = 7;
            button2.TabStop = false;
            button2.Text = "↑";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(39, 39, 39);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox3.ForeColor = Color.FromArgb(241, 241, 241);
            textBox3.Location = new Point(90, 7);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(559, 16);
            textBox3.TabIndex = 1;
            textBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 15, 15);
            ClientSize = new Size(685, 538);
            Controls.Add(panel6);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(panel4);
            Controls.Add(button3);
            Controls.Add(groupBox2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = Color.FromArgb(241, 241, 241);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YtDlpGui";
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private TextBox textBox2;
        private GroupBox groupBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button3;
        private Panel panel4;
        private TextBox textBox1;
        private Panel panel3;
        private Panel panel5;
        private PictureBox pictureBox1;
        private Label label4;
        private Panel panel6;
        private Label label5;
        private Button button2;
        private TextBox textBox3;
        private Label label6;
        private CheckBox checkBox1;
    }
}
