namespace GestionJardin
{
    partial class frmSalasPopUpEliminar
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
            this.lblIdSala = new System.Windows.Forms.Label();
            this.btn_Cancelar = new FontAwesome.Sharp.IconButton();
            this.btn_ConfirmarEliminar = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdSala
            // 
            this.lblIdSala.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIdSala.AutoSize = true;
            this.lblIdSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdSala.ForeColor = System.Drawing.Color.Yellow;
            this.lblIdSala.Location = new System.Drawing.Point(117, 375);
            this.lblIdSala.Name = "lblIdSala";
            this.lblIdSala.Size = new System.Drawing.Size(106, 32);
            this.lblIdSala.TabIndex = 22;
            this.lblIdSala.Text = "id_sala";
            this.lblIdSala.Visible = false;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_Cancelar.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btn_Cancelar.IconColor = System.Drawing.Color.DarkGray;
            this.btn_Cancelar.IconSize = 36;
            this.btn_Cancelar.Location = new System.Drawing.Point(575, 369);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Rotation = 0D;
            this.btn_Cancelar.Size = new System.Drawing.Size(125, 52);
            this.btn_Cancelar.TabIndex = 21;
            this.btn_Cancelar.Text = "NO";
            this.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_ConfirmarEliminar
            // 
            this.btn_ConfirmarEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ConfirmarEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btn_ConfirmarEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConfirmarEliminar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_ConfirmarEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConfirmarEliminar.ForeColor = System.Drawing.Color.Red;
            this.btn_ConfirmarEliminar.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btn_ConfirmarEliminar.IconColor = System.Drawing.Color.Red;
            this.btn_ConfirmarEliminar.IconSize = 36;
            this.btn_ConfirmarEliminar.Location = new System.Drawing.Point(368, 369);
            this.btn_ConfirmarEliminar.Name = "btn_ConfirmarEliminar";
            this.btn_ConfirmarEliminar.Rotation = 0D;
            this.btn_ConfirmarEliminar.Size = new System.Drawing.Size(125, 52);
            this.btn_ConfirmarEliminar.TabIndex = 20;
            this.btn_ConfirmarEliminar.Text = "SI";
            this.btn_ConfirmarEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ConfirmarEliminar.UseVisualStyleBackColor = false;
            this.btn_ConfirmarEliminar.Click += new System.EventHandler(this.btn_ConfirmarEliminar_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(393, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "NO podrá reactivar la misma";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(364, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tenga en cuenta que al confirmar,";
            // 
            // lblSala
            // 
            this.lblSala.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSala.AutoSize = true;
            this.lblSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSala.ForeColor = System.Drawing.Color.Yellow;
            this.lblSala.Location = new System.Drawing.Point(451, 92);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(111, 32);
            this.lblSala.TabIndex = 17;
            this.lblSala.Text = "SALA ?";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "¿Esta seguro que desea ELIMINAR la SALA";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Red;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Red;
            this.iconPictureBox1.IconSize = 170;
            this.iconPictureBox1.Location = new System.Drawing.Point(76, 142);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Padding = new System.Windows.Forms.Padding(5);
            this.iconPictureBox1.Size = new System.Drawing.Size(190, 170);
            this.iconPictureBox1.TabIndex = 15;
            this.iconPictureBox1.TabStop = false;
            // 
            // frmSalasPopUpEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIdSala);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_ConfirmarEliminar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSala);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconPictureBox1);
            this.Name = "frmSalasPopUpEliminar";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdSala;
        private FontAwesome.Sharp.IconButton btn_Cancelar;
        private FontAwesome.Sharp.IconButton btn_ConfirmarEliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}