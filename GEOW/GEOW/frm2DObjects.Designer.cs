namespace GEOW
{
    partial class frm2DObjects
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm2DObjects));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.picOut = new System.Windows.Forms.PictureBox();
            this.cmdConsultas = new System.Windows.Forms.Button();
            this.cmdGrabar = new System.Windows.Forms.Button();
            this.lblGrabando = new System.Windows.Forms.Label();
            this.panelControlDireccion = new System.Windows.Forms.Panel();
            this.picClosePanel = new System.Windows.Forms.PictureBox();
            this.cmdIzquierda = new System.Windows.Forms.Button();
            this.cmdDerecha = new System.Windows.Forms.Button();
            this.cmdAbajo = new System.Windows.Forms.Button();
            this.cmdArriba = new System.Windows.Forms.Button();
            this.cmdEscenarios = new System.Windows.Forms.Button();
            this.chkRelleno = new System.Windows.Forms.CheckBox();
            this.cmdComportamiento = new System.Windows.Forms.Button();
            this.cmdClean = new System.Windows.Forms.Button();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.lblTotalObjetos = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmdColor = new System.Windows.Forms.Button();
            this.cmbDireccion = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmdAddObject = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAlto = new System.Windows.Forms.TextBox();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYInicial = new System.Windows.Forms.TextBox();
            this.txtXInicial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstInfo = new System.Windows.Forms.ListView();
            this.chObjeto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chkCambios = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarVelocidad = new System.Windows.Forms.TrackBar();
            this.chkTraza = new System.Windows.Forms.CheckBox();
            this.timerAnimacion = new System.Windows.Forms.Timer(this.components);
            this.timerEsperaInicial = new System.Windows.Forms.Timer(this.components);
            this.timerObjetos = new System.Windows.Forms.Timer(this.components);
            this.timerCambiosDireccion = new System.Windows.Forms.Timer(this.components);
            this.timerTransferPositions = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOut)).BeginInit();
            this.panelControlDireccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClosePanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVelocidad)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.picOut);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cmdConsultas);
            this.splitContainer1.Panel2.Controls.Add(this.cmdGrabar);
            this.splitContainer1.Panel2.Controls.Add(this.lblGrabando);
            this.splitContainer1.Panel2.Controls.Add(this.panelControlDireccion);
            this.splitContainer1.Panel2.Controls.Add(this.cmdEscenarios);
            this.splitContainer1.Panel2.Controls.Add(this.chkRelleno);
            this.splitContainer1.Panel2.Controls.Add(this.cmdComportamiento);
            this.splitContainer1.Panel2.Controls.Add(this.cmdClean);
            this.splitContainer1.Panel2.Controls.Add(this.chkActivo);
            this.splitContainer1.Panel2.Controls.Add(this.lblTotalObjetos);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.txtCantidad);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.txtNombre);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.cmdColor);
            this.splitContainer1.Panel2.Controls.Add(this.cmbDireccion);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.cmdAddObject);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.txtAlto);
            this.splitContainer1.Panel2.Controls.Add(this.txtAncho);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.txtColor);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.txtYInicial);
            this.splitContainer1.Panel2.Controls.Add(this.txtXInicial);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.lstInfo);
            this.splitContainer1.Panel2.Controls.Add(this.chkCambios);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.trackBarVelocidad);
            this.splitContainer1.Panel2.Controls.Add(this.chkTraza);
            this.splitContainer1.Size = new System.Drawing.Size(1477, 1007);
            this.splitContainer1.SplitterDistance = 1114;
            this.splitContainer1.TabIndex = 0;
            // 
            // picOut
            // 
            this.picOut.BackColor = System.Drawing.Color.White;
            this.picOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picOut.Location = new System.Drawing.Point(0, 0);
            this.picOut.Name = "picOut";
            this.picOut.Size = new System.Drawing.Size(1114, 1007);
            this.picOut.TabIndex = 1;
            this.picOut.TabStop = false;
            // 
            // cmdConsultas
            // 
            this.cmdConsultas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdConsultas.Location = new System.Drawing.Point(252, 785);
            this.cmdConsultas.Name = "cmdConsultas";
            this.cmdConsultas.Size = new System.Drawing.Size(95, 34);
            this.cmdConsultas.TabIndex = 50;
            this.cmdConsultas.Text = "Consultas";
            this.cmdConsultas.UseVisualStyleBackColor = true;
            this.cmdConsultas.Click += new System.EventHandler(this.cmdConsultas_Click);
            // 
            // cmdGrabar
            // 
            this.cmdGrabar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdGrabar.Location = new System.Drawing.Point(252, 705);
            this.cmdGrabar.Name = "cmdGrabar";
            this.cmdGrabar.Size = new System.Drawing.Size(95, 34);
            this.cmdGrabar.TabIndex = 49;
            this.cmdGrabar.Text = "Inicia grabación";
            this.cmdGrabar.UseVisualStyleBackColor = true;
            this.cmdGrabar.Click += new System.EventHandler(this.cmdGrabar_Click);
            // 
            // lblGrabando
            // 
            this.lblGrabando.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGrabando.AutoSize = true;
            this.lblGrabando.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrabando.ForeColor = System.Drawing.Color.Red;
            this.lblGrabando.Location = new System.Drawing.Point(255, 0);
            this.lblGrabando.Name = "lblGrabando";
            this.lblGrabando.Size = new System.Drawing.Size(101, 18);
            this.lblGrabando.TabIndex = 48;
            this.lblGrabando.Text = "GRABANDO";
            this.lblGrabando.Visible = false;
            // 
            // panelControlDireccion
            // 
            this.panelControlDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControlDireccion.Controls.Add(this.picClosePanel);
            this.panelControlDireccion.Controls.Add(this.cmdIzquierda);
            this.panelControlDireccion.Controls.Add(this.cmdDerecha);
            this.panelControlDireccion.Controls.Add(this.cmdAbajo);
            this.panelControlDireccion.Controls.Add(this.cmdArriba);
            this.panelControlDireccion.Location = new System.Drawing.Point(39, 875);
            this.panelControlDireccion.Name = "panelControlDireccion";
            this.panelControlDireccion.Size = new System.Drawing.Size(265, 110);
            this.panelControlDireccion.TabIndex = 47;
            this.panelControlDireccion.Visible = false;
            // 
            // picClosePanel
            // 
            this.picClosePanel.BackColor = System.Drawing.Color.Transparent;
            this.picClosePanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClosePanel.Image = ((System.Drawing.Image)(resources.GetObject("picClosePanel.Image")));
            this.picClosePanel.Location = new System.Drawing.Point(242, 3);
            this.picClosePanel.Name = "picClosePanel";
            this.picClosePanel.Size = new System.Drawing.Size(20, 20);
            this.picClosePanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picClosePanel.TabIndex = 21;
            this.picClosePanel.TabStop = false;
            this.picClosePanel.Click += new System.EventHandler(this.picClosePanel_Click);
            // 
            // cmdIzquierda
            // 
            this.cmdIzquierda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdIzquierda.Location = new System.Drawing.Point(48, 42);
            this.cmdIzquierda.Name = "cmdIzquierda";
            this.cmdIzquierda.Size = new System.Drawing.Size(55, 34);
            this.cmdIzquierda.TabIndex = 18;
            this.cmdIzquierda.Text = "<-";
            this.cmdIzquierda.UseVisualStyleBackColor = true;
            this.cmdIzquierda.Click += new System.EventHandler(this.cmdIzquierda_Click);
            // 
            // cmdDerecha
            // 
            this.cmdDerecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdDerecha.Location = new System.Drawing.Point(170, 42);
            this.cmdDerecha.Name = "cmdDerecha";
            this.cmdDerecha.Size = new System.Drawing.Size(55, 34);
            this.cmdDerecha.TabIndex = 19;
            this.cmdDerecha.Text = "->";
            this.cmdDerecha.UseVisualStyleBackColor = true;
            this.cmdDerecha.Click += new System.EventHandler(this.cmdDerecha_Click);
            // 
            // cmdAbajo
            // 
            this.cmdAbajo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdAbajo.Location = new System.Drawing.Point(109, 67);
            this.cmdAbajo.Name = "cmdAbajo";
            this.cmdAbajo.Size = new System.Drawing.Size(55, 34);
            this.cmdAbajo.TabIndex = 20;
            this.cmdAbajo.Text = "DWN";
            this.cmdAbajo.UseVisualStyleBackColor = true;
            this.cmdAbajo.Click += new System.EventHandler(this.cmdAbajo_Click);
            // 
            // cmdArriba
            // 
            this.cmdArriba.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdArriba.Location = new System.Drawing.Point(109, 27);
            this.cmdArriba.Name = "cmdArriba";
            this.cmdArriba.Size = new System.Drawing.Size(55, 34);
            this.cmdArriba.TabIndex = 17;
            this.cmdArriba.Text = "UP";
            this.cmdArriba.UseVisualStyleBackColor = true;
            this.cmdArriba.Click += new System.EventHandler(this.cmdArriba_Click);
            // 
            // cmdEscenarios
            // 
            this.cmdEscenarios.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdEscenarios.Location = new System.Drawing.Point(252, 665);
            this.cmdEscenarios.Name = "cmdEscenarios";
            this.cmdEscenarios.Size = new System.Drawing.Size(95, 34);
            this.cmdEscenarios.TabIndex = 15;
            this.cmdEscenarios.Text = "Carga escenario";
            this.cmdEscenarios.UseVisualStyleBackColor = true;
            this.cmdEscenarios.Click += new System.EventHandler(this.cmdEscenarios_Click);
            // 
            // chkRelleno
            // 
            this.chkRelleno.AutoSize = true;
            this.chkRelleno.Location = new System.Drawing.Point(128, 762);
            this.chkRelleno.Name = "chkRelleno";
            this.chkRelleno.Size = new System.Drawing.Size(62, 17);
            this.chkRelleno.TabIndex = 12;
            this.chkRelleno.Text = "Relleno";
            this.chkRelleno.UseVisualStyleBackColor = true;
            // 
            // cmdComportamiento
            // 
            this.cmdComportamiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdComportamiento.Location = new System.Drawing.Point(252, 825);
            this.cmdComportamiento.Name = "cmdComportamiento";
            this.cmdComportamiento.Size = new System.Drawing.Size(95, 34);
            this.cmdComportamiento.TabIndex = 16;
            this.cmdComportamiento.Text = "Comportamiento";
            this.cmdComportamiento.UseVisualStyleBackColor = true;
            this.cmdComportamiento.Visible = false;
            // 
            // cmdClean
            // 
            this.cmdClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClean.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmdClean.Location = new System.Drawing.Point(252, 745);
            this.cmdClean.Name = "cmdClean";
            this.cmdClean.Size = new System.Drawing.Size(95, 34);
            this.cmdClean.TabIndex = 13;
            this.cmdClean.Text = "Elimina objetos";
            this.cmdClean.UseVisualStyleBackColor = true;
            this.cmdClean.Click += new System.EventHandler(this.cmdClean_Click);
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(16, 12);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(56, 17);
            this.chkActivo.TabIndex = 0;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            this.chkActivo.CheckedChanged += new System.EventHandler(this.chkActivo_CheckedChanged);
            // 
            // lblTotalObjetos
            // 
            this.lblTotalObjetos.AutoSize = true;
            this.lblTotalObjetos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalObjetos.ForeColor = System.Drawing.Color.Maroon;
            this.lblTotalObjetos.Location = new System.Drawing.Point(174, 12);
            this.lblTotalObjetos.Name = "lblTotalObjetos";
            this.lblTotalObjetos.Size = new System.Drawing.Size(14, 13);
            this.lblTotalObjetos.TabIndex = 41;
            this.lblTotalObjetos.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(95, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Total objetos:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(65, 759);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(46, 20);
            this.txtCantidad.TabIndex = 11;
            this.txtCantidad.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 762);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Cantidad";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(65, 625);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(156, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 628);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Nombre";
            // 
            // cmdColor
            // 
            this.cmdColor.Location = new System.Drawing.Point(175, 706);
            this.cmdColor.Name = "cmdColor";
            this.cmdColor.Size = new System.Drawing.Size(46, 20);
            this.cmdColor.TabIndex = 9;
            this.cmdColor.Text = "...";
            this.cmdColor.UseVisualStyleBackColor = true;
            this.cmdColor.Click += new System.EventHandler(this.cmdColor_Click);
            // 
            // cmbDireccion
            // 
            this.cmbDireccion.FormattingEnabled = true;
            this.cmbDireccion.Items.AddRange(new object[] {
            "Arriba",
            "Abajo",
            "Izquierda",
            "Derecha"});
            this.cmbDireccion.Location = new System.Drawing.Point(65, 732);
            this.cmbDireccion.Name = "cmbDireccion";
            this.cmbDireccion.Size = new System.Drawing.Size(156, 21);
            this.cmbDireccion.TabIndex = 10;
            this.cmbDireccion.Text = "Derecha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 735);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Dirección";
            // 
            // cmdAddObject
            // 
            this.cmdAddObject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdAddObject.Location = new System.Drawing.Point(252, 625);
            this.cmdAddObject.Name = "cmdAddObject";
            this.cmdAddObject.Size = new System.Drawing.Size(95, 34);
            this.cmdAddObject.TabIndex = 14;
            this.cmdAddObject.Text = "Añade objetos";
            this.cmdAddObject.UseVisualStyleBackColor = true;
            this.cmdAddObject.Click += new System.EventHandler(this.cmdAddObject_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 680);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Alto";
            // 
            // txtAlto
            // 
            this.txtAlto.Location = new System.Drawing.Point(175, 677);
            this.txtAlto.Name = "txtAlto";
            this.txtAlto.Size = new System.Drawing.Size(46, 20);
            this.txtAlto.TabIndex = 8;
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(65, 677);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(46, 20);
            this.txtAncho.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 680);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Ancho";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(65, 706);
            this.txtColor.Name = "txtColor";
            this.txtColor.ReadOnly = true;
            this.txtColor.Size = new System.Drawing.Size(104, 20);
            this.txtColor.TabIndex = 30;
            this.txtColor.TabStop = false;
            this.txtColor.Text = "Black";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 709);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Color";
            // 
            // txtYInicial
            // 
            this.txtYInicial.Location = new System.Drawing.Point(175, 651);
            this.txtYInicial.Name = "txtYInicial";
            this.txtYInicial.Size = new System.Drawing.Size(46, 20);
            this.txtYInicial.TabIndex = 6;
            this.txtYInicial.Text = "10";
            // 
            // txtXInicial
            // 
            this.txtXInicial.Location = new System.Drawing.Point(65, 651);
            this.txtXInicial.Name = "txtXInicial";
            this.txtXInicial.Size = new System.Drawing.Size(46, 20);
            this.txtXInicial.TabIndex = 5;
            this.txtXInicial.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 654);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Y Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 654);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "X Inicial";
            // 
            // lstInfo
            // 
            this.lstInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstInfo.BackColor = System.Drawing.SystemColors.Control;
            this.lstInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chObjeto,
            this.chX,
            this.chY});
            this.lstInfo.HideSelection = false;
            this.lstInfo.Location = new System.Drawing.Point(16, 133);
            this.lstInfo.Name = "lstInfo";
            this.lstInfo.Size = new System.Drawing.Size(335, 468);
            this.lstInfo.TabIndex = 12;
            this.lstInfo.TabStop = false;
            this.lstInfo.UseCompatibleStateImageBehavior = false;
            this.lstInfo.View = System.Windows.Forms.View.Details;
            this.lstInfo.SelectedIndexChanged += new System.EventHandler(this.lstInfo_SelectedIndexChanged);
            // 
            // chObjeto
            // 
            this.chObjeto.Text = "Obj";
            this.chObjeto.Width = 180;
            // 
            // chX
            // 
            this.chX.Text = "X";
            // 
            // chY
            // 
            this.chY.Text = "Y";
            // 
            // chkCambios
            // 
            this.chkCambios.AutoSize = true;
            this.chkCambios.Location = new System.Drawing.Point(98, 35);
            this.chkCambios.Name = "chkCambios";
            this.chkCambios.Size = new System.Drawing.Size(127, 17);
            this.chkCambios.TabIndex = 2;
            this.chkCambios.Text = "Cambios de dirección";
            this.chkCambios.UseVisualStyleBackColor = true;
            this.chkCambios.CheckedChanged += new System.EventHandler(this.chkCambios_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Velocidad";
            // 
            // trackBarVelocidad
            // 
            this.trackBarVelocidad.Location = new System.Drawing.Point(14, 82);
            this.trackBarVelocidad.Maximum = 300;
            this.trackBarVelocidad.Minimum = 40;
            this.trackBarVelocidad.Name = "trackBarVelocidad";
            this.trackBarVelocidad.Size = new System.Drawing.Size(254, 45);
            this.trackBarVelocidad.TabIndex = 3;
            this.trackBarVelocidad.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarVelocidad.Value = 100;
            this.trackBarVelocidad.Scroll += new System.EventHandler(this.trackBarVelocidad_Scroll);
            // 
            // chkTraza
            // 
            this.chkTraza.AutoSize = true;
            this.chkTraza.Checked = true;
            this.chkTraza.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTraza.Location = new System.Drawing.Point(16, 35);
            this.chkTraza.Name = "chkTraza";
            this.chkTraza.Size = new System.Drawing.Size(53, 17);
            this.chkTraza.TabIndex = 1;
            this.chkTraza.Text = "Traza";
            this.chkTraza.UseVisualStyleBackColor = true;
            this.chkTraza.CheckedChanged += new System.EventHandler(this.chkTraza_CheckedChanged);
            // 
            // timerAnimacion
            // 
            this.timerAnimacion.Interval = 300;
            this.timerAnimacion.Tick += new System.EventHandler(this.timerAnimacion_Tick);
            // 
            // timerEsperaInicial
            // 
            this.timerEsperaInicial.Enabled = true;
            this.timerEsperaInicial.Interval = 2000;
            // 
            // timerObjetos
            // 
            this.timerObjetos.Interval = 500;
            this.timerObjetos.Tick += new System.EventHandler(this.timerObjetos_Tick);
            // 
            // timerCambiosDireccion
            // 
            this.timerCambiosDireccion.Interval = 1000;
            this.timerCambiosDireccion.Tick += new System.EventHandler(this.timerCambios_Tick);
            // 
            // timerTransferPositions
            // 
            this.timerTransferPositions.Enabled = true;
            this.timerTransferPositions.Interval = 30000;
            this.timerTransferPositions.Tick += new System.EventHandler(this.timerTransferPositions_Tick);
            // 
            // frm2DObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 1007);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frm2DObjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2D Scenes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm2DObjects_FormClosing);
            this.Load += new System.EventHandler(this.frm2DObjects_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm2DObjects_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picOut)).EndInit();
            this.panelControlDireccion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picClosePanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVelocidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox picOut;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cmdColor;
        private System.Windows.Forms.ComboBox cmbDireccion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cmdAddObject;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAlto;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYInicial;
        private System.Windows.Forms.TextBox txtXInicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstInfo;
        private System.Windows.Forms.CheckBox chkCambios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarVelocidad;
        private System.Windows.Forms.CheckBox chkTraza;
        private System.Windows.Forms.Timer timerAnimacion;
        private System.Windows.Forms.Timer timerEsperaInicial;
        private System.Windows.Forms.Timer timerObjetos;
        private System.Windows.Forms.Timer timerCambiosDireccion;
        private System.Windows.Forms.ColumnHeader chObjeto;
        private System.Windows.Forms.ColumnHeader chX;
        private System.Windows.Forms.ColumnHeader chY;
        private System.Windows.Forms.Label lblTotalObjetos;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cmdClean;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Button cmdComportamiento;
        private System.Windows.Forms.CheckBox chkRelleno;
        private System.Windows.Forms.Panel panelControlDireccion;
        private System.Windows.Forms.Button cmdIzquierda;
        private System.Windows.Forms.Button cmdDerecha;
        private System.Windows.Forms.Button cmdAbajo;
        private System.Windows.Forms.Button cmdArriba;
        private System.Windows.Forms.Button cmdEscenarios;
        private System.Windows.Forms.PictureBox picClosePanel;
        private System.Windows.Forms.Label lblGrabando;
        private System.Windows.Forms.Button cmdGrabar;
        private System.Windows.Forms.Timer timerTransferPositions;
        private System.Windows.Forms.Button cmdConsultas;
    }
}

