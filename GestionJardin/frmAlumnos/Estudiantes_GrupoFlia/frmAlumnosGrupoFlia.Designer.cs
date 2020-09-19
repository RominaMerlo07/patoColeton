namespace GestionJardin
{
    partial class frmAlumnosGrupoFlia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtGA_Buscar = new MetroFramework.Controls.MetroTextBox();
            this.btnGA_Filtrar = new FontAwesome.Sharp.IconPictureBox();
            this.btnGA_Excel = new FontAwesome.Sharp.IconPictureBox();
            this.btnGA_Pdf = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGF_Eliminar = new FontAwesome.Sharp.IconButton();
            this.btnGF_Editar = new FontAwesome.Sharp.IconButton();
            this.btnGF_Agregar = new FontAwesome.Sharp.IconButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btnGA_Filtrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGA_Excel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGA_Pdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
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
            this.txtGA_Buscar.Location = new System.Drawing.Point(45, 298);
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
            this.txtGA_Buscar.TabIndex = 35;
            this.txtGA_Buscar.UseSelectable = true;
            this.txtGA_Buscar.WaterMark = "BUSCAR ALUMNO";
            this.txtGA_Buscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGA_Buscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnGA_Filtrar.Location = new System.Drawing.Point(674, 277);
            this.btnGA_Filtrar.Name = "btnGA_Filtrar";
            this.btnGA_Filtrar.Padding = new System.Windows.Forms.Padding(5);
            this.btnGA_Filtrar.Size = new System.Drawing.Size(95, 83);
            this.btnGA_Filtrar.TabIndex = 34;
            this.btnGA_Filtrar.TabStop = false;
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
            this.btnGA_Excel.Location = new System.Drawing.Point(795, 277);
            this.btnGA_Excel.Name = "btnGA_Excel";
            this.btnGA_Excel.Padding = new System.Windows.Forms.Padding(5);
            this.btnGA_Excel.Size = new System.Drawing.Size(95, 83);
            this.btnGA_Excel.TabIndex = 33;
            this.btnGA_Excel.TabStop = false;
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
            this.btnGA_Pdf.Location = new System.Drawing.Point(915, 277);
            this.btnGA_Pdf.Name = "btnGA_Pdf";
            this.btnGA_Pdf.Padding = new System.Windows.Forms.Padding(5);
            this.btnGA_Pdf.Size = new System.Drawing.Size(95, 83);
            this.btnGA_Pdf.TabIndex = 32;
            this.btnGA_Pdf.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(41, 909);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(814, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "* Para poder editar los datos de un alumno o dar de baja al mismo, debe seleccion" +
    "ar el registro previamente";
            // 
            // btnGF_Eliminar
            // 
            this.btnGF_Eliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGF_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGF_Eliminar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGF_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGF_Eliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGF_Eliminar.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btnGF_Eliminar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGF_Eliminar.IconSize = 100;
            this.btnGF_Eliminar.Location = new System.Drawing.Point(1320, 722);
            this.btnGF_Eliminar.Name = "btnGF_Eliminar";
            this.btnGF_Eliminar.Rotation = 0D;
            this.btnGF_Eliminar.Size = new System.Drawing.Size(293, 134);
            this.btnGF_Eliminar.TabIndex = 30;
            this.btnGF_Eliminar.Text = "ELIMINAR";
            this.btnGF_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGF_Eliminar.UseVisualStyleBackColor = true;
            this.btnGF_Eliminar.Click += new System.EventHandler(this.btnGF_Eliminar_Click);
            // 
            // btnGF_Editar
            // 
            this.btnGF_Editar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGF_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGF_Editar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGF_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGF_Editar.ForeColor = System.Drawing.Color.Cyan;
            this.btnGF_Editar.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnGF_Editar.IconColor = System.Drawing.Color.Cyan;
            this.btnGF_Editar.IconSize = 100;
            this.btnGF_Editar.Location = new System.Drawing.Point(1320, 560);
            this.btnGF_Editar.Name = "btnGF_Editar";
            this.btnGF_Editar.Rotation = 0D;
            this.btnGF_Editar.Size = new System.Drawing.Size(293, 134);
            this.btnGF_Editar.TabIndex = 29;
            this.btnGF_Editar.Text = "EDITAR";
            this.btnGF_Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGF_Editar.UseVisualStyleBackColor = true;
            this.btnGF_Editar.Click += new System.EventHandler(this.btnGF_Editar_Click);
            // 
            // btnGF_Agregar
            // 
            this.btnGF_Agregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGF_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGF_Agregar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGF_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGF_Agregar.ForeColor = System.Drawing.Color.Lime;
            this.btnGF_Agregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnGF_Agregar.IconColor = System.Drawing.Color.Lime;
            this.btnGF_Agregar.IconSize = 100;
            this.btnGF_Agregar.Location = new System.Drawing.Point(1320, 408);
            this.btnGF_Agregar.Name = "btnGF_Agregar";
            this.btnGF_Agregar.Rotation = 0D;
            this.btnGF_Agregar.Size = new System.Drawing.Size(293, 134);
            this.btnGF_Agregar.TabIndex = 28;
            this.btnGF_Agregar.Text = "AGREGAR";
            this.btnGF_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGF_Agregar.UseVisualStyleBackColor = true;
            this.btnGF_Agregar.Click += new System.EventHandler(this.btnGF_Agregar_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 7.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alumno,
            this.documento,
            this.FechaNac,
            this.documentoF,
            this.Edad,
            this.autorizado});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle7;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(45, 391);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 24;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(1221, 497);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroGrid1.TabIndex = 27;
            this.metroGrid1.UseCustomBackColor = true;
            // 
            // alumno
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            this.alumno.DefaultCellStyle = dataGridViewCellStyle6;
            this.alumno.HeaderText = "ALUMNO";
            this.alumno.Name = "alumno";
            // 
            // documento
            // 
            this.documento.HeaderText = "DOCUMENTO";
            this.documento.Name = "documento";
            // 
            // FechaNac
            // 
            this.FechaNac.HeaderText = "FAMILIAR";
            this.FechaNac.Name = "FechaNac";
            // 
            // documentoF
            // 
            this.documentoF.HeaderText = "DOCUMENTO";
            this.documentoF.Name = "documentoF";
            // 
            // Edad
            // 
            this.Edad.HeaderText = "OBSERVACIÓN";
            this.Edad.Name = "Edad";
            // 
            // autorizado
            // 
            this.autorizado.HeaderText = "AUTORIZADO";
            this.autorizado.Name = "autorizado";
            // 
            // frmAlumnosGrupoFlia
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
            this.Controls.Add(this.btnGF_Eliminar);
            this.Controls.Add(this.btnGF_Editar);
            this.Controls.Add(this.btnGF_Agregar);
            this.Controls.Add(this.metroGrid1);
            this.Name = "frmAlumnosGrupoFlia";
            this.Text = "GRUPO FAMILIAR";
            ((System.ComponentModel.ISupportInitialize)(this.btnGA_Filtrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGA_Excel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGA_Pdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtGA_Buscar;
        private FontAwesome.Sharp.IconPictureBox btnGA_Filtrar;
        private FontAwesome.Sharp.IconPictureBox btnGA_Excel;
        private FontAwesome.Sharp.IconPictureBox btnGA_Pdf;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnGF_Eliminar;
        private FontAwesome.Sharp.IconButton btnGF_Editar;
        private FontAwesome.Sharp.IconButton btnGF_Agregar;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorizado;
    }
}