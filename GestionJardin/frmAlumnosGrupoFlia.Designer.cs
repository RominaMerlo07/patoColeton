namespace GestionJardin
{
    partial class frmAlumnosGrupoFlia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGF_Eliminar = new FontAwesome.Sharp.IconButton();
            this.btnGF_Editar = new FontAwesome.Sharp.IconButton();
            this.btnGF_Agregar = new FontAwesome.Sharp.IconButton();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(120, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(814, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "* Para poder editar los datos de un alumno o dar de baja al mismo, debe seleccion" +
    "ar el registro previamente";
            // 
            // btnGF_Eliminar
            // 
            this.btnGF_Eliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGF_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGF_Eliminar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGF_Eliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGF_Eliminar.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btnGF_Eliminar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGF_Eliminar.IconSize = 100;
            this.btnGF_Eliminar.Location = new System.Drawing.Point(1032, 428);
            this.btnGF_Eliminar.Name = "btnGF_Eliminar";
            this.btnGF_Eliminar.Rotation = 0D;
            this.btnGF_Eliminar.Size = new System.Drawing.Size(206, 104);
            this.btnGF_Eliminar.TabIndex = 14;
            this.btnGF_Eliminar.Text = "ELIMINAR";
            this.btnGF_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGF_Eliminar.UseVisualStyleBackColor = true;
            // 
            // btnGF_Editar
            // 
            this.btnGF_Editar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGF_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGF_Editar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGF_Editar.ForeColor = System.Drawing.Color.Cyan;
            this.btnGF_Editar.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnGF_Editar.IconColor = System.Drawing.Color.Cyan;
            this.btnGF_Editar.IconSize = 100;
            this.btnGF_Editar.Location = new System.Drawing.Point(1032, 266);
            this.btnGF_Editar.Name = "btnGF_Editar";
            this.btnGF_Editar.Rotation = 0D;
            this.btnGF_Editar.Size = new System.Drawing.Size(206, 104);
            this.btnGF_Editar.TabIndex = 13;
            this.btnGF_Editar.Text = "EDITAR";
            this.btnGF_Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGF_Editar.UseVisualStyleBackColor = true;
            // 
            // btnGF_Agregar
            // 
            this.btnGF_Agregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGF_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGF_Agregar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGF_Agregar.ForeColor = System.Drawing.Color.Lime;
            this.btnGF_Agregar.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnGF_Agregar.IconColor = System.Drawing.Color.Lime;
            this.btnGF_Agregar.IconSize = 100;
            this.btnGF_Agregar.Location = new System.Drawing.Point(1032, 114);
            this.btnGF_Agregar.Name = "btnGF_Agregar";
            this.btnGF_Agregar.Rotation = 0D;
            this.btnGF_Agregar.Size = new System.Drawing.Size(206, 104);
            this.btnGF_Agregar.TabIndex = 12;
            this.btnGF_Agregar.Text = "AGREGAR";
            this.btnGF_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGF_Agregar.UseVisualStyleBackColor = true;
            this.btnGF_Agregar.Click += new System.EventHandler(this.btnGF_Agregar_Click);
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(351, 2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(50, 112);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "BUSCAR PERSONA";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(379, 30);
            this.metroTextBox1.TabIndex = 11;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "BUSCAR PERSONA";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(50, 191);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.RowTemplate.Height = 24;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(931, 339);
            this.metroGrid1.TabIndex = 10;
            // 
            // alumno
            // 
            this.alumno.HeaderText = "ALUMNO";
            this.alumno.Name = "alumno";
            this.alumno.ReadOnly = true;
            // 
            // documento
            // 
            this.documento.HeaderText = "DOCUMENTO";
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            // 
            // FechaNac
            // 
            this.FechaNac.HeaderText = "FAMILIAR";
            this.FechaNac.Name = "FechaNac";
            this.FechaNac.ReadOnly = true;
            // 
            // Edad
            // 
            this.Edad.HeaderText = "DOCUMENTO";
            this.Edad.Name = "Edad";
            this.Edad.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "PARENTESCO";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "DOMICILIO";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // telefono_2
            // 
            this.telefono_2.HeaderText = "TELEFONO";
            this.telefono_2.Name = "telefono_2";
            this.telefono_2.ReadOnly = true;
            // 
            // turno
            // 
            this.turno.HeaderText = "TELEFONO 2";
            this.turno.Name = "turno";
            this.turno.ReadOnly = true;
            // 
            // Sala
            // 
            this.Sala.HeaderText = "E-MAIL";
            this.Sala.Name = "Sala";
            this.Sala.ReadOnly = true;
            // 
            // frmAlumnosGrupoFlia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1289, 645);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGF_Eliminar);
            this.Controls.Add(this.btnGF_Editar);
            this.Controls.Add(this.btnGF_Agregar);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroGrid1);
            this.Name = "frmAlumnosGrupoFlia";
            this.Text = "GRUPO FAMILIAR";
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnGF_Eliminar;
        private FontAwesome.Sharp.IconButton btnGF_Editar;
        private FontAwesome.Sharp.IconButton btnGF_Agregar;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn turno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sala;
    }
}