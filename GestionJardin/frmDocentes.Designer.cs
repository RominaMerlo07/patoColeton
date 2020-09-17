﻿namespace GestionJardin
{
    partial class frmDocentes
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
            this.btnGD_Filtrar = new FontAwesome.Sharp.IconPictureBox();
            this.btnGD_Excel = new FontAwesome.Sharp.IconPictureBox();
            this.btnGD_Pdf = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGD_Eliminar = new FontAwesome.Sharp.IconButton();
            this.btnGD_Editar = new FontAwesome.Sharp.IconButton();
            this.btnGD_Agregar = new FontAwesome.Sharp.IconButton();
            this.txtGU_Buscar = new MetroFramework.Controls.MetroTextBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btnGD_Filtrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGD_Excel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGD_Pdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGD_Filtrar
            // 
            this.btnGD_Filtrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGD_Filtrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnGD_Filtrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnGD_Filtrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGD_Filtrar.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btnGD_Filtrar.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnGD_Filtrar.IconSize = 81;
            this.btnGD_Filtrar.Location = new System.Drawing.Point(879, 54);
            this.btnGD_Filtrar.Name = "btnGD_Filtrar";
            this.btnGD_Filtrar.Padding = new System.Windows.Forms.Padding(5);
            this.btnGD_Filtrar.Size = new System.Drawing.Size(91, 81);
            this.btnGD_Filtrar.TabIndex = 41;
            this.btnGD_Filtrar.TabStop = false;
            // 
            // btnGD_Excel
            // 
            this.btnGD_Excel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGD_Excel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnGD_Excel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnGD_Excel.ForeColor = System.Drawing.Color.Chartreuse;
            this.btnGD_Excel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnGD_Excel.IconColor = System.Drawing.Color.Chartreuse;
            this.btnGD_Excel.IconSize = 81;
            this.btnGD_Excel.Location = new System.Drawing.Point(999, 54);
            this.btnGD_Excel.Name = "btnGD_Excel";
            this.btnGD_Excel.Padding = new System.Windows.Forms.Padding(5);
            this.btnGD_Excel.Size = new System.Drawing.Size(91, 81);
            this.btnGD_Excel.TabIndex = 40;
            this.btnGD_Excel.TabStop = false;
            // 
            // btnGD_Pdf
            // 
            this.btnGD_Pdf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGD_Pdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnGD_Pdf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnGD_Pdf.ForeColor = System.Drawing.Color.Salmon;
            this.btnGD_Pdf.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.btnGD_Pdf.IconColor = System.Drawing.Color.Salmon;
            this.btnGD_Pdf.IconSize = 81;
            this.btnGD_Pdf.Location = new System.Drawing.Point(1108, 54);
            this.btnGD_Pdf.Name = "btnGD_Pdf";
            this.btnGD_Pdf.Padding = new System.Windows.Forms.Padding(5);
            this.btnGD_Pdf.Size = new System.Drawing.Size(91, 81);
            this.btnGD_Pdf.TabIndex = 39;
            this.btnGD_Pdf.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(54, 701);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(819, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "* Para poder editar los datos de un docente o dar de baja al mismo, debe seleccio" +
    "nar el registro previamente";
            // 
            // btnGD_Eliminar
            // 
            this.btnGD_Eliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGD_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGD_Eliminar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGD_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGD_Eliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGD_Eliminar.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btnGD_Eliminar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGD_Eliminar.IconSize = 100;
            this.btnGD_Eliminar.Location = new System.Drawing.Point(1349, 463);
            this.btnGD_Eliminar.Name = "btnGD_Eliminar";
            this.btnGD_Eliminar.Rotation = 0D;
            this.btnGD_Eliminar.Size = new System.Drawing.Size(293, 134);
            this.btnGD_Eliminar.TabIndex = 37;
            this.btnGD_Eliminar.Text = "ELIMINAR";
            this.btnGD_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGD_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btnGD_Editar
            // 
            this.btnGD_Editar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGD_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGD_Editar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGD_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGD_Editar.ForeColor = System.Drawing.Color.Cyan;
            this.btnGD_Editar.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnGD_Editar.IconColor = System.Drawing.Color.Cyan;
            this.btnGD_Editar.IconSize = 100;
            this.btnGD_Editar.Location = new System.Drawing.Point(1349, 305);
            this.btnGD_Editar.Name = "btnGD_Editar";
            this.btnGD_Editar.Rotation = 0D;
            this.btnGD_Editar.Size = new System.Drawing.Size(293, 134);
            this.btnGD_Editar.TabIndex = 36;
            this.btnGD_Editar.Text = "EDITAR";
            this.btnGD_Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGD_Editar.UseVisualStyleBackColor = true;
            // 
            // btnGD_Agregar
            // 
            this.btnGD_Agregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGD_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGD_Agregar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGD_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGD_Agregar.ForeColor = System.Drawing.Color.Lime;
            this.btnGD_Agregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnGD_Agregar.IconColor = System.Drawing.Color.Lime;
            this.btnGD_Agregar.IconSize = 100;
            this.btnGD_Agregar.Location = new System.Drawing.Point(1349, 149);
            this.btnGD_Agregar.Name = "btnGD_Agregar";
            this.btnGD_Agregar.Rotation = 0D;
            this.btnGD_Agregar.Size = new System.Drawing.Size(293, 134);
            this.btnGD_Agregar.TabIndex = 35;
            this.btnGD_Agregar.Text = "AGREGAR";
            this.btnGD_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGD_Agregar.UseVisualStyleBackColor = true;
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
            this.txtGU_Buscar.Location = new System.Drawing.Point(57, 54);
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
            this.txtGU_Buscar.TabIndex = 34;
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
            this.telefono,
            this.direccion,
            this.telefono_2});
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
            this.metroGrid1.Location = new System.Drawing.Point(57, 176);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 24;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(1142, 497);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroGrid1.TabIndex = 33;
            this.metroGrid1.UseCustomBackColor = true;
            // 
            // alumno
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            this.alumno.DefaultCellStyle = dataGridViewCellStyle2;
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
            // frmDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1697, 774);
            this.Controls.Add(this.btnGD_Filtrar);
            this.Controls.Add(this.btnGD_Excel);
            this.Controls.Add(this.btnGD_Pdf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGD_Eliminar);
            this.Controls.Add(this.btnGD_Editar);
            this.Controls.Add(this.btnGD_Agregar);
            this.Controls.Add(this.txtGU_Buscar);
            this.Controls.Add(this.metroGrid1);
            this.Name = "frmDocentes";
            this.Text = "GESTIÓN DOCENTES";
            ((System.ComponentModel.ISupportInitialize)(this.btnGD_Filtrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGD_Excel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGD_Pdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox btnGD_Filtrar;
        private FontAwesome.Sharp.IconPictureBox btnGD_Excel;
        private FontAwesome.Sharp.IconPictureBox btnGD_Pdf;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnGD_Eliminar;
        private FontAwesome.Sharp.IconButton btnGD_Editar;
        private FontAwesome.Sharp.IconButton btnGD_Agregar;
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