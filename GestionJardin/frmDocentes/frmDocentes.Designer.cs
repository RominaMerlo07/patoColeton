namespace GestionJardin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGU_Buscar = new MetroFramework.Controls.MetroTextBox();
            this.btnGD_Filtrar = new FontAwesome.Sharp.IconPictureBox();
            this.btnGD_Excel = new FontAwesome.Sharp.IconPictureBox();
            this.btnGD_Pdf = new FontAwesome.Sharp.IconPictureBox();
            this.btnGD_Eliminar = new FontAwesome.Sharp.IconButton();
            this.btnGD_Editar = new FontAwesome.Sharp.IconButton();
            this.btnGD_Agregar = new FontAwesome.Sharp.IconButton();
            this.dtgrdocente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btnGD_Filtrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGD_Excel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGD_Pdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdocente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(61, 876);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1052, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "* Para poder editar los datos de un docente o dar de baja al mismo, debe seleccio" +
    "nar el registro previamente";
            // 
            // txtGU_Buscar
            // 
            this.txtGU_Buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtGU_Buscar.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGU_Buscar.CustomButton.Image = null;
            this.txtGU_Buscar.CustomButton.Location = new System.Drawing.Point(469, 2);
            this.txtGU_Buscar.CustomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGU_Buscar.CustomButton.Name = "";
            this.txtGU_Buscar.CustomButton.Size = new System.Drawing.Size(64, 71);
            this.txtGU_Buscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGU_Buscar.CustomButton.TabIndex = 1;
            this.txtGU_Buscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGU_Buscar.CustomButton.UseSelectable = true;
            this.txtGU_Buscar.CustomButton.Visible = false;
            this.txtGU_Buscar.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtGU_Buscar.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtGU_Buscar.Lines = new string[0];
            this.txtGU_Buscar.Location = new System.Drawing.Point(64, 68);
            this.txtGU_Buscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGU_Buscar.MaxLength = 32767;
            this.txtGU_Buscar.Name = "txtGU_Buscar";
            this.txtGU_Buscar.PasswordChar = '\0';
            this.txtGU_Buscar.PromptText = "BUSCAR DOCENTE";
            this.txtGU_Buscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGU_Buscar.SelectedText = "";
            this.txtGU_Buscar.SelectionLength = 0;
            this.txtGU_Buscar.SelectionStart = 0;
            this.txtGU_Buscar.ShortcutsEnabled = true;
            this.txtGU_Buscar.ShowButton = true;
            this.txtGU_Buscar.Size = new System.Drawing.Size(477, 62);
            this.txtGU_Buscar.TabIndex = 34;
            this.txtGU_Buscar.UseSelectable = true;
            this.txtGU_Buscar.WaterMark = "BUSCAR DOCENTE";
            this.txtGU_Buscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGU_Buscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGU_Buscar.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtGU_Buscar_ButtonClick);
            this.txtGU_Buscar.Click += new System.EventHandler(this.txtGU_Buscar_Click);
            this.txtGU_Buscar.Enter += new System.EventHandler(this.txtGU_Buscar_Enter);
            // 
            // btnGD_Filtrar
            // 
            this.btnGD_Filtrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGD_Filtrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnGD_Filtrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnGD_Filtrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGD_Filtrar.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btnGD_Filtrar.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnGD_Filtrar.IconSize = 101;
            this.btnGD_Filtrar.Location = new System.Drawing.Point(989, 68);
            this.btnGD_Filtrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGD_Filtrar.Name = "btnGD_Filtrar";
            this.btnGD_Filtrar.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnGD_Filtrar.Size = new System.Drawing.Size(102, 101);
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
            this.btnGD_Excel.IconSize = 101;
            this.btnGD_Excel.Location = new System.Drawing.Point(1124, 68);
            this.btnGD_Excel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGD_Excel.Name = "btnGD_Excel";
            this.btnGD_Excel.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnGD_Excel.Size = new System.Drawing.Size(102, 101);
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
            this.btnGD_Pdf.IconSize = 101;
            this.btnGD_Pdf.Location = new System.Drawing.Point(1246, 68);
            this.btnGD_Pdf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGD_Pdf.Name = "btnGD_Pdf";
            this.btnGD_Pdf.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnGD_Pdf.Size = new System.Drawing.Size(102, 101);
            this.btnGD_Pdf.TabIndex = 39;
            this.btnGD_Pdf.TabStop = false;
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
            this.btnGD_Eliminar.Location = new System.Drawing.Point(1518, 625);
            this.btnGD_Eliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGD_Eliminar.Name = "btnGD_Eliminar";
            this.btnGD_Eliminar.Rotation = 0D;
            this.btnGD_Eliminar.Size = new System.Drawing.Size(330, 168);
            this.btnGD_Eliminar.TabIndex = 37;
            this.btnGD_Eliminar.Text = "ELIMINAR";
            this.btnGD_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGD_Eliminar.UseVisualStyleBackColor = true;
            this.btnGD_Eliminar.Click += new System.EventHandler(this.btnGD_Eliminar_Click);
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
            this.btnGD_Editar.Location = new System.Drawing.Point(1518, 428);
            this.btnGD_Editar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGD_Editar.Name = "btnGD_Editar";
            this.btnGD_Editar.Rotation = 0D;
            this.btnGD_Editar.Size = new System.Drawing.Size(330, 168);
            this.btnGD_Editar.TabIndex = 36;
            this.btnGD_Editar.Text = "EDITAR";
            this.btnGD_Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGD_Editar.UseVisualStyleBackColor = true;
            this.btnGD_Editar.Click += new System.EventHandler(this.btnGD_Editar_Click);
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
            this.btnGD_Agregar.Location = new System.Drawing.Point(1518, 232);
            this.btnGD_Agregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGD_Agregar.Name = "btnGD_Agregar";
            this.btnGD_Agregar.Rotation = 0D;
            this.btnGD_Agregar.Size = new System.Drawing.Size(330, 168);
            this.btnGD_Agregar.TabIndex = 35;
            this.btnGD_Agregar.Text = "AGREGAR";
            this.btnGD_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGD_Agregar.UseVisualStyleBackColor = true;
            this.btnGD_Agregar.Click += new System.EventHandler(this.btnGD_Agregar_Click);
            // 
            // dtgrdocente
            // 
            this.dtgrdocente.AllowUserToAddRows = false;
            this.dtgrdocente.AllowUserToDeleteRows = false;
            this.dtgrdocente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtgrdocente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgrdocente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgrdocente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrdocente.DefaultCellStyle = dataGridViewCellStyle9;
            this.dtgrdocente.Location = new System.Drawing.Point(65, 210);
            this.dtgrdocente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgrdocente.Name = "dtgrdocente";
            this.dtgrdocente.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrdocente.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgrdocente.RowTemplate.Height = 24;
            this.dtgrdocente.Size = new System.Drawing.Size(1284, 619);
            this.dtgrdocente.TabIndex = 42;
            // 
            // frmDocentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1909, 968);
            this.Controls.Add(this.dtgrdocente);
            this.Controls.Add(this.btnGD_Filtrar);
            this.Controls.Add(this.btnGD_Excel);
            this.Controls.Add(this.btnGD_Pdf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGD_Eliminar);
            this.Controls.Add(this.btnGD_Editar);
            this.Controls.Add(this.btnGD_Agregar);
            this.Controls.Add(this.txtGU_Buscar);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDocentes";
            this.Text = "GESTIÓN DOCENTES";
            ((System.ComponentModel.ISupportInitialize)(this.btnGD_Filtrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGD_Excel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGD_Pdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrdocente)).EndInit();
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
        private System.Windows.Forms.DataGridView dtgrdocente;
    }
}