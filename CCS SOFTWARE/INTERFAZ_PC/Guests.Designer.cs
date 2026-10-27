namespace INTERFAZ_PC
{
    partial class Guests
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guests));
            panel3 = new Panel();
            txt_UID = new TextBox();
            label6 = new Label();
            txt_ID = new TextBox();
            btn_updateguest = new Button();
            dataGridView1 = new DataGridView();
            telefonoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            uidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            horaEntradaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            horaSalidaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            invitadosBindingSource = new BindingSource(components);
            label1 = new Label();
            button6 = new Button();
            button4 = new Button();
            txt_phoneguest = new TextBox();
            txt_guest = new TextBox();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            label5 = new Label();
            invitadoRepositoryBindingSource = new BindingSource(components);
            invitadoBindingSource = new BindingSource(components);
            invitadosBindingSource1 = new BindingSource(components);
            panel4 = new Panel();
            label11 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            btn_report = new Button();
            button2 = new Button();
            btn_monitoring = new Button();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            pictureBox5 = new PictureBox();
            btn_addguest = new Button();
            pictureBox4 = new PictureBox();
            btn_deleteguest = new Button();
            pictureBox6 = new PictureBox();
            label7 = new Label();
            label9 = new Label();
            invitadoRepositoryBindingSource1 = new BindingSource(components);
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)invitadosBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)invitadoRepositoryBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)invitadoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)invitadosBindingSource1).BeginInit();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)invitadoRepositoryBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(95, 130, 194);
            panel3.Controls.Add(txt_UID);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(txt_ID);
            panel3.Controls.Add(btn_updateguest);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(txt_phoneguest);
            panel3.Controls.Add(txt_guest);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(214, 127);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(727, 310);
            panel3.TabIndex = 34;
            // 
            // txt_UID
            // 
            txt_UID.BackColor = SystemColors.InactiveCaption;
            txt_UID.Location = new Point(161, 127);
            txt_UID.Margin = new Padding(2);
            txt_UID.Name = "txt_UID";
            txt_UID.Size = new Size(196, 23);
            txt_UID.TabIndex = 32;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(60, 128);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 31;
            label6.Text = "UID:";
            // 
            // txt_ID
            // 
            txt_ID.BackColor = SystemColors.InactiveCaption;
            txt_ID.Location = new Point(565, 158);
            txt_ID.Margin = new Padding(2);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(53, 23);
            txt_ID.TabIndex = 30;
            txt_ID.Visible = false;
            // 
            // btn_updateguest
            // 
            btn_updateguest.BackColor = Color.LightGray;
            btn_updateguest.FlatAppearance.BorderColor = Color.Black;
            btn_updateguest.FlatAppearance.BorderSize = 4;
            btn_updateguest.FlatStyle = FlatStyle.Flat;
            btn_updateguest.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_updateguest.Location = new Point(565, 251);
            btn_updateguest.Margin = new Padding(2);
            btn_updateguest.Name = "btn_updateguest";
            btn_updateguest.Size = new Size(106, 38);
            btn_updateguest.TabIndex = 29;
            btn_updateguest.Text = "Actualizar";
            btn_updateguest.UseVisualStyleBackColor = false;
            btn_updateguest.Click += btn_updateguest_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AccessibleRole = AccessibleRole.None;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.FromArgb(95, 130, 194);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nombreDataGridViewTextBoxColumn, uidDataGridViewTextBoxColumn, telefonoDataGridViewTextBoxColumn, horaEntradaDataGridViewTextBoxColumn, horaSalidaDataGridViewTextBoxColumn, idDataGridViewTextBoxColumn });
            dataGridView1.DataSource = invitadosBindingSource;
            dataGridView1.Location = new Point(36, 165);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(465, 135);
            dataGridView1.TabIndex = 16;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            //
            // uidDataGridViewTextBoxColumn
            //
            uidDataGridViewTextBoxColumn.DataPropertyName = "Uid";
            uidDataGridViewTextBoxColumn.HeaderText = "UID";
            uidDataGridViewTextBoxColumn.Name = "uidDataGridViewTextBoxColumn";
            uidDataGridViewTextBoxColumn.ReadOnly = true;
            //
            // horaEntradaDataGridViewTextBoxColumn
            //
            horaEntradaDataGridViewTextBoxColumn.DataPropertyName = "HoraEntrada";
            horaEntradaDataGridViewTextBoxColumn.HeaderText = "Hora de entrada";
            horaEntradaDataGridViewTextBoxColumn.Name = "horaEntradaDataGridViewTextBoxColumn";
            horaEntradaDataGridViewTextBoxColumn.ReadOnly = true;
            //
            // horaSalidaDataGridViewTextBoxColumn
            //
            horaSalidaDataGridViewTextBoxColumn.DataPropertyName = "HoraSalida";
            horaSalidaDataGridViewTextBoxColumn.HeaderText = "Hora de salida";
            horaSalidaDataGridViewTextBoxColumn.Name = "horaSalidaDataGridViewTextBoxColumn";
            horaSalidaDataGridViewTextBoxColumn.ReadOnly = true;
            //
            // invitadosBindingSource
            // 
            invitadosBindingSource.DataSource = typeof(INTERFAZ_PC.Models.Invitado);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(201, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 15;
            label1.Text = "INVITADO";
            // 
            // button6
            // 
            button6.Font = new Font("MS Reference Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(545, 124);
            button6.Margin = new Padding(2);
            button6.Name = "button6";
            button6.Size = new Size(85, 24);
            button6.TabIndex = 14;
            button6.Text = "ELIMINAR";
            button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("MS Reference Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(419, 124);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(78, 26);
            button4.TabIndex = 13;
            button4.Text = "CARGAR";
            button4.UseVisualStyleBackColor = true;
            // 
            // txt_phoneguest
            // 
            txt_phoneguest.BackColor = SystemColors.InactiveCaption;
            txt_phoneguest.Location = new Point(161, 88);
            txt_phoneguest.Margin = new Padding(2);
            txt_phoneguest.Name = "txt_phoneguest";
            txt_phoneguest.Size = new Size(196, 23);
            txt_phoneguest.TabIndex = 9;
            // 
            // txt_guest
            // 
            txt_guest.BackColor = SystemColors.InactiveCaption;
            txt_guest.Location = new Point(161, 49);
            txt_guest.Margin = new Padding(2);
            txt_guest.Name = "txt_guest";
            txt_guest.Size = new Size(196, 23);
            txt_guest.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(450, 10);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(31, 89);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(111, 20);
            label8.TabIndex = 3;
            label8.Text = "TELEFONO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(36, 50);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 0;
            label5.Text = "NOMBRES:";
            // 
            // invitadoRepositoryBindingSource
            // 
            invitadoRepositoryBindingSource.DataSource = typeof(Repositories.InvitadoRepository);
            // 
            // invitadoBindingSource
            // 
            invitadoBindingSource.DataSource = typeof(Models.Invitado);
            // 
            // invitadosBindingSource1
            // 
            invitadosBindingSource1.DataSource = typeof(INTERFAZ_PC.Models.Invitado);
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(18, 116, 130);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(210, 0);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(731, 49);
            panel4.TabIndex = 33;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("MS Reference Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.White;
            label11.Location = new Point(0, 13);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(247, 24);
            label11.TabIndex = 24;
            label11.Text = "REGISTRO INVITADOS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("MS Reference Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(628, 2);
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 56, 117);
            panel1.Controls.Add(btn_report);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btn_monitoring);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 427);
            panel1.TabIndex = 32;
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
            btn_report.Margin = new Padding(2);
            btn_report.Name = "btn_report";
            btn_report.Size = new Size(210, 55);
            btn_report.TabIndex = 3;
            btn_report.Text = "Reporte";
            btn_report.TextAlign = ContentAlignment.MiddleLeft;
            btn_report.UseVisualStyleBackColor = true;
            btn_report.Click += btn_report_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderColor = SystemColors.Desktop;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(0, 104);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(210, 55);
            button2.TabIndex = 2;
            button2.Text = "Invitados";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
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
            btn_monitoring.Margin = new Padding(2);
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
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(210, 67);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(69, 94, 140);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(210, 49);
            panel2.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(105, 2);
            pictureBox3.Margin = new Padding(2);
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
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(738, 82);
            pictureBox5.Margin = new Padding(2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(54, 29);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 28;
            pictureBox5.TabStop = false;
            // 
            // btn_addguest
            // 
            btn_addguest.BackColor = Color.LightGray;
            btn_addguest.FlatAppearance.BorderColor = Color.Black;
            btn_addguest.FlatAppearance.BorderSize = 4;
            btn_addguest.FlatStyle = FlatStyle.Flat;
            btn_addguest.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_addguest.Location = new Point(796, 76);
            btn_addguest.Margin = new Padding(2);
            btn_addguest.Name = "btn_addguest";
            btn_addguest.Size = new Size(136, 41);
            btn_addguest.TabIndex = 27;
            btn_addguest.Text = "Agregar";
            btn_addguest.UseVisualStyleBackColor = false;
            btn_addguest.Click += btn_addguest_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(226, 82);
            pictureBox4.Margin = new Padding(2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(54, 29);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 36;
            pictureBox4.TabStop = false;
            // 
            // btn_deleteguest
            // 
            btn_deleteguest.BackColor = Color.LightGray;
            btn_deleteguest.FlatAppearance.BorderColor = Color.Black;
            btn_deleteguest.FlatAppearance.BorderSize = 4;
            btn_deleteguest.FlatStyle = FlatStyle.Flat;
            btn_deleteguest.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_deleteguest.Location = new Point(284, 76);
            btn_deleteguest.Margin = new Padding(2);
            btn_deleteguest.Name = "btn_deleteguest";
            btn_deleteguest.Size = new Size(111, 41);
            btn_deleteguest.TabIndex = 35;
            btn_deleteguest.Text = "Eliminar";
            btn_deleteguest.UseVisualStyleBackColor = false;
            btn_deleteguest.Click += btn_deleteguest_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.chip_rfid;
            pictureBox6.Location = new Point(460, 82);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(55, 43);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 37;
            pictureBox6.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(520, 97);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 33;
            label7.Text = "UID:";
            label7.Click += label7_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(571, 97);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 38;
            // 
            // invitadoRepositoryBindingSource1
            // 
            invitadoRepositoryBindingSource1.DataSource = typeof(Repositories.InvitadoRepository);
            // 
            // Guests
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(153, 167, 194);
            ClientSize = new Size(941, 427);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            Controls.Add(panel3);
            Controls.Add(btn_deleteguest);
            Controls.Add(btn_addguest);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "Guests";
            Text = "Guests";
            Load += Guests_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)invitadosBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)invitadoRepositoryBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)invitadoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)invitadosBindingSource1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)invitadoRepositoryBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private Panel panel3;
        private TextBox txt_phoneguest;
        private TextBox txt_guest;
        private Label label8;
        private Label label5;
        private Panel panel4;
        private Label label11;
        private Label label4;
        private Label label3;
        private Panel panel1;
        private Button btn_report;
        private Button button2;
        private Button btn_monitoring;
        private PictureBox pictureBox2;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Label label2;
        private PictureBox pictureBox5;
        private Button btn_addguest;
        private Button button6;
        private Button button4;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Label label1;
        private PictureBox pictureBox4;
        private Button btn_deleteguest;
        private Button btn_updateguest;
        private TextBox txt_ID;
        private TextBox txt_UID;
        private Label label6;
        private BindingSource invitadosBindingSource;
        private PictureBox pictureBox6;
        private Label label7;
        private Label label9;
        private BindingSource invitadosBindingSource1;
        private BindingSource invitadoBindingSource;
        private BindingSource invitadoRepositoryBindingSource;
        private DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn uidDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horaEntradaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn horaSalidaDataGridViewTextBoxColumn;
        private BindingSource invitadoRepositoryBindingSource1;
    }
}