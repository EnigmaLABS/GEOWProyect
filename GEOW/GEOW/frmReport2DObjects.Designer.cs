namespace GEOW
{
    partial class frmReport2DObjects
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
            this.components = new System.ComponentModel.Container();
            this.lstTrayectos = new System.Windows.Forms.ListView();
            this.chInicio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNumObjetos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCoordenadas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTrayectos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblObjetos = new System.Windows.Forms.Label();
            this.lstObjetos = new System.Windows.Forms.ListView();
            this.chObjeto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAlto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAncho = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTotalCoordenadas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.lstCoordenadas = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timerTrayectos = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lstTrayectos
            // 
            this.lstTrayectos.BackColor = System.Drawing.SystemColors.Control;
            this.lstTrayectos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstTrayectos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chInicio,
            this.chNumObjetos,
            this.chCoordenadas});
            this.lstTrayectos.FullRowSelect = true;
            this.lstTrayectos.HideSelection = false;
            this.lstTrayectos.Location = new System.Drawing.Point(12, 48);
            this.lstTrayectos.Name = "lstTrayectos";
            this.lstTrayectos.Size = new System.Drawing.Size(677, 355);
            this.lstTrayectos.TabIndex = 0;
            this.lstTrayectos.UseCompatibleStateImageBehavior = false;
            this.lstTrayectos.View = System.Windows.Forms.View.Details;
            this.lstTrayectos.SelectedIndexChanged += new System.EventHandler(this.lstTrayectos_SelectedIndexChanged);
            // 
            // chInicio
            // 
            this.chInicio.Text = "Inicio";
            this.chInicio.Width = 140;
            // 
            // chNumObjetos
            // 
            this.chNumObjetos.Text = "Objetos";
            this.chNumObjetos.Width = 140;
            // 
            // chCoordenadas
            // 
            this.chCoordenadas.Text = "Total coordenadas";
            this.chCoordenadas.Width = 150;
            // 
            // lblTrayectos
            // 
            this.lblTrayectos.AutoSize = true;
            this.lblTrayectos.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrayectos.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTrayectos.Location = new System.Drawing.Point(12, 9);
            this.lblTrayectos.Name = "lblTrayectos";
            this.lblTrayectos.Size = new System.Drawing.Size(206, 36);
            this.lblTrayectos.TabIndex = 1;
            this.lblTrayectos.Text = "Trayectos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(719, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Totales";
            // 
            // lblObjetos
            // 
            this.lblObjetos.AutoSize = true;
            this.lblObjetos.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjetos.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblObjetos.Location = new System.Drawing.Point(12, 406);
            this.lblObjetos.Name = "lblObjetos";
            this.lblObjetos.Size = new System.Drawing.Size(156, 36);
            this.lblObjetos.TabIndex = 3;
            this.lblObjetos.Text = "Objetos";
            // 
            // lstObjetos
            // 
            this.lstObjetos.BackColor = System.Drawing.SystemColors.Control;
            this.lstObjetos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstObjetos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chObjeto,
            this.chColor,
            this.chAlto,
            this.chAncho,
            this.chTotalCoordenadas});
            this.lstObjetos.FullRowSelect = true;
            this.lstObjetos.HideSelection = false;
            this.lstObjetos.Location = new System.Drawing.Point(18, 445);
            this.lstObjetos.Name = "lstObjetos";
            this.lstObjetos.Size = new System.Drawing.Size(677, 362);
            this.lstObjetos.TabIndex = 4;
            this.lstObjetos.UseCompatibleStateImageBehavior = false;
            this.lstObjetos.View = System.Windows.Forms.View.Details;
            // 
            // chObjeto
            // 
            this.chObjeto.Text = "Desc.";
            this.chObjeto.Width = 140;
            // 
            // chColor
            // 
            this.chColor.Text = "Color";
            this.chColor.Width = 100;
            // 
            // chAlto
            // 
            this.chAlto.Text = "Alto";
            this.chAlto.Width = 70;
            // 
            // chAncho
            // 
            this.chAncho.Text = "Ancho";
            this.chAncho.Width = 70;
            // 
            // chTotalCoordenadas
            // 
            this.chTotalCoordenadas.Text = "Coordenadas";
            this.chTotalCoordenadas.Width = 100;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(719, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "Coordenadas";
            // 
            // lstCoordenadas
            // 
            this.lstCoordenadas.BackColor = System.Drawing.SystemColors.Control;
            this.lstCoordenadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstCoordenadas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstCoordenadas.HideSelection = false;
            this.lstCoordenadas.Location = new System.Drawing.Point(725, 445);
            this.lstCoordenadas.Name = "lstCoordenadas";
            this.lstCoordenadas.Size = new System.Drawing.Size(677, 362);
            this.lstCoordenadas.TabIndex = 6;
            this.lstCoordenadas.UseCompatibleStateImageBehavior = false;
            this.lstCoordenadas.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Inicio";
            this.columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Objetos";
            this.columnHeader5.Width = 140;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Total coordenadas";
            this.columnHeader6.Width = 150;
            // 
            // timerTrayectos
            // 
            this.timerTrayectos.Interval = 15000;
            this.timerTrayectos.Tick += new System.EventHandler(this.timerTrayectos_Tick);
            // 
            // frmReport2DObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 819);
            this.Controls.Add(this.lstCoordenadas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstObjetos);
            this.Controls.Add(this.lblObjetos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTrayectos);
            this.Controls.Add(this.lstTrayectos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmReport2DObjects";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2DObjects Report";
            this.Load += new System.EventHandler(this.frmReport2DObjects_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstTrayectos;
        private System.Windows.Forms.Label lblTrayectos;
        private System.Windows.Forms.ColumnHeader chInicio;
        private System.Windows.Forms.ColumnHeader chNumObjetos;
        private System.Windows.Forms.ColumnHeader chCoordenadas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblObjetos;
        private System.Windows.Forms.ListView lstObjetos;
        private System.Windows.Forms.ColumnHeader chObjeto;
        private System.Windows.Forms.ColumnHeader chColor;
        private System.Windows.Forms.ColumnHeader chAlto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lstCoordenadas;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader chAncho;
        private System.Windows.Forms.ColumnHeader chTotalCoordenadas;
        private System.Windows.Forms.Timer timerTrayectos;
    }
}