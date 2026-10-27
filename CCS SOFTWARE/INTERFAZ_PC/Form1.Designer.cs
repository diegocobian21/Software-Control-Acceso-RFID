namespace INTERFAZ_PC
{
    partial class load_screen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Loading = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(99)))), ((int)(((byte)(168)))));
            this.panel1.Controls.Add(this.Loading);
            this.panel1.Location = new System.Drawing.Point(1, 718);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1260, 50);
            this.panel1.TabIndex = 0;
            // 
            // Loading
            // 
            this.Loading.AutoSize = true;
            this.Loading.BackColor = System.Drawing.Color.Transparent;
            this.Loading.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Loading.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Loading.Location = new System.Drawing.Point(546, 5);
            this.Loading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Loading.Name = "Loading";
            this.Loading.Size = new System.Drawing.Size(227, 39);
            this.Loading.TabIndex = 0;
            this.Loading.Text = "CARGANDO....";
            this.Loading.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // load_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::INTERFAZ_PC.Properties.Resources.LOAD_SCREEN1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1263, 768);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "load_screen";
            this.Text = "Pantalla de carga";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.load_screen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label Loading;
    }
}