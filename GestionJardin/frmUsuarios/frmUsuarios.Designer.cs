namespace GestionJardin
{
    partial class frmUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnGU_Filtrar = new FontAwesome.Sharp.IconPictureBox();
            this.btnGU_Excel = new FontAwesome.Sharp.IconPictureBox();
            this.btnGU_Pdf = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGU_Eliminar = new FontAwesome.Sharp.IconButton();
            this.btnGU_Editar = new FontAwesome.Sharp.IconButton();
            this.btnGU_Agregar = new FontAwesome.Sharp.IconButton();
            this.txtGU_Buscar = new MetroFramework.Controls.MetroTextBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btnGU_Filtrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGU_Excel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGU_Pdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGU_Filtrar
            // 
            this.btnGU_Filtrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGU_Filtrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnGU_Filtrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnGU_Filtrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGU_Filtrar.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btnGU_Filtrar.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnGU_Filtrar.IconSize = 81;
            this.btnGU_Filtrar.Location = new System.Drawing.Point(897, 18);
            this.btnGU_Filtrar.Name = "btnGU_Filtrar";
            this.btnGU_Filtrar.Padding = new System.Windows.Forms.Padding(5);
            this.btnGU_Filtrar.Size = new System.Drawing.Size(91, 81);
            this.btnGU_Filtrar.TabIndex = 32;
            this.btnGU_Filtrar.TabStop = false;
            // 
            // btnGU_Excel
            // 
            this.btnGU_Excel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGU_Excel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnGU_Excel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnGU_Excel.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnGU_Excel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnGU_Excel.IconColor = System.Drawing.Color.Chartreuse;
            this.btnGU_Excel.IconSize = 81;
            this.btnGU_Excel.Location = new System.Drawing.Point(1017, 18);
            this.btnGU_Excel.Name = "btnGU_Excel";
            this.btnGU_Excel.Padding = new System.Windows.Forms.Padding(5);
            this.btnGU_Excel.Size = new System.Drawing.Size(91, 81);
            this.btnGU_Excel.TabIndex = 31;
            this.btnGU_Excel.TabStop = false;
            // 
            // btnGU_Pdf
            // 
            this.btnGU_Pdf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGU_Pdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnGU_Pdf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnGU_Pdf.ForeColor = System.Drawing.Color.Salmon;
            this.btnGU_Pdf.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btnGU_Pdf.IconColor = System.Drawing.Color.Salmon;
            this.btnGU_Pdf.IconSize = 81;
            this.btnGU_Pdf.Location = new System.Drawing.Point(1126, 18);
            this.btnGU_Pdf.Name = "btnGU_Pdf";
            this.btnGU_Pdf.Padding = new System.Windows.Forms.Padding(5);
            this.btnGU_Pdf.Size = new System.Drawing.Size(91, 81);
            this.btnGU_Pdf.TabIndex = 30;
            this.btnGU_Pdf.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(72, 665);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(815, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "* Para poder editar los datos de un usuario o dar de baja al mismo, debe seleccio" +
    "nar el registro previamente";
            // 
            // btnGU_Eliminar
            // 
            this.btnGU_Eliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGU_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGU_Eliminar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGU_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGU_Eliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGU_Eliminar.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btnGU_Eliminar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGU_Eliminar.IconSize = 100;
            this.btnGU_Eliminar.Location = new System.Drawing.Point(1367, 427);
            this.btnGU_Eliminar.Name = "btnGU_Eliminar";
            this.btnGU_Eliminar.Rotation = 0D;
            this.btnGU_Eliminar.Size = new System.Drawing.Size(293, 134);
            this.btnGU_Eliminar.TabIndex = 28;
            this.btnGU_Eliminar.Text = "ELIMINAR";
            this.btnGU_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGU_Eliminar.UseVisualStyleBackColor = true;
            this.btnGU_Eliminar.Click += new System.EventHandler(this.btnGU_Eliminar_Click);
            // 
            // btnGU_Editar
            // 
            this.btnGU_Editar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGU_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGU_Editar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGU_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGU_Editar.ForeColor = System.Drawing.Color.Cyan;
            this.btnGU_Editar.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnGU_Editar.IconColor = System.Drawing.Color.Cyan;
            this.btnGU_Editar.IconSize = 100;
            this.btnGU_Editar.Location = new System.Drawing.Point(1367, 269);
            this.btnGU_Editar.Name = "btnGU_Editar";
            this.btnGU_Editar.Rotation = 0D;
            this.btnGU_Editar.Size = new System.Drawing.Size(293, 134);
            this.btnGU_Editar.TabIndex = 27;
            this.btnGU_Editar.Text = "EDITAR";
            this.btnGU_Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGU_Editar.UseVisualStyleBackColor = true;
            this.btnGU_Editar.Click += new System.EventHandler(this.btnGU_Editar_Click);
            // 
            // btnGU_Agregar
            // 
            this.btnGU_Agregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGU_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGU_Agregar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGU_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGU_Agregar.ForeColor = System.Drawing.Color.Lime;
            this.btnGU_Agregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnGU_Agregar.IconColor = System.Drawing.Color.Lime;
            this.btnGU_Agregar.IconSize = 100;
            this.btnGU_Agregar.Location = new System.Drawing.Point(1367, 113);
            this.btnGU_Agregar.Name = "btnGU_Agregar";
            this.btnGU_Agregar.Rotation = 0D;
            this.btnGU_Agregar.Size = new System.Drawing.Size(293, 134);
            this.btnGU_Agregar.TabIndex = 26;
            this.btnGU_Agregar.Text = "AGREGAR";
            this.btnGU_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGU_Agregar.UseVisualStyleBackColor = true;
            this.btnGU_Agregar.Click += new System.EventHandler(this.btnGU_Agregar_Click);
            // 
            // txtGU_Buscar
            // 
            this.txtGU_Buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtGU_Buscar.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGU_Buscar.CustomButton.Image = null;
            this.txtGU_Buscar.CustomButton.Location = new System.Drawing.Point(376, 2);
            this.txtGU_Buscar.CustomButton.Name = "";
            this.txtGU_Buscar.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.txtGU_Buscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGU_Buscar.CustomButton.TabIndex = 1;
            this.txtGU_Buscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGU_Buscar.CustomButton.UseSelectable = true;
            this.txtGU_Buscar.CustomButton.Visible = false;
            this.txtGU_Buscar.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtGU_Buscar.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtGU_Buscar.Lines = new string[0];
            this.txtGU_Buscar.Location = new System.Drawing.Point(75, 18);
            this.txtGU_Buscar.MaxLength = 32767;
            this.txtGU_Buscar.Name = "txtGU_Buscar";
            this.txtGU_Buscar.PasswordChar = '\0';
            this.txtGU_Buscar.PromptText = "BUSCAR DOCENTE";
            this.txtGU_Buscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGU_Buscar.SelectedText = "";
            this.txtGU_Buscar.SelectionLength = 0;
            this.txtGU_Buscar.SelectionStart = 0;
            this.txtGU_Buscar.ShortcutsEnabled = true;
            this.txtGU_Buscar.Size = new System.Drawing.Size(424, 50);
            this.txtGU_Buscar.TabIndex = 25;
            this.txtGU_Buscar.UseSelectable = true;
            this.txtGU_Buscar.WaterMark = "BUSCAR DOCENTE";
            this.txtGU_Buscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGU_Buscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 7.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alumno,
            this.documento,
            this.FechaNac,
            this.Edad,
            this.telefono,
            this.direccion,
            this.telefono_2});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle11;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(75, 140);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 24;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(1142, 497);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroGrid1.TabIndex = 24;
            this.metroGrid1.UseCustomBackColor = true;
            // 
            // alumno
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            this.alumno.DefaultCellStyle = dataGridViewCellStyle10;
            this.alumno.HeaderText = "DOCENTE";
            this.alumno.Name = "alumno";
            // 
            // documento
            // 
            this.documento.HeaderText = "USUARIO";
            this.documento.Name = "documento";
            // 
            // FechaNac
            // 
            this.FechaNac.HeaderText = "CONTRASEÑA";
            this.FechaNac.Name = "FechaNac";
            // 
            // Edad
            // 
            this.Edad.HeaderText = "ROL";
            this.Edad.Name = "Edad";
            // 
            // telefono
            // 
            this.telefono.HeaderText = "FECHA ALTA";
            this.telefono.Name = "telefono";
            // 
            // direccion
            // 
            this.direccion.HeaderText = "FECHA MODIFICACIÓN";
            this.direccion.Name = "direccion";
            // 
            // telefono_2
            // 
            this.telefono_2.HeaderText = "FECHA BAJA";
            this.telefono_2.Name = "telefono_2";
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1697, 774);
            this.Controls.Add(this.btnGU_Filtrar);
            this.Controls.Add(this.btnGU_Excel);
            this.Controls.Add(this.btnGU_Pdf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGU_Eliminar);
            this.Controls.Add(this.btnGU_Editar);
            this.Controls.Add(this.btnGU_Agregar);
            this.Controls.Add(this.txtGU_Buscar);
            this.Controls.Add(this.metroGrid1);
            this.Name = "frmUsuarios";
            this.Text = "GESTIÓN USUARIOS";
            ((System.ComponentModel.ISupportInitialize)(this.btnGU_Filtrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGU_Excel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGU_Pdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox btnGU_Filtrar;
        private FontAwesome.Sharp.IconPictureBox btnGU_Excel;
        private FontAwesome.Sharp.IconPictureBox btnGU_Pdf;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnGU_Eliminar;
        private FontAwesome.Sharp.IconButton btnGU_Editar;
        private FontAwesome.Sharp.IconButton btnGU_Agregar;
        private MetroFramework.Controls.MetroTextBox txtGU_Buscar;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono_2;
    }
}