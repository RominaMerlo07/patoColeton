namespace GestionJardin
{
    partial class frmUsuariosPopUpEditar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.btn_CancelarUsuMod = new FontAwesome.Sharp.IconButton();
            this.btn_GuardarUsuMod = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(117, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "INGRESE NUEVA CONTRASEÑA PARA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(285, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "USUARIO";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(209, 201);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "CONTRASEÑA";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(297, 33);
            this.metroTextBox1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.TabIndex = 2;
            this.metroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.UseStyleColors = true;
            this.metroTextBox1.WaterMark = "CONTRASEÑA";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_CancelarUsuMod
            // 
            this.btn_CancelarUsuMod.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_CancelarUsuMod.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btn_CancelarUsuMod.IconColor = System.Drawing.Color.Black;
            this.btn_CancelarUsuMod.IconSize = 36;
            this.btn_CancelarUsuMod.Location = new System.Drawing.Point(396, 315);
            this.btn_CancelarUsuMod.Name = "btn_CancelarUsuMod";
            this.btn_CancelarUsuMod.Rotation = 0D;
            this.btn_CancelarUsuMod.Size = new System.Drawing.Size(185, 52);
            this.btn_CancelarUsuMod.TabIndex = 6;
            this.btn_CancelarUsuMod.Text = "CANCELAR";
            this.btn_CancelarUsuMod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_CancelarUsuMod.UseVisualStyleBackColor = true;
            // 
            // btn_GuardarUsuMod
            // 
            this.btn_GuardarUsuMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(183)))), ((int)(((byte)(87)))));
            this.btn_GuardarUsuMod.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_GuardarUsuMod.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btn_GuardarUsuMod.IconColor = System.Drawing.Color.Black;
            this.btn_GuardarUsuMod.IconSize = 36;
            this.btn_GuardarUsuMod.Location = new System.Drawing.Point(121, 315);
            this.btn_GuardarUsuMod.Name = "btn_GuardarUsuMod";
            this.btn_GuardarUsuMod.Rotation = 0D;
            this.btn_GuardarUsuMod.Size = new System.Drawing.Size(184, 52);
            this.btn_GuardarUsuMod.TabIndex = 5;
            this.btn_GuardarUsuMod.Text = "CONFIRMAR";
            this.btn_GuardarUsuMod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_GuardarUsuMod.UseVisualStyleBackColor = false;
            // 
            // frmUsuariosPopUpEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(206)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(704, 445);
            this.Controls.Add(this.btn_CancelarUsuMod);
            this.Controls.Add(this.btn_GuardarUsuMod);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmUsuariosPopUpEditar";
            this.Text = "MODIFICAR CONTRASEÑA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private FontAwesome.Sharp.IconButton btn_CancelarUsuMod;
        private FontAwesome.Sharp.IconButton btn_GuardarUsuMod;
    }
}