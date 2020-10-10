namespace GestionJardin
{
    partial class frmAsistencia
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
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.cbTurno = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbSala = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dgv_Alumnos = new System.Windows.Forms.DataGridView();
            this.txtGAs_Buscar = new MetroFramework.Controls.MetroTextBox();
            this.btnAsistencia = new FontAwesome.Sharp.IconPictureBox();
            this.btnInasistencia = new FontAwesome.Sharp.IconPictureBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblSala = new System.Windows.Forms.Label();
            this.labelFechError = new System.Windows.Forms.Label();
            this.lblFecha = new MetroFramework.Controls.MetroLabel();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAsistencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInasistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel3
            // 
            this.metroPanel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.metroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel3.Controls.Add(this.labelFechError);
            this.metroPanel3.Controls.Add(this.lblSala);
            this.metroPanel3.Controls.Add(this.lblTurno);
            this.metroPanel3.Controls.Add(this.lblFecha);
            this.metroPanel3.Controls.Add(this.cbTurno);
            this.metroPanel3.Controls.Add(this.metroLabel4);
            this.metroPanel3.Controls.Add(this.monthCalendar1);
            this.metroPanel3.Controls.Add(this.metroLabel1);
            this.metroPanel3.Controls.Add(this.cbSala);
            this.metroPanel3.Controls.Add(this.metroLabel2);
            this.metroPanel3.Controls.Add(this.metroLabel3);
            this.metroPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(30, 280);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(473, 675);
            this.metroPanel3.TabIndex = 1;
            this.metroPanel3.UseCustomBackColor = true;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // cbTurno
            // 
            this.cbTurno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbTurno.FormattingEnabled = true;
            this.cbTurno.ItemHeight = 24;
            this.cbTurno.Items.AddRange(new object[] {
            "MAÑANA",
            "TARDE"});
            this.cbTurno.Location = new System.Drawing.Point(232, 73);
            this.cbTurno.Name = "cbTurno";
            this.cbTurno.Size = new System.Drawing.Size(185, 30);
            this.cbTurno.Style = MetroFramework.MetroColorStyle.Green;
            this.cbTurno.TabIndex = 1;
            this.cbTurno.UseCustomBackColor = true;
            this.cbTurno.UseSelectable = true;
            this.cbTurno.UseStyleColors = true;
            this.cbTurno.SelectedValueChanged += new System.EventHandler(this.cbTurno_SelectedValueChanged);
            this.cbTurno.Leave += new System.EventHandler(this.cbTurno_Leave);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.metroLabel4.Location = new System.Drawing.Point(49, 73);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(163, 44);
            this.metroLabel4.TabIndex = 30;
            this.metroLabel4.Text = "TURNO";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(72, 319);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);

            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.metroLabel1.Location = new System.Drawing.Point(148, 253);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(144, 44);
            this.metroLabel1.TabIndex = 26;
            this.metroLabel1.Text = "FECHA:";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // cbSala
            // 
            this.cbSala.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbSala.Enabled = false;
            this.cbSala.FormattingEnabled = true;
            this.cbSala.ItemHeight = 24;
            this.cbSala.Location = new System.Drawing.Point(232, 159);
            this.cbSala.Name = "cbSala";
            this.cbSala.Size = new System.Drawing.Size(185, 30);
            this.cbSala.Style = MetroFramework.MetroColorStyle.Orange;
            this.cbSala.TabIndex = 2;
            this.cbSala.UseCustomBackColor = true;
            this.cbSala.UseSelectable = true;
            this.cbSala.UseStyleColors = true;
            this.cbSala.SelectedValueChanged += new System.EventHandler(this.cbSala_SelectedValueChanged);
            this.cbSala.Leave += new System.EventHandler(this.cbSala_Leave);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.metroLabel2.Location = new System.Drawing.Point(49, 159);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(212, 44);
            this.metroLabel2.TabIndex = 28;
            this.metroLabel2.Text = "SALA";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.metroLabel3.Location = new System.Drawing.Point(123, 19);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(294, 44);
            this.metroLabel3.TabIndex = 27;
            this.metroLabel3.Text = "SELECCIONE";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // dgv_Alumnos
            // 
            this.dgv_Alumnos.AllowUserToAddRows = false;
            this.dgv_Alumnos.AllowUserToDeleteRows = false;
            this.dgv_Alumnos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dgv_Alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Alumnos.Location = new System.Drawing.Point(611, 377);
            this.dgv_Alumnos.Name = "dgv_Alumnos";
            this.dgv_Alumnos.ReadOnly = true;
            this.dgv_Alumnos.RowTemplate.Height = 24;
            this.dgv_Alumnos.Size = new System.Drawing.Size(1163, 578);
            this.dgv_Alumnos.TabIndex = 2;
            // 
            // txtGAs_Buscar
            // 
            this.txtGAs_Buscar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtGAs_Buscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtGAs_Buscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtGAs_Buscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtGAs_Buscar.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGAs_Buscar.CustomButton.Image = null;
            this.txtGAs_Buscar.CustomButton.Location = new System.Drawing.Point(376, 2);
            this.txtGAs_Buscar.CustomButton.Name = "";
            this.txtGAs_Buscar.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.txtGAs_Buscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGAs_Buscar.CustomButton.TabIndex = 1;
            this.txtGAs_Buscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGAs_Buscar.CustomButton.UseSelectable = true;
            this.txtGAs_Buscar.CustomButton.Visible = false;
            this.txtGAs_Buscar.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtGAs_Buscar.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txtGAs_Buscar.Lines = new string[0];
            this.txtGAs_Buscar.Location = new System.Drawing.Point(611, 294);
            this.txtGAs_Buscar.MaxLength = 32767;
            this.txtGAs_Buscar.Name = "txtGAs_Buscar";
            this.txtGAs_Buscar.PasswordChar = '\0';
            this.txtGAs_Buscar.PromptText = "BUSCAR ALUMNO";
            this.txtGAs_Buscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGAs_Buscar.SelectedText = "";
            this.txtGAs_Buscar.SelectionLength = 0;
            this.txtGAs_Buscar.SelectionStart = 0;
            this.txtGAs_Buscar.ShortcutsEnabled = true;
            this.txtGAs_Buscar.Size = new System.Drawing.Size(424, 50);
            this.txtGAs_Buscar.TabIndex = 27;
            this.txtGAs_Buscar.UseSelectable = true;
            this.txtGAs_Buscar.WaterMark = "BUSCAR ALUMNO";
            this.txtGAs_Buscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGAs_Buscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAsistencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnAsistencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnAsistencia.ForeColor = System.Drawing.Color.Lime;
            this.btnAsistencia.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.btnAsistencia.IconColor = System.Drawing.Color.Lime;
            this.btnAsistencia.IconSize = 83;
            this.btnAsistencia.Location = new System.Drawing.Point(1548, 280);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Padding = new System.Windows.Forms.Padding(5);
            this.btnAsistencia.Size = new System.Drawing.Size(95, 83);
            this.btnAsistencia.TabIndex = 28;
            this.btnAsistencia.TabStop = false;
            // 
            // btnInasistencia
            // 
            this.btnInasistencia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnInasistencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnInasistencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnInasistencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnInasistencia.IconChar = FontAwesome.Sharp.IconChar.UserTimes;
            this.btnInasistencia.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnInasistencia.IconSize = 83;
            this.btnInasistencia.Location = new System.Drawing.Point(1679, 280);
            this.btnInasistencia.Name = "btnInasistencia";
            this.btnInasistencia.Padding = new System.Windows.Forms.Padding(5);
            this.btnInasistencia.Size = new System.Drawing.Size(95, 83);
            this.btnInasistencia.TabIndex = 29;
            this.btnInasistencia.TabStop = false;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.ForeColor = System.Drawing.Color.Red;
            this.lblTurno.Location = new System.Drawing.Point(49, 127);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(53, 20);
            this.lblTurno.TabIndex = 33;
            this.lblTurno.Text = "label1";
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.ForeColor = System.Drawing.Color.Red;
            this.lblSala.Location = new System.Drawing.Point(49, 212);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(53, 20);
            this.lblSala.TabIndex = 34;
            this.lblSala.Text = "label1";
            // 
            // labelFechError
            // 
            this.labelFechError.AutoSize = true;
            this.labelFechError.ForeColor = System.Drawing.Color.Red;
            this.labelFechError.Location = new System.Drawing.Point(49, 568);
            this.labelFechError.Name = "labelFechError";
            this.labelFechError.Size = new System.Drawing.Size(53, 20);
            this.labelFechError.TabIndex = 35;
            this.labelFechError.Text = "label1";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFecha.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblFecha.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblFecha.Location = new System.Drawing.Point(49, 606);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(341, 32);
            this.lblFecha.TabIndex = 32;
            this.lblFecha.Text = "FECHA A REGISTRAR";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblFecha.UseCustomBackColor = true;
            this.lblFecha.UseCustomForeColor = true;
            // 
            // frmAsistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1781, 1042);
            this.Controls.Add(this.btnInasistencia);
            this.Controls.Add(this.btnAsistencia);
            this.Controls.Add(this.txtGAs_Buscar);
            this.Controls.Add(this.dgv_Alumnos);
            this.Controls.Add(this.metroPanel3);
            this.Name = "frmAsistencia";
            this.Text = "GESTIONAR ASISTENCIAS";
            this.Load += new System.EventHandler(this.frmAsistencia_Load);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAsistencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInasistencia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel3;
        private System.Windows.Forms.DataGridView dgv_Alumnos;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox cbSala;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cbTurno;
        private MetroFramework.Controls.MetroTextBox txtGAs_Buscar;
        private FontAwesome.Sharp.IconPictureBox btnAsistencia;
        private FontAwesome.Sharp.IconPictureBox btnInasistencia;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label labelFechError;
        private MetroFramework.Controls.MetroLabel lblFecha;
    }
}