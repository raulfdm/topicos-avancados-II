﻿using System;
using System.Windows.Forms;

namespace AgendaMedica {
    partial class Cadastro {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.barAcoes = new System.Windows.Forms.ToolStrip();
            this.btnAdicionar = new System.Windows.Forms.ToolStripButton();
            this.btnLimpar = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.barInfos = new System.Windows.Forms.StatusStrip();
            this.lbDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabCadastrar = new System.Windows.Forms.TabControl();
            this.tabConsulta = new System.Windows.Forms.TabPage();
            this.lblPlanoMedAgen = new System.Windows.Forms.Label();
            this.cbxConvenioConsulta = new System.Windows.Forms.ComboBox();
            this.txtPacienteConsulta = new System.Windows.Forms.TextBox();
            this.cbxEspecialidadeConsulta = new System.Windows.Forms.ComboBox();
            this.lblEspecialidadeAgen = new System.Windows.Forms.Label();
            this.lblPacienteAgen = new System.Windows.Forms.Label();
            this.cbxMedicoConsulta = new System.Windows.Forms.ComboBox();
            this.lblMedicoAgen = new System.Windows.Forms.Label();
            this.lblDataAgen = new System.Windows.Forms.Label();
            this.dtpDataConsulta = new System.Windows.Forms.DateTimePicker();
            this.tabPaciente = new System.Windows.Forms.TabPage();
            this.dtpDataNascPaciente = new System.Windows.Forms.DateTimePicker();
            this.lblComplementoPaciente = new System.Windows.Forms.Label();
            this.txtComplementoPaciente = new System.Windows.Forms.TextBox();
            this.lblEmailPaciente = new System.Windows.Forms.Label();
            this.txtEmailPaciente = new System.Windows.Forms.TextBox();
            this.lblCelularPaciente = new System.Windows.Forms.Label();
            this.txtCelularPaciente = new System.Windows.Forms.TextBox();
            this.lblTelefonePaciente = new System.Windows.Forms.Label();
            this.txtTelefonePaciente = new System.Windows.Forms.TextBox();
            this.lblCidadePaciente = new System.Windows.Forms.Label();
            this.lblEstadoPaciente = new System.Windows.Forms.Label();
            this.lblCepPaciente = new System.Windows.Forms.Label();
            this.txtCepPaciente = new System.Windows.Forms.TextBox();
            this.cbxCidadePaciente = new System.Windows.Forms.ComboBox();
            this.cbxUFPaciente = new System.Windows.Forms.ComboBox();
            this.txtBairroPaciente = new System.Windows.Forms.TextBox();
            this.lblBairroPaciente = new System.Windows.Forms.Label();
            this.lblNumeroEndPaciente = new System.Windows.Forms.Label();
            this.txtNumeroEndPaciente = new System.Windows.Forms.TextBox();
            this.txtEnderecoPaciente = new System.Windows.Forms.TextBox();
            this.lblEnderecoPaciente = new System.Windows.Forms.Label();
            this.lblOrgaoEmiPaciente = new System.Windows.Forms.Label();
            this.txtOrgaoEmiPaciente = new System.Windows.Forms.TextBox();
            this.lblRgPaciente = new System.Windows.Forms.Label();
            this.txtRgPaciente = new System.Windows.Forms.TextBox();
            this.lblCpfPaciente = new System.Windows.Forms.Label();
            this.txtCpfPaciente = new System.Windows.Forms.TextBox();
            this.lblSobrenomePaciente = new System.Windows.Forms.Label();
            this.txtSobrenomePaciente = new System.Windows.Forms.TextBox();
            this.rdbSexoMPaciente = new System.Windows.Forms.RadioButton();
            this.rdbSexoFPaciente = new System.Windows.Forms.RadioButton();
            this.lblSexoPac = new System.Windows.Forms.Label();
            this.lblConvenioPac = new System.Windows.Forms.Label();
            this.cbxConvenioPaciente = new System.Windows.Forms.ComboBox();
            this.lblNumCarteirinhaPaciente = new System.Windows.Forms.Label();
            this.txtNumCarteirinhaPaciente = new System.Windows.Forms.TextBox();
            this.lblNascPaciente = new System.Windows.Forms.Label();
            this.lblNomePaciente = new System.Windows.Forms.Label();
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.tabMedico = new System.Windows.Forms.TabPage();
            this.dtpDataNascMedico = new System.Windows.Forms.DateTimePicker();
            this.lblUfMed = new System.Windows.Forms.Label();
            this.cbxUFMed = new System.Windows.Forms.ComboBox();
            this.lblSexoMed = new System.Windows.Forms.Label();
            this.rdbSexoMMed = new System.Windows.Forms.RadioButton();
            this.rdbSexoFMed = new System.Windows.Forms.RadioButton();
            this.lblOrgaoEmiMed = new System.Windows.Forms.Label();
            this.txtOrgaoEmiMed = new System.Windows.Forms.TextBox();
            this.lblRgMed = new System.Windows.Forms.Label();
            this.txtRgMed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCpfMed = new System.Windows.Forms.TextBox();
            this.lblComplementoMed = new System.Windows.Forms.Label();
            this.txtComplementoMed = new System.Windows.Forms.TextBox();
            this.lblSobrenomeMed = new System.Windows.Forms.Label();
            this.txtSobrenomeMed = new System.Windows.Forms.TextBox();
            this.lblEspecialidadeMed = new System.Windows.Forms.Label();
            this.cbxEspecialidadeMed = new System.Windows.Forms.ComboBox();
            this.lblCRM = new System.Windows.Forms.Label();
            this.txtCrm = new System.Windows.Forms.TextBox();
            this.lblEmailMed = new System.Windows.Forms.Label();
            this.txtEmailMed = new System.Windows.Forms.TextBox();
            this.lblCelularMed = new System.Windows.Forms.Label();
            this.txtCelularMed = new System.Windows.Forms.TextBox();
            this.lblTelefoneMed = new System.Windows.Forms.Label();
            this.txtTelefoneMed = new System.Windows.Forms.TextBox();
            this.lblCidadeMed = new System.Windows.Forms.Label();
            this.lblCepMed = new System.Windows.Forms.Label();
            this.txtCepMed = new System.Windows.Forms.TextBox();
            this.cbxCidadeMed = new System.Windows.Forms.ComboBox();
            this.txtBairroMed = new System.Windows.Forms.TextBox();
            this.lblBairroMed = new System.Windows.Forms.Label();
            this.lblNumMed = new System.Windows.Forms.Label();
            this.txtNumeroEndMed = new System.Windows.Forms.TextBox();
            this.txtEnderecoMed = new System.Windows.Forms.TextBox();
            this.lblEndMed = new System.Windows.Forms.Label();
            this.lblNascMed = new System.Windows.Forms.Label();
            this.lblNomeMed = new System.Windows.Forms.Label();
            this.txtNomeMed = new System.Windows.Forms.TextBox();
            this.tabConvenio = new System.Windows.Forms.TabPage();
            this.lblNomeConvenio = new System.Windows.Forms.Label();
            this.txtNomeConvenio = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.agendaMedicaDataSet = new AgendaMedica.agendaMedicaDataSet();
            this.agendaMedicaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.barAcoes.SuspendLayout();
            this.barInfos.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabCadastrar.SuspendLayout();
            this.tabConsulta.SuspendLayout();
            this.tabPaciente.SuspendLayout();
            this.tabMedico.SuspendLayout();
            this.tabConvenio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendaMedicaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaMedicaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.barAcoes);
            this.panel1.Controls.Add(this.barInfos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 436);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 67);
            this.panel1.TabIndex = 0;
            // 
            // barAcoes
            // 
            this.barAcoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barAcoes.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.barAcoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdicionar,
            this.btnLimpar,
            this.btnExit});
            this.barAcoes.Location = new System.Drawing.Point(0, -3);
            this.barAcoes.Name = "barAcoes";
            this.barAcoes.Size = new System.Drawing.Size(660, 48);
            this.barAcoes.TabIndex = 1;
            this.barAcoes.Text = "Ações";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.AutoSize = false;
            this.btnAdicionar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionar.Image")));
            this.btnAdicionar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAdicionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(3);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(40, 40);
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.AutoSize = false;
            this.btnLimpar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLimpar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(40, 40);
            this.btnLimpar.Text = "Adicionar";
            this.btnLimpar.ToolTipText = "Limpar Tudo";
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExit
            // 
            this.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExit.AutoSize = false;
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.Text = "Sair";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // barInfos
            // 
            this.barInfos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbDateTime});
            this.barInfos.Location = new System.Drawing.Point(0, 45);
            this.barInfos.Name = "barInfos";
            this.barInfos.Size = new System.Drawing.Size(660, 22);
            this.barInfos.TabIndex = 0;
            this.barInfos.Text = "statusStrip1";
            // 
            // lbDateTime
            // 
            this.lbDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lbDateTime.Name = "lbDateTime";
            this.lbDateTime.Size = new System.Drawing.Size(68, 17);
            this.lbDateTime.Text = "lbDateTime";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabCadastrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 503);
            this.panel2.TabIndex = 1;
            // 
            // tabCadastrar
            // 
            this.tabCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCadastrar.Controls.Add(this.tabConsulta);
            this.tabCadastrar.Controls.Add(this.tabPaciente);
            this.tabCadastrar.Controls.Add(this.tabMedico);
            this.tabCadastrar.Controls.Add(this.tabConvenio);
            this.tabCadastrar.Location = new System.Drawing.Point(0, 0);
            this.tabCadastrar.Name = "tabCadastrar";
            this.tabCadastrar.SelectedIndex = 0;
            this.tabCadastrar.Size = new System.Drawing.Size(660, 437);
            this.tabCadastrar.TabIndex = 1;
            // 
            // tabConsulta
            // 
            this.tabConsulta.Controls.Add(this.lblPlanoMedAgen);
            this.tabConsulta.Controls.Add(this.cbxConvenioConsulta);
            this.tabConsulta.Controls.Add(this.txtPacienteConsulta);
            this.tabConsulta.Controls.Add(this.cbxEspecialidadeConsulta);
            this.tabConsulta.Controls.Add(this.lblEspecialidadeAgen);
            this.tabConsulta.Controls.Add(this.lblPacienteAgen);
            this.tabConsulta.Controls.Add(this.cbxMedicoConsulta);
            this.tabConsulta.Controls.Add(this.lblMedicoAgen);
            this.tabConsulta.Controls.Add(this.lblDataAgen);
            this.tabConsulta.Controls.Add(this.dtpDataConsulta);
            this.tabConsulta.Location = new System.Drawing.Point(4, 22);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsulta.Size = new System.Drawing.Size(652, 411);
            this.tabConsulta.TabIndex = 0;
            this.tabConsulta.Text = "Consulta";
            this.tabConsulta.UseVisualStyleBackColor = true;
            // 
            // lblPlanoMedAgen
            // 
            this.lblPlanoMedAgen.AutoSize = true;
            this.lblPlanoMedAgen.Location = new System.Drawing.Point(470, 53);
            this.lblPlanoMedAgen.Name = "lblPlanoMedAgen";
            this.lblPlanoMedAgen.Size = new System.Drawing.Size(52, 13);
            this.lblPlanoMedAgen.TabIndex = 9;
            this.lblPlanoMedAgen.Text = "Convênio";
            // 
            // cbxConvenioConsulta
            // 
            this.cbxConvenioConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxConvenioConsulta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxConvenioConsulta.FormattingEnabled = true;
            this.cbxConvenioConsulta.Location = new System.Drawing.Point(473, 69);
            this.cbxConvenioConsulta.Name = "cbxConvenioConsulta";
            this.cbxConvenioConsulta.Size = new System.Drawing.Size(154, 24);
            this.cbxConvenioConsulta.TabIndex = 8;
            this.cbxConvenioConsulta.GotFocus += new System.EventHandler(this.carregaConvenio);
            // 
            // txtPacienteConsulta
            // 
            this.txtPacienteConsulta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPacienteConsulta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPacienteConsulta.Location = new System.Drawing.Point(122, 69);
            this.txtPacienteConsulta.Name = "txtPacienteConsulta";
            this.txtPacienteConsulta.Size = new System.Drawing.Size(342, 22);
            this.txtPacienteConsulta.TabIndex = 7;
            this.txtPacienteConsulta.WordWrap = false;
            // 
            // cbxEspecialidadeConsulta
            // 
            this.cbxEspecialidadeConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEspecialidadeConsulta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEspecialidadeConsulta.FormattingEnabled = true;
            this.cbxEspecialidadeConsulta.Items.AddRange(new object[] {
            "ACUPUNTURA",
            "ALERGIA E IMUNOLOGIA",
            "ANESTESIOLOGIA",
            "ANGIOLOGIA",
            "CANCEROLOGIA (ONCOLOGIA)",
            "CARDIOLOGIA",
            "CIRURGIA CARDIOVASCULAR",
            "CIRURGIA DA MÃO",
            "CIRURGIA DE CABEÇA E PESCOÇO",
            "CIRURGIA DO APARELHO DIGESTIVO",
            "CIRURGIA GERAL",
            "CIRURGIA PEDIÁTRICA",
            "CIRURGIA PLÁSTICA",
            "CIRURGIA TORÁCICA",
            "CIRURGIA VASCULAR",
            "CLÍNICA MÉDICA (MEDICINA INTERNA)",
            "COLOPROCTOLOGIA",
            "DERMATOLOGIA",
            "ENDOCRINOLOGIA E METABOLOGIA",
            "ENDOSCOPIA",
            "GASTROENTEROLOGIA",
            "GENÉTICA MÉDICA",
            "GERIATRIA",
            "GINECOLOGIA E OBSTETRÍCIA",
            "HEMATOLOGIA E HEMOTERAPIA",
            "HOMEOPATIA",
            "INFECTOLOGIA",
            "MASTOLOGIA",
            "MEDICINA DE FAMÍLIA E COMUNIDADE",
            "MEDICINA DO TRABALHO",
            "MEDICINA DO TRÁFEGO",
            "MEDICINA ESPORTIVA",
            "MEDICINA FÍSICA E REABILITAÇÃO",
            "MEDICINA INTENSIVA",
            "MEDICINA LEGAL E PERÍCIA MÉDICA",
            "MEDICINA NUCLEAR",
            "MEDICINA PREVENTIVA E SOCIAL",
            "NEFROLOGIA",
            "NEUROCIRURGIA",
            "NEUROLOGIA",
            "NUTROLOGIA",
            "OBSTETRÍCIA",
            "OFTALMOLOGIA",
            "ORTOPEDIA E TRAUMATOLOGIA",
            "OTORRINOLARINGOLOGIA",
            "PATOLOGIA",
            "PATOLOGIA CLÍNICA/MEDICINA LABORATORIAL",
            "PEDIATRIA",
            "PNEUMOLOGIA",
            "PSIQUIATRIA",
            "RADIOLOGIA E DIAGNÓSTICO POR IMAGEM",
            "RADIOTERAPIA",
            "REUMATOLOGIA",
            "UROLOGIA"});
            this.cbxEspecialidadeConsulta.Location = new System.Drawing.Point(301, 22);
            this.cbxEspecialidadeConsulta.Name = "cbxEspecialidadeConsulta";
            this.cbxEspecialidadeConsulta.Size = new System.Drawing.Size(326, 24);
            this.cbxEspecialidadeConsulta.TabIndex = 6;
            // 
            // lblEspecialidadeAgen
            // 
            this.lblEspecialidadeAgen.AutoSize = true;
            this.lblEspecialidadeAgen.Location = new System.Drawing.Point(298, 6);
            this.lblEspecialidadeAgen.Name = "lblEspecialidadeAgen";
            this.lblEspecialidadeAgen.Size = new System.Drawing.Size(73, 13);
            this.lblEspecialidadeAgen.TabIndex = 5;
            this.lblEspecialidadeAgen.Text = "Especialidade";
            // 
            // lblPacienteAgen
            // 
            this.lblPacienteAgen.AutoSize = true;
            this.lblPacienteAgen.Location = new System.Drawing.Point(119, 53);
            this.lblPacienteAgen.Name = "lblPacienteAgen";
            this.lblPacienteAgen.Size = new System.Drawing.Size(49, 13);
            this.lblPacienteAgen.TabIndex = 4;
            this.lblPacienteAgen.Text = "Paciente";
            // 
            // cbxMedicoConsulta
            // 
            this.cbxMedicoConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMedicoConsulta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMedicoConsulta.FormattingEnabled = true;
            this.cbxMedicoConsulta.Location = new System.Drawing.Point(12, 22);
            this.cbxMedicoConsulta.Name = "cbxMedicoConsulta";
            this.cbxMedicoConsulta.Size = new System.Drawing.Size(273, 24);
            this.cbxMedicoConsulta.TabIndex = 3;
            this.cbxMedicoConsulta.GotFocus += new System.EventHandler(this.carregaMedicos);
            // 
            // lblMedicoAgen
            // 
            this.lblMedicoAgen.AutoSize = true;
            this.lblMedicoAgen.Location = new System.Drawing.Point(9, 8);
            this.lblMedicoAgen.Name = "lblMedicoAgen";
            this.lblMedicoAgen.Size = new System.Drawing.Size(42, 13);
            this.lblMedicoAgen.TabIndex = 2;
            this.lblMedicoAgen.Text = "Médico";
            // 
            // lblDataAgen
            // 
            this.lblDataAgen.AutoSize = true;
            this.lblDataAgen.Location = new System.Drawing.Point(12, 53);
            this.lblDataAgen.Name = "lblDataAgen";
            this.lblDataAgen.Size = new System.Drawing.Size(30, 13);
            this.lblDataAgen.TabIndex = 1;
            this.lblDataAgen.Text = "Data";
            // 
            // dtpDataConsulta
            // 
            this.dtpDataConsulta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataConsulta.Location = new System.Drawing.Point(15, 69);
            this.dtpDataConsulta.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dtpDataConsulta.Name = "dtpDataConsulta";
            this.dtpDataConsulta.Size = new System.Drawing.Size(101, 22);
            this.dtpDataConsulta.TabIndex = 0;
            // 
            // tabPaciente
            // 
            this.tabPaciente.Controls.Add(this.dtpDataNascPaciente);
            this.tabPaciente.Controls.Add(this.lblComplementoPaciente);
            this.tabPaciente.Controls.Add(this.txtComplementoPaciente);
            this.tabPaciente.Controls.Add(this.lblEmailPaciente);
            this.tabPaciente.Controls.Add(this.txtEmailPaciente);
            this.tabPaciente.Controls.Add(this.lblCelularPaciente);
            this.tabPaciente.Controls.Add(this.txtCelularPaciente);
            this.tabPaciente.Controls.Add(this.lblTelefonePaciente);
            this.tabPaciente.Controls.Add(this.txtTelefonePaciente);
            this.tabPaciente.Controls.Add(this.lblCidadePaciente);
            this.tabPaciente.Controls.Add(this.lblEstadoPaciente);
            this.tabPaciente.Controls.Add(this.lblCepPaciente);
            this.tabPaciente.Controls.Add(this.txtCepPaciente);
            this.tabPaciente.Controls.Add(this.cbxCidadePaciente);
            this.tabPaciente.Controls.Add(this.cbxUFPaciente);
            this.tabPaciente.Controls.Add(this.txtBairroPaciente);
            this.tabPaciente.Controls.Add(this.lblBairroPaciente);
            this.tabPaciente.Controls.Add(this.lblNumeroEndPaciente);
            this.tabPaciente.Controls.Add(this.txtNumeroEndPaciente);
            this.tabPaciente.Controls.Add(this.txtEnderecoPaciente);
            this.tabPaciente.Controls.Add(this.lblEnderecoPaciente);
            this.tabPaciente.Controls.Add(this.lblOrgaoEmiPaciente);
            this.tabPaciente.Controls.Add(this.txtOrgaoEmiPaciente);
            this.tabPaciente.Controls.Add(this.lblRgPaciente);
            this.tabPaciente.Controls.Add(this.txtRgPaciente);
            this.tabPaciente.Controls.Add(this.lblCpfPaciente);
            this.tabPaciente.Controls.Add(this.txtCpfPaciente);
            this.tabPaciente.Controls.Add(this.lblSobrenomePaciente);
            this.tabPaciente.Controls.Add(this.txtSobrenomePaciente);
            this.tabPaciente.Controls.Add(this.rdbSexoMPaciente);
            this.tabPaciente.Controls.Add(this.rdbSexoFPaciente);
            this.tabPaciente.Controls.Add(this.lblSexoPac);
            this.tabPaciente.Controls.Add(this.lblConvenioPac);
            this.tabPaciente.Controls.Add(this.cbxConvenioPaciente);
            this.tabPaciente.Controls.Add(this.lblNumCarteirinhaPaciente);
            this.tabPaciente.Controls.Add(this.txtNumCarteirinhaPaciente);
            this.tabPaciente.Controls.Add(this.lblNascPaciente);
            this.tabPaciente.Controls.Add(this.lblNomePaciente);
            this.tabPaciente.Controls.Add(this.txtNomePaciente);
            this.tabPaciente.Location = new System.Drawing.Point(4, 22);
            this.tabPaciente.Name = "tabPaciente";
            this.tabPaciente.Padding = new System.Windows.Forms.Padding(3);
            this.tabPaciente.Size = new System.Drawing.Size(652, 411);
            this.tabPaciente.TabIndex = 2;
            this.tabPaciente.Text = "Paciente";
            this.tabPaciente.UseVisualStyleBackColor = true;
            // 
            // dtpDataNascPaciente
            // 
            this.dtpDataNascPaciente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNascPaciente.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascPaciente.Location = new System.Drawing.Point(468, 23);
            this.dtpDataNascPaciente.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDataNascPaciente.Name = "dtpDataNascPaciente";
            this.dtpDataNascPaciente.Size = new System.Drawing.Size(162, 22);
            this.dtpDataNascPaciente.TabIndex = 2;
            // 
            // lblComplementoPaciente
            // 
            this.lblComplementoPaciente.AutoSize = true;
            this.lblComplementoPaciente.Location = new System.Drawing.Point(434, 103);
            this.lblComplementoPaciente.Name = "lblComplementoPaciente";
            this.lblComplementoPaciente.Size = new System.Drawing.Size(71, 13);
            this.lblComplementoPaciente.TabIndex = 85;
            this.lblComplementoPaciente.Text = "Complemento";
            // 
            // txtComplementoPaciente
            // 
            this.txtComplementoPaciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComplementoPaciente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplementoPaciente.Location = new System.Drawing.Point(437, 119);
            this.txtComplementoPaciente.Name = "txtComplementoPaciente";
            this.txtComplementoPaciente.Size = new System.Drawing.Size(85, 22);
            this.txtComplementoPaciente.TabIndex = 9;
            this.txtComplementoPaciente.WordWrap = false;
            // 
            // lblEmailPaciente
            // 
            this.lblEmailPaciente.AutoSize = true;
            this.lblEmailPaciente.Location = new System.Drawing.Point(21, 201);
            this.lblEmailPaciente.Name = "lblEmailPaciente";
            this.lblEmailPaciente.Size = new System.Drawing.Size(35, 13);
            this.lblEmailPaciente.TabIndex = 83;
            this.lblEmailPaciente.Text = "E-mail";
            // 
            // txtEmailPaciente
            // 
            this.txtEmailPaciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmailPaciente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailPaciente.Location = new System.Drawing.Point(24, 217);
            this.txtEmailPaciente.Name = "txtEmailPaciente";
            this.txtEmailPaciente.Size = new System.Drawing.Size(287, 22);
            this.txtEmailPaciente.TabIndex = 16;
            this.txtEmailPaciente.WordWrap = false;
            // 
            // lblCelularPaciente
            // 
            this.lblCelularPaciente.AutoSize = true;
            this.lblCelularPaciente.Location = new System.Drawing.Point(532, 151);
            this.lblCelularPaciente.Name = "lblCelularPaciente";
            this.lblCelularPaciente.Size = new System.Drawing.Size(39, 13);
            this.lblCelularPaciente.TabIndex = 82;
            this.lblCelularPaciente.Text = "Celular";
            // 
            // txtCelularPaciente
            // 
            this.txtCelularPaciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCelularPaciente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelularPaciente.Location = new System.Drawing.Point(535, 167);
            this.txtCelularPaciente.Name = "txtCelularPaciente";
            this.txtCelularPaciente.Size = new System.Drawing.Size(96, 22);
            this.txtCelularPaciente.TabIndex = 15;
            this.txtCelularPaciente.WordWrap = false;
            // 
            // lblTelefonePaciente
            // 
            this.lblTelefonePaciente.AutoSize = true;
            this.lblTelefonePaciente.Location = new System.Drawing.Point(434, 151);
            this.lblTelefonePaciente.Name = "lblTelefonePaciente";
            this.lblTelefonePaciente.Size = new System.Drawing.Size(49, 13);
            this.lblTelefonePaciente.TabIndex = 81;
            this.lblTelefonePaciente.Text = "Telefone";
            // 
            // txtTelefonePaciente
            // 
            this.txtTelefonePaciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefonePaciente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonePaciente.Location = new System.Drawing.Point(437, 167);
            this.txtTelefonePaciente.Name = "txtTelefonePaciente";
            this.txtTelefonePaciente.Size = new System.Drawing.Size(85, 22);
            this.txtTelefonePaciente.TabIndex = 14;
            this.txtTelefonePaciente.WordWrap = false;
            // 
            // lblCidadePaciente
            // 
            this.lblCidadePaciente.AutoSize = true;
            this.lblCidadePaciente.Location = new System.Drawing.Point(204, 152);
            this.lblCidadePaciente.Name = "lblCidadePaciente";
            this.lblCidadePaciente.Size = new System.Drawing.Size(40, 13);
            this.lblCidadePaciente.TabIndex = 80;
            this.lblCidadePaciente.Text = "Cidade";
            // 
            // lblEstadoPaciente
            // 
            this.lblEstadoPaciente.AutoSize = true;
            this.lblEstadoPaciente.Location = new System.Drawing.Point(359, 151);
            this.lblEstadoPaciente.Name = "lblEstadoPaciente";
            this.lblEstadoPaciente.Size = new System.Drawing.Size(21, 13);
            this.lblEstadoPaciente.TabIndex = 79;
            this.lblEstadoPaciente.Text = "UF";
            // 
            // lblCepPaciente
            // 
            this.lblCepPaciente.AutoSize = true;
            this.lblCepPaciente.Location = new System.Drawing.Point(532, 103);
            this.lblCepPaciente.Name = "lblCepPaciente";
            this.lblCepPaciente.Size = new System.Drawing.Size(28, 13);
            this.lblCepPaciente.TabIndex = 78;
            this.lblCepPaciente.Text = "CEP";
            // 
            // txtCepPaciente
            // 
            this.txtCepPaciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCepPaciente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCepPaciente.Location = new System.Drawing.Point(535, 119);
            this.txtCepPaciente.Name = "txtCepPaciente";
            this.txtCepPaciente.Size = new System.Drawing.Size(96, 22);
            this.txtCepPaciente.TabIndex = 10;
            this.txtCepPaciente.WordWrap = false;
            // 
            // cbxCidadePaciente
            // 
            this.cbxCidadePaciente.FormattingEnabled = true;
            this.cbxCidadePaciente.Location = new System.Drawing.Point(207, 167);
            this.cbxCidadePaciente.Name = "cbxCidadePaciente";
            this.cbxCidadePaciente.Size = new System.Drawing.Size(136, 21);
            this.cbxCidadePaciente.TabIndex = 12;
            // 
            // cbxUFPaciente
            // 
            this.cbxUFPaciente.AllowDrop = true;
            this.cbxUFPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUFPaciente.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbxUFPaciente.Location = new System.Drawing.Point(362, 167);
            this.cbxUFPaciente.Name = "cbxUFPaciente";
            this.cbxUFPaciente.Size = new System.Drawing.Size(60, 21);
            this.cbxUFPaciente.TabIndex = 13;
            // 
            // txtBairroPaciente
            // 
            this.txtBairroPaciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairroPaciente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairroPaciente.Location = new System.Drawing.Point(24, 167);
            this.txtBairroPaciente.Name = "txtBairroPaciente";
            this.txtBairroPaciente.Size = new System.Drawing.Size(161, 22);
            this.txtBairroPaciente.TabIndex = 11;
            this.txtBairroPaciente.WordWrap = false;
            // 
            // lblBairroPaciente
            // 
            this.lblBairroPaciente.AutoSize = true;
            this.lblBairroPaciente.Location = new System.Drawing.Point(21, 151);
            this.lblBairroPaciente.Name = "lblBairroPaciente";
            this.lblBairroPaciente.Size = new System.Drawing.Size(34, 13);
            this.lblBairroPaciente.TabIndex = 77;
            this.lblBairroPaciente.Text = "Bairro";
            // 
            // lblNumeroEndPaciente
            // 
            this.lblNumeroEndPaciente.AutoSize = true;
            this.lblNumeroEndPaciente.Location = new System.Drawing.Point(359, 103);
            this.lblNumeroEndPaciente.Name = "lblNumeroEndPaciente";
            this.lblNumeroEndPaciente.Size = new System.Drawing.Size(44, 13);
            this.lblNumeroEndPaciente.TabIndex = 76;
            this.lblNumeroEndPaciente.Text = "Número";
            // 
            // txtNumeroEndPaciente
            // 
            this.txtNumeroEndPaciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeroEndPaciente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroEndPaciente.Location = new System.Drawing.Point(362, 119);
            this.txtNumeroEndPaciente.Name = "txtNumeroEndPaciente";
            this.txtNumeroEndPaciente.Size = new System.Drawing.Size(60, 22);
            this.txtNumeroEndPaciente.TabIndex = 8;
            this.txtNumeroEndPaciente.WordWrap = false;
            // 
            // txtEnderecoPaciente
            // 
            this.txtEnderecoPaciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEnderecoPaciente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoPaciente.Location = new System.Drawing.Point(24, 119);
            this.txtEnderecoPaciente.Name = "txtEnderecoPaciente";
            this.txtEnderecoPaciente.Size = new System.Drawing.Size(321, 22);
            this.txtEnderecoPaciente.TabIndex = 7;
            this.txtEnderecoPaciente.WordWrap = false;
            // 
            // lblEnderecoPaciente
            // 
            this.lblEnderecoPaciente.AutoSize = true;
            this.lblEnderecoPaciente.Location = new System.Drawing.Point(21, 103);
            this.lblEnderecoPaciente.Name = "lblEnderecoPaciente";
            this.lblEnderecoPaciente.Size = new System.Drawing.Size(53, 13);
            this.lblEnderecoPaciente.TabIndex = 75;
            this.lblEnderecoPaciente.Text = "Endereço";
            // 
            // lblOrgaoEmiPaciente
            // 
            this.lblOrgaoEmiPaciente.AutoSize = true;
            this.lblOrgaoEmiPaciente.Location = new System.Drawing.Point(542, 54);
            this.lblOrgaoEmiPaciente.Name = "lblOrgaoEmiPaciente";
            this.lblOrgaoEmiPaciente.Size = new System.Drawing.Size(75, 13);
            this.lblOrgaoEmiPaciente.TabIndex = 63;
            this.lblOrgaoEmiPaciente.Text = "Orgão Emissor";
            // 
            // txtOrgaoEmiPaciente
            // 
            this.txtOrgaoEmiPaciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOrgaoEmiPaciente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrgaoEmiPaciente.Location = new System.Drawing.Point(545, 70);
            this.txtOrgaoEmiPaciente.Name = "txtOrgaoEmiPaciente";
            this.txtOrgaoEmiPaciente.Size = new System.Drawing.Size(87, 22);
            this.txtOrgaoEmiPaciente.TabIndex = 6;
            this.txtOrgaoEmiPaciente.WordWrap = false;
            // 
            // lblRgPaciente
            // 
            this.lblRgPaciente.AutoSize = true;
            this.lblRgPaciente.Location = new System.Drawing.Point(322, 54);
            this.lblRgPaciente.Name = "lblRgPaciente";
            this.lblRgPaciente.Size = new System.Drawing.Size(23, 13);
            this.lblRgPaciente.TabIndex = 62;
            this.lblRgPaciente.Text = "RG";
            // 
            // txtRgPaciente
            // 
            this.txtRgPaciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRgPaciente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRgPaciente.Location = new System.Drawing.Point(325, 70);
            this.txtRgPaciente.Name = "txtRgPaciente";
            this.txtRgPaciente.Size = new System.Drawing.Size(194, 22);
            this.txtRgPaciente.TabIndex = 5;
            this.txtRgPaciente.WordWrap = false;
            // 
            // lblCpfPaciente
            // 
            this.lblCpfPaciente.AutoSize = true;
            this.lblCpfPaciente.Location = new System.Drawing.Point(114, 54);
            this.lblCpfPaciente.Name = "lblCpfPaciente";
            this.lblCpfPaciente.Size = new System.Drawing.Size(27, 13);
            this.lblCpfPaciente.TabIndex = 61;
            this.lblCpfPaciente.Text = "CPF";
            // 
            // txtCpfPaciente
            // 
            this.txtCpfPaciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCpfPaciente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfPaciente.Location = new System.Drawing.Point(117, 70);
            this.txtCpfPaciente.Name = "txtCpfPaciente";
            this.txtCpfPaciente.Size = new System.Drawing.Size(194, 22);
            this.txtCpfPaciente.TabIndex = 4;
            this.txtCpfPaciente.WordWrap = false;
            // 
            // lblSobrenomePaciente
            // 
            this.lblSobrenomePaciente.AutoSize = true;
            this.lblSobrenomePaciente.Location = new System.Drawing.Point(229, 9);
            this.lblSobrenomePaciente.Name = "lblSobrenomePaciente";
            this.lblSobrenomePaciente.Size = new System.Drawing.Size(82, 13);
            this.lblSobrenomePaciente.TabIndex = 30;
            this.lblSobrenomePaciente.Text = "Nome Completo";
            // 
            // txtSobrenomePaciente
            // 
            this.txtSobrenomePaciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSobrenomePaciente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobrenomePaciente.Location = new System.Drawing.Point(232, 25);
            this.txtSobrenomePaciente.Name = "txtSobrenomePaciente";
            this.txtSobrenomePaciente.Size = new System.Drawing.Size(218, 22);
            this.txtSobrenomePaciente.TabIndex = 1;
            this.txtSobrenomePaciente.WordWrap = false;
            // 
            // rdbSexoMPaciente
            // 
            this.rdbSexoMPaciente.AutoSize = true;
            this.rdbSexoMPaciente.Location = new System.Drawing.Point(67, 71);
            this.rdbSexoMPaciente.Name = "rdbSexoMPaciente";
            this.rdbSexoMPaciente.Size = new System.Drawing.Size(34, 17);
            this.rdbSexoMPaciente.TabIndex = 28;
            this.rdbSexoMPaciente.TabStop = true;
            this.rdbSexoMPaciente.Text = "M";
            this.rdbSexoMPaciente.UseVisualStyleBackColor = true;
            // 
            // rdbSexoFPaciente
            // 
            this.rdbSexoFPaciente.AutoSize = true;
            this.rdbSexoFPaciente.Location = new System.Drawing.Point(24, 71);
            this.rdbSexoFPaciente.Name = "rdbSexoFPaciente";
            this.rdbSexoFPaciente.Size = new System.Drawing.Size(31, 17);
            this.rdbSexoFPaciente.TabIndex = 3;
            this.rdbSexoFPaciente.TabStop = true;
            this.rdbSexoFPaciente.Text = "F";
            this.rdbSexoFPaciente.UseVisualStyleBackColor = true;
            // 
            // lblSexoPac
            // 
            this.lblSexoPac.AutoSize = true;
            this.lblSexoPac.Location = new System.Drawing.Point(21, 52);
            this.lblSexoPac.Name = "lblSexoPac";
            this.lblSexoPac.Size = new System.Drawing.Size(31, 13);
            this.lblSexoPac.TabIndex = 26;
            this.lblSexoPac.Text = "Sexo";
            // 
            // lblConvenioPac
            // 
            this.lblConvenioPac.AutoSize = true;
            this.lblConvenioPac.Location = new System.Drawing.Point(467, 201);
            this.lblConvenioPac.Name = "lblConvenioPac";
            this.lblConvenioPac.Size = new System.Drawing.Size(52, 13);
            this.lblConvenioPac.TabIndex = 25;
            this.lblConvenioPac.Text = "Convênio";
            // 
            // cbxConvenioPaciente
            // 
            this.cbxConvenioPaciente.AllowDrop = true;
            this.cbxConvenioPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxConvenioPaciente.FormattingEnabled = true;
            this.cbxConvenioPaciente.Location = new System.Drawing.Point(468, 217);
            this.cbxConvenioPaciente.Name = "cbxConvenioPaciente";
            this.cbxConvenioPaciente.Size = new System.Drawing.Size(162, 21);
            this.cbxConvenioPaciente.TabIndex = 18;
            this.cbxConvenioPaciente.GotFocus += new System.EventHandler(this.carregaConvenio);
            // 
            // lblNumCarteirinhaPaciente
            // 
            this.lblNumCarteirinhaPaciente.AutoSize = true;
            this.lblNumCarteirinhaPaciente.Location = new System.Drawing.Point(331, 201);
            this.lblNumCarteirinhaPaciente.Name = "lblNumCarteirinhaPaciente";
            this.lblNumCarteirinhaPaciente.Size = new System.Drawing.Size(72, 13);
            this.lblNumCarteirinhaPaciente.TabIndex = 23;
            this.lblNumCarteirinhaPaciente.Text = "Nº Carteirinha";
            // 
            // txtNumCarteirinhaPaciente
            // 
            this.txtNumCarteirinhaPaciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumCarteirinhaPaciente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumCarteirinhaPaciente.Location = new System.Drawing.Point(334, 217);
            this.txtNumCarteirinhaPaciente.Name = "txtNumCarteirinhaPaciente";
            this.txtNumCarteirinhaPaciente.Size = new System.Drawing.Size(116, 22);
            this.txtNumCarteirinhaPaciente.TabIndex = 17;
            this.txtNumCarteirinhaPaciente.WordWrap = false;
            // 
            // lblNascPaciente
            // 
            this.lblNascPaciente.AutoSize = true;
            this.lblNascPaciente.Location = new System.Drawing.Point(465, 10);
            this.lblNascPaciente.Name = "lblNascPaciente";
            this.lblNascPaciente.Size = new System.Drawing.Size(89, 13);
            this.lblNascPaciente.TabIndex = 2;
            this.lblNascPaciente.Text = "Data Nascimento";
            // 
            // lblNomePaciente
            // 
            this.lblNomePaciente.AutoSize = true;
            this.lblNomePaciente.Location = new System.Drawing.Point(20, 10);
            this.lblNomePaciente.Name = "lblNomePaciente";
            this.lblNomePaciente.Size = new System.Drawing.Size(35, 13);
            this.lblNomePaciente.TabIndex = 1;
            this.lblNomePaciente.Text = "Nome";
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomePaciente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomePaciente.Location = new System.Drawing.Point(23, 25);
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(192, 22);
            this.txtNomePaciente.TabIndex = 0;
            this.txtNomePaciente.WordWrap = false;
            // 
            // tabMedico
            // 
            this.tabMedico.Controls.Add(this.dtpDataNascMedico);
            this.tabMedico.Controls.Add(this.lblUfMed);
            this.tabMedico.Controls.Add(this.cbxUFMed);
            this.tabMedico.Controls.Add(this.lblSexoMed);
            this.tabMedico.Controls.Add(this.rdbSexoMMed);
            this.tabMedico.Controls.Add(this.rdbSexoFMed);
            this.tabMedico.Controls.Add(this.lblOrgaoEmiMed);
            this.tabMedico.Controls.Add(this.txtOrgaoEmiMed);
            this.tabMedico.Controls.Add(this.lblRgMed);
            this.tabMedico.Controls.Add(this.txtRgMed);
            this.tabMedico.Controls.Add(this.label1);
            this.tabMedico.Controls.Add(this.txtCpfMed);
            this.tabMedico.Controls.Add(this.lblComplementoMed);
            this.tabMedico.Controls.Add(this.txtComplementoMed);
            this.tabMedico.Controls.Add(this.lblSobrenomeMed);
            this.tabMedico.Controls.Add(this.txtSobrenomeMed);
            this.tabMedico.Controls.Add(this.lblEspecialidadeMed);
            this.tabMedico.Controls.Add(this.cbxEspecialidadeMed);
            this.tabMedico.Controls.Add(this.lblCRM);
            this.tabMedico.Controls.Add(this.txtCrm);
            this.tabMedico.Controls.Add(this.lblEmailMed);
            this.tabMedico.Controls.Add(this.txtEmailMed);
            this.tabMedico.Controls.Add(this.lblCelularMed);
            this.tabMedico.Controls.Add(this.txtCelularMed);
            this.tabMedico.Controls.Add(this.lblTelefoneMed);
            this.tabMedico.Controls.Add(this.txtTelefoneMed);
            this.tabMedico.Controls.Add(this.lblCidadeMed);
            this.tabMedico.Controls.Add(this.lblCepMed);
            this.tabMedico.Controls.Add(this.txtCepMed);
            this.tabMedico.Controls.Add(this.cbxCidadeMed);
            this.tabMedico.Controls.Add(this.txtBairroMed);
            this.tabMedico.Controls.Add(this.lblBairroMed);
            this.tabMedico.Controls.Add(this.lblNumMed);
            this.tabMedico.Controls.Add(this.txtNumeroEndMed);
            this.tabMedico.Controls.Add(this.txtEnderecoMed);
            this.tabMedico.Controls.Add(this.lblEndMed);
            this.tabMedico.Controls.Add(this.lblNascMed);
            this.tabMedico.Controls.Add(this.lblNomeMed);
            this.tabMedico.Controls.Add(this.txtNomeMed);
            this.tabMedico.Location = new System.Drawing.Point(4, 22);
            this.tabMedico.Name = "tabMedico";
            this.tabMedico.Padding = new System.Windows.Forms.Padding(3);
            this.tabMedico.Size = new System.Drawing.Size(652, 411);
            this.tabMedico.TabIndex = 3;
            this.tabMedico.Text = "Médico";
            this.tabMedico.UseVisualStyleBackColor = true;
            // 
            // dtpDataNascMedico
            // 
            this.dtpDataNascMedico.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataNascMedico.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascMedico.Location = new System.Drawing.Point(469, 24);
            this.dtpDataNascMedico.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDataNascMedico.Name = "dtpDataNascMedico";
            this.dtpDataNascMedico.Size = new System.Drawing.Size(158, 22);
            this.dtpDataNascMedico.TabIndex = 82;
            // 
            // lblUfMed
            // 
            this.lblUfMed.AutoSize = true;
            this.lblUfMed.Location = new System.Drawing.Point(317, 137);
            this.lblUfMed.Name = "lblUfMed";
            this.lblUfMed.Size = new System.Drawing.Size(21, 13);
            this.lblUfMed.TabIndex = 81;
            this.lblUfMed.Text = "UF";
            // 
            // cbxUFMed
            // 
            this.cbxUFMed.AllowDrop = true;
            this.cbxUFMed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUFMed.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUFMed.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbxUFMed.Location = new System.Drawing.Point(320, 152);
            this.cbxUFMed.Name = "cbxUFMed";
            this.cbxUFMed.Size = new System.Drawing.Size(60, 24);
            this.cbxUFMed.TabIndex = 80;
            // 
            // lblSexoMed
            // 
            this.lblSexoMed.AutoSize = true;
            this.lblSexoMed.Location = new System.Drawing.Point(21, 51);
            this.lblSexoMed.Name = "lblSexoMed";
            this.lblSexoMed.Size = new System.Drawing.Size(31, 13);
            this.lblSexoMed.TabIndex = 60;
            this.lblSexoMed.Text = "Sexo";
            // 
            // rdbSexoMMed
            // 
            this.rdbSexoMMed.AutoSize = true;
            this.rdbSexoMMed.Location = new System.Drawing.Point(62, 67);
            this.rdbSexoMMed.Name = "rdbSexoMMed";
            this.rdbSexoMMed.Size = new System.Drawing.Size(34, 17);
            this.rdbSexoMMed.TabIndex = 5;
            this.rdbSexoMMed.TabStop = true;
            this.rdbSexoMMed.Text = "M";
            this.rdbSexoMMed.UseVisualStyleBackColor = true;
            // 
            // rdbSexoFMed
            // 
            this.rdbSexoFMed.AutoSize = true;
            this.rdbSexoFMed.Location = new System.Drawing.Point(25, 67);
            this.rdbSexoFMed.Name = "rdbSexoFMed";
            this.rdbSexoFMed.Size = new System.Drawing.Size(31, 17);
            this.rdbSexoFMed.TabIndex = 4;
            this.rdbSexoFMed.TabStop = true;
            this.rdbSexoFMed.Text = "F";
            this.rdbSexoFMed.UseVisualStyleBackColor = true;
            // 
            // lblOrgaoEmiMed
            // 
            this.lblOrgaoEmiMed.AutoSize = true;
            this.lblOrgaoEmiMed.Location = new System.Drawing.Point(537, 51);
            this.lblOrgaoEmiMed.Name = "lblOrgaoEmiMed";
            this.lblOrgaoEmiMed.Size = new System.Drawing.Size(75, 13);
            this.lblOrgaoEmiMed.TabIndex = 57;
            this.lblOrgaoEmiMed.Text = "Orgão Emissor";
            // 
            // txtOrgaoEmiMed
            // 
            this.txtOrgaoEmiMed.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOrgaoEmiMed.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrgaoEmiMed.Location = new System.Drawing.Point(540, 67);
            this.txtOrgaoEmiMed.Name = "txtOrgaoEmiMed";
            this.txtOrgaoEmiMed.Size = new System.Drawing.Size(87, 22);
            this.txtOrgaoEmiMed.TabIndex = 8;
            this.txtOrgaoEmiMed.WordWrap = false;
            // 
            // lblRgMed
            // 
            this.lblRgMed.AutoSize = true;
            this.lblRgMed.Location = new System.Drawing.Point(317, 51);
            this.lblRgMed.Name = "lblRgMed";
            this.lblRgMed.Size = new System.Drawing.Size(23, 13);
            this.lblRgMed.TabIndex = 55;
            this.lblRgMed.Text = "RG";
            // 
            // txtRgMed
            // 
            this.txtRgMed.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRgMed.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRgMed.Location = new System.Drawing.Point(320, 67);
            this.txtRgMed.Name = "txtRgMed";
            this.txtRgMed.Size = new System.Drawing.Size(194, 22);
            this.txtRgMed.TabIndex = 7;
            this.txtRgMed.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "CPF";
            // 
            // txtCpfMed
            // 
            this.txtCpfMed.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCpfMed.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfMed.Location = new System.Drawing.Point(112, 67);
            this.txtCpfMed.Name = "txtCpfMed";
            this.txtCpfMed.Size = new System.Drawing.Size(194, 22);
            this.txtCpfMed.TabIndex = 6;
            this.txtCpfMed.WordWrap = false;
            // 
            // lblComplementoMed
            // 
            this.lblComplementoMed.AutoSize = true;
            this.lblComplementoMed.Location = new System.Drawing.Point(434, 90);
            this.lblComplementoMed.Name = "lblComplementoMed";
            this.lblComplementoMed.Size = new System.Drawing.Size(71, 13);
            this.lblComplementoMed.TabIndex = 51;
            this.lblComplementoMed.Text = "Complemento";
            // 
            // txtComplementoMed
            // 
            this.txtComplementoMed.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtComplementoMed.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplementoMed.Location = new System.Drawing.Point(437, 106);
            this.txtComplementoMed.Name = "txtComplementoMed";
            this.txtComplementoMed.Size = new System.Drawing.Size(85, 22);
            this.txtComplementoMed.TabIndex = 11;
            this.txtComplementoMed.WordWrap = false;
            // 
            // lblSobrenomeMed
            // 
            this.lblSobrenomeMed.AutoSize = true;
            this.lblSobrenomeMed.Location = new System.Drawing.Point(229, 8);
            this.lblSobrenomeMed.Name = "lblSobrenomeMed";
            this.lblSobrenomeMed.Size = new System.Drawing.Size(61, 13);
            this.lblSobrenomeMed.TabIndex = 49;
            this.lblSobrenomeMed.Text = "Sobrenome";
            // 
            // txtSobrenomeMed
            // 
            this.txtSobrenomeMed.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSobrenomeMed.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobrenomeMed.Location = new System.Drawing.Point(232, 23);
            this.txtSobrenomeMed.Name = "txtSobrenomeMed";
            this.txtSobrenomeMed.Size = new System.Drawing.Size(219, 22);
            this.txtSobrenomeMed.TabIndex = 2;
            this.txtSobrenomeMed.WordWrap = false;
            // 
            // lblEspecialidadeMed
            // 
            this.lblEspecialidadeMed.AutoSize = true;
            this.lblEspecialidadeMed.Location = new System.Drawing.Point(342, 186);
            this.lblEspecialidadeMed.Name = "lblEspecialidadeMed";
            this.lblEspecialidadeMed.Size = new System.Drawing.Size(73, 13);
            this.lblEspecialidadeMed.TabIndex = 47;
            this.lblEspecialidadeMed.Text = "Especialidade";
            // 
            // cbxEspecialidadeMed
            // 
            this.cbxEspecialidadeMed.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEspecialidadeMed.FormattingEnabled = true;
            this.cbxEspecialidadeMed.Location = new System.Drawing.Point(345, 202);
            this.cbxEspecialidadeMed.Name = "cbxEspecialidadeMed";
            this.cbxEspecialidadeMed.Size = new System.Drawing.Size(177, 24);
            this.cbxEspecialidadeMed.TabIndex = 18;
            // 
            // lblCRM
            // 
            this.lblCRM.AutoSize = true;
            this.lblCRM.Location = new System.Drawing.Point(532, 188);
            this.lblCRM.Name = "lblCRM";
            this.lblCRM.Size = new System.Drawing.Size(31, 13);
            this.lblCRM.TabIndex = 45;
            this.lblCRM.Text = "CRM";
            // 
            // txtCrm
            // 
            this.txtCrm.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCrm.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCrm.Location = new System.Drawing.Point(534, 204);
            this.txtCrm.Name = "txtCrm";
            this.txtCrm.Size = new System.Drawing.Size(93, 22);
            this.txtCrm.TabIndex = 19;
            this.txtCrm.WordWrap = false;
            // 
            // lblEmailMed
            // 
            this.lblEmailMed.AutoSize = true;
            this.lblEmailMed.Location = new System.Drawing.Point(21, 188);
            this.lblEmailMed.Name = "lblEmailMed";
            this.lblEmailMed.Size = new System.Drawing.Size(35, 13);
            this.lblEmailMed.TabIndex = 43;
            this.lblEmailMed.Text = "E-mail";
            // 
            // txtEmailMed
            // 
            this.txtEmailMed.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmailMed.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailMed.Location = new System.Drawing.Point(24, 204);
            this.txtEmailMed.Name = "txtEmailMed";
            this.txtEmailMed.Size = new System.Drawing.Size(314, 22);
            this.txtEmailMed.TabIndex = 17;
            this.txtEmailMed.WordWrap = false;
            // 
            // lblCelularMed
            // 
            this.lblCelularMed.AutoSize = true;
            this.lblCelularMed.Location = new System.Drawing.Point(513, 137);
            this.lblCelularMed.Name = "lblCelularMed";
            this.lblCelularMed.Size = new System.Drawing.Size(39, 13);
            this.lblCelularMed.TabIndex = 41;
            this.lblCelularMed.Text = "Celular";
            // 
            // txtCelularMed
            // 
            this.txtCelularMed.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCelularMed.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelularMed.Location = new System.Drawing.Point(516, 152);
            this.txtCelularMed.Name = "txtCelularMed";
            this.txtCelularMed.Size = new System.Drawing.Size(111, 22);
            this.txtCelularMed.TabIndex = 16;
            this.txtCelularMed.WordWrap = false;
            // 
            // lblTelefoneMed
            // 
            this.lblTelefoneMed.AutoSize = true;
            this.lblTelefoneMed.Location = new System.Drawing.Point(395, 138);
            this.lblTelefoneMed.Name = "lblTelefoneMed";
            this.lblTelefoneMed.Size = new System.Drawing.Size(49, 13);
            this.lblTelefoneMed.TabIndex = 39;
            this.lblTelefoneMed.Text = "Telefone";
            // 
            // txtTelefoneMed
            // 
            this.txtTelefoneMed.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefoneMed.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoneMed.Location = new System.Drawing.Point(398, 152);
            this.txtTelefoneMed.Name = "txtTelefoneMed";
            this.txtTelefoneMed.Size = new System.Drawing.Size(107, 22);
            this.txtTelefoneMed.TabIndex = 15;
            this.txtTelefoneMed.WordWrap = false;
            // 
            // lblCidadeMed
            // 
            this.lblCidadeMed.AutoSize = true;
            this.lblCidadeMed.Location = new System.Drawing.Point(167, 137);
            this.lblCidadeMed.Name = "lblCidadeMed";
            this.lblCidadeMed.Size = new System.Drawing.Size(40, 13);
            this.lblCidadeMed.TabIndex = 37;
            this.lblCidadeMed.Text = "Cidade";
            // 
            // lblCepMed
            // 
            this.lblCepMed.AutoSize = true;
            this.lblCepMed.Location = new System.Drawing.Point(532, 90);
            this.lblCepMed.Name = "lblCepMed";
            this.lblCepMed.Size = new System.Drawing.Size(28, 13);
            this.lblCepMed.TabIndex = 35;
            this.lblCepMed.Text = "CEP";
            // 
            // txtCepMed
            // 
            this.txtCepMed.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCepMed.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCepMed.Location = new System.Drawing.Point(535, 106);
            this.txtCepMed.Name = "txtCepMed";
            this.txtCepMed.Size = new System.Drawing.Size(92, 22);
            this.txtCepMed.TabIndex = 12;
            this.txtCepMed.WordWrap = false;
            // 
            // cbxCidadeMed
            // 
            this.cbxCidadeMed.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCidadeMed.FormattingEnabled = true;
            this.cbxCidadeMed.Location = new System.Drawing.Point(170, 152);
            this.cbxCidadeMed.Name = "cbxCidadeMed";
            this.cbxCidadeMed.Size = new System.Drawing.Size(136, 24);
            this.cbxCidadeMed.TabIndex = 14;
            // 
            // txtBairroMed
            // 
            this.txtBairroMed.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBairroMed.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairroMed.Location = new System.Drawing.Point(24, 154);
            this.txtBairroMed.Name = "txtBairroMed";
            this.txtBairroMed.Size = new System.Drawing.Size(140, 22);
            this.txtBairroMed.TabIndex = 12;
            this.txtBairroMed.WordWrap = false;
            // 
            // lblBairroMed
            // 
            this.lblBairroMed.AutoSize = true;
            this.lblBairroMed.Location = new System.Drawing.Point(21, 138);
            this.lblBairroMed.Name = "lblBairroMed";
            this.lblBairroMed.Size = new System.Drawing.Size(34, 13);
            this.lblBairroMed.TabIndex = 30;
            this.lblBairroMed.Text = "Bairro";
            // 
            // lblNumMed
            // 
            this.lblNumMed.AutoSize = true;
            this.lblNumMed.Location = new System.Drawing.Point(359, 90);
            this.lblNumMed.Name = "lblNumMed";
            this.lblNumMed.Size = new System.Drawing.Size(44, 13);
            this.lblNumMed.TabIndex = 29;
            this.lblNumMed.Text = "Número";
            // 
            // txtNumeroEndMed
            // 
            this.txtNumeroEndMed.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNumeroEndMed.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroEndMed.Location = new System.Drawing.Point(362, 106);
            this.txtNumeroEndMed.Name = "txtNumeroEndMed";
            this.txtNumeroEndMed.Size = new System.Drawing.Size(60, 22);
            this.txtNumeroEndMed.TabIndex = 10;
            this.txtNumeroEndMed.WordWrap = false;
            // 
            // txtEnderecoMed
            // 
            this.txtEnderecoMed.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEnderecoMed.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoMed.Location = new System.Drawing.Point(24, 106);
            this.txtEnderecoMed.Name = "txtEnderecoMed";
            this.txtEnderecoMed.Size = new System.Drawing.Size(321, 22);
            this.txtEnderecoMed.TabIndex = 9;
            this.txtEnderecoMed.WordWrap = false;
            // 
            // lblEndMed
            // 
            this.lblEndMed.AutoSize = true;
            this.lblEndMed.Location = new System.Drawing.Point(21, 90);
            this.lblEndMed.Name = "lblEndMed";
            this.lblEndMed.Size = new System.Drawing.Size(53, 13);
            this.lblEndMed.TabIndex = 26;
            this.lblEndMed.Text = "Endereço";
            // 
            // lblNascMed
            // 
            this.lblNascMed.AutoSize = true;
            this.lblNascMed.Location = new System.Drawing.Point(466, 8);
            this.lblNascMed.Name = "lblNascMed";
            this.lblNascMed.Size = new System.Drawing.Size(89, 13);
            this.lblNascMed.TabIndex = 24;
            this.lblNascMed.Text = "Data Nascimento";
            // 
            // lblNomeMed
            // 
            this.lblNomeMed.AutoSize = true;
            this.lblNomeMed.Location = new System.Drawing.Point(21, 8);
            this.lblNomeMed.Name = "lblNomeMed";
            this.lblNomeMed.Size = new System.Drawing.Size(35, 13);
            this.lblNomeMed.TabIndex = 23;
            this.lblNomeMed.Text = "Nome";
            // 
            // txtNomeMed
            // 
            this.txtNomeMed.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeMed.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeMed.Location = new System.Drawing.Point(24, 24);
            this.txtNomeMed.Name = "txtNomeMed";
            this.txtNomeMed.Size = new System.Drawing.Size(194, 22);
            this.txtNomeMed.TabIndex = 1;
            this.txtNomeMed.WordWrap = false;
            // 
            // tabConvenio
            // 
            this.tabConvenio.Controls.Add(this.lblNomeConvenio);
            this.tabConvenio.Controls.Add(this.txtNomeConvenio);
            this.tabConvenio.Location = new System.Drawing.Point(4, 22);
            this.tabConvenio.Name = "tabConvenio";
            this.tabConvenio.Padding = new System.Windows.Forms.Padding(3);
            this.tabConvenio.Size = new System.Drawing.Size(652, 411);
            this.tabConvenio.TabIndex = 4;
            this.tabConvenio.Text = "Convênio";
            this.tabConvenio.UseVisualStyleBackColor = true;
            // 
            // lblNomeConvenio
            // 
            this.lblNomeConvenio.AutoSize = true;
            this.lblNomeConvenio.Location = new System.Drawing.Point(18, 13);
            this.lblNomeConvenio.Name = "lblNomeConvenio";
            this.lblNomeConvenio.Size = new System.Drawing.Size(35, 13);
            this.lblNomeConvenio.TabIndex = 25;
            this.lblNomeConvenio.Text = "Nome";
            // 
            // txtNomeConvenio
            // 
            this.txtNomeConvenio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeConvenio.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeConvenio.Location = new System.Drawing.Point(21, 29);
            this.txtNomeConvenio.Name = "txtNomeConvenio";
            this.txtNomeConvenio.Size = new System.Drawing.Size(194, 21);
            this.txtNomeConvenio.TabIndex = 24;
            this.txtNomeConvenio.WordWrap = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.lbDateTime_Tick);
            // 
            // agendaMedicaDataSet
            // 
            this.agendaMedicaDataSet.DataSetName = "agendaMedicaDataSet";
            this.agendaMedicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agendaMedicaDataSetBindingSource
            // 
            this.agendaMedicaDataSetBindingSource.DataSource = this.agendaMedicaDataSet;
            this.agendaMedicaDataSetBindingSource.Position = 0;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 503);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cadastro";
            this.Text = "Cadastrar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.barAcoes.ResumeLayout(false);
            this.barAcoes.PerformLayout();
            this.barInfos.ResumeLayout(false);
            this.barInfos.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabCadastrar.ResumeLayout(false);
            this.tabConsulta.ResumeLayout(false);
            this.tabConsulta.PerformLayout();
            this.tabPaciente.ResumeLayout(false);
            this.tabPaciente.PerformLayout();
            this.tabMedico.ResumeLayout(false);
            this.tabMedico.PerformLayout();
            this.tabConvenio.ResumeLayout(false);
            this.tabConvenio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendaMedicaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaMedicaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.TabControl tabCadastrar;
        public System.Windows.Forms.TabPage tabConsulta;
        public System.Windows.Forms.TabPage tabMedico;
        public System.Windows.Forms.Label lblCRM;
        public System.Windows.Forms.TextBox txtCrm;
        public System.Windows.Forms.Label lblEmailMed;
        public System.Windows.Forms.TextBox txtEmailMed;
        public System.Windows.Forms.Label lblCelularMed;
        public System.Windows.Forms.Label lblTelefoneMed;
        public System.Windows.Forms.Label lblCidadeMed;
        public System.Windows.Forms.Label lblCepMed;
        public System.Windows.Forms.TextBox txtCepMed;
        public System.Windows.Forms.ComboBox cbxCidadeMed;
        public System.Windows.Forms.TextBox txtBairroMed;
        public System.Windows.Forms.Label lblBairroMed;
        public System.Windows.Forms.Label lblNumMed;
        public System.Windows.Forms.TextBox txtNumeroEndMed;
        public System.Windows.Forms.TextBox txtEnderecoMed;
        public System.Windows.Forms.Label lblEndMed;
        public System.Windows.Forms.Label lblNascMed;
        public System.Windows.Forms.Label lblNomeMed;
        public System.Windows.Forms.TextBox txtNomeMed;
        public System.Windows.Forms.Label lblDataAgen;
        public System.Windows.Forms.DateTimePicker dtpDataConsulta;
        public System.Windows.Forms.Label lblMedicoAgen;
        public System.Windows.Forms.Label lblEspecialidadeMed;
        public System.Windows.Forms.ComboBox cbxEspecialidadeMed;
        public System.Windows.Forms.Label lblPacienteAgen;
        public System.Windows.Forms.ComboBox cbxMedicoConsulta;
        public System.Windows.Forms.TextBox txtPacienteConsulta;
        public System.Windows.Forms.ComboBox cbxEspecialidadeConsulta;
        public System.Windows.Forms.Label lblEspecialidadeAgen;
        public System.Windows.Forms.Label lblPlanoMedAgen;
        public System.Windows.Forms.ComboBox cbxConvenioConsulta;
        public System.Windows.Forms.TextBox txtCelularMed;
        public System.Windows.Forms.TextBox txtTelefoneMed;
        public System.Windows.Forms.TextBox txtSobrenomeMed;
        public System.Windows.Forms.Label lblComplementoMed;
        public System.Windows.Forms.TextBox txtComplementoMed;
        public System.Windows.Forms.Label lblSobrenomeMed;
        public System.Windows.Forms.Label lblOrgaoEmiMed;
        public System.Windows.Forms.TextBox txtOrgaoEmiMed;
        public System.Windows.Forms.Label lblRgMed;
        public System.Windows.Forms.TextBox txtRgMed;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtCpfMed;
        public System.Windows.Forms.RadioButton rdbSexoMMed;
        public System.Windows.Forms.RadioButton rdbSexoFMed;
        public System.Windows.Forms.Label lblSexoMed;
        public System.Windows.Forms.ToolStrip barAcoes;
        public System.Windows.Forms.ToolStripButton btnAdicionar;
        public System.Windows.Forms.ToolStripButton btnLimpar;
        public System.Windows.Forms.ToolStripButton btnExit;
        public System.Windows.Forms.StatusStrip barInfos;
        public System.Windows.Forms.ToolStripStatusLabel lbDateTime;
        public System.Windows.Forms.TabPage tabPaciente;
        public System.Windows.Forms.Label lblComplementoPaciente;
        public System.Windows.Forms.TextBox txtComplementoPaciente;
        public System.Windows.Forms.Label lblEmailPaciente;
        public System.Windows.Forms.Label lblCelularPaciente;
        public System.Windows.Forms.TextBox txtCelularPaciente;
        public System.Windows.Forms.Label lblTelefonePaciente;
        public System.Windows.Forms.Label lblCidadePaciente;
        public System.Windows.Forms.Label lblEstadoPaciente;
        public System.Windows.Forms.Label lblCepPaciente;
        public System.Windows.Forms.TextBox txtCepPaciente;
        public System.Windows.Forms.ComboBox cbxCidadePaciente;
        public System.Windows.Forms.TextBox txtBairroPaciente;
        public System.Windows.Forms.Label lblBairroPaciente;
        public System.Windows.Forms.Label lblNumeroEndPaciente;
        public System.Windows.Forms.Label lblEnderecoPaciente;
        public System.Windows.Forms.Label lblOrgaoEmiPaciente;
        public System.Windows.Forms.TextBox txtOrgaoEmiPaciente;
        public System.Windows.Forms.Label lblRgPaciente;
        public System.Windows.Forms.TextBox txtRgPaciente;
        public System.Windows.Forms.Label lblCpfPaciente;
        public System.Windows.Forms.Label lblSobrenomePaciente;
        public System.Windows.Forms.RadioButton rdbSexoMPaciente;
        public System.Windows.Forms.RadioButton rdbSexoFPaciente;
        public System.Windows.Forms.Label lblSexoPac;
        public System.Windows.Forms.Label lblConvenioPac;
        public System.Windows.Forms.ComboBox cbxConvenioPaciente;
        public System.Windows.Forms.Label lblNumCarteirinhaPaciente;
        public System.Windows.Forms.Label lblNascPaciente;
        public System.Windows.Forms.Label lblNomePaciente;
        public System.Windows.Forms.TextBox txtEmailPaciente;
        public System.Windows.Forms.TextBox txtTelefonePaciente;
        public System.Windows.Forms.ComboBox cbxUFPaciente;
        public System.Windows.Forms.TextBox txtNumeroEndPaciente;
        public System.Windows.Forms.TextBox txtEnderecoPaciente;
        public System.Windows.Forms.TextBox txtCpfPaciente;
        public System.Windows.Forms.TextBox txtSobrenomePaciente;
        public System.Windows.Forms.TextBox txtNumCarteirinhaPaciente;
        public System.Windows.Forms.TextBox txtNomePaciente;
        public System.Windows.Forms.Label lblUfMed;
        public System.Windows.Forms.ComboBox cbxUFMed;
        public System.Windows.Forms.TabPage tabConvenio;
        public System.Windows.Forms.Label lblNomeConvenio;
        public System.Windows.Forms.TextBox txtNomeConvenio;
        public agendaMedicaDataSet agendaMedicaDataSet;
        public System.Windows.Forms.BindingSource agendaMedicaDataSetBindingSource;
        public System.Windows.Forms.DateTimePicker dtpDataNascPaciente;
        public System.Windows.Forms.DateTimePicker dtpDataNascMedico;
    }
}

