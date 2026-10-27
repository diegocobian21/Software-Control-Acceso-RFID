namespace INTERFAZ_PC
{
    partial class StartProgram
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
            timer1 = new System.Windows.Forms.Timer(components);
            progressBar1 = new ProgressBar();
            Loading = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10000;
            timer1.Tick += timer1_Tick;
            // 
            // progressBar1
            // 
            progressBar1.Cursor = Cursors.AppStarting;
            progressBar1.Location = new Point(-1, 439);
            progressBar1.Margin = new Padding(2, 2, 2, 2);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(886, 23);
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.TabIndex = 2;
            progressBar1.Click += progressBar1_Click;
            // 
            // Loading
            // 
            Loading.AutoSize = true;
            Loading.BackColor = Color.Transparent;
            Loading.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Loading.ForeColor = SystemColors.ButtonHighlight;
            Loading.Location = new Point(380, 414);
            Loading.Name = "Loading";
            Loading.Size = new Size(148, 26);
            Loading.TabIndex = 0;
            Loading.Text = "CARGANDO....";
            Loading.TextAlign = ContentAlignment.BottomCenter;
            // 
            // StartProgram
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.LOAD_SCREEN2;
            ClientSize = new Size(884, 461);
            Controls.Add(Loading);
            Controls.Add(progressBar1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "StartProgram";
            Text = "StartProgram";
            Load += StartProgram_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private ProgressBar progressBar1;
        private Label Loading;
    }
}