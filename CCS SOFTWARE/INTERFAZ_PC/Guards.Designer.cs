namespace INTERFAZ_PC
{
    partial class Guards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guards));
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            txt_searcher = new TextBox();
            btn_search = new Button();
            button3 = new Button();
            panel1 = new Panel();
            btn_Report = new Button();
            btn_Users = new Button();
            btn_Guards = new Button();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            btn_delete = new Button();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            btn_update = new Button();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            dataGridView1 = new DataGridView();
            telefonoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            claveDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            correoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            domicilioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usuarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            uidDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            guardiasBindingSource = new BindingSource(components);
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guardiasBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(32, 44, 66);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(txt_searcher);
            panel3.Controls.Add(btn_search);
            panel3.Location = new Point(218, 129);
            panel3.Margin = new Padding(2, 2, 2, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(714, 44);
            panel3.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 2);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // txt_searcher
            // 
            txt_searcher.BackColor = SystemColors.InactiveCaption;
            txt_searcher.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            txt_searcher.ForeColor = SystemColors.WindowText;
            txt_searcher.Location = new Point(112, 7);
            txt_searcher.Margin = new Padding(2, 2, 2, 2);
            txt_searcher.Name = "txt_searcher";
            txt_searcher.Size = new Size(453, 35);
            txt_searcher.TabIndex = 14;
            txt_searcher.Text = "\"Buscador\"";
            txt_searcher.TextAlign = HorizontalAlignment.Center;
            txt_searcher.Click += txt_searcher_Click;
            txt_searcher.TextChanged += txt_searcher_TextChanged;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.LightGray;
            btn_search.FlatAppearance.BorderColor = Color.Black;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_search.Location = new Point(576, 2);
            btn_search.Margin = new Padding(2, 2, 2, 2);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(136, 41);
            btn_search.TabIndex = 13;
            btn_search.Text = "Buscar";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightGray;
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.FlatAppearance.BorderSize = 4;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(794, 75);
            button3.Margin = new Padding(2, 2, 2, 2);
            button3.Name = "button3";
            button3.Size = new Size(136, 34);
            button3.TabIndex = 8;
            button3.Text = "Agregar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(22, 56, 117);
            panel1.Controls.Add(btn_Report);
            panel1.Controls.Add(btn_Users);
            panel1.Controls.Add(btn_Guards);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 427);
            panel1.TabIndex = 14;
            // 
            // btn_Report
            // 
            btn_Report.Dock = DockStyle.Top;
            btn_Report.FlatAppearance.BorderColor = SystemColors.Desktop;
            btn_Report.FlatStyle = FlatStyle.Flat;
            btn_Report.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Report.ForeColor = Color.White;
            btn_Report.Image = (Image)resources.GetObject("btn_Report.Image");
            btn_Report.ImageAlign = ContentAlignment.MiddleRight;
            btn_Report.Location = new Point(0, 159);
            btn_Report.Margin = new Padding(2, 2, 2, 2);
            btn_Report.Name = "btn_Report";
            btn_Report.Size = new Size(210, 55);
            btn_Report.TabIndex = 3;
            btn_Report.Text = "Reporte";
            btn_Report.TextAlign = ContentAlignment.MiddleLeft;
            btn_Report.UseVisualStyleBackColor = true;
            btn_Report.Click += btn_Report_Click;
            // 
            // btn_Users
            // 
            btn_Users.Dock = DockStyle.Top;
            btn_Users.FlatAppearance.BorderColor = SystemColors.Desktop;
            btn_Users.FlatStyle = FlatStyle.Flat;
            btn_Users.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Users.ForeColor = Color.White;
            btn_Users.Image = (Image)resources.GetObject("btn_Users.Image");
            btn_Users.ImageAlign = ContentAlignment.MiddleRight;
            btn_Users.Location = new Point(0, 104);
            btn_Users.Margin = new Padding(2, 2, 2, 2);
            btn_Users.Name = "btn_Users";
            btn_Users.Size = new Size(210, 55);
            btn_Users.TabIndex = 2;
            btn_Users.Text = "Usuarios";
            btn_Users.TextAlign = ContentAlignment.MiddleLeft;
            btn_Users.UseVisualStyleBackColor = true;
            btn_Users.Click += btn_Users_Click;
            // 
            // btn_Guards
            // 
            btn_Guards.Dock = DockStyle.Top;
            btn_Guards.FlatAppearance.BorderColor = SystemColors.Desktop;
            btn_Guards.FlatStyle = FlatStyle.Flat;
            btn_Guards.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Guards.ForeColor = Color.White;
            btn_Guards.Image = (Image)resources.GetObject("btn_Guards.Image");
            btn_Guards.ImageAlign = ContentAlignment.MiddleRight;
            btn_Guards.Location = new Point(0, 49);
            btn_Guards.Margin = new Padding(2, 2, 2, 2);
            btn_Guards.Name = "btn_Guards";
            btn_Guards.Size = new Size(210, 55);
            btn_Guards.TabIndex = 1;
            btn_Guards.Text = "Guardias";
            btn_Guards.TextAlign = ContentAlignment.MiddleLeft;
            btn_Guards.UseVisualStyleBackColor = true;
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
            panel4.TabIndex = 15;
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
            label1.Size = new Size(122, 24);
            label1.TabIndex = 0;
            label1.Text = "GUARDIAS";
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.LightGray;
            btn_delete.FlatAppearance.BorderColor = Color.Black;
            btn_delete.FlatAppearance.BorderSize = 4;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete.Location = new Point(286, 70);
            btn_delete.Margin = new Padding(2, 2, 2, 2);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(111, 39);
            btn_delete.TabIndex = 16;
            btn_delete.Text = "Eliminar";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(228, 75);
            pictureBox4.Margin = new Padding(2, 2, 2, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(54, 29);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(736, 75);
            pictureBox5.Margin = new Padding(2, 2, 2, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(54, 29);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 18;
            pictureBox5.TabStop = false;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.LightGray;
            btn_update.FlatAppearance.BorderColor = Color.Black;
            btn_update.FlatAppearance.BorderSize = 4;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_update.Location = new Point(827, 179);
            btn_update.Margin = new Padding(2, 2, 2, 2);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(106, 34);
            btn_update.TabIndex = 28;
            btn_update.Text = "Actualizar";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.FromArgb(95, 130, 194);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { telefonoDataGridViewTextBoxColumn, claveDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, correoDataGridViewTextBoxColumn, domicilioDataGridViewTextBoxColumn, usuarioDataGridViewTextBoxColumn, idDataGridViewTextBoxColumn, uidDataGridViewTextBoxColumn });
            dataGridView1.DataSource = guardiasBindingSource;
            dataGridView1.Location = new Point(212, 217);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(729, 211);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            telefonoDataGridViewTextBoxColumn.MinimumWidth = 8;
            telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            telefonoDataGridViewTextBoxColumn.Width = 150;
            // 
            // claveDataGridViewTextBoxColumn
            // 
            claveDataGridViewTextBoxColumn.DataPropertyName = "Clave";
            claveDataGridViewTextBoxColumn.HeaderText = "Clave";
            claveDataGridViewTextBoxColumn.MinimumWidth = 8;
            claveDataGridViewTextBoxColumn.Name = "claveDataGridViewTextBoxColumn";
            claveDataGridViewTextBoxColumn.ReadOnly = true;
            claveDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.MinimumWidth = 8;
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            nombreDataGridViewTextBoxColumn.Width = 150;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            correoDataGridViewTextBoxColumn.DataPropertyName = "Correo";
            correoDataGridViewTextBoxColumn.HeaderText = "Correo";
            correoDataGridViewTextBoxColumn.MinimumWidth = 8;
            correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            correoDataGridViewTextBoxColumn.ReadOnly = true;
            correoDataGridViewTextBoxColumn.Width = 150;
            // 
            // domicilioDataGridViewTextBoxColumn
            // 
            domicilioDataGridViewTextBoxColumn.DataPropertyName = "Domicilio";
            domicilioDataGridViewTextBoxColumn.HeaderText = "Domicilio";
            domicilioDataGridViewTextBoxColumn.MinimumWidth = 8;
            domicilioDataGridViewTextBoxColumn.Name = "domicilioDataGridViewTextBoxColumn";
            domicilioDataGridViewTextBoxColumn.ReadOnly = true;
            domicilioDataGridViewTextBoxColumn.Width = 150;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            usuarioDataGridViewTextBoxColumn.MinimumWidth = 8;
            usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            usuarioDataGridViewTextBoxColumn.Width = 150;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 8;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 150;
            // 
            // uidDataGridViewTextBoxColumn
            // 
            uidDataGridViewTextBoxColumn.DataPropertyName = "Uid";
            uidDataGridViewTextBoxColumn.HeaderText = "Uid";
            uidDataGridViewTextBoxColumn.MinimumWidth = 8;
            uidDataGridViewTextBoxColumn.Name = "uidDataGridViewTextBoxColumn";
            uidDataGridViewTextBoxColumn.ReadOnly = true;
            uidDataGridViewTextBoxColumn.Width = 150;
            // 
            // guardiasBindingSource
            // 
            guardiasBindingSource.DataSource = typeof(INTERFAZ_PC.Models.Guardia);
            // 
            // Guards
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(153, 167, 194);
            ClientSize = new Size(941, 427);
            Controls.Add(btn_update);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(btn_delete);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(panel3);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Guards";
            Text = "Guards";
            Load += Guards_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)guardiasBindingSource).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private Panel panel3;
        private TextBox txt_searcher;
        private Button btn_search;
        private Button button3;
        private Panel panel1;
        private Button btn_Report;
        private Button btn_Users;
        private Button btn_Guards;
        private Panel panel2;
        private Panel panel4;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label label4;
        private Label label3;
        private Button btn_delete;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Button btn_update;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn claveDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn domicilioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn uidDataGridViewTextBoxColumn;
        private BindingSource guardiasBindingSource;
    }
}