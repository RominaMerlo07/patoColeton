﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaLog;
using CaEnt;

namespace GestionJardin
{
    public partial class frmInformeSemestral_Generar : Form
    {
        public frmInformeSemestral_Generar()
        {
            InitializeComponent();
        }

        string id_sala;

        logAsistencia logAsistencia = new logAsistencia(); // ver si es necesario generar uno nuevo por informe??

        private void frmInformeSemestral_Generar_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void cargar_cbSala()
        {

            cbSala.SelectedValueChanged -= new EventHandler(cbSala_SelectedValueChanged);


            string indexTurno = cbTurno.SelectedIndex.ToString();
            logSalas objlogSalas = new logSalas();
            DataTable Tabla = new DataTable();
            Tabla = objlogSalas.ListarSalas(indexTurno);

            cbSala.DisplayMember = "SAL_NOMBRE";
            cbSala.ValueMember = "SAL_ID";
            cbSala.DataSource = Tabla;
            cbSala.SelectedItem = null;
            cbSala.Enabled = true;

            cbSala.SelectedValueChanged += new EventHandler(cbSala_SelectedValueChanged);

        }

        private void cbSala_SelectedValueChanged(object sender, EventArgs e)
        {
            id_sala = cbSala.SelectedValue.ToString(); //.ToString();    
        }

        private void cbTurno_SelectedValueChanged(object sender, EventArgs e)
        {
            cargar_cbSala();
        }

        private void Inicializar()
        {
            cbTurno.Focus();
            cbTurno.SelectedIndex = -1;
            cbSala.SelectedIndex = -1;
            cbEtapa.SelectedIndex = -1;
            cbEdad.SelectedIndex = -1;
            lbl_panelInforme.Visible = true;
            txtGInf_Buscar.Visible = false;
            dgv_Informe.Visible = false;
            lblInformeEdit.Visible = false;
            btnGInf_Editar.Visible = false;
            lblTurno.Visible = false;
            lblSala.Visible = false;
            lblEtapa.Visible = false;
            lblEdad.Visible = false;
        }

        private void cbTurno_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbTurno.Text.Trim()) == true)
            {
                cbTurno.Style = MetroFramework.MetroColorStyle.Red;
                cbTurno.Focus();
                lblTurno.Visible = true;
                lblTurno.Text = "Por favor seleccione un turno";
            }
            else
            {
                lblTurno.Visible = false;
            }
        }

        private void cbSala_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbSala.Text.Trim()) == true)
            {
                cbSala.Style = MetroFramework.MetroColorStyle.Red;
                cbSala.Focus();
                lblSala.Visible = true;
                lblSala.Text = "Por favor seleccione una sala";
            }
            else
            {
                lblSala.Visible = false;
            }
        }

        private void cbEdad_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbEdad.Text.Trim()) == true)
            {
                cbEdad.Style = MetroFramework.MetroColorStyle.Red;
                cbEdad.Focus();
                lblEdad.Visible = true;
                lblEdad.Text = "Por favor seleccione una edad";
            }
            else
            {
                lblEdad.Visible = false;
            }
        }

        private void cbEtapa_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbEtapa.Text.Trim()) == true)
            {
                cbEtapa.Style = MetroFramework.MetroColorStyle.Red;
                cbEtapa.Focus();
                lblEtapa.Visible = true;
                lblEtapa.Text = "Por favor seleccione una etapa";
            }
            else
            {
                lblEtapa.Visible = false;
            }
        }

        private void cbEtapa_SelectedValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbTurno.Text.Trim()) == false && string.IsNullOrWhiteSpace(cbSala.Text.Trim()) == false && string.IsNullOrWhiteSpace(cbEdad.Text.Trim()) == false  && string.IsNullOrWhiteSpace(cbEtapa.Text.Trim()) == false)
            {
                lbl_panelInforme.Visible = false;
                txtGInf_Buscar.Visible = true;
                dgv_Informe.Visible = true;
                lblInformeEdit.Visible = true;
                btnGInf_Editar.Visible = true;
            }
        }

        private void btnGInf_Editar_Click(object sender, EventArgs e)
        {
            frmInformeProgreso_Nuevo frmInformeProgreso_Nuevo = new frmInformeProgreso_Nuevo();
            frmInformeProgreso_Nuevo.Text = "GESTIÓN ALUMNOS / INFORME DE PROGRESO / REDACTAR INFORME ";
            frmInformeProgreso_Nuevo.ShowDialog();
        }

    }
}
