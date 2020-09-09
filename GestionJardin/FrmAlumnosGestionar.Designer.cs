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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGA_Buscar = new MetroFramework.Controls.MetroTextBox();
            this.btnGA_Eliminar = new FontAwesome.Sharp.IconButton();
            this.btnGA_Editar = new FontAwesome.Sharp.IconButton();
            this.btnGA_Agregar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGA_Excel = new FontAwesome.Sharp.IconPictureBox();
            this.btnGA_Filtrar = new FontAwesome.Sharp.IconPictureBox();
            this.btnGA_Pdf = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGA_Excel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGA_Filtrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGA_Pdf)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 7.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.alumno,
            this.documento,
            this.FechaNac,
            this.Edad,
            this.direccion,
            this.telefono,
            this.telefono_2,
            this.turno,
            this.Sala});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(30, 150);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 24;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(931, 339);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroGrid1.TabIndex = 0;
            this.metroGrid1.UseCustomBackColor = true;
            // 
            // alumno
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            this.alumno.DefaultCellStyle = dataGridViewCellStyle2;
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
            this.FechaNac.HeaderText = "FECHA NACIMIENTO";
            this.FechaNac.Name = "FechaNac";
            // 
            // Edad
            // 
            this.Edad.HeaderText = "EDAD";
            this.Edad.Name = "Edad";
            // 
            // direccion
            // 
            this.direccion.HeaderText = "DIRECCION";
            this.direccion.Name = "direccion";
            // 
            // telefono
            // 
            this.telefono.HeaderText = "TELEFONO";
            this.telefono.Name = "telefono";
            // 
            // telefono_2
            // 
            this.telefono_2.HeaderText = "TELEFONO 2";
            this.telefono_2.Name = "telefono_2";
            // 
            // turno
            // 
            this.turno.HeaderText = "TURNO";
            this.turno.Name = "turno";
            // 
            // Sala
            // 
            this.Sala.HeaderText = "SALA";
            this.Sala.Name = "Sala";
            // 
            // txtGA_Buscar
            // 
            this.txtGA_Buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtGA_Buscar.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGA_Buscar.CustomButton.Image = null;
            this.txtGA_Buscar.CustomButton.Location = new System.Drawing.Point(351, 2);
            this.txtGA_Buscar.CustomButton.Name = "";
            this.txtGA_Buscar.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtGA_Buscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGA_Buscar.CustomButton.TabIndex = 1;
            this.txtGA_Buscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGA_Buscar.CustomButton.UseSelectable = true;
            this.txtGA_Buscar.CustomButton.Visible = false;
            this.txtGA_Buscar.Lines = new string[0];
            this.txtGA_Buscar.Location = new System.Drawing.Point(30, 69);
            this.txtGA_Buscar.MaxLength = 32767;
            this.txtGA_Buscar.Name = "txtGA_Buscar";
            this.txtGA_Buscar.PasswordChar = '\0';
            this.txtGA_Buscar.PromptText = "BUSCAR ALUMNO";
            this.txtGA_Buscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGA_Buscar.SelectedText = "";
            this.txtGA_Buscar.SelectionLength = 0;
            this.txtGA_Buscar.SelectionStart = 0;
            this.txtGA_Buscar.ShortcutsEnabled = true;
            this.txtGA_Buscar.Size = new System.Drawing.Size(379, 30);
            this.txtGA_Buscar.TabIndex = 4;
            this.txtGA_Buscar.UseSelectable = true;
            this.txtGA_Buscar.WaterMark = "BUSCAR ALUMNO";
            this.txtGA_Buscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGA_Buscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnGA_Eliminar
            // 
            this.btnGA_Eliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGA_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGA_Eliminar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGA_Eliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGA_Eliminar.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btnGA_Eliminar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGA_Eliminar.IconSize = 100;
            this.btnGA_Eliminar.Location = new System.Drawing.Point(1012, 385);
            this.btnGA_Eliminar.Name = "btnGA_Eliminar";
            this.btnGA_Eliminar.Rotation = 0D;
            this.btnGA_Eliminar.Size = new System.Drawing.Size(206, 104);
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
            this.btnGA_Editar.ForeColor = System.Drawing.Color.Cyan;
            this.btnGA_Editar.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnGA_Editar.IconColor = System.Drawing.Color.Cyan;
            this.btnGA_Editar.IconSize = 100;
            this.btnGA_Editar.Location = new System.Drawing.Point(1012, 223);
            this.btnGA_Editar.Name = "btnGA_Editar";
            this.btnGA_Editar.Rotation = 0D;
            this.btnGA_Editar.Size = new System.Drawing.Size(206, 104);
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
            this.btnGA_Agregar.ForeColor = System.Drawing.Color.Lime;
            this.btnGA_Agregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnGA_Agregar.IconColor = System.Drawing.Color.Lime;
            this.btnGA_Agregar.IconSize = 100;
            this.btnGA_Agregar.Location = new System.Drawing.Point(1012, 71);
            this.btnGA_Agregar.Name = "btnGA_Agregar";
            this.btnGA_Agregar.Rotation = 0D;
            this.btnGA_Agregar.Size = new System.Drawing.Size(206, 104);
            this.btnGA_Agregar.TabIndex = 6;
            this.btnGA_Agregar.Text = "AGREGAR";
            this.btnGA_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGA_Agregar.UseVisualStyleBackColor = true;
            this.btnGA_Agregar.Click += new System.EventHandler(this.btnGA_Agregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(92, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(814, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "* Para poder editar los datos de un alumno o dar de baja al mismo, debe seleccion" +
    "ar el registro previamente";
            // 
            // btnGA_Excel
            // 
            this.btnGA_Excel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGA_Excel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnGA_Excel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnGA_Excel.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnGA_Excel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnGA_Excel.IconColor = System.Drawing.Color.ForestGreen;
            this.btnGA_Excel.IconSize = 53;
            this.btnGA_Excel.Location = new System.Drawing.Point(838, 53);
            this.btnGA_Excel.Name = "btnGA_Excel";
            this.btnGA_Excel.Padding = new System.Windows.Forms.Padding(5);
            this.btnGA_Excel.Size = new System.Drawing.Size(58, 53);
            this.btnGA_Excel.TabIndex = 12;
            this.btnGA_Excel.TabStop = false;
            // 
            // btnGA_Filtrar
            // 
            this.btnGA_Filtrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGA_Filtrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnGA_Filtrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnGA_Filtrar.ForeColor = System.Drawing.Color.Silver;
            this.btnGA_Filtrar.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btnGA_Filtrar.IconColor = System.Drawing.Color.Silver;
            this.btnGA_Filtrar.IconSize = 53;
            this.btnGA_Filtrar.Location = new System.Drawing.Point(738, 53);
            this.btnGA_Filtrar.Name = "btnGA_Filtrar";
            this.btnGA_Filtrar.Padding = new System.Windows.Forms.Padding(5);
            this.btnGA_Filtrar.Size = new System.Drawing.Size(58, 53);
            this.btnGA_Filtrar.TabIndex = 14;
            this.btnGA_Filtrar.TabStop = false;
            // 
            // btnGA_Pdf
            // 
            this.btnGA_Pdf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGA_Pdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnGA_Pdf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnGA_Pdf.ForeColor = System.Drawing.Color.IndianRed;
            this.btnGA_Pdf.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btnGA_Pdf.IconColor = System.Drawing.Color.IndianRed;
            this.btnGA_Pdf.IconSize = 53;
            this.btnGA_Pdf.Location = new System.Drawing.Point(902, 53);
            this.btnGA_Pdf.Name = "btnGA_Pdf";
            this.btnGA_Pdf.Padding = new System.Windows.Forms.Padding(5);
            this.btnGA_Pdf.Size = new System.Drawing.Size(58, 53);
            this.btnGA_Pdf.TabIndex = 11;
            this.btnGA_Pdf.TabStop = false;
            // 
            // frmAlumnosGestionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1289, 645);
            this.Controls.Add(this.btnGA_Filtrar);
            this.Controls.Add(this.btnGA_Excel);
            this.Controls.Add(this.btnGA_Pdf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGA_Eliminar);
            this.Controls.Add(this.btnGA_Editar);
            this.Controls.Add(this.btnGA_Agregar);
            this.Controls.Add(this.txtGA_Buscar);
            this.Controls.Add(this.metroGrid1);
            this.Name = "frmAlumnosGestionar";
            this.Text = "GESTIONAR ALUMNOS";
            this.Load += new System.EventHandler(this.frmAlumnosGestionar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGA_Excel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGA_Filtrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGA_Pdf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroTextBox txtGA_Buscar;
        private FontAwesome.Sharp.IconButton btnGA_Agregar;
        private FontAwesome.Sharp.IconButton btnGA_Editar;
        private FontAwesome.Sharp.IconButton btnGA_Eliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sala;
        private FontAwesome.Sharp.IconPictureBox btnGA_Excel;
        private FontAwesome.Sharp.IconPictureBox btnGA_Filtrar;
        private FontAwesome.Sharp.IconPictureBox btnGA_Pdf;
    }
}