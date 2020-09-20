namespace GestionJardin
{
    partial class frmSalas
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
            this.btnGS_Eliminar = new FontAwesome.Sharp.IconButton();
            this.btnGS_Editar = new FontAwesome.Sharp.IconButton();
            this.btnGS_Agregar = new FontAwesome.Sharp.IconButton();
            this.txtGU_Buscar = new MetroFramework.Controls.MetroTextBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangoEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cupoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuposActivos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cupoVacante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaMod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaBaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnGD_Filtrar.TabIndex = 50;
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
            this.btnGD_Excel.TabIndex = 49;
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
            this.btnGD_Pdf.TabIndex = 48;
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
            this.label1.Size = new System.Drawing.Size(800, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "* Para poder editar los datos de una sala o dar de baja la misma, debe selecciona" +
    "r el registro previamente";
            // 
            // btnGS_Eliminar
            // 
            this.btnGS_Eliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGS_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGS_Eliminar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGS_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGS_Eliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGS_Eliminar.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btnGS_Eliminar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGS_Eliminar.IconSize = 100;
            this.btnGS_Eliminar.Location = new System.Drawing.Point(1349, 463);
            this.btnGS_Eliminar.Name = "btnGS_Eliminar";
            this.btnGS_Eliminar.Rotation = 0D;
            this.btnGS_Eliminar.Size = new System.Drawing.Size(293, 134);
            this.btnGS_Eliminar.TabIndex = 46;
            this.btnGS_Eliminar.Text = "ELIMINAR";
            this.btnGS_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGS_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btnGS_Editar
            // 
            this.btnGS_Editar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGS_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGS_Editar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGS_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGS_Editar.ForeColor = System.Drawing.Color.Cyan;
            this.btnGS_Editar.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnGS_Editar.IconColor = System.Drawing.Color.Cyan;
            this.btnGS_Editar.IconSize = 100;
            this.btnGS_Editar.Location = new System.Drawing.Point(1349, 305);
            this.btnGS_Editar.Name = "btnGS_Editar";
            this.btnGS_Editar.Rotation = 0D;
            this.btnGS_Editar.Size = new System.Drawing.Size(293, 134);
            this.btnGS_Editar.TabIndex = 45;
            this.btnGS_Editar.Text = "EDITAR";
            this.btnGS_Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGS_Editar.UseVisualStyleBackColor = true;
            // 
            // btnGS_Agregar
            // 
            this.btnGS_Agregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGS_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGS_Agregar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGS_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGS_Agregar.ForeColor = System.Drawing.Color.Lime;
            this.btnGS_Agregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnGS_Agregar.IconColor = System.Drawing.Color.Lime;
            this.btnGS_Agregar.IconSize = 100;
            this.btnGS_Agregar.Location = new System.Drawing.Point(1349, 149);
            this.btnGS_Agregar.Name = "btnGS_Agregar";
            this.btnGS_Agregar.Rotation = 0D;
            this.btnGS_Agregar.Size = new System.Drawing.Size(293, 134);
            this.btnGS_Agregar.TabIndex = 44;
            this.btnGS_Agregar.Text = "AGREGAR";
            this.btnGS_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGS_Agregar.UseVisualStyleBackColor = true;
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
            this.txtGU_Buscar.PromptText = "BUSCAR SALA - TURNO";
            this.txtGU_Buscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGU_Buscar.SelectedText = "";
            this.txtGU_Buscar.SelectionLength = 0;
            this.txtGU_Buscar.SelectionStart = 0;
            this.txtGU_Buscar.ShortcutsEnabled = true;
            this.txtGU_Buscar.Size = new System.Drawing.Size(424, 50);
            this.txtGU_Buscar.TabIndex = 43;
            this.txtGU_Buscar.UseSelectable = true;
            this.txtGU_Buscar.WaterMark = "BUSCAR SALA - TURNO";
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
            this.sala,
            this.color,
            this.rangoEdad,
            this.cupoTotal,
            this.cuposActivos,
            this.cupoVacante,
            this.fechaAlta,
            this.fechaMod,
            this.fechaBaja});
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
            this.metroGrid1.TabIndex = 42;
            this.metroGrid1.UseCustomBackColor = true;
            // 
            // sala
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            this.sala.DefaultCellStyle = dataGridViewCellStyle2;
            this.sala.HeaderText = "SALA";
            this.sala.Name = "sala";
            // 
            // color
            // 
            this.color.HeaderText = "COLOR";
            this.color.Name = "color";
            // 
            // rangoEdad
            // 
            this.rangoEdad.HeaderText = "RANGO EDAD";
            this.rangoEdad.Name = "rangoEdad";
            // 
            // cupoTotal
            // 
            this.cupoTotal.HeaderText = "CUPO TOTAL";
            this.cupoTotal.Name = "cupoTotal";
            // 
            // cuposActivos
            // 
            this.cuposActivos.HeaderText = "CUPO ACTIVOS";
            this.cuposActivos.Name = "cuposActivos";
            // 
            // cupoVacante
            // 
            this.cupoVacante.HeaderText = "CUPO VACANTE";
            this.cupoVacante.Name = "cupoVacante";
            // 
            // fechaAlta
            // 
            this.fechaAlta.HeaderText = "FECHA ALTA";
            this.fechaAlta.Name = "fechaAlta";
            // 
            // fechaMod
            // 
            this.fechaMod.HeaderText = "FECHA MODIFICACIÓN";
            this.fechaMod.Name = "fechaMod";
            // 
            // fechaBaja
            // 
            this.fechaBaja.HeaderText = "FECHA BAJA";
            this.fechaBaja.Name = "fechaBaja";
            // 
            // frmSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1697, 774);
            this.Controls.Add(this.btnGD_Filtrar);
            this.Controls.Add(this.btnGD_Excel);
            this.Controls.Add(this.btnGD_Pdf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGS_Eliminar);
            this.Controls.Add(this.btnGS_Editar);
            this.Controls.Add(this.btnGS_Agregar);
            this.Controls.Add(this.txtGU_Buscar);
            this.Controls.Add(this.metroGrid1);
            this.Name = "frmSalas";
            this.Text = "GESTIÓN SALAS";
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
        private FontAwesome.Sharp.IconButton btnGS_Eliminar;
        private FontAwesome.Sharp.IconButton btnGS_Editar;
        private FontAwesome.Sharp.IconButton btnGS_Agregar;
        private MetroFramework.Controls.MetroTextBox txtGU_Buscar;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sala;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangoEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cupoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuposActivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cupoVacante;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaMod;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaBaja;
    }
}