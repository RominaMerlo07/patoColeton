namespace GestionJardin
{
    partial class frmUsuariosPopUpAgregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuariosPopUpAgregar));
            this.txt_nombre_usuario = new MetroFramework.Controls.MetroTextBox();
            this.btn_GuardarUsuNuevo = new FontAwesome.Sharp.IconButton();
            this.btn_CancelarUsuNuevo = new FontAwesome.Sharp.IconButton();
            this.txt_contra_usu = new MetroFramework.Controls.MetroTextBox();
            this.txtSeleccionarDocente = new MetroFramework.Controls.MetroTextBox();
            this.lblNvoUsu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_nombre_usuario
            // 
            // 
            // 
            // 
            this.txt_nombre_usuario.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_usuario.CustomButton.Image = null;
            this.txt_nombre_usuario.CustomButton.Location = new System.Drawing.Point(104, 2);
            this.txt_nombre_usuario.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombre_usuario.CustomButton.Name = "";
            this.txt_nombre_usuario.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_nombre_usuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_nombre_usuario.CustomButton.TabIndex = 1;
            this.txt_nombre_usuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_nombre_usuario.CustomButton.UseSelectable = true;
            this.txt_nombre_usuario.CustomButton.Visible = false;
            this.txt_nombre_usuario.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_nombre_usuario.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txt_nombre_usuario.ForeColor = System.Drawing.Color.White;
            this.txt_nombre_usuario.IconRight = true;
            this.txt_nombre_usuario.Lines = new string[0];
            this.txt_nombre_usuario.Location = new System.Drawing.Point(230, 118);
            this.txt_nombre_usuario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombre_usuario.MaxLength = 32767;
            this.txt_nombre_usuario.Name = "txt_nombre_usuario";
            this.txt_nombre_usuario.PasswordChar = '\0';
            this.txt_nombre_usuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_nombre_usuario.SelectedText = "";
            this.txt_nombre_usuario.SelectionLength = 0;
            this.txt_nombre_usuario.SelectionStart = 0;
            this.txt_nombre_usuario.ShortcutsEnabled = true;
            this.txt_nombre_usuario.Size = new System.Drawing.Size(134, 32);
            this.txt_nombre_usuario.Style = MetroFramework.MetroColorStyle.Green;
            this.txt_nombre_usuario.TabIndex = 6;
            this.txt_nombre_usuario.TabStop = false;
            this.txt_nombre_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_nombre_usuario.UseCustomBackColor = true;
            this.txt_nombre_usuario.UseCustomForeColor = true;
            this.txt_nombre_usuario.UseSelectable = true;
            this.txt_nombre_usuario.UseStyleColors = true;
            this.txt_nombre_usuario.WaterMarkColor = System.Drawing.Color.Lime;
            this.txt_nombre_usuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_GuardarUsuNuevo
            // 
            this.btn_GuardarUsuNuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_GuardarUsuNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GuardarUsuNuevo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_GuardarUsuNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GuardarUsuNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_GuardarUsuNuevo.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btn_GuardarUsuNuevo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_GuardarUsuNuevo.IconSize = 50;
            this.btn_GuardarUsuNuevo.Location = new System.Drawing.Point(57, 271);
            this.btn_GuardarUsuNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_GuardarUsuNuevo.Name = "btn_GuardarUsuNuevo";
            this.btn_GuardarUsuNuevo.Rotation = 0D;
            this.btn_GuardarUsuNuevo.Size = new System.Drawing.Size(162, 54);
            this.btn_GuardarUsuNuevo.TabIndex = 41;
            this.btn_GuardarUsuNuevo.Text = "GUARDAR";
            this.btn_GuardarUsuNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_GuardarUsuNuevo.UseVisualStyleBackColor = true;
            this.btn_GuardarUsuNuevo.Click += new System.EventHandler(this.btn_GuardarUsuNuevo_Click);
            // 
            // btn_CancelarUsuNuevo
            // 
            this.btn_CancelarUsuNuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_CancelarUsuNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelarUsuNuevo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_CancelarUsuNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelarUsuNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_CancelarUsuNuevo.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btn_CancelarUsuNuevo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_CancelarUsuNuevo.IconSize = 50;
            this.btn_CancelarUsuNuevo.Location = new System.Drawing.Point(281, 271);
            this.btn_CancelarUsuNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_CancelarUsuNuevo.Name = "btn_CancelarUsuNuevo";
            this.btn_CancelarUsuNuevo.Rotation = 0D;
            this.btn_CancelarUsuNuevo.Size = new System.Drawing.Size(162, 54);
            this.btn_CancelarUsuNuevo.TabIndex = 42;
            this.btn_CancelarUsuNuevo.Text = "CANCELAR";
            this.btn_CancelarUsuNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CancelarUsuNuevo.UseVisualStyleBackColor = true;
            this.btn_CancelarUsuNuevo.Click += new System.EventHandler(this.btn_CancelarUsuNuevo_Click);
            // 
            // txt_contra_usu
            // 
            // 
            // 
            // 
            this.txt_contra_usu.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contra_usu.CustomButton.Image = null;
            this.txt_contra_usu.CustomButton.Location = new System.Drawing.Point(214, 2);
            this.txt_contra_usu.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.txt_contra_usu.CustomButton.Name = "";
            this.txt_contra_usu.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txt_contra_usu.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_contra_usu.CustomButton.TabIndex = 1;
            this.txt_contra_usu.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_contra_usu.CustomButton.UseSelectable = true;
            this.txt_contra_usu.CustomButton.Visible = false;
            this.txt_contra_usu.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_contra_usu.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txt_contra_usu.ForeColor = System.Drawing.Color.White;
            this.txt_contra_usu.IconRight = true;
            this.txt_contra_usu.Lines = new string[0];
            this.txt_contra_usu.Location = new System.Drawing.Point(120, 188);
            this.txt_contra_usu.Margin = new System.Windows.Forms.Padding(2);
            this.txt_contra_usu.MaxLength = 32767;
            this.txt_contra_usu.Name = "txt_contra_usu";
            this.txt_contra_usu.PasswordChar = '\0';
            this.txt_contra_usu.PromptText = "INGRESE UNA CONTRASEÑA";
            this.txt_contra_usu.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_contra_usu.SelectedText = "";
            this.txt_contra_usu.SelectionLength = 0;
            this.txt_contra_usu.SelectionStart = 0;
            this.txt_contra_usu.ShortcutsEnabled = true;
            this.txt_contra_usu.Size = new System.Drawing.Size(244, 32);
            this.txt_contra_usu.Style = MetroFramework.MetroColorStyle.Green;
            this.txt_contra_usu.TabIndex = 3;
            this.txt_contra_usu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_contra_usu.UseCustomBackColor = true;
            this.txt_contra_usu.UseCustomForeColor = true;
            this.txt_contra_usu.UseSelectable = true;
            this.txt_contra_usu.UseStyleColors = true;
            this.txt_contra_usu.WaterMark = "INGRESE UNA CONTRASEÑA";
            this.txt_contra_usu.WaterMarkColor = System.Drawing.Color.Lime;
            this.txt_contra_usu.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contra_usu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_contra_usu_KeyPress);
            // 
            // txtSeleccionarDocente
            // 
            this.txtSeleccionarDocente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSeleccionarDocente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSeleccionarDocente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSeleccionarDocente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtSeleccionarDocente.CustomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSeleccionarDocente.CustomButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtSeleccionarDocente.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtSeleccionarDocente.CustomButton.Location = new System.Drawing.Point(267, 1);
            this.txtSeleccionarDocente.CustomButton.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.txtSeleccionarDocente.CustomButton.Name = "";
            this.txtSeleccionarDocente.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtSeleccionarDocente.CustomButton.Style = MetroFramework.MetroColorStyle.Black;
            this.txtSeleccionarDocente.CustomButton.TabIndex = 1;
            this.txtSeleccionarDocente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSeleccionarDocente.CustomButton.UseSelectable = true;
            this.txtSeleccionarDocente.CustomButton.UseStyleColors = true;
            this.txtSeleccionarDocente.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtSeleccionarDocente.Lines = new string[0];
            this.txtSeleccionarDocente.Location = new System.Drawing.Point(93, 37);
            this.txtSeleccionarDocente.Margin = new System.Windows.Forms.Padding(2);
            this.txtSeleccionarDocente.MaxLength = 32767;
            this.txtSeleccionarDocente.Name = "txtSeleccionarDocente";
            this.txtSeleccionarDocente.PasswordChar = '\0';
            this.txtSeleccionarDocente.PromptText = "INGRESE DOCENTE";
            this.txtSeleccionarDocente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSeleccionarDocente.SelectedText = "";
            this.txtSeleccionarDocente.SelectionLength = 0;
            this.txtSeleccionarDocente.SelectionStart = 0;
            this.txtSeleccionarDocente.ShortcutsEnabled = true;
            this.txtSeleccionarDocente.ShowButton = true;
            this.txtSeleccionarDocente.ShowClearButton = true;
            this.txtSeleccionarDocente.Size = new System.Drawing.Size(301, 35);
            this.txtSeleccionarDocente.Style = MetroFramework.MetroColorStyle.Lime;
            this.txtSeleccionarDocente.TabIndex = 1;
            this.txtSeleccionarDocente.UseSelectable = true;
            this.txtSeleccionarDocente.UseStyleColors = true;
            this.txtSeleccionarDocente.WaterMark = "INGRESE DOCENTE";
            this.txtSeleccionarDocente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSeleccionarDocente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeleccionarDocente.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtSeleccionarDocente_ButtonClick);
            // 
            // lblNvoUsu
            // 
            this.lblNvoUsu.AutoSize = true;
            this.lblNvoUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNvoUsu.ForeColor = System.Drawing.Color.Lime;
            this.lblNvoUsu.Location = new System.Drawing.Point(116, 118);
            this.lblNvoUsu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNvoUsu.Name = "lblNvoUsu";
            this.lblNvoUsu.Size = new System.Drawing.Size(92, 20);
            this.lblNvoUsu.TabIndex = 78;
            this.lblNvoUsu.Text = "USUARIO: ";
            // 
            // frmUsuariosPopUpAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(500, 366);
            this.Controls.Add(this.lblNvoUsu);
            this.Controls.Add(this.txtSeleccionarDocente);
            this.Controls.Add(this.txt_contra_usu);
            this.Controls.Add(this.btn_CancelarUsuNuevo);
            this.Controls.Add(this.btn_GuardarUsuNuevo);
            this.Controls.Add(this.txt_nombre_usuario);
            this.Location = new System.Drawing.Point(32, 177);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUsuariosPopUpAgregar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GESTIÓN USUARIO / GENERAR USUARIO NUEVO";
            this.Load += new System.EventHandler(this.frmUsuariosPopUpAgregar_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txt_nombre_usuario;
        private FontAwesome.Sharp.IconButton btn_GuardarUsuNuevo;
        private FontAwesome.Sharp.IconButton btn_CancelarUsuNuevo;
        public MetroFramework.Controls.MetroTextBox txtSeleccionarDocente;
        public System.Windows.Forms.Label lblNvoUsu;
        public MetroFramework.Controls.MetroTextBox txt_contra_usu;
    }
}