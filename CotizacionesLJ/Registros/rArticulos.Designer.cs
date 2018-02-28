namespace CotizacionesLJ.Registros
{
    partial class rArticulos
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
            this.label1 = new System.Windows.Forms.Label();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.consultarbutton = new System.Windows.Forms.Button();
            this.buscarbutton = new System.Windows.Forms.Button();
            this.eliminarbutton = new System.Windows.Forms.Button();
            this.nuevobutton = new System.Windows.Forms.Button();
            this.guardarbutton = new System.Windows.Forms.Button();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PrecionumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ValidarerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecionumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidarerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(81, 57);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(204, 20);
            this.DescripciontextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Precio";
            // 
            // consultarbutton
            // 
            this.consultarbutton.Image = global::CotizacionesLJ.Properties.Resources.impresora;
            this.consultarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.consultarbutton.Location = new System.Drawing.Point(226, 137);
            this.consultarbutton.Name = "consultarbutton";
            this.consultarbutton.Size = new System.Drawing.Size(62, 59);
            this.consultarbutton.TabIndex = 29;
            this.consultarbutton.Text = "Consultar";
            this.consultarbutton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.consultarbutton.UseVisualStyleBackColor = true;
            this.consultarbutton.Click += new System.EventHandler(this.consultarbutton_Click);
            // 
            // buscarbutton
            // 
            this.buscarbutton.Image = global::CotizacionesLJ.Properties.Resources.preview_search_find_locate_1551;
            this.buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buscarbutton.Location = new System.Drawing.Point(118, 10);
            this.buscarbutton.Name = "buscarbutton";
            this.buscarbutton.Size = new System.Drawing.Size(73, 41);
            this.buscarbutton.TabIndex = 28;
            this.buscarbutton.Text = "Buscar";
            this.buscarbutton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.buscarbutton.UseVisualStyleBackColor = true;
            this.buscarbutton.Click += new System.EventHandler(this.buscarbutton_Click);
            // 
            // eliminarbutton
            // 
            this.eliminarbutton.Image = global::CotizacionesLJ.Properties.Resources.delete_remove_page_document_16678;
            this.eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.eliminarbutton.Location = new System.Drawing.Point(158, 137);
            this.eliminarbutton.Name = "eliminarbutton";
            this.eliminarbutton.Size = new System.Drawing.Size(62, 59);
            this.eliminarbutton.TabIndex = 27;
            this.eliminarbutton.Text = "Eliminar";
            this.eliminarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.eliminarbutton.UseVisualStyleBackColor = true;
            this.eliminarbutton.Click += new System.EventHandler(this.eliminarbutton_Click);
            // 
            // nuevobutton
            // 
            this.nuevobutton.Image = global::CotizacionesLJ.Properties.Resources.New_File_36861;
            this.nuevobutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.nuevobutton.Location = new System.Drawing.Point(15, 137);
            this.nuevobutton.Name = "nuevobutton";
            this.nuevobutton.Size = new System.Drawing.Size(68, 59);
            this.nuevobutton.TabIndex = 26;
            this.nuevobutton.Text = "Nuevo";
            this.nuevobutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.nuevobutton.UseVisualStyleBackColor = true;
            this.nuevobutton.Click += new System.EventHandler(this.nuevobutton_Click);
            // 
            // guardarbutton
            // 
            this.guardarbutton.Image = global::CotizacionesLJ.Properties.Resources.Save_as_37111;
            this.guardarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.guardarbutton.Location = new System.Drawing.Point(89, 137);
            this.guardarbutton.Name = "guardarbutton";
            this.guardarbutton.Size = new System.Drawing.Size(63, 59);
            this.guardarbutton.TabIndex = 25;
            this.guardarbutton.Text = "Guardar";
            this.guardarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.guardarbutton.UseVisualStyleBackColor = true;
            this.guardarbutton.Click += new System.EventHandler(this.guardarbutton_Click);
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Location = new System.Drawing.Point(81, 19);
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.Size = new System.Drawing.Size(31, 20);
            this.IDnumericUpDown.TabIndex = 30;
            // 
            // PrecionumericUpDown
            // 
            this.PrecionumericUpDown.Location = new System.Drawing.Point(81, 94);
            this.PrecionumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.PrecionumericUpDown.Name = "PrecionumericUpDown";
            this.PrecionumericUpDown.Size = new System.Drawing.Size(204, 20);
            this.PrecionumericUpDown.TabIndex = 31;
            // 
            // ValidarerrorProvider
            // 
            this.ValidarerrorProvider.ContainerControl = this;
            // 
            // rArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 202);
            this.Controls.Add(this.PrecionumericUpDown);
            this.Controls.Add(this.IDnumericUpDown);
            this.Controls.Add(this.consultarbutton);
            this.Controls.Add(this.buscarbutton);
            this.Controls.Add(this.eliminarbutton);
            this.Controls.Add(this.nuevobutton);
            this.Controls.Add(this.guardarbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "rArticulos";
            this.Text = "Articulos";
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecionumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidarerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button consultarbutton;
        private System.Windows.Forms.Button buscarbutton;
        private System.Windows.Forms.Button eliminarbutton;
        private System.Windows.Forms.Button nuevobutton;
        private System.Windows.Forms.Button guardarbutton;
        private System.Windows.Forms.NumericUpDown IDnumericUpDown;
        private System.Windows.Forms.NumericUpDown PrecionumericUpDown;
        private System.Windows.Forms.ErrorProvider ValidarerrorProvider;
    }
}