namespace editortexto
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BarraDeMenus = new System.Windows.Forms.MenuStrip();
            this.menuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.ArchivoSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoPdfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdicion = new System.Windows.Forms.ToolStripMenuItem();
            this.EdicionCortar = new System.Windows.Forms.ToolStripMenuItem();
            this.EdicionPegar = new System.Windows.Forms.ToolStripMenuItem();
            this.EdicionCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.deshacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpciones = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcionesFuente = new System.Windows.Forms.ToolStripMenuItem();
            this.OpFuCouriernew = new System.Windows.Forms.ToolStripMenuItem();
            this.OpFuArial = new System.Windows.Forms.ToolStripMenuItem();
            this.OpFuPredeterminada = new System.Windows.Forms.ToolStripMenuItem();
            this.OpcionesTam = new System.Windows.Forms.ToolStripMenuItem();
            this.Optam16 = new System.Windows.Forms.ToolStripMenuItem();
            this.OpTam24 = new System.Windows.Forms.ToolStripMenuItem();
            this.OpTamPredeterminado = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFuente = new System.Windows.Forms.ToolStripComboBox();
            this.menuTamanio = new System.Windows.Forms.ToolStripComboBox();
            this.BarraDeEstado = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.BarraDeHerramientas = new System.Windows.Forms.ToolStrip();
            this.btnbarAbrir = new System.Windows.Forms.ToolStripButton();
            this.btnbarGuardarword = new System.Windows.Forms.ToolStripButton();
            this.btnbarGuardarpdf = new System.Windows.Forms.ToolStripButton();
            this.btnbarGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnbarDeshacer = new System.Windows.Forms.ToolStripButton();
            this.btnbarCortar = new System.Windows.Forms.ToolStripButton();
            this.btnbarCopiar = new System.Windows.Forms.ToolStripButton();
            this.btnbarPegar = new System.Windows.Forms.ToolStripButton();
            this.ctEditor = new System.Windows.Forms.TextBox();
            this.BarraDeMenus.SuspendLayout();
            this.BarraDeEstado.SuspendLayout();
            this.BarraDeHerramientas.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraDeMenus
            // 
            this.BarraDeMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivo,
            this.menuEdicion,
            this.menuOpciones,
            this.menuFuente,
            this.menuTamanio});
            this.BarraDeMenus.Location = new System.Drawing.Point(0, 0);
            this.BarraDeMenus.Name = "BarraDeMenus";
            this.BarraDeMenus.Size = new System.Drawing.Size(626, 27);
            this.BarraDeMenus.TabIndex = 0;
            this.BarraDeMenus.Text = "menuStrip1";
            // 
            // menuArchivo
            // 
            this.menuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivoSalir,
            this.guardarToolStripMenuItem,
            this.guardarComoPdfToolStripMenuItem});
            this.menuArchivo.Name = "menuArchivo";
            this.menuArchivo.Size = new System.Drawing.Size(60, 23);
            this.menuArchivo.Text = "&Archivo";
            // 
            // ArchivoSalir
            // 
            this.ArchivoSalir.Name = "ArchivoSalir";
            this.ArchivoSalir.Size = new System.Drawing.Size(158, 22);
            this.ArchivoSalir.Text = "&Salir";
            this.ArchivoSalir.Click += new System.EventHandler(this.ArchivoSalir_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // guardarComoPdfToolStripMenuItem
            // 
            this.guardarComoPdfToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pDFToolStripMenuItem,
            this.wordToolStripMenuItem});
            this.guardarComoPdfToolStripMenuItem.Name = "guardarComoPdfToolStripMenuItem";
            this.guardarComoPdfToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.guardarComoPdfToolStripMenuItem.Text = "Guardar como";
            // 
            // pDFToolStripMenuItem
            // 
            this.pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            this.pDFToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.pDFToolStripMenuItem.Text = "PDF";
            this.pDFToolStripMenuItem.Click += new System.EventHandler(this.pDFToolStripMenuItem_Click);
            // 
            // wordToolStripMenuItem
            // 
            this.wordToolStripMenuItem.Name = "wordToolStripMenuItem";
            this.wordToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.wordToolStripMenuItem.Text = "Word";
            this.wordToolStripMenuItem.Click += new System.EventHandler(this.wordToolStripMenuItem_Click);
            // 
            // menuEdicion
            // 
            this.menuEdicion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EdicionCortar,
            this.EdicionPegar,
            this.EdicionCopiar,
            this.deshacerToolStripMenuItem});
            this.menuEdicion.Name = "menuEdicion";
            this.menuEdicion.Size = new System.Drawing.Size(58, 23);
            this.menuEdicion.Text = "&Edicion";
            this.menuEdicion.DropDownOpened += new System.EventHandler(this.menuEdicion_DropDownOpened);
            // 
            // EdicionCortar
            // 
            this.EdicionCortar.Enabled = false;
            this.EdicionCortar.Name = "EdicionCortar";
            this.EdicionCortar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.EdicionCortar.Size = new System.Drawing.Size(163, 22);
            this.EdicionCortar.Text = "Cor&tar";
            this.EdicionCortar.Click += new System.EventHandler(this.EdicionCortar_Click);
            // 
            // EdicionPegar
            // 
            this.EdicionPegar.Name = "EdicionPegar";
            this.EdicionPegar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.EdicionPegar.Size = new System.Drawing.Size(163, 22);
            this.EdicionPegar.Text = "&Pegar";
            this.EdicionPegar.Click += new System.EventHandler(this.EdicionPegar_Click);
            // 
            // EdicionCopiar
            // 
            this.EdicionCopiar.Enabled = false;
            this.EdicionCopiar.Name = "EdicionCopiar";
            this.EdicionCopiar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.EdicionCopiar.Size = new System.Drawing.Size(163, 22);
            this.EdicionCopiar.Text = "&Copiar";
            this.EdicionCopiar.Click += new System.EventHandler(this.EdicionCopiar_Click);
            // 
            // deshacerToolStripMenuItem
            // 
            this.deshacerToolStripMenuItem.Name = "deshacerToolStripMenuItem";
            this.deshacerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.deshacerToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.deshacerToolStripMenuItem.Text = "Deshacer";
            this.deshacerToolStripMenuItem.Click += new System.EventHandler(this.deshacerToolStripMenuItem_Click);
            // 
            // menuOpciones
            // 
            this.menuOpciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpcionesFuente,
            this.OpcionesTam});
            this.menuOpciones.Name = "menuOpciones";
            this.menuOpciones.Size = new System.Drawing.Size(69, 23);
            this.menuOpciones.Text = "&Opciones";
            // 
            // OpcionesFuente
            // 
            this.OpcionesFuente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpFuCouriernew,
            this.OpFuArial,
            this.OpFuPredeterminada});
            this.OpcionesFuente.Name = "OpcionesFuente";
            this.OpcionesFuente.Size = new System.Drawing.Size(118, 22);
            this.OpcionesFuente.Text = "&Fuente";
            // 
            // OpFuCouriernew
            // 
            this.OpFuCouriernew.Name = "OpFuCouriernew";
            this.OpFuCouriernew.Size = new System.Drawing.Size(158, 22);
            this.OpFuCouriernew.Text = "Courier New";
            this.OpFuCouriernew.Click += new System.EventHandler(this.OpFuCouriernew_Click);
            // 
            // OpFuArial
            // 
            this.OpFuArial.Name = "OpFuArial";
            this.OpFuArial.Size = new System.Drawing.Size(158, 22);
            this.OpFuArial.Text = "Arial";
            this.OpFuArial.Click += new System.EventHandler(this.OpFuArial_Click);
            // 
            // OpFuPredeterminada
            // 
            this.OpFuPredeterminada.Checked = true;
            this.OpFuPredeterminada.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OpFuPredeterminada.Name = "OpFuPredeterminada";
            this.OpFuPredeterminada.Size = new System.Drawing.Size(158, 22);
            this.OpFuPredeterminada.Text = "Predeterminada";
            this.OpFuPredeterminada.Click += new System.EventHandler(this.OpFuPredeterminada_Click);
            // 
            // OpcionesTam
            // 
            this.OpcionesTam.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Optam16,
            this.OpTam24,
            this.OpTamPredeterminado});
            this.OpcionesTam.Name = "OpcionesTam";
            this.OpcionesTam.Size = new System.Drawing.Size(118, 22);
            this.OpcionesTam.Text = "&Tamaño";
            // 
            // Optam16
            // 
            this.Optam16.Name = "Optam16";
            this.Optam16.Size = new System.Drawing.Size(159, 22);
            this.Optam16.Text = "16";
            this.Optam16.Click += new System.EventHandler(this.Optam16_Click);
            // 
            // OpTam24
            // 
            this.OpTam24.Name = "OpTam24";
            this.OpTam24.Size = new System.Drawing.Size(159, 22);
            this.OpTam24.Text = "24";
            this.OpTam24.Click += new System.EventHandler(this.OpTam24_Click);
            // 
            // OpTamPredeterminado
            // 
            this.OpTamPredeterminado.Checked = true;
            this.OpTamPredeterminado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.OpTamPredeterminado.Name = "OpTamPredeterminado";
            this.OpTamPredeterminado.Size = new System.Drawing.Size(159, 22);
            this.OpTamPredeterminado.Text = "Predeterminado";
            this.OpTamPredeterminado.Click += new System.EventHandler(this.OpTamPredeterminado_Click);
            // 
            // menuFuente
            // 
            this.menuFuente.Items.AddRange(new object[] {
            "Courier New",
            "Arial",
            "Predeterminada"});
            this.menuFuente.Name = "menuFuente";
            this.menuFuente.Size = new System.Drawing.Size(121, 23);
            this.menuFuente.Text = "Predeterminada";
            this.menuFuente.SelectedIndexChanged += new System.EventHandler(this.menuFuente_SelectedIndexChanged);
            // 
            // menuTamanio
            // 
            this.menuTamanio.Items.AddRange(new object[] {
            "16",
            "24",
            "Predeterminada"});
            this.menuTamanio.Name = "menuTamanio";
            this.menuTamanio.Size = new System.Drawing.Size(121, 23);
            this.menuTamanio.Text = "Predeterminada";
            this.menuTamanio.SelectedIndexChanged += new System.EventHandler(this.menuTamanio_SelectedIndexChanged);
            // 
            // BarraDeEstado
            // 
            this.BarraDeEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.BarraDeEstado.Location = new System.Drawing.Point(0, 385);
            this.BarraDeEstado.Name = "BarraDeEstado";
            this.BarraDeEstado.Size = new System.Drawing.Size(626, 22);
            this.BarraDeEstado.TabIndex = 1;
            this.BarraDeEstado.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(108, 17);
            this.status.Text = "Nuevo Documento";
            // 
            // BarraDeHerramientas
            // 
            this.BarraDeHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnbarAbrir,
            this.btnbarGuardarword,
            this.btnbarGuardarpdf,
            this.btnbarGuardar,
            this.btnbarDeshacer,
            this.btnbarCortar,
            this.btnbarCopiar,
            this.btnbarPegar});
            this.BarraDeHerramientas.Location = new System.Drawing.Point(0, 27);
            this.BarraDeHerramientas.Name = "BarraDeHerramientas";
            this.BarraDeHerramientas.Size = new System.Drawing.Size(626, 25);
            this.BarraDeHerramientas.TabIndex = 2;
            this.BarraDeHerramientas.Text = "toolStrip1";
            // 
            // btnbarAbrir
            // 
            this.btnbarAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnbarAbrir.Image = ((System.Drawing.Image)(resources.GetObject("btnbarAbrir.Image")));
            this.btnbarAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnbarAbrir.Name = "btnbarAbrir";
            this.btnbarAbrir.Size = new System.Drawing.Size(23, 22);
            this.btnbarAbrir.Text = "&Abrir";
            this.btnbarAbrir.Click += new System.EventHandler(this.btnbarAbrir_Click);
            // 
            // btnbarGuardarword
            // 
            this.btnbarGuardarword.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnbarGuardarword.Image = ((System.Drawing.Image)(resources.GetObject("btnbarGuardarword.Image")));
            this.btnbarGuardarword.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnbarGuardarword.Name = "btnbarGuardarword";
            this.btnbarGuardarword.Size = new System.Drawing.Size(23, 22);
            this.btnbarGuardarword.Text = "Guardar en &Word";
            this.btnbarGuardarword.Click += new System.EventHandler(this.btnbarGuardarword_Click);
            // 
            // btnbarGuardarpdf
            // 
            this.btnbarGuardarpdf.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnbarGuardarpdf.Image = ((System.Drawing.Image)(resources.GetObject("btnbarGuardarpdf.Image")));
            this.btnbarGuardarpdf.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnbarGuardarpdf.Name = "btnbarGuardarpdf";
            this.btnbarGuardarpdf.Size = new System.Drawing.Size(23, 22);
            this.btnbarGuardarpdf.Text = "Guardar en &PDF";
            this.btnbarGuardarpdf.ToolTipText = "Guardar en PDF";
            this.btnbarGuardarpdf.Click += new System.EventHandler(this.btnbarGuardarpdf_Click);
            // 
            // btnbarGuardar
            // 
            this.btnbarGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnbarGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnbarGuardar.Image")));
            this.btnbarGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnbarGuardar.Name = "btnbarGuardar";
            this.btnbarGuardar.Size = new System.Drawing.Size(23, 22);
            this.btnbarGuardar.Text = "&Guardar";
            this.btnbarGuardar.Click += new System.EventHandler(this.btnbarGuardar_Click);
            // 
            // btnbarDeshacer
            // 
            this.btnbarDeshacer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnbarDeshacer.Image = ((System.Drawing.Image)(resources.GetObject("btnbarDeshacer.Image")));
            this.btnbarDeshacer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnbarDeshacer.Name = "btnbarDeshacer";
            this.btnbarDeshacer.Size = new System.Drawing.Size(23, 22);
            this.btnbarDeshacer.Text = "&Deshacer";
            this.btnbarDeshacer.Click += new System.EventHandler(this.btnbarDeshacer_Click);
            // 
            // btnbarCortar
            // 
            this.btnbarCortar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnbarCortar.Enabled = false;
            this.btnbarCortar.Image = ((System.Drawing.Image)(resources.GetObject("btnbarCortar.Image")));
            this.btnbarCortar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnbarCortar.Name = "btnbarCortar";
            this.btnbarCortar.Size = new System.Drawing.Size(23, 22);
            this.btnbarCortar.Text = "Cort&ar";
            this.btnbarCortar.Click += new System.EventHandler(this.btnbarCortar_Click);
            // 
            // btnbarCopiar
            // 
            this.btnbarCopiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnbarCopiar.Enabled = false;
            this.btnbarCopiar.Image = ((System.Drawing.Image)(resources.GetObject("btnbarCopiar.Image")));
            this.btnbarCopiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnbarCopiar.Name = "btnbarCopiar";
            this.btnbarCopiar.Size = new System.Drawing.Size(23, 22);
            this.btnbarCopiar.Text = "&Copiar";
            this.btnbarCopiar.Click += new System.EventHandler(this.btnbarCopiar_Click);
            // 
            // btnbarPegar
            // 
            this.btnbarPegar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnbarPegar.Image = ((System.Drawing.Image)(resources.GetObject("btnbarPegar.Image")));
            this.btnbarPegar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnbarPegar.Name = "btnbarPegar";
            this.btnbarPegar.Size = new System.Drawing.Size(23, 22);
            this.btnbarPegar.Text = "&Pegar";
            this.btnbarPegar.Click += new System.EventHandler(this.btnbarPegar_Click);
            // 
            // ctEditor
            // 
            this.ctEditor.AcceptsReturn = true;
            this.ctEditor.AcceptsTab = true;
            this.ctEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctEditor.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctEditor.Location = new System.Drawing.Point(0, 52);
            this.ctEditor.Multiline = true;
            this.ctEditor.Name = "ctEditor";
            this.ctEditor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ctEditor.Size = new System.Drawing.Size(626, 333);
            this.ctEditor.TabIndex = 3;
            this.ctEditor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ctEditor_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 407);
            this.Controls.Add(this.ctEditor);
            this.Controls.Add(this.BarraDeHerramientas);
            this.Controls.Add(this.BarraDeEstado);
            this.Controls.Add(this.BarraDeMenus);
            this.MainMenuStrip = this.BarraDeMenus;
            this.Name = "Form1";
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BarraDeMenus.ResumeLayout(false);
            this.BarraDeMenus.PerformLayout();
            this.BarraDeEstado.ResumeLayout(false);
            this.BarraDeEstado.PerformLayout();
            this.BarraDeHerramientas.ResumeLayout(false);
            this.BarraDeHerramientas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip BarraDeMenus;
        private System.Windows.Forms.StatusStrip BarraDeEstado;
        private System.Windows.Forms.ToolStrip BarraDeHerramientas;
        private System.Windows.Forms.TextBox ctEditor;
        private System.Windows.Forms.ToolStripMenuItem menuArchivo;
        private System.Windows.Forms.ToolStripMenuItem menuEdicion;
        private System.Windows.Forms.ToolStripMenuItem menuOpciones;
        private System.Windows.Forms.ToolStripButton btnbarGuardar;
        private System.Windows.Forms.ToolStripButton btnbarCortar;
        private System.Windows.Forms.ToolStripButton btnbarCopiar;
        private System.Windows.Forms.ToolStripButton btnbarPegar;
        private System.Windows.Forms.ToolStripMenuItem ArchivoSalir;
        private System.Windows.Forms.ToolStripMenuItem EdicionCortar;
        private System.Windows.Forms.ToolStripMenuItem EdicionPegar;
        private System.Windows.Forms.ToolStripMenuItem EdicionCopiar;
        private System.Windows.Forms.ToolStripMenuItem OpcionesFuente;
        private System.Windows.Forms.ToolStripMenuItem OpFuCouriernew;
        private System.Windows.Forms.ToolStripMenuItem OpFuArial;
        private System.Windows.Forms.ToolStripMenuItem OpFuPredeterminada;
        private System.Windows.Forms.ToolStripMenuItem OpcionesTam;
        private System.Windows.Forms.ToolStripMenuItem Optam16;
        private System.Windows.Forms.ToolStripMenuItem OpTam24;
        private System.Windows.Forms.ToolStripMenuItem OpTamPredeterminado;
        private System.Windows.Forms.ToolStripButton btnbarAbrir;
        private System.Windows.Forms.ToolStripButton btnbarDeshacer;
        private System.Windows.Forms.ToolStripMenuItem deshacerToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox menuFuente;
        private System.Windows.Forms.ToolStripComboBox menuTamanio;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoPdfToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnbarGuardarpdf;
        private System.Windows.Forms.ToolStripButton btnbarGuardarword;
        private System.Windows.Forms.ToolStripMenuItem pDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel status;
    }
}

