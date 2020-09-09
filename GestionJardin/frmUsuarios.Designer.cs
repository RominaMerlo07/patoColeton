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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_UsuarioActivo = new System.Windows.Forms.Panel();
            this.dgv_UsuariosActivos = new MetroFramework.Controls.MetroGrid();
            this.DOCENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONTRASEÑA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_ALTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA_MODIFICACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDocenteFiltro = new MetroFramework.Controls.MetroTextBox();
            this.btn_EliminarUsuario = new FontAwesome.Sharp.IconPictureBox();
            this.btn_EditarUsuario = new FontAwesome.Sharp.IconPictureBox();
            this.btn_AgregarUsuario = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            this.panel_UsuarioActivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UsuariosActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EliminarUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EditarUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.btn_EliminarUsuario);
            this.panel1.Controls.Add(this.btn_EditarUsuario);
            this.panel1.Controls.Add(this.btn_AgregarUsuario);
            this.panel1.Controls.Add(this.panel_UsuarioActivo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1131, 725);
            this.panel1.TabIndex = 0;
            // 
            // panel_UsuarioActivo
            // 
            this.panel_UsuarioActivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_UsuarioActivo.Controls.Add(this.dgv_UsuariosActivos);
            this.panel_UsuarioActivo.Controls.Add(this.txtDocenteFiltro);
            this.panel_UsuarioActivo.Location = new System.Drawing.Point(67, 61);
            this.panel_UsuarioActivo.Name = "panel_UsuarioActivo";
            this.panel_UsuarioActivo.Size = new System.Drawing.Size(723, 605);
            this.panel_UsuarioActivo.TabIndex = 62;
            // 
            // dgv_UsuariosActivos
            // 
            this.dgv_UsuariosActivos.AllowUserToAddRows = false;
            this.dgv_UsuariosActivos.AllowUserToDeleteRows = false;
            this.dgv_UsuariosActivos.AllowUserToResizeRows = false;
            this.dgv_UsuariosActivos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_UsuariosActivos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_UsuariosActivos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgv_UsuariosActivos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_UsuariosActivos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_UsuariosActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UsuariosActivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DOCENTE,
            this.USUARIO,
            this.CONTRASEÑA,
            this.FECHA_ALTA,
            this.FECHA_MODIFICACION});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_UsuariosActivos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_UsuariosActivos.EnableHeadersVisualStyles = false;
            this.dgv_UsuariosActivos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgv_UsuariosActivos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgv_UsuariosActivos.Location = new System.Drawing.Point(32, 177);
            this.dgv_UsuariosActivos.Name = "dgv_UsuariosActivos";
            this.dgv_UsuariosActivos.ReadOnly = true;
            this.dgv_UsuariosActivos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_UsuariosActivos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_UsuariosActivos.RowHeadersWidth = 45;
            this.dgv_UsuariosActivos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_UsuariosActivos.RowTemplate.Height = 24;
            this.dgv_UsuariosActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_UsuariosActivos.Size = new System.Drawing.Size(651, 377);
            this.dgv_UsuariosActivos.TabIndex = 64;
            // 
            // DOCENTE
            // 
            this.DOCENTE.HeaderText = "DOCENTE";
            this.DOCENTE.Name = "DOCENTE";
            this.DOCENTE.ReadOnly = true;
            // 
            // USUARIO
            // 
            this.USUARIO.HeaderText = "USUARIO";
            this.USUARIO.Name = "USUARIO";
            this.USUARIO.ReadOnly = true;
            // 
            // CONTRASEÑA
            // 
            this.CONTRASEÑA.HeaderText = "CONTRASEÑA";
            this.CONTRASEÑA.Name = "CONTRASEÑA";
            this.CONTRASEÑA.ReadOnly = true;
            // 
            // FECHA_ALTA
            // 
            this.FECHA_ALTA.HeaderText = "FECHA_ALTA";
            this.FECHA_ALTA.Name = "FECHA_ALTA";
            this.FECHA_ALTA.ReadOnly = true;
            // 
            // FECHA_MODIFICACION
            // 
            this.FECHA_MODIFICACION.HeaderText = "FECHA_MODIFICACION";
            this.FECHA_MODIFICACION.Name = "FECHA_MODIFICACION";
            this.FECHA_MODIFICACION.ReadOnly = true;
            // 
            // txtDocenteFiltro
            // 
            this.txtDocenteFiltro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDocenteFiltro.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDocenteFiltro.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDocenteFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtDocenteFiltro.CustomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDocenteFiltro.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtDocenteFiltro.CustomButton.Location = new System.Drawing.Point(501, 1);
            this.txtDocenteFiltro.CustomButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtDocenteFiltro.CustomButton.Name = "";
            this.txtDocenteFiltro.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.txtDocenteFiltro.CustomButton.Style = MetroFramework.MetroColorStyle.Black;
            this.txtDocenteFiltro.CustomButton.TabIndex = 1;
            this.txtDocenteFiltro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDocenteFiltro.CustomButton.UseSelectable = true;
            this.txtDocenteFiltro.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtDocenteFiltro.Lines = new string[0];
            this.txtDocenteFiltro.Location = new System.Drawing.Point(87, 37);
            this.txtDocenteFiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDocenteFiltro.MaxLength = 32767;
            this.txtDocenteFiltro.Name = "txtDocenteFiltro";
            this.txtDocenteFiltro.PasswordChar = '\0';
            this.txtDocenteFiltro.PromptText = "DOCENTE";
            this.txtDocenteFiltro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDocenteFiltro.SelectedText = "";
            this.txtDocenteFiltro.SelectionLength = 0;
            this.txtDocenteFiltro.SelectionStart = 0;
            this.txtDocenteFiltro.ShortcutsEnabled = true;
            this.txtDocenteFiltro.ShowButton = true;
            this.txtDocenteFiltro.ShowClearButton = true;
            this.txtDocenteFiltro.Size = new System.Drawing.Size(543, 43);
            this.txtDocenteFiltro.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDocenteFiltro.TabIndex = 63;
            this.txtDocenteFiltro.UseSelectable = true;
            this.txtDocenteFiltro.UseStyleColors = true;
            this.txtDocenteFiltro.WaterMark = "DOCENTE";
            this.txtDocenteFiltro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDocenteFiltro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_EliminarUsuario
            // 
            this.btn_EliminarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_EliminarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btn_EliminarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_EliminarUsuario.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btn_EliminarUsuario.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_EliminarUsuario.IconSize = 131;
            this.btn_EliminarUsuario.Location = new System.Drawing.Point(955, 500);
            this.btn_EliminarUsuario.Name = "btn_EliminarUsuario";
            this.btn_EliminarUsuario.Size = new System.Drawing.Size(138, 131);
            this.btn_EliminarUsuario.TabIndex = 68;
            this.btn_EliminarUsuario.TabStop = false;
            this.btn_EliminarUsuario.Click += new System.EventHandler(this.btn_EliminarUsuario_Click);
            // 
            // btn_EditarUsuario
            // 
            this.btn_EditarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_EditarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btn_EditarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(213)))), ((int)(((byte)(249)))));
            this.btn_EditarUsuario.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btn_EditarUsuario.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(213)))), ((int)(((byte)(249)))));
            this.btn_EditarUsuario.IconSize = 131;
            this.btn_EditarUsuario.Location = new System.Drawing.Point(955, 296);
            this.btn_EditarUsuario.Name = "btn_EditarUsuario";
            this.btn_EditarUsuario.Size = new System.Drawing.Size(138, 131);
            this.btn_EditarUsuario.TabIndex = 67;
            this.btn_EditarUsuario.TabStop = false;
            this.btn_EditarUsuario.Click += new System.EventHandler(this.btn_EditarUsuario_Click);
            // 
            // btn_AgregarUsuario
            // 
            this.btn_AgregarUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_AgregarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btn_AgregarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(244)))), ((int)(((byte)(190)))));
            this.btn_AgregarUsuario.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btn_AgregarUsuario.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(244)))), ((int)(((byte)(190)))));
            this.btn_AgregarUsuario.IconSize = 131;
            this.btn_AgregarUsuario.Location = new System.Drawing.Point(955, 98);
            this.btn_AgregarUsuario.Name = "btn_AgregarUsuario";
            this.btn_AgregarUsuario.Size = new System.Drawing.Size(138, 131);
            this.btn_AgregarUsuario.TabIndex = 66;
            this.btn_AgregarUsuario.TabStop = false;
            this.btn_AgregarUsuario.Click += new System.EventHandler(this.btn_AgregarUsuario_Click);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 725);
            this.Controls.Add(this.panel1);
            this.Name = "frmUsuarios";
            this.Text = "GESTIÓN USUARIOS";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel_UsuarioActivo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UsuariosActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EliminarUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_EditarUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_AgregarUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_UsuarioActivo;
        private MetroFramework.Controls.MetroGrid dgv_UsuariosActivos;
        private MetroFramework.Controls.MetroTextBox txtDocenteFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOCENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTRASEÑA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_ALTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA_MODIFICACION;
        private FontAwesome.Sharp.IconPictureBox btn_AgregarUsuario;
        private FontAwesome.Sharp.IconPictureBox btn_EditarUsuario;
        private FontAwesome.Sharp.IconPictureBox btn_EliminarUsuario;
    }
}