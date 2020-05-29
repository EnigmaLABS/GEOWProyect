namespace GEOW.subforms
{
    partial class frmGetEscenario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGetEscenario));
            this.chkEscernarios = new System.Windows.Forms.CheckedListBox();
            this.picLoadEscenario = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLoadEscenario)).BeginInit();
            this.SuspendLayout();
            // 
            // chkEscernarios
            // 
            this.chkEscernarios.BackColor = System.Drawing.SystemColors.Control;
            this.chkEscernarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chkEscernarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEscernarios.FormattingEnabled = true;
            this.chkEscernarios.Location = new System.Drawing.Point(12, 12);
            this.chkEscernarios.Name = "chkEscernarios";
            this.chkEscernarios.Size = new System.Drawing.Size(475, 285);
            this.chkEscernarios.TabIndex = 0;
            // 
            // picLoadEscenario
            // 
            this.picLoadEscenario.BackColor = System.Drawing.Color.Transparent;
            this.picLoadEscenario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLoadEscenario.Image = ((System.Drawing.Image)(resources.GetObject("picLoadEscenario.Image")));
            this.picLoadEscenario.Location = new System.Drawing.Point(493, 12);
            this.picLoadEscenario.Name = "picLoadEscenario";
            this.picLoadEscenario.Size = new System.Drawing.Size(65, 62);
            this.picLoadEscenario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLoadEscenario.TabIndex = 22;
            this.picLoadEscenario.TabStop = false;
            this.picLoadEscenario.Click += new System.EventHandler(this.picLoadEscenario_Click);
            // 
            // frmGetEscenario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 310);
            this.Controls.Add(this.picLoadEscenario);
            this.Controls.Add(this.chkEscernarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmGetEscenario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Escenarios";
            this.Load += new System.EventHandler(this.frmGetEscenario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLoadEscenario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkEscernarios;
        private System.Windows.Forms.PictureBox picLoadEscenario;
    }
}