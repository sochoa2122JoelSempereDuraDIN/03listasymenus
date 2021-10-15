
namespace listasymenus
{
    partial class fmListasMenus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmListasMenus));
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMostrarMas = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.cbCursos = new System.Windows.Forms.ComboBox();
            this.lbAlumnos = new System.Windows.Forms.ListBox();
            this.laCursos = new System.Windows.Forms.Label();
            this.laAlumnos = new System.Windows.Forms.Label();
            this.laNuevo = new System.Windows.Forms.Label();
            this.tbNuevo = new System.Windows.Forms.TextBox();
            this.btnArriba = new System.Windows.Forms.Button();
            this.btnAbajo = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.pnActualiza = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAnyadir = new System.Windows.Forms.Button();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.smArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.itNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.itAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.itGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.itSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.smAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.itAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsListas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itcNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.itcAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.itcGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.pnActualiza.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.cmsListas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(275, 425);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.itNuevo_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(356, 426);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 1;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.itAbrir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(437, 426);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.itGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(518, 425);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.itSalir_Click);
            // 
            // btnMostrarMas
            // 
            this.btnMostrarMas.Location = new System.Drawing.Point(203, 376);
            this.btnMostrarMas.Name = "btnMostrarMas";
            this.btnMostrarMas.Size = new System.Drawing.Size(110, 23);
            this.btnMostrarMas.TabIndex = 4;
            this.btnMostrarMas.Text = "Mostrar Mas ...";
            this.btnMostrarMas.UseVisualStyleBackColor = true;
            this.btnMostrarMas.Click += new System.EventHandler(this.btnMostrarMas_Click);
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(203, 347);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(110, 23);
            this.btnMostrarTodos.TabIndex = 5;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // cbCursos
            // 
            this.cbCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCursos.FormattingEnabled = true;
            this.cbCursos.Items.AddRange(new object[] {
            "1A",
            "2B",
            "3C"});
            this.cbCursos.Location = new System.Drawing.Point(51, 58);
            this.cbCursos.Name = "cbCursos";
            this.cbCursos.Size = new System.Drawing.Size(121, 21);
            this.cbCursos.TabIndex = 6;
            this.cbCursos.TextChanged += new System.EventHandler(this.itAbrir_Click);
            // 
            // lbAlumnos
            // 
            this.lbAlumnos.ContextMenuStrip = this.cmsListas;
            this.lbAlumnos.FormattingEnabled = true;
            this.lbAlumnos.Items.AddRange(new object[] {
            "Joel",
            "Alex",
            "Rafa",
            "Fernando",
            "Vicky",
            "David",
            "Aaron"});
            this.lbAlumnos.Location = new System.Drawing.Point(51, 98);
            this.lbAlumnos.Name = "lbAlumnos";
            this.lbAlumnos.Size = new System.Drawing.Size(120, 199);
            this.lbAlumnos.TabIndex = 7;
            // 
            // laCursos
            // 
            this.laCursos.AutoSize = true;
            this.laCursos.Location = new System.Drawing.Point(48, 42);
            this.laCursos.Name = "laCursos";
            this.laCursos.Size = new System.Drawing.Size(39, 13);
            this.laCursos.TabIndex = 8;
            this.laCursos.Text = "Cursos";
            // 
            // laAlumnos
            // 
            this.laAlumnos.AutoSize = true;
            this.laAlumnos.Location = new System.Drawing.Point(48, 82);
            this.laAlumnos.Name = "laAlumnos";
            this.laAlumnos.Size = new System.Drawing.Size(47, 13);
            this.laAlumnos.TabIndex = 9;
            this.laAlumnos.Text = "Alumnos";
            this.laAlumnos.Click += new System.EventHandler(this.laAlumnos_Click);
            // 
            // laNuevo
            // 
            this.laNuevo.AutoSize = true;
            this.laNuevo.Enabled = false;
            this.laNuevo.Location = new System.Drawing.Point(47, 412);
            this.laNuevo.Name = "laNuevo";
            this.laNuevo.Size = new System.Drawing.Size(39, 13);
            this.laNuevo.TabIndex = 10;
            this.laNuevo.Text = "Nuevo";
            // 
            // tbNuevo
            // 
            this.tbNuevo.Enabled = false;
            this.tbNuevo.Location = new System.Drawing.Point(50, 429);
            this.tbNuevo.Name = "tbNuevo";
            this.tbNuevo.Size = new System.Drawing.Size(100, 20);
            this.tbNuevo.TabIndex = 11;
            this.tbNuevo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNuevo_KeyPress);
            // 
            // btnArriba
            // 
            this.btnArriba.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArriba.Location = new System.Drawing.Point(193, 98);
            this.btnArriba.Name = "btnArriba";
            this.btnArriba.Size = new System.Drawing.Size(35, 77);
            this.btnArriba.TabIndex = 12;
            this.btnArriba.Text = "⬆";
            this.btnArriba.UseVisualStyleBackColor = true;
            this.btnArriba.Click += new System.EventHandler(this.btnArriba_Click);
            // 
            // btnAbajo
            // 
            this.btnAbajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbajo.Location = new System.Drawing.Point(193, 220);
            this.btnAbajo.Name = "btnAbajo";
            this.btnAbajo.Size = new System.Drawing.Size(35, 77);
            this.btnAbajo.TabIndex = 13;
            this.btnAbajo.Text = "⬇";
            this.btnAbajo.UseVisualStyleBackColor = true;
            this.btnAbajo.Click += new System.EventHandler(this.btnAbajo_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(673, 45);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 14;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Red;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnActualizar.Location = new System.Drawing.Point(673, 82);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 15;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // pnActualiza
            // 
            this.pnActualiza.Controls.Add(this.btnBuscar);
            this.pnActualiza.Controls.Add(this.btnInsertar);
            this.pnActualiza.Controls.Add(this.btnBorrar);
            this.pnActualiza.Controls.Add(this.btnAnyadir);
            this.pnActualiza.Location = new System.Drawing.Point(618, 177);
            this.pnActualiza.Name = "pnActualiza";
            this.pnActualiza.Size = new System.Drawing.Size(146, 193);
            this.pnActualiza.TabIndex = 16;
            this.pnActualiza.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(36, 155);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(36, 107);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 2;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(36, 58);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAnyadir
            // 
            this.btnAnyadir.Location = new System.Drawing.Point(36, 15);
            this.btnAnyadir.Name = "btnAnyadir";
            this.btnAnyadir.Size = new System.Drawing.Size(75, 23);
            this.btnAnyadir.TabIndex = 0;
            this.btnAnyadir.Text = "Añadir";
            this.btnAnyadir.UseVisualStyleBackColor = true;
            this.btnAnyadir.Click += new System.EventHandler(this.btnAnyadir_Click);
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smArchivo,
            this.smAyuda});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(800, 24);
            this.menuStrip3.TabIndex = 19;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // smArchivo
            // 
            this.smArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itNuevo,
            this.itAbrir,
            this.itGuardar,
            this.itSalir});
            this.smArchivo.Name = "smArchivo";
            this.smArchivo.Size = new System.Drawing.Size(60, 20);
            this.smArchivo.Text = "Archivo";
            // 
            // itNuevo
            // 
            this.itNuevo.Name = "itNuevo";
            this.itNuevo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.itNuevo.Size = new System.Drawing.Size(158, 22);
            this.itNuevo.Text = "Nuevo";
            this.itNuevo.Click += new System.EventHandler(this.itNuevo_Click);
            // 
            // itAbrir
            // 
            this.itAbrir.Name = "itAbrir";
            this.itAbrir.Size = new System.Drawing.Size(158, 22);
            this.itAbrir.Text = "Abrir";
            this.itAbrir.Click += new System.EventHandler(this.itAbrir_Click);
            // 
            // itGuardar
            // 
            this.itGuardar.Image = ((System.Drawing.Image)(resources.GetObject("itGuardar.Image")));
            this.itGuardar.Name = "itGuardar";
            this.itGuardar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.itGuardar.Size = new System.Drawing.Size(158, 22);
            this.itGuardar.Text = "Guardar";
            this.itGuardar.Click += new System.EventHandler(this.itGuardar_Click);
            // 
            // itSalir
            // 
            this.itSalir.Name = "itSalir";
            this.itSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.itSalir.Size = new System.Drawing.Size(158, 22);
            this.itSalir.Text = "Salir";
            this.itSalir.Click += new System.EventHandler(this.itSalir_Click);
            // 
            // smAyuda
            // 
            this.smAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itAcercaDe});
            this.smAyuda.Name = "smAyuda";
            this.smAyuda.Size = new System.Drawing.Size(53, 20);
            this.smAyuda.Text = "Ayuda";
            // 
            // itAcercaDe
            // 
            this.itAcercaDe.Name = "itAcercaDe";
            this.itAcercaDe.Size = new System.Drawing.Size(180, 22);
            this.itAcercaDe.Text = "Acerca De";
            this.itAcercaDe.Click += new System.EventHandler(this.itAcercaDe_Click);
            // 
            // cmsListas
            // 
            this.cmsListas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itcNuevo,
            this.itcAbrir,
            this.itcGuardar});
            this.cmsListas.Name = "cmsListas";
            this.cmsListas.Size = new System.Drawing.Size(117, 70);
            // 
            // itcNuevo
            // 
            this.itcNuevo.Name = "itcNuevo";
            this.itcNuevo.Size = new System.Drawing.Size(116, 22);
            this.itcNuevo.Text = "Nuevo";
            this.itcNuevo.Click += new System.EventHandler(this.itNuevo_Click);
            // 
            // itcAbrir
            // 
            this.itcAbrir.Name = "itcAbrir";
            this.itcAbrir.Size = new System.Drawing.Size(116, 22);
            this.itcAbrir.Text = "Abrir";
            this.itcAbrir.Click += new System.EventHandler(this.itAbrir_Click);
            // 
            // itcGuardar
            // 
            this.itcGuardar.Name = "itcGuardar";
            this.itcGuardar.Size = new System.Drawing.Size(116, 22);
            this.itcGuardar.Text = "Guardar";
            this.itcGuardar.Click += new System.EventHandler(this.itGuardar_Click);
            // 
            // fmListasMenus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnActualiza);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnAbajo);
            this.Controls.Add(this.btnArriba);
            this.Controls.Add(this.tbNuevo);
            this.Controls.Add(this.laNuevo);
            this.Controls.Add(this.laAlumnos);
            this.Controls.Add(this.laCursos);
            this.Controls.Add(this.lbAlumnos);
            this.Controls.Add(this.cbCursos);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.btnMostrarMas);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.menuStrip3);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmListasMenus";
            this.Text = "Listas y Menus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnActualiza.ResumeLayout(false);
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.cmsListas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMostrarMas;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.ComboBox cbCursos;
        private System.Windows.Forms.ListBox lbAlumnos;
        private System.Windows.Forms.Label laCursos;
        private System.Windows.Forms.Label laAlumnos;
        private System.Windows.Forms.Label laNuevo;
        private System.Windows.Forms.TextBox tbNuevo;
        private System.Windows.Forms.Button btnArriba;
        private System.Windows.Forms.Button btnAbajo;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Panel pnActualiza;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAnyadir;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem smArchivo;
        private System.Windows.Forms.ToolStripMenuItem itNuevo;
        private System.Windows.Forms.ToolStripMenuItem itAbrir;
        private System.Windows.Forms.ToolStripMenuItem itGuardar;
        private System.Windows.Forms.ToolStripMenuItem itSalir;
        private System.Windows.Forms.ToolStripMenuItem smAyuda;
        private System.Windows.Forms.ToolStripMenuItem itAcercaDe;
        private System.Windows.Forms.ContextMenuStrip cmsListas;
        private System.Windows.Forms.ToolStripMenuItem itcNuevo;
        private System.Windows.Forms.ToolStripMenuItem itcAbrir;
        private System.Windows.Forms.ToolStripMenuItem itcGuardar;
    }
}

