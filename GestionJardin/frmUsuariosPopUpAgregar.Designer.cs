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
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.btn_CancelarUsuNuevo = new FontAwesome.Sharp.IconButton();
            this.btn_GuardarUsuNuevo = new FontAwesome.Sharp.IconButton();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 24;
            this.metroComboBox1.Location = new System.Drawing.Point(76, 37);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.PromptText = "SELECCIONE DOCENTE";
            this.metroComboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.metroComboBox1.Size = new System.Drawing.Size(420, 30);
            this.metroComboBox1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroComboBox1.TabIndex = 0;
            this.metroComboBox1.UseCustomBackColor = true;
            this.metroComboBox1.UseSelectable = true;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(187, 2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBox1.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTextBox1.IconRight = true;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(177, 119);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "USUARIO";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(215, 30);
            this.metroTextBox1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBox1.TabIndex = 1;
            this.metroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.UseStyleColors = true;
            this.metroTextBox1.WaterMark = "USUARIO";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_CancelarUsuNuevo
            // 
            this.btn_CancelarUsuNuevo.BackColor = System.Drawing.Color.DarkGray;
            this.btn_CancelarUsuNuevo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_CancelarUsuNuevo.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btn_CancelarUsuNuevo.IconColor = System.Drawing.Color.Black;
            this.btn_CancelarUsuNuevo.IconSize = 36;
            this.btn_CancelarUsuNuevo.Location = new System.Drawing.Point(326, 298);
            this.btn_CancelarUsuNuevo.Name = "btn_CancelarUsuNuevo";
            this.btn_CancelarUsuNuevo.Rotation = 0D;
            this.btn_CancelarUsuNuevo.Size = new System.Drawing.Size(170, 52);
            this.btn_CancelarUsuNuevo.TabIndex = 4;
            this.btn_CancelarUsuNuevo.Text = "CANCELAR";
            this.btn_CancelarUsuNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CancelarUsuNuevo.UseVisualStyleBackColor = false;
            // 
            // btn_GuardarUsuNuevo
            // 
            this.btn_GuardarUsuNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(183)))), ((int)(((byte)(87)))));
            this.btn_GuardarUsuNuevo.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_GuardarUsuNuevo.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btn_GuardarUsuNuevo.IconColor = System.Drawing.Color.Black;
            this.btn_GuardarUsuNuevo.IconSize = 36;
            this.btn_GuardarUsuNuevo.Location = new System.Drawing.Point(76, 298);
            this.btn_GuardarUsuNuevo.Name = "btn_GuardarUsuNuevo";
            this.btn_GuardarUsuNuevo.Rotation = 0D;
            this.btn_GuardarUsuNuevo.Size = new System.Drawing.Size(170, 52);
            this.btn_GuardarUsuNuevo.TabIndex = 3;
            this.btn_GuardarUsuNuevo.Text = "GUARDAR";
            this.btn_GuardarUsuNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_GuardarUsuNuevo.UseVisualStyleBackColor = false;
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(187, 2);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.metroTextBox2.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.metroTextBox2.Icon = ((System.Drawing.Image)(resources.GetObject("metroTextBox2.Icon")));
            this.metroTextBox2.IconRight = true;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(177, 205);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.PromptText = "CONTRASEÑA";
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(215, 30);
            this.metroTextBox2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBox2.TabIndex = 2;
            this.metroTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.UseStyleColors = true;
            this.metroTextBox2.WaterMark = "CONTRASEÑA";
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frmUsuariosPopUpAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(587, 420);
            this.Controls.Add(this.btn_CancelarUsuNuevo);
            this.Controls.Add(this.btn_GuardarUsuNuevo);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroComboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Location = new System.Drawing.Point(32, 177);
            this.Name = "frmUsuariosPopUpAgregar";
            this.Text = "GENERAR USUARIO";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private FontAwesome.Sharp.IconButton btn_GuardarUsuNuevo;
        private FontAwesome.Sharp.IconButton btn_CancelarUsuNuevo;
    }
}