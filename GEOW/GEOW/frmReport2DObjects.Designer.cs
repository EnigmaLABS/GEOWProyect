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
            this.lblCoordenadas = new System.Windows.Forms.Label();
            this.lstCoordenadas = new System.Windows.Forms.ListView();
            this.chFechaCoord = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timerTrayectos = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalFiguras = new System.Windows.Forms.Label();
            this.lblPromedio1 = new System.Windows.Forms.Label();
            this.lblPromedio2 = new System.Windows.Forms.Label();
            this.lblTotalCoordenadas = new System.Windows.Forms.Label();
            this.timerTotales = new System.Windows.Forms.Timer(this.components);
            this.lblVelocidad = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.lstObjetos.SelectedIndexChanged += new System.EventHandler(this.lstObjetos_SelectedIndexChanged);
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
            // lblCoordenadas
            // 
            this.lblCoordenadas.AutoSize = true;
            this.lblCoordenadas.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoordenadas.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblCoordenadas.Location = new System.Drawing.Point(719, 406);
            this.lblCoordenadas.Name = "lblCoordenadas";
            this.lblCoordenadas.Size = new System.Drawing.Size(243, 36);
            this.lblCoordenadas.TabIndex = 5;
            this.lblCoordenadas.Text = "Coordenadas";
            // 
            // lstCoordenadas
            // 
            this.lstCoordenadas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstCoordenadas.BackColor = System.Drawing.SystemColors.Control;
            this.lstCoordenadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstCoordenadas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chFechaCoord,
            this.chX,
            this.chY});
            this.lstCoordenadas.FullRowSelect = true;
            this.lstCoordenadas.HideSelection = false;
            this.lstCoordenadas.Location = new System.Drawing.Point(725, 445);
            this.lstCoordenadas.Name = "lstCoordenadas";
            this.lstCoordenadas.Size = new System.Drawing.Size(657, 362);
            this.lstCoordenadas.TabIndex = 6;
            this.lstCoordenadas.UseCompatibleStateImageBehavior = false;
            this.lstCoordenadas.View = System.Windows.Forms.View.Details;
            // 
            // chFechaCoord
            // 
            this.chFechaCoord.Text = "Fecha";
            this.chFechaCoord.Width = 300;
            // 
            // chX
            // 
            this.chX.Text = "X";
            this.chX.Width = 100;
            // 
            // chY
            // 
            this.chY.Text = "Y";
            this.chY.Width = 100;
            // 
            // timerTrayectos
            // 
            this.timerTrayectos.Interval = 5000;
            this.timerTrayectos.Tick += new System.EventHandler(this.timerTrayectos_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(755, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total figuras:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(754, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Promedio coordenadas / figura:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(755, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total coordenadas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(755, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(281, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Promedio coordenadas / trayecto:";
            // 
            // lblTotalFiguras
            // 
            this.lblTotalFiguras.AutoSize = true;
            this.lblTotalFiguras.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFiguras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTotalFiguras.Location = new System.Drawing.Point(1075, 70);
            this.lblTotalFiguras.Name = "lblTotalFiguras";
            this.lblTotalFiguras.Size = new System.Drawing.Size(23, 29);
            this.lblTotalFiguras.TabIndex = 11;
            this.lblTotalFiguras.Text = "0";
            // 
            // lblPromedio1
            // 
            this.lblPromedio1.AutoSize = true;
            this.lblPromedio1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblPromedio1.Location = new System.Drawing.Point(1075, 117);
            this.lblPromedio1.Name = "lblPromedio1";
            this.lblPromedio1.Size = new System.Drawing.Size(23, 29);
            this.lblPromedio1.TabIndex = 12;
            this.lblPromedio1.Text = "0";
            // 
            // lblPromedio2
            // 
            this.lblPromedio2.AutoSize = true;
            this.lblPromedio2.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblPromedio2.Location = new System.Drawing.Point(1075, 168);
            this.lblPromedio2.Name = "lblPromedio2";
            this.lblPromedio2.Size = new System.Drawing.Size(23, 29);
            this.lblPromedio2.TabIndex = 13;
            this.lblPromedio2.Text = "0";
            // 
            // lblTotalCoordenadas
            // 
            this.lblTotalCoordenadas.AutoSize = true;
            this.lblTotalCoordenadas.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCoordenadas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTotalCoordenadas.Location = new System.Drawing.Point(1075, 224);
            this.lblTotalCoordenadas.Name = "lblTotalCoordenadas";
            this.lblTotalCoordenadas.Size = new System.Drawing.Size(23, 29);
            this.lblTotalCoordenadas.TabIndex = 14;
            this.lblTotalCoordenadas.Text = "0";
            // 
            // timerTotales
            // 
            this.timerTotales.Enabled = true;
            this.timerTotales.Interval = 6000;
            this.timerTotales.Tick += new System.EventHandler(this.timerTotales_Tick);
            // 
            // lblVelocidad
            // 
            this.lblVelocidad.AutoSize = true;
            this.lblVelocidad.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVelocidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblVelocidad.Location = new System.Drawing.Point(1075, 279);
            this.lblVelocidad.Name = "lblVelocidad";
            this.lblVelocidad.Size = new System.Drawing.Size(23, 29);
            this.lblVelocidad.TabIndex = 16;
            this.lblVelocidad.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(755, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "Velocidad (coord / seg):";
            // 
            // frmReport2DObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 819);
            this.Controls.Add(this.lblVelocidad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTotalCoordenadas);
            this.Controls.Add(this.lblPromedio2);
            this.Controls.Add(this.lblPromedio1);
            this.Controls.Add(this.lblTotalFiguras);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCoordenadas);
            this.Controls.Add(this.lblCoordenadas);
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
        private System.Windows.Forms.Label lblCoordenadas;
        private System.Windows.Forms.ListView lstCoordenadas;
        private System.Windows.Forms.ColumnHeader chAncho;
        private System.Windows.Forms.ColumnHeader chTotalCoordenadas;
        private System.Windows.Forms.Timer timerTrayectos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalFiguras;
        private System.Windows.Forms.Label lblPromedio1;
        private System.Windows.Forms.Label lblPromedio2;
        private System.Windows.Forms.Label lblTotalCoordenadas;
        private System.Windows.Forms.Timer timerTotales;
        private System.Windows.Forms.Label lblVelocidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader chFechaCoord;
        private System.Windows.Forms.ColumnHeader chX;
        private System.Windows.Forms.ColumnHeader chY;
    }
}