namespace ShutdownBasic
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbxAccion = new System.Windows.Forms.ComboBox();
            this.tabControlAcciones = new System.Windows.Forms.TabControl();
            this.tabPageAcciones = new System.Windows.Forms.TabPage();
            this.txtTiempo = new System.Windows.Forms.NumericUpDown();
            this.tabPageAcercaDe = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lnkWebSite = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lnkLinkedIn = new System.Windows.Forms.LinkLabel();
            this.lnkFacebook = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlAcciones.SuspendLayout();
            this.tabPageAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTiempo)).BeginInit();
            this.tabPageAcercaDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnApagar
            // 
            this.btnApagar.Font = new System.Drawing.Font("Lato Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(0, 98);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(258, 47);
            this.btnApagar.TabIndex = 0;
            this.btnApagar.Text = "Ejecutar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            this.btnApagar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnApagar_KeyDown);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Lato Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(0, 145);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(258, 47);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnCancelar_KeyDown);
            // 
            // cbxAccion
            // 
            this.cbxAccion.AutoCompleteCustomSource.AddRange(new string[] {
            "Apagar",
            "Reiniciar"});
            this.cbxAccion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbxAccion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxAccion.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAccion.FormattingEnabled = true;
            this.cbxAccion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbxAccion.Items.AddRange(new object[] {
            "Apagar",
            "Reiniciar"});
            this.cbxAccion.Location = new System.Drawing.Point(0, 65);
            this.cbxAccion.MaxDropDownItems = 3;
            this.cbxAccion.Name = "cbxAccion";
            this.cbxAccion.Size = new System.Drawing.Size(257, 31);
            this.cbxAccion.Sorted = true;
            this.cbxAccion.TabIndex = 3;
            this.cbxAccion.Text = "Seleccionar";
            this.cbxAccion.Leave += new System.EventHandler(this.cbxAccion_Leave);
            // 
            // tabControlAcciones
            // 
            this.tabControlAcciones.AccessibleName = "";
            this.tabControlAcciones.Controls.Add(this.tabPageAcciones);
            this.tabControlAcciones.Controls.Add(this.tabPageAcercaDe);
            this.tabControlAcciones.Location = new System.Drawing.Point(1, 1);
            this.tabControlAcciones.Name = "tabControlAcciones";
            this.tabControlAcciones.SelectedIndex = 0;
            this.tabControlAcciones.Size = new System.Drawing.Size(265, 222);
            this.tabControlAcciones.TabIndex = 4;
            // 
            // tabPageAcciones
            // 
            this.tabPageAcciones.Controls.Add(this.txtTiempo);
            this.tabPageAcciones.Controls.Add(this.cbxAccion);
            this.tabPageAcciones.Controls.Add(this.btnApagar);
            this.tabPageAcciones.Controls.Add(this.btnCancelar);
            this.tabPageAcciones.Location = new System.Drawing.Point(4, 22);
            this.tabPageAcciones.Name = "tabPageAcciones";
            this.tabPageAcciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAcciones.Size = new System.Drawing.Size(257, 196);
            this.tabPageAcciones.TabIndex = 0;
            this.tabPageAcciones.Text = "Acciones";
            this.tabPageAcciones.UseVisualStyleBackColor = true;
            // 
            // txtTiempo
            // 
            this.txtTiempo.DecimalPlaces = 1;
            this.txtTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.txtTiempo.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.txtTiempo.Location = new System.Drawing.Point(0, 6);
            this.txtTiempo.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(257, 53);
            this.txtTiempo.TabIndex = 5;
            this.txtTiempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTiempo_KeyPress);
            this.txtTiempo.Leave += new System.EventHandler(this.txtTiempo_Leave);
            // 
            // tabPageAcercaDe
            // 
            this.tabPageAcercaDe.Controls.Add(this.pictureBox3);
            this.tabPageAcercaDe.Controls.Add(this.lnkWebSite);
            this.tabPageAcercaDe.Controls.Add(this.pictureBox2);
            this.tabPageAcercaDe.Controls.Add(this.pictureBox1);
            this.tabPageAcercaDe.Controls.Add(this.lnkLinkedIn);
            this.tabPageAcercaDe.Controls.Add(this.lnkFacebook);
            this.tabPageAcercaDe.Controls.Add(this.label2);
            this.tabPageAcercaDe.Controls.Add(this.label1);
            this.tabPageAcercaDe.Location = new System.Drawing.Point(4, 22);
            this.tabPageAcercaDe.Name = "tabPageAcercaDe";
            this.tabPageAcercaDe.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAcercaDe.Size = new System.Drawing.Size(257, 196);
            this.tabPageAcercaDe.TabIndex = 1;
            this.tabPageAcercaDe.Text = "Acerca de";
            this.tabPageAcercaDe.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(151, 57);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // lnkWebSite
            // 
            this.lnkWebSite.AutoSize = true;
            this.lnkWebSite.Location = new System.Drawing.Point(148, 87);
            this.lnkWebSite.Name = "lnkWebSite";
            this.lnkWebSite.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lnkWebSite.Size = new System.Drawing.Size(60, 13);
            this.lnkWebSite.TabIndex = 6;
            this.lnkWebSite.TabStop = true;
            this.lnkWebSite.Text = "Official Site";
            this.lnkWebSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkWebSite_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(80, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lnkLinkedIn
            // 
            this.lnkLinkedIn.AutoSize = true;
            this.lnkLinkedIn.Location = new System.Drawing.Point(77, 87);
            this.lnkLinkedIn.Name = "lnkLinkedIn";
            this.lnkLinkedIn.Size = new System.Drawing.Size(51, 13);
            this.lnkLinkedIn.TabIndex = 3;
            this.lnkLinkedIn.TabStop = true;
            this.lnkLinkedIn.Text = "Linked In";
            this.lnkLinkedIn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLinkedIn_LinkClicked);
            // 
            // lnkFacebook
            // 
            this.lnkFacebook.AutoSize = true;
            this.lnkFacebook.Location = new System.Drawing.Point(7, 87);
            this.lnkFacebook.Name = "lnkFacebook";
            this.lnkFacebook.Size = new System.Drawing.Size(55, 13);
            this.lnkFacebook.TabIndex = 2;
            this.lnkFacebook.TabStop = true;
            this.lnkFacebook.Text = "Facebook";
            this.lnkFacebook.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkFacebook_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sígueme en:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desarrollado por Vito Mendoza.";
            // 
            // Principal
            // 
            this.AcceptButton = this.btnApagar;
            this.AccessibleDescription = "Shutdown Basic";
            this.AccessibleName = "Shutdown Basic";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(263, 220);
            this.Controls.Add(this.tabControlAcciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.Opacity = 0.9D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shutdown Basic";
            this.TopMost = true;
            this.tabControlAcciones.ResumeLayout(false);
            this.tabPageAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTiempo)).EndInit();
            this.tabPageAcercaDe.ResumeLayout(false);
            this.tabPageAcercaDe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbxAccion;
        private System.Windows.Forms.TabControl tabControlAcciones;
        private System.Windows.Forms.TabPage tabPageAcciones;
        private System.Windows.Forms.TabPage tabPageAcercaDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lnkLinkedIn;
        private System.Windows.Forms.LinkLabel lnkFacebook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtTiempo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.LinkLabel lnkWebSite;
    }
}

