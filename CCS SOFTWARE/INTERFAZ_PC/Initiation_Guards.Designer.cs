namespace INTERFAZ_PC
{
    partial class Initiation_Guards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Initiation_Guards));
            panel4 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            btn_report = new Button();
            btn_guests = new Button();
            btn_monitoring = new Button();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            label8 = new Label();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(57, 121, 130);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(210, 0);
            panel4.Margin = new Padding(2, 2, 2, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(731, 49);
            panel4.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("MS Reference Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(623, 2);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(113, 19);
            label4.TabIndex = 2;
            label4.Text = "09/03/2023";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("MS Reference Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(628, 30);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(105, 19);
            label3.TabIndex = 1;
            label3.Text = "11:08 p.m.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("MS Reference Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(2, 13);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 24);
            label1.TabIndex = 0;
            label1.Text = "INICIO";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 56, 117);
            panel1.Controls.Add(btn_report);
            panel1.Controls.Add(btn_guests);
            panel1.Controls.Add(btn_monitoring);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 427);
            panel1.TabIndex = 22;
            // 
            // btn_report
            // 
            btn_report.Dock = DockStyle.Top;
            btn_report.FlatAppearance.BorderColor = SystemColors.Desktop;
            btn_report.FlatStyle = FlatStyle.Flat;
            btn_report.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_report.ForeColor = Color.White;
            btn_report.Image = (Image)resources.GetObject("btn_report.Image");
            btn_report.ImageAlign = ContentAlignment.MiddleRight;
            btn_report.Location = new Point(0, 159);
            btn_report.Margin = new Padding(2, 2, 2, 2);
            btn_report.Name = "btn_report";
            btn_report.Size = new Size(210, 55);
            btn_report.TabIndex = 3;
            btn_report.Text = "Reporte";
            btn_report.TextAlign = ContentAlignment.MiddleLeft;
            btn_report.UseVisualStyleBackColor = true;
            btn_report.Click += btn_report_Click;
            // 
            // btn_guests
            // 
            btn_guests.Dock = DockStyle.Top;
            btn_guests.FlatAppearance.BorderColor = SystemColors.Desktop;
            btn_guests.FlatStyle = FlatStyle.Flat;
            btn_guests.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_guests.ForeColor = Color.White;
            btn_guests.Image = (Image)resources.GetObject("btn_guests.Image");
            btn_guests.ImageAlign = ContentAlignment.MiddleRight;
            btn_guests.Location = new Point(0, 104);
            btn_guests.Margin = new Padding(2, 2, 2, 2);
            btn_guests.Name = "btn_guests";
            btn_guests.Size = new Size(210, 55);
            btn_guests.TabIndex = 2;
            btn_guests.Text = "Invitados";
            btn_guests.TextAlign = ContentAlignment.MiddleLeft;
            btn_guests.UseVisualStyleBackColor = true;
            btn_guests.Click += btn_guests_Click;
            // 
            // btn_monitoring
            // 
            btn_monitoring.Dock = DockStyle.Top;
            btn_monitoring.FlatAppearance.BorderColor = SystemColors.Desktop;
            btn_monitoring.FlatStyle = FlatStyle.Flat;
            btn_monitoring.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_monitoring.ForeColor = Color.White;
            btn_monitoring.Image = Properties.Resources._7733835;
            btn_monitoring.ImageAlign = ContentAlignment.MiddleRight;
            btn_monitoring.Location = new Point(0, 49);
            btn_monitoring.Margin = new Padding(2, 2, 2, 2);
            btn_monitoring.Name = "btn_monitoring";
            btn_monitoring.Size = new Size(210, 55);
            btn_monitoring.TabIndex = 1;
            btn_monitoring.Text = "Monitoreo";
            btn_monitoring.TextAlign = ContentAlignment.MiddleLeft;
            btn_monitoring.UseVisualStyleBackColor = true;
            btn_monitoring.Click += btn_monitoring_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Bottom;
            pictureBox2.Image = Properties.Resources.LOGO_LOGIN2;
            pictureBox2.Location = new Point(0, 360);
            pictureBox2.Margin = new Padding(2, 2, 2, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(210, 67);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(57, 78, 117);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(210, 49);
            panel2.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(105, 2);
            pictureBox3.Margin = new Padding(2, 2, 2, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(105, 45);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(16, 10);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 28);
            label2.TabIndex = 0;
            label2.Text = "MENU";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.torniquete_en_el_subterráneo_18763387;
            pictureBox1.Location = new Point(259, 0);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(472, 185);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(62, 110, 140);
            panel3.Controls.Add(pictureBox4);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(210, 49);
            panel3.Margin = new Padding(2, 2, 2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(729, 185);
            panel3.TabIndex = 26;
            panel3.Paint += panel3_Paint;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources._1185509;
            pictureBox4.Location = new Point(70, 67);
            pictureBox4.Margin = new Padding(2, 2, 2, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(117, 86);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 27;
            pictureBox4.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MS Reference Sans Serif", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(30, 26);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(197, 34);
            label5.TabIndex = 26;
            label5.Text = "¡Bienvenido!";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("MS Reference Sans Serif", 7F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(214, 245);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(841, 182);
            label8.TabIndex = 35;
            label8.Text = resources.GetString("label8.Text");
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Initiation_Guards
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(941, 427);
            Controls.Add(label8);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Initiation_Guards";
            Text = "Initiation_Guards";
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Panel panel4;
        private Label label4;
        private Label label3;
        private Label label1;
        private Panel panel1;
        private Button btn_report;
        private Button btn_guests;
        private Button btn_monitoring;
        private PictureBox pictureBox2;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private PictureBox pictureBox4;
        private Label label5;
        private Label label8;
    }
}