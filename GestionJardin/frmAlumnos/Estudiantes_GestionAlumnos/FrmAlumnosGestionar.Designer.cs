namespace GestionJardin
{
    partial class frmAlumnosGestionar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGA_Buscar = new MetroFramework.Controls.MetroTextBox();
            this.btnGA_Filtrar = new FontAwesome.Sharp.IconPictureBox();
            this.btnGA_Excel = new FontAwesome.Sharp.IconPictureBox();
            this.btnGA_Pdf = new FontAwesome.Sharp.IconPictureBox();
            this.btnGA_Eliminar = new FontAwesome.Sharp.IconButton();
            this.btnGA_Editar = new FontAwesome.Sharp.IconButton();
            this.btnGA_Agregar = new FontAwesome.Sharp.IconButton();
            this.dgvAlumnos = new MetroFramework.Controls.MetroGrid();
            ((System.ComponentModel.ISupportInitialize)(this.btnGA_Filtrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGA_Excel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGA_Pdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(34, 868);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(814, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "* Para poder editar los datos de un alumno o dar de baja al mismo, debe seleccion" +
    "ar el registro previamente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtGA_Buscar
            // 
            this.txtGA_Buscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.txtGA_Buscar.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGA_Buscar.CustomButton.Image = null;
            this.txtGA_Buscar.CustomButton.Location = new System.Drawing.Point(376, 2);
            this.txtGA_Buscar.CustomButton.Name = "";
            this.txtGA_Buscar.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.txtGA_Buscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGA_Buscar.CustomButton.TabIndex = 1;
            this.txtGA_Buscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGA_Buscar.CustomButton.UseSelectable = true;
            this.txtGA_Buscar.CustomButton.Visible = false;
            this.txtGA_Buscar.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtGA_Buscar.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtGA_Buscar.Lines = new string[0];
            this.txtGA_Buscar.Location = new System.Drawing.Point(38, 257);
            this.txtGA_Buscar.MaxLength = 32767;
            this.txtGA_Buscar.Name = "txtGA_Buscar";
            this.txtGA_Buscar.PasswordChar = '\0';
            this.txtGA_Buscar.PromptText = "BUSCAR ALUMNO";
            this.txtGA_Buscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGA_Buscar.SelectedText = "";
            this.txtGA_Buscar.SelectionLength = 0;
            this.txtGA_Buscar.SelectionStart = 0;
            this.txtGA_Buscar.ShortcutsEnabled = true;
            this.txtGA_Buscar.Size = new System.Drawing.Size(424, 50);
            this.txtGA_Buscar.TabIndex = 26;
            this.txtGA_Buscar.UseSelectable = true;
            this.txtGA_Buscar.WaterMark = "BUSCAR ALUMNO";
            this.txtGA_Buscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGA_Buscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGA_Buscar.Click += new System.EventHandler(this.txtGA_Buscar_Click);
            // 
            // btnGA_Filtrar
            // 
            this.btnGA_Filtrar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGA_Filtrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnGA_Filtrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnGA_Filtrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGA_Filtrar.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btnGA_Filtrar.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnGA_Filtrar.IconSize = 83;
            this.btnGA_Filtrar.Location = new System.Drawing.Point(667, 236);
            this.btnGA_Filtrar.Name = "btnGA_Filtrar";
            this.btnGA_Filtrar.Padding = new System.Windows.Forms.Padding(5);
            this.btnGA_Filtrar.Size = new System.Drawing.Size(95, 83);
            this.btnGA_Filtrar.TabIndex = 14;
            this.btnGA_Filtrar.TabStop = false;
            this.btnGA_Filtrar.Click += new System.EventHandler(this.btnGA_Filtrar_Click);
            // 
            // btnGA_Excel
            // 
            this.btnGA_Excel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGA_Excel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnGA_Excel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnGA_Excel.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnGA_Excel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnGA_Excel.IconColor = System.Drawing.Color.Chartreuse;
            this.btnGA_Excel.IconSize = 83;
            this.btnGA_Excel.Location = new System.Drawing.Point(788, 236);
            this.btnGA_Excel.Name = "btnGA_Excel";
            this.btnGA_Excel.Padding = new System.Windows.Forms.Padding(5);
            this.btnGA_Excel.Size = new System.Drawing.Size(95, 83);
            this.btnGA_Excel.TabIndex = 12;
            this.btnGA_Excel.TabStop = false;
            this.btnGA_Excel.Click += new System.EventHandler(this.btnGA_Excel_Click);
            // 
            // btnGA_Pdf
            // 
            this.btnGA_Pdf.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnGA_Pdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnGA_Pdf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnGA_Pdf.ForeColor = System.Drawing.Color.Salmon;
            this.btnGA_Pdf.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btnGA_Pdf.IconColor = System.Drawing.Color.Salmon;
            this.btnGA_Pdf.IconSize = 83;
            this.btnGA_Pdf.Location = new System.Drawing.Point(908, 236);
            this.btnGA_Pdf.Name = "btnGA_Pdf";
            this.btnGA_Pdf.Padding = new System.Windows.Forms.Padding(5);
            this.btnGA_Pdf.Size = new System.Drawing.Size(95, 83);
            this.btnGA_Pdf.TabIndex = 11;
            this.btnGA_Pdf.TabStop = false;
            this.btnGA_Pdf.Click += new System.EventHandler(this.btnGA_Pdf_Click);
            // 
            // btnGA_Eliminar
            // 
            this.btnGA_Eliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGA_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGA_Eliminar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGA_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGA_Eliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGA_Eliminar.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btnGA_Eliminar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGA_Eliminar.IconSize = 100;
            this.btnGA_Eliminar.Location = new System.Drawing.Point(1313, 681);
            this.btnGA_Eliminar.Name = "btnGA_Eliminar";
            this.btnGA_Eliminar.Rotation = 0D;
            this.btnGA_Eliminar.Size = new System.Drawing.Size(293, 134);
            this.btnGA_Eliminar.TabIndex = 8;
            this.btnGA_Eliminar.Text = "ELIMINAR";
            this.btnGA_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGA_Eliminar.UseVisualStyleBackColor = true;
            this.btnGA_Eliminar.Click += new System.EventHandler(this.btnGA_Eliminar_Click);
            // 
            // btnGA_Editar
            // 
            this.btnGA_Editar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGA_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGA_Editar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGA_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGA_Editar.ForeColor = System.Drawing.Color.Cyan;
            this.btnGA_Editar.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnGA_Editar.IconColor = System.Drawing.Color.Cyan;
            this.btnGA_Editar.IconSize = 100;
            this.btnGA_Editar.Location = new System.Drawing.Point(1313, 519);
            this.btnGA_Editar.Name = "btnGA_Editar";
            this.btnGA_Editar.Rotation = 0D;
            this.btnGA_Editar.Size = new System.Drawing.Size(293, 134);
            this.btnGA_Editar.TabIndex = 7;
            this.btnGA_Editar.Text = "EDITAR";
            this.btnGA_Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGA_Editar.UseVisualStyleBackColor = true;
            this.btnGA_Editar.Click += new System.EventHandler(this.btnGA_Editar_Click);
            // 
            // btnGA_Agregar
            // 
            this.btnGA_Agregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGA_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGA_Agregar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGA_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGA_Agregar.ForeColor = System.Drawing.Color.Lime;
            this.btnGA_Agregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnGA_Agregar.IconColor = System.Drawing.Color.Lime;
            this.btnGA_Agregar.IconSize = 100;
            this.btnGA_Agregar.Location = new System.Drawing.Point(1313, 367);
            this.btnGA_Agregar.Name = "btnGA_Agregar";
            this.btnGA_Agregar.Rotation = 0D;
            this.btnGA_Agregar.Size = new System.Drawing.Size(293, 134);
            this.btnGA_Agregar.TabIndex = 6;
            this.btnGA_Agregar.Text = "AGREGAR";
            this.btnGA_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGA_Agregar.UseVisualStyleBackColor = true;
            this.btnGA_Agregar.Click += new System.EventHandler(this.btnGA_Agregar_Click);
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AllowUserToAddRows = false;
            this.dgvAlumnos.AllowUserToDeleteRows = false;
            this.dgvAlumnos.AllowUserToResizeRows = false;
            this.dgvAlumnos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlumnos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAlumnos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 7.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlumnos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAlumnos.EnableHeadersVisualStyles = false;
            this.dgvAlumnos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvAlumnos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvAlumnos.Location = new System.Drawing.Point(38, 350);
            this.dgvAlumnos.MultiSelect = false;
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlumnos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAlumnos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAlumnos.RowTemplate.Height = 24;
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.Size = new System.Drawing.Size(1221, 497);
            this.dgvAlumnos.Style = MetroFramework.MetroColorStyle.Silver;
            this.dgvAlumnos.TabIndex = 0;
            this.dgvAlumnos.UseCustomBackColor = true;
            this.dgvAlumnos.UseCustomForeColor = true;
            this.dgvAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            this.dgvAlumnos.SelectionChanged += new System.EventHandler(this.dgvAlumnos_SelectionChanged);
            // 
            // frmAlumnosGestionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1660, 947);
            this.Controls.Add(this.txtGA_Buscar);
            this.Controls.Add(this.btnGA_Filtrar);
            this.Controls.Add(this.btnGA_Excel);
            this.Controls.Add(this.btnGA_Pdf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGA_Eliminar);
            this.Controls.Add(this.btnGA_Editar);
            this.Controls.Add(this.btnGA_Agregar);
            this.Controls.Add(this.dgvAlumnos);
            this.Name = "frmAlumnosGestionar";
            this.Text = "GESTIONAR ALUMNOS";
            this.Load += new System.EventHandler(this.frmAlumnosGestionar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnGA_Filtrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGA_Excel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGA_Pdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnGA_Agregar;
        private FontAwesome.Sharp.IconButton btnGA_Editar;
        private FontAwesome.Sharp.IconButton btnGA_Eliminar;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox btnGA_Excel;
        private FontAwesome.Sharp.IconPictureBox btnGA_Filtrar;
        private FontAwesome.Sharp.IconPictureBox btnGA_Pdf;
        private MetroFramework.Controls.MetroTextBox txtGA_Buscar;
        private MetroFramework.Controls.MetroGrid dgvAlumnos;
    }
}