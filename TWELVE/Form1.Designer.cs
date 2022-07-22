namespace TWELVE
{
    partial class Form1
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
            this.pbxtablero = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modoDeJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modoAgresivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modoAgresivoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarPartidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarPartidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelcolumnas = new System.Windows.Forms.Label();
            this.labelfilas = new System.Windows.Forms.Label();
            this.numericUpDowncolumnas = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownfilas = new System.Windows.Forms.NumericUpDown();
            this.botonreiniciar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblpuntuaciones = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pbxtablero)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowncolumnas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownfilas)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxtablero
            // 
            this.pbxtablero.BackColor = System.Drawing.SystemColors.Control;
            this.pbxtablero.Location = new System.Drawing.Point(10, 57);
            this.pbxtablero.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbxtablero.Name = "pbxtablero";
            this.pbxtablero.Size = new System.Drawing.Size(304, 402);
            this.pbxtablero.TabIndex = 0;
            this.pbxtablero.TabStop = false;
            this.pbxtablero.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxtablero_Paint);
            this.pbxtablero.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbxtablero_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modoDeJuegoToolStripMenuItem,
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(562, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modoDeJuegoToolStripMenuItem
            // 
            this.modoDeJuegoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modoAgresivoToolStripMenuItem,
            this.modoAgresivoToolStripMenuItem1});
            this.modoDeJuegoToolStripMenuItem.Name = "modoDeJuegoToolStripMenuItem";
            this.modoDeJuegoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.modoDeJuegoToolStripMenuItem.Text = "Modo de Juego";
            // 
            // modoAgresivoToolStripMenuItem
            // 
            this.modoAgresivoToolStripMenuItem.Name = "modoAgresivoToolStripMenuItem";
            this.modoAgresivoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.modoAgresivoToolStripMenuItem.Text = "Modo Normal";
            this.modoAgresivoToolStripMenuItem.Click += new System.EventHandler(this.modoNormalToolStripMenuItem_Click);
            // 
            // modoAgresivoToolStripMenuItem1
            // 
            this.modoAgresivoToolStripMenuItem1.Name = "modoAgresivoToolStripMenuItem1";
            this.modoAgresivoToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.modoAgresivoToolStripMenuItem1.Text = "Modo Agresivo";
            this.modoAgresivoToolStripMenuItem1.Click += new System.EventHandler(this.modoAgresivoToolStripMenuItem1_Click);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarPartidaToolStripMenuItem,
            this.cargarPartidaToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.archivoToolStripMenuItem.Text = "    Archivo";
            // 
            // guardarPartidaToolStripMenuItem
            // 
            this.guardarPartidaToolStripMenuItem.Name = "guardarPartidaToolStripMenuItem";
            this.guardarPartidaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.guardarPartidaToolStripMenuItem.Text = "Guardar Partida";
            this.guardarPartidaToolStripMenuItem.Click += new System.EventHandler(this.guardarPartidaToolStripMenuItem_Click);
            // 
            // cargarPartidaToolStripMenuItem
            // 
            this.cargarPartidaToolStripMenuItem.Name = "cargarPartidaToolStripMenuItem";
            this.cargarPartidaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.cargarPartidaToolStripMenuItem.Text = "Cargar Partida";
            this.cargarPartidaToolStripMenuItem.Click += new System.EventHandler(this.cargarPartidaToolStripMenuItem_Click);
            // 
            // labelcolumnas
            // 
            this.labelcolumnas.AutoSize = true;
            this.labelcolumnas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcolumnas.Location = new System.Drawing.Point(318, 51);
            this.labelcolumnas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelcolumnas.Name = "labelcolumnas";
            this.labelcolumnas.Size = new System.Drawing.Size(160, 16);
            this.labelcolumnas.TabIndex = 2;
            this.labelcolumnas.Text = "Cantidad deColumnas";
            // 
            // labelfilas
            // 
            this.labelfilas.AutoSize = true;
            this.labelfilas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfilas.Location = new System.Drawing.Point(331, 92);
            this.labelfilas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelfilas.Name = "labelfilas";
            this.labelfilas.Size = new System.Drawing.Size(130, 16);
            this.labelfilas.TabIndex = 3;
            this.labelfilas.Text = "Cantidad de Filas";
            // 
            // numericUpDowncolumnas
            // 
            this.numericUpDowncolumnas.Location = new System.Drawing.Point(488, 47);
            this.numericUpDowncolumnas.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numericUpDowncolumnas.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDowncolumnas.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDowncolumnas.Name = "numericUpDowncolumnas";
            this.numericUpDowncolumnas.Size = new System.Drawing.Size(37, 20);
            this.numericUpDowncolumnas.TabIndex = 4;
            this.numericUpDowncolumnas.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDownfilas
            // 
            this.numericUpDownfilas.Location = new System.Drawing.Point(489, 88);
            this.numericUpDownfilas.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numericUpDownfilas.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownfilas.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownfilas.Name = "numericUpDownfilas";
            this.numericUpDownfilas.Size = new System.Drawing.Size(36, 20);
            this.numericUpDownfilas.TabIndex = 5;
            this.numericUpDownfilas.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // botonreiniciar
            // 
            this.botonreiniciar.BackColor = System.Drawing.SystemColors.Control;
            this.botonreiniciar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonreiniciar.Location = new System.Drawing.Point(376, 139);
            this.botonreiniciar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.botonreiniciar.Name = "botonreiniciar";
            this.botonreiniciar.Size = new System.Drawing.Size(124, 27);
            this.botonreiniciar.TabIndex = 6;
            this.botonreiniciar.Text = "Cambiar Dimensiones";
            this.botonreiniciar.UseVisualStyleBackColor = false;
            this.botonreiniciar.Click += new System.EventHandler(this.botonreiniciar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(326, 261);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(199, 50);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Twelve";
            // 
            // lblpuntuaciones
            // 
            this.lblpuntuaciones.AutoSize = true;
            this.lblpuntuaciones.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblpuntuaciones.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpuntuaciones.Location = new System.Drawing.Point(373, 218);
            this.lblpuntuaciones.Name = "lblpuntuaciones";
            this.lblpuntuaciones.Size = new System.Drawing.Size(105, 23);
            this.lblpuntuaciones.TabIndex = 8;
            this.lblpuntuaciones.Text = "Puntuación: 0";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(334, 423);
            this.progressBar1.Maximum = 18;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(191, 23);
            this.progressBar1.TabIndex = 9;
            this.progressBar1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(562, 469);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblpuntuaciones);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.botonreiniciar);
            this.Controls.Add(this.numericUpDownfilas);
            this.Controls.Add(this.numericUpDowncolumnas);
            this.Controls.Add(this.labelfilas);
            this.Controls.Add(this.labelcolumnas);
            this.Controls.Add(this.pbxtablero);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Twelve 12";
            ((System.ComponentModel.ISupportInitialize)(this.pbxtablero)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowncolumnas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownfilas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxtablero;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modoDeJuegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modoAgresivoToolStripMenuItem;
        private System.Windows.Forms.Label labelcolumnas;
        private System.Windows.Forms.Label labelfilas;
        private System.Windows.Forms.NumericUpDown numericUpDowncolumnas;
        private System.Windows.Forms.NumericUpDown numericUpDownfilas;
        private System.Windows.Forms.Button botonreiniciar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ToolStripMenuItem modoAgresivoToolStripMenuItem1;
        private System.Windows.Forms.Label lblpuntuaciones;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarPartidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarPartidaToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

