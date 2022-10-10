namespace Ticketek
{
    partial class FrmCompraEntrada
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
            this.cboShows = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cboUbicacion = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboShows
            // 
            this.cboShows.FormattingEnabled = true;
            this.cboShows.Location = new System.Drawing.Point(37, 29);
            this.cboShows.Name = "cboShows";
            this.cboShows.Size = new System.Drawing.Size(286, 23);
            this.cboShows.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboUbicacion
            // 
            this.cboUbicacion.FormattingEnabled = true;
            this.cboUbicacion.Location = new System.Drawing.Point(37, 96);
            this.cboUbicacion.Name = "cboUbicacion";
            this.cboUbicacion.Size = new System.Drawing.Size(286, 23);
            this.cboUbicacion.TabIndex = 2;
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(37, 163);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(286, 23);
            this.cboCategoria.TabIndex = 3;
            // 
            // FrmCompraEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 308);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboUbicacion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboShows);
            this.Name = "FrmCompraEntrada";
            this.Text = "FrmCompraEntrada";
            this.Load += new System.EventHandler(this.FrmCompraEntrada_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cboShows;
        private Button button1;
        private ComboBox cboUbicacion;
        private ComboBox cboCategoria;
    }
}