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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnGU_Filtrar = new FontAwesome.Sharp.IconPictureBox();
            this.btnGU_Excel = new FontAwesome.Sharp.IconPictureBox();
            this.btnGU_Pdf = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGU_Eliminar = new FontAwesome.Sharp.IconButton();
            this.btnGU_Editar = new FontAwesome.Sharp.IconButton();
            this.btnGU_Agregar = new FontAwesome.Sharp.IconButton();
            this.txtGU_Buscar = new MetroFramework.Controls.MetroTextBox();
            this.dgv_UsuariosActivos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btnGU_Filtrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGU_Excel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGU_Pdf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UsuariosActivos)).BeginInit();
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
            this.btnGU_Filtrar.IconSize = 66;
            this.btnGU_Filtrar.Location = new System.Drawing.Point(655, 24);
            this.btnGU_Filtrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGU_Filtrar.Name = "btnGU_Filtrar";
            this.btnGU_Filtrar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGU_Filtrar.Size = new System.Drawing.Size(69, 66);
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
            this.btnGU_Excel.IconSize = 66;
            this.btnGU_Excel.Location = new System.Drawing.Point(745, 24);
            this.btnGU_Excel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGU_Excel.Name = "btnGU_Excel";
            this.btnGU_Excel.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGU_Excel.Size = new System.Drawing.Size(69, 66);
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
            this.btnGU_Pdf.IconSize = 66;
            this.btnGU_Pdf.Location = new System.Drawing.Point(826, 24);
            this.btnGU_Pdf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGU_Pdf.Name = "btnGU_Pdf";
            this.btnGU_Pdf.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGU_Pdf.Size = new System.Drawing.Size(69, 66);
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
            this.label1.Location = new System.Drawing.Point(36, 550);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(692, 17);
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
            this.btnGU_Eliminar.ForeColor = System.Drawing.Color.Gray;
            this.btnGU_Eliminar.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btnGU_Eliminar.IconColor = System.Drawing.Color.Gray;
            this.btnGU_Eliminar.IconSize = 100;
            this.btnGU_Eliminar.Location = new System.Drawing.Point(997, 398);
            this.btnGU_Eliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGU_Eliminar.Name = "btnGU_Eliminar";
            this.btnGU_Eliminar.Rotation = 0D;
            this.btnGU_Eliminar.Size = new System.Drawing.Size(220, 109);
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
            this.btnGU_Editar.ForeColor = System.Drawing.Color.Gray;
            this.btnGU_Editar.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnGU_Editar.IconColor = System.Drawing.Color.Gray;
            this.btnGU_Editar.IconSize = 100;
            this.btnGU_Editar.Location = new System.Drawing.Point(997, 271);
            this.btnGU_Editar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGU_Editar.Name = "btnGU_Editar";
            this.btnGU_Editar.Rotation = 0D;
            this.btnGU_Editar.Size = new System.Drawing.Size(220, 109);
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
            this.btnGU_Agregar.Location = new System.Drawing.Point(997, 143);
            this.btnGU_Agregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGU_Agregar.Name = "btnGU_Agregar";
            this.btnGU_Agregar.Rotation = 0D;
            this.btnGU_Agregar.Size = new System.Drawing.Size(220, 109);
            this.btnGU_Agregar.TabIndex = 26;
            this.btnGU_Agregar.Text = "AGREGAR";
            this.btnGU_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGU_Agregar.UseVisualStyleBackColor = true;
            this.btnGU_Agregar.Click += new System.EventHandler(this.btnGU_Agregar_Click);
            // 
            // txtGU_Buscar
            // 
            this.txtGU_Buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGU_Buscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtGU_Buscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.txtGU_Buscar.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGU_Buscar.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtGU_Buscar.CustomButton.Location = new System.Drawing.Point(278, 1);
            this.txtGU_Buscar.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGU_Buscar.CustomButton.Name = "";
            this.txtGU_Buscar.CustomButton.Size = new System.Drawing.Size(39, 39);
            this.txtGU_Buscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGU_Buscar.CustomButton.TabIndex = 1;
            this.txtGU_Buscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGU_Buscar.CustomButton.UseSelectable = true;
            this.txtGU_Buscar.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtGU_Buscar.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtGU_Buscar.Lines = new string[0];
            this.txtGU_Buscar.Location = new System.Drawing.Point(39, 34);
            this.txtGU_Buscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.txtGU_Buscar.Size = new System.Drawing.Size(318, 41);
            this.txtGU_Buscar.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtGU_Buscar.TabIndex = 33;
            this.txtGU_Buscar.UseSelectable = true;
            this.txtGU_Buscar.WaterMark = "BUSCAR DOCENTE";
            this.txtGU_Buscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGU_Buscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGU_Buscar.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtGU_Buscar_ButtonClick);
            this.txtGU_Buscar.TextChanged += new System.EventHandler(this.txtGU_Buscar_TextChanged);
            this.txtGU_Buscar.Enter += new System.EventHandler(this.txtGU_Buscar_Enter);
            // 
            // dgv_UsuariosActivos
            // 
            this.dgv_UsuariosActivos.AllowUserToAddRows = false;
            this.dgv_UsuariosActivos.AllowUserToDeleteRows = false;
            this.dgv_UsuariosActivos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_UsuariosActivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_UsuariosActivos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_UsuariosActivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_UsuariosActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_UsuariosActivos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_UsuariosActivos.Location = new System.Drawing.Point(39, 125);
            this.dgv_UsuariosActivos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_UsuariosActivos.MultiSelect = false;
            this.dgv_UsuariosActivos.Name = "dgv_UsuariosActivos";
            this.dgv_UsuariosActivos.ReadOnly = true;
            this.dgv_UsuariosActivos.RowTemplate.Height = 24;
            this.dgv_UsuariosActivos.Size = new System.Drawing.Size(855, 397);
            this.dgv_UsuariosActivos.TabIndex = 34;
            this.dgv_UsuariosActivos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_UsuariosActivos_CellClick_1);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.dgv_UsuariosActivos);
            this.Controls.Add(this.txtGU_Buscar);
            this.Controls.Add(this.btnGU_Filtrar);
            this.Controls.Add(this.btnGU_Excel);
            this.Controls.Add(this.btnGU_Pdf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGU_Eliminar);
            this.Controls.Add(this.btnGU_Editar);
            this.Controls.Add(this.btnGU_Agregar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmUsuarios";
            this.Text = "GESTIÓN USUARIOS";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnGU_Filtrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGU_Excel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGU_Pdf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UsuariosActivos)).EndInit();
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
        public System.Windows.Forms.DataGridView dgv_UsuariosActivos;
    }
}