using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Xsl;
namespace Quadro.UI
{
    partial class Quadro
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtReuniaoMeioSemana = new System.Windows.Forms.TextBox();
            this.txtReuniaoFimSemana = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.pnlCor2 = new System.Windows.Forms.Panel();
            this.pnlCor1 = new System.Windows.Forms.Panel();
            this.label50 = new System.Windows.Forms.Label();
            this.n_Ano = new System.Windows.Forms.NumericUpDown();
            this.label49 = new System.Windows.Forms.Label();
            this.n_Mes = new System.Windows.Forms.NumericUpDown();
            this.chk_Congresso = new System.Windows.Forms.CheckBox();
            this.chk_Assembleia = new System.Windows.Forms.CheckBox();
            this.chk_VisitaSup = new System.Windows.Forms.CheckBox();
            this.chk_SalaB = new System.Windows.Forms.CheckBox();
            this.chk_PrimeiraSemana = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.txt_NVMC_Oracao_Final = new System.Windows.Forms.TextBox();
            this.label85 = new System.Windows.Forms.Label();
            this.txt_NVMC_Oracao_Inicial = new System.Windows.Forms.TextBox();
            this.label84 = new System.Windows.Forms.Label();
            this.txt_NVMC_SalaB_Leitura = new System.Windows.Forms.TextBox();
            this.txt_NVMC_SalaA_Leitura = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_NVMC_DiscursoDesignado = new System.Windows.Forms.TextBox();
            this.txt_NVMC_DiscursoTema = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_NVMC_Joias = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_NVMC_Presidente = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_NVMC_SalaB_Dirigente = new System.Windows.Forms.TextBox();
            this.txt_NVMC_SalaA_Dirigente = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_NVMC_SalaB_QuartaParteAjudante = new System.Windows.Forms.TextBox();
            this.txt_NVMC_SalaB_QuartaParteDesignado = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txt_NVMC_SalaB_TerceiraParteAjudante = new System.Windows.Forms.TextBox();
            this.txt_NVMC_SalaB_TerceiraParteDesignado = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.txt_NVMC_SalaB_PrimeiraParteAjudante = new System.Windows.Forms.TextBox();
            this.txt_NVMC_SalaB_PrimeiraParteDesignado = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.txt_NVMC_SalaB_SegundaParteAjudante = new System.Windows.Forms.TextBox();
            this.txt_NVMC_SalaB_SegundaParteDesignado = new System.Windows.Forms.TextBox();
            this.label70 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.txt_NVMC_NomeQuartaParte = new System.Windows.Forms.TextBox();
            this.label73 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.txt_NVMC_SalaA_QuartaParteAjudante = new System.Windows.Forms.TextBox();
            this.txt_NVMC_SalaA_QuartaParteDesignado = new System.Windows.Forms.TextBox();
            this.txt_NVMC_NomeTerceiraParte = new System.Windows.Forms.TextBox();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.txt_NVMC_SalaA_TerceiraParteAjudante = new System.Windows.Forms.TextBox();
            this.txt_NVMC_SalaA_TerceiraParteDesignado = new System.Windows.Forms.TextBox();
            this.txt_NVMC_NomeSegundaParte = new System.Windows.Forms.TextBox();
            this.label77 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.txt_NVMC_SalaA_PrimeiraParteAjudante = new System.Windows.Forms.TextBox();
            this.txt_NVMC_SalaA_PrimeiraParteDesignado = new System.Windows.Forms.TextBox();
            this.label80 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.txt_NVMC_NomePrimeiraParte = new System.Windows.Forms.TextBox();
            this.txt_NVMC_SalaA_SegundaParteAjudante = new System.Windows.Forms.TextBox();
            this.txt_NVMC_SalaA_SegundaParteDesignado = new System.Windows.Forms.TextBox();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.label41 = new System.Windows.Forms.Label();
            this.txt_NVMC_EBC_Leitor = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.txt_NVMC_EBC_Dirigente = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.txt_NVMC_Parte3_Designado = new System.Windows.Forms.TextBox();
            this.txt_NVMC_Parte3_Tema = new System.Windows.Forms.TextBox();
            this.txt_NVMC_Parte3_Dur = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.txt_NVMC_Parte2_Designado = new System.Windows.Forms.TextBox();
            this.txt_NVMC_Parte2_Tema = new System.Windows.Forms.TextBox();
            this.txt_NVMC_Parte2_Dur = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.txt_NVMC_Parte1_Designado = new System.Windows.Forms.TextBox();
            this.txt_NVMC_Parte1_Tema = new System.Windows.Forms.TextBox();
            this.txt_NVMC_Parte1_Dur = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_RP_Discurso_Cong = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.txt_RP_Discurso_Orador = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.txt_RP_Discurso_Tema = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.txt_RP_Sentinela_Leitor = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.txt_RP_Presidente = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label30 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.txt_DS_Transporte_FS = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_DS_Indicador_FS = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.txt_DS_Audio_FS = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txt_DS_Video_FS = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_DS_Marcador_Tempo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_DS_Transporte_MS = new System.Windows.Forms.TextBox();
            this.label69 = new System.Windows.Forms.Label();
            this.txt_DS_Limpeza_Dirigente = new System.Windows.Forms.TextBox();
            this.txt_DS_Limpeza_Grupo = new System.Windows.Forms.TextBox();
            this.label68 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.txt_DS_Brigada_Brigadista2 = new System.Windows.Forms.TextBox();
            this.txt_DS_Brigada_Brigadista1 = new System.Windows.Forms.TextBox();
            this.label66 = new System.Windows.Forms.Label();
            this.txt_DS_Brigada_Lider = new System.Windows.Forms.TextBox();
            this.label65 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.txt_DS_Brigada_ChefeTurno = new System.Windows.Forms.TextBox();
            this.label64 = new System.Windows.Forms.Label();
            this.txt_DS_Audio_MS = new System.Windows.Forms.TextBox();
            this.label60 = new System.Windows.Forms.Label();
            this.txt_DS_Video_MS = new System.Windows.Forms.TextBox();
            this.txt_DS_Indicador_MS = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_SC_Comercial = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.txt_SC_Residencial = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnProxSemana = new System.Windows.Forms.Button();
            this.btnSemanaAnt = new System.Windows.Forms.Button();
            this.lblSemana = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnFolhaNvmc = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnGerarQuadro = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_Ano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_Mes)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1024, 673);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 44);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1018, 570);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(10);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(1010, 539);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Semana";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtReuniaoMeioSemana);
            this.panel1.Controls.Add(this.txtReuniaoFimSemana);
            this.panel1.Controls.Add(this.label52);
            this.panel1.Controls.Add(this.label51);
            this.panel1.Controls.Add(this.pnlCor2);
            this.panel1.Controls.Add(this.pnlCor1);
            this.panel1.Controls.Add(this.label50);
            this.panel1.Controls.Add(this.n_Ano);
            this.panel1.Controls.Add(this.label49);
            this.panel1.Controls.Add(this.n_Mes);
            this.panel1.Controls.Add(this.chk_Congresso);
            this.panel1.Controls.Add(this.chk_Assembleia);
            this.panel1.Controls.Add(this.chk_VisitaSup);
            this.panel1.Controls.Add(this.chk_SalaB);
            this.panel1.Controls.Add(this.chk_PrimeiraSemana);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 479);
            this.panel1.TabIndex = 0;
            // 
            // txtReuniaoMeioSemana
            // 
            this.txtReuniaoMeioSemana.Location = new System.Drawing.Point(75, 215);
            this.txtReuniaoMeioSemana.Name = "txtReuniaoMeioSemana";
            this.txtReuniaoMeioSemana.Size = new System.Drawing.Size(309, 26);
            this.txtReuniaoMeioSemana.TabIndex = 23;
            // 
            // txtReuniaoFimSemana
            // 
            this.txtReuniaoFimSemana.Location = new System.Drawing.Point(75, 265);
            this.txtReuniaoFimSemana.Name = "txtReuniaoFimSemana";
            this.txtReuniaoFimSemana.Size = new System.Drawing.Size(309, 26);
            this.txtReuniaoFimSemana.TabIndex = 22;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(259, 135);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(45, 16);
            this.label52.TabIndex = 21;
            this.label52.Text = "Cor 2";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(209, 135);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(45, 16);
            this.label51.TabIndex = 20;
            this.label51.Text = "Cor 1";
            // 
            // pnlCor2
            // 
            this.pnlCor2.BackColor = System.Drawing.Color.DarkRed;
            this.pnlCor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCor2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlCor2.Location = new System.Drawing.Point(260, 152);
            this.pnlCor2.Name = "pnlCor2";
            this.pnlCor2.Size = new System.Drawing.Size(35, 21);
            this.pnlCor2.TabIndex = 19;
            this.pnlCor2.Click += new System.EventHandler(this.pnlCor2_Click);
            // 
            // pnlCor1
            // 
            this.pnlCor1.BackColor = System.Drawing.Color.DarkRed;
            this.pnlCor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCor1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlCor1.Location = new System.Drawing.Point(209, 152);
            this.pnlCor1.Name = "pnlCor1";
            this.pnlCor1.Size = new System.Drawing.Size(35, 21);
            this.pnlCor1.TabIndex = 18;
            this.pnlCor1.Click += new System.EventHandler(this.pnlCor1_Click);
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(128, 135);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(35, 16);
            this.label50.TabIndex = 17;
            this.label50.Text = "Ano";
            // 
            // n_Ano
            // 
            this.n_Ano.Location = new System.Drawing.Point(128, 152);
            this.n_Ano.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.n_Ano.Minimum = new decimal(new int[] {
            2016,
            0,
            0,
            0});
            this.n_Ano.Name = "n_Ano";
            this.n_Ano.Size = new System.Drawing.Size(67, 26);
            this.n_Ano.TabIndex = 16;
            this.n_Ano.Value = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(80, 135);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(37, 16);
            this.label49.TabIndex = 15;
            this.label49.Text = "Mês";
            // 
            // n_Mes
            // 
            this.n_Mes.Location = new System.Drawing.Point(80, 152);
            this.n_Mes.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.n_Mes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n_Mes.Name = "n_Mes";
            this.n_Mes.Size = new System.Drawing.Size(42, 26);
            this.n_Mes.TabIndex = 14;
            this.n_Mes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chk_Congresso
            // 
            this.chk_Congresso.AutoSize = true;
            this.chk_Congresso.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Congresso.Location = new System.Drawing.Point(431, 243);
            this.chk_Congresso.Name = "chk_Congresso";
            this.chk_Congresso.Size = new System.Drawing.Size(107, 20);
            this.chk_Congresso.TabIndex = 11;
            this.chk_Congresso.Text = "Congresso";
            this.chk_Congresso.UseVisualStyleBackColor = true;
            // 
            // chk_Assembleia
            // 
            this.chk_Assembleia.AutoSize = true;
            this.chk_Assembleia.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Assembleia.Location = new System.Drawing.Point(431, 219);
            this.chk_Assembleia.Name = "chk_Assembleia";
            this.chk_Assembleia.Size = new System.Drawing.Size(109, 20);
            this.chk_Assembleia.TabIndex = 10;
            this.chk_Assembleia.Text = "Assembléia";
            this.chk_Assembleia.UseVisualStyleBackColor = true;
            // 
            // chk_VisitaSup
            // 
            this.chk_VisitaSup.AutoSize = true;
            this.chk_VisitaSup.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_VisitaSup.Location = new System.Drawing.Point(431, 195);
            this.chk_VisitaSup.Name = "chk_VisitaSup";
            this.chk_VisitaSup.Size = new System.Drawing.Size(191, 20);
            this.chk_VisitaSup.TabIndex = 9;
            this.chk_VisitaSup.Text = "Visita Superintendente";
            this.chk_VisitaSup.UseVisualStyleBackColor = true;
            // 
            // chk_SalaB
            // 
            this.chk_SalaB.AutoSize = true;
            this.chk_SalaB.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_SalaB.Location = new System.Drawing.Point(431, 171);
            this.chk_SalaB.Name = "chk_SalaB";
            this.chk_SalaB.Size = new System.Drawing.Size(73, 20);
            this.chk_SalaB.TabIndex = 8;
            this.chk_SalaB.Text = "Sala B";
            this.chk_SalaB.UseVisualStyleBackColor = true;
            // 
            // chk_PrimeiraSemana
            // 
            this.chk_PrimeiraSemana.AutoSize = true;
            this.chk_PrimeiraSemana.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_PrimeiraSemana.Location = new System.Drawing.Point(431, 147);
            this.chk_PrimeiraSemana.Name = "chk_PrimeiraSemana";
            this.chk_PrimeiraSemana.Size = new System.Drawing.Size(147, 20);
            this.chk_PrimeiraSemana.TabIndex = 7;
            this.chk_PrimeiraSemana.Text = "Primeira Semana";
            this.chk_PrimeiraSemana.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Maroon;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(428, 117);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.label9.Size = new System.Drawing.Size(77, 22);
            this.label9.TabIndex = 6;
            this.label9.Text = "OPÇÕES";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(73, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Reunião de Fim de Semana";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(73, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(208, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Reunião de Meio de Semana";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Maroon;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(80, 103);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.label6.Size = new System.Drawing.Size(61, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "DATAS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuração da Semana";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(1010, 539);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nossa Vida Ministério Cristão";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(9, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(994, 520);
            this.panel2.TabIndex = 1;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Controls.Add(this.tabPage8);
            this.tabControl2.Location = new System.Drawing.Point(3, 37);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(986, 480);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.txt_NVMC_Oracao_Final);
            this.tabPage6.Controls.Add(this.label85);
            this.tabPage6.Controls.Add(this.txt_NVMC_Oracao_Inicial);
            this.tabPage6.Controls.Add(this.label84);
            this.tabPage6.Controls.Add(this.txt_NVMC_SalaB_Leitura);
            this.tabPage6.Controls.Add(this.txt_NVMC_SalaA_Leitura);
            this.tabPage6.Controls.Add(this.label16);
            this.tabPage6.Controls.Add(this.label21);
            this.tabPage6.Controls.Add(this.label20);
            this.tabPage6.Controls.Add(this.label12);
            this.tabPage6.Controls.Add(this.txt_NVMC_DiscursoDesignado);
            this.tabPage6.Controls.Add(this.txt_NVMC_DiscursoTema);
            this.tabPage6.Controls.Add(this.label11);
            this.tabPage6.Controls.Add(this.txt_NVMC_Joias);
            this.tabPage6.Controls.Add(this.label13);
            this.tabPage6.Controls.Add(this.txt_NVMC_Presidente);
            this.tabPage6.Controls.Add(this.label10);
            this.tabPage6.Location = new System.Drawing.Point(4, 27);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(978, 449);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "TESOUROS DA PALAVRA DE DEUS";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // txt_NVMC_Oracao_Final
            // 
            this.txt_NVMC_Oracao_Final.Location = new System.Drawing.Point(611, 53);
            this.txt_NVMC_Oracao_Final.Name = "txt_NVMC_Oracao_Final";
            this.txt_NVMC_Oracao_Final.Size = new System.Drawing.Size(263, 26);
            this.txt_NVMC_Oracao_Final.TabIndex = 2;
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label85.Location = new System.Drawing.Point(610, 35);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(92, 16);
            this.label85.TabIndex = 105;
            this.label85.Text = "Oração final";
            // 
            // txt_NVMC_Oracao_Inicial
            // 
            this.txt_NVMC_Oracao_Inicial.Location = new System.Drawing.Point(322, 53);
            this.txt_NVMC_Oracao_Inicial.Name = "txt_NVMC_Oracao_Inicial";
            this.txt_NVMC_Oracao_Inicial.Size = new System.Drawing.Size(268, 26);
            this.txt_NVMC_Oracao_Inicial.TabIndex = 1;
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label84.Location = new System.Drawing.Point(321, 35);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(103, 16);
            this.label84.TabIndex = 103;
            this.label84.Text = "Oração inicial";
            // 
            // txt_NVMC_SalaB_Leitura
            // 
            this.txt_NVMC_SalaB_Leitura.Location = new System.Drawing.Point(321, 328);
            this.txt_NVMC_SalaB_Leitura.Name = "txt_NVMC_SalaB_Leitura";
            this.txt_NVMC_SalaB_Leitura.Size = new System.Drawing.Size(268, 26);
            this.txt_NVMC_SalaB_Leitura.TabIndex = 7;
            // 
            // txt_NVMC_SalaA_Leitura
            // 
            this.txt_NVMC_SalaA_Leitura.Location = new System.Drawing.Point(30, 328);
            this.txt_NVMC_SalaA_Leitura.Name = "txt_NVMC_SalaA_Leitura";
            this.txt_NVMC_SalaA_Leitura.Size = new System.Drawing.Size(267, 26);
            this.txt_NVMC_SalaA_Leitura.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(31, 275);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(120, 16);
            this.label16.TabIndex = 100;
            this.label16.Text = "Leitura da bíblia";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Maroon;
            this.label21.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(321, 297);
            this.label21.Name = "label21";
            this.label21.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.label21.Size = new System.Drawing.Size(66, 22);
            this.label21.TabIndex = 30;
            this.label21.Text = "SALA B";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Maroon;
            this.label20.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(31, 297);
            this.label20.Name = "label20";
            this.label20.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.label20.Size = new System.Drawing.Size(64, 22);
            this.label20.TabIndex = 29;
            this.label20.Text = "SALA A";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(321, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 16);
            this.label12.TabIndex = 24;
            this.label12.Text = "Designado";
            // 
            // txt_NVMC_DiscursoDesignado
            // 
            this.txt_NVMC_DiscursoDesignado.Location = new System.Drawing.Point(321, 143);
            this.txt_NVMC_DiscursoDesignado.Name = "txt_NVMC_DiscursoDesignado";
            this.txt_NVMC_DiscursoDesignado.Size = new System.Drawing.Size(268, 26);
            this.txt_NVMC_DiscursoDesignado.TabIndex = 4;
            // 
            // txt_NVMC_DiscursoTema
            // 
            this.txt_NVMC_DiscursoTema.Location = new System.Drawing.Point(34, 143);
            this.txt_NVMC_DiscursoTema.Name = "txt_NVMC_DiscursoTema";
            this.txt_NVMC_DiscursoTema.Size = new System.Drawing.Size(263, 26);
            this.txt_NVMC_DiscursoTema.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(33, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Discurso - Tema";
            // 
            // txt_NVMC_Joias
            // 
            this.txt_NVMC_Joias.Location = new System.Drawing.Point(34, 215);
            this.txt_NVMC_Joias.Name = "txt_NVMC_Joias";
            this.txt_NVMC_Joias.Size = new System.Drawing.Size(263, 26);
            this.txt_NVMC_Joias.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(33, 197);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(191, 16);
            this.label13.TabIndex = 19;
            this.label13.Text = "Encontre Jóias Espirituais";
            // 
            // txt_NVMC_Presidente
            // 
            this.txt_NVMC_Presidente.Location = new System.Drawing.Point(35, 53);
            this.txt_NVMC_Presidente.Name = "txt_NVMC_Presidente";
            this.txt_NVMC_Presidente.Size = new System.Drawing.Size(263, 26);
            this.txt_NVMC_Presidente.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Presidente";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.panel6);
            this.tabPage7.Location = new System.Drawing.Point(4, 27);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(978, 449);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "FAÇA SEU MELHOR NO MINISTÉRIO";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txt_NVMC_SalaB_Dirigente);
            this.panel6.Controls.Add(this.txt_NVMC_SalaA_Dirigente);
            this.panel6.Controls.Add(this.label33);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.label22);
            this.panel6.Controls.Add(this.label23);
            this.panel6.Controls.Add(this.txt_NVMC_SalaB_QuartaParteAjudante);
            this.panel6.Controls.Add(this.txt_NVMC_SalaB_QuartaParteDesignado);
            this.panel6.Controls.Add(this.label24);
            this.panel6.Controls.Add(this.label25);
            this.panel6.Controls.Add(this.txt_NVMC_SalaB_TerceiraParteAjudante);
            this.panel6.Controls.Add(this.txt_NVMC_SalaB_TerceiraParteDesignado);
            this.panel6.Controls.Add(this.label26);
            this.panel6.Controls.Add(this.label27);
            this.panel6.Controls.Add(this.txt_NVMC_SalaB_PrimeiraParteAjudante);
            this.panel6.Controls.Add(this.txt_NVMC_SalaB_PrimeiraParteDesignado);
            this.panel6.Controls.Add(this.label28);
            this.panel6.Controls.Add(this.label29);
            this.panel6.Controls.Add(this.txt_NVMC_SalaB_SegundaParteAjudante);
            this.panel6.Controls.Add(this.txt_NVMC_SalaB_SegundaParteDesignado);
            this.panel6.Controls.Add(this.label70);
            this.panel6.Controls.Add(this.label71);
            this.panel6.Controls.Add(this.label72);
            this.panel6.Controls.Add(this.txt_NVMC_NomeQuartaParte);
            this.panel6.Controls.Add(this.label73);
            this.panel6.Controls.Add(this.label74);
            this.panel6.Controls.Add(this.txt_NVMC_SalaA_QuartaParteAjudante);
            this.panel6.Controls.Add(this.txt_NVMC_SalaA_QuartaParteDesignado);
            this.panel6.Controls.Add(this.txt_NVMC_NomeTerceiraParte);
            this.panel6.Controls.Add(this.label75);
            this.panel6.Controls.Add(this.label76);
            this.panel6.Controls.Add(this.txt_NVMC_SalaA_TerceiraParteAjudante);
            this.panel6.Controls.Add(this.txt_NVMC_SalaA_TerceiraParteDesignado);
            this.panel6.Controls.Add(this.txt_NVMC_NomeSegundaParte);
            this.panel6.Controls.Add(this.label77);
            this.panel6.Controls.Add(this.label78);
            this.panel6.Controls.Add(this.label79);
            this.panel6.Controls.Add(this.txt_NVMC_SalaA_PrimeiraParteAjudante);
            this.panel6.Controls.Add(this.txt_NVMC_SalaA_PrimeiraParteDesignado);
            this.panel6.Controls.Add(this.label80);
            this.panel6.Controls.Add(this.label81);
            this.panel6.Controls.Add(this.txt_NVMC_NomePrimeiraParte);
            this.panel6.Controls.Add(this.txt_NVMC_SalaA_SegundaParteAjudante);
            this.panel6.Controls.Add(this.txt_NVMC_SalaA_SegundaParteDesignado);
            this.panel6.Location = new System.Drawing.Point(6, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(966, 437);
            this.panel6.TabIndex = 63;
            // 
            // txt_NVMC_SalaB_Dirigente
            // 
            this.txt_NVMC_SalaB_Dirigente.Location = new System.Drawing.Point(646, 35);
            this.txt_NVMC_SalaB_Dirigente.Name = "txt_NVMC_SalaB_Dirigente";
            this.txt_NVMC_SalaB_Dirigente.Size = new System.Drawing.Size(293, 26);
            this.txt_NVMC_SalaB_Dirigente.TabIndex = 1;
            // 
            // txt_NVMC_SalaA_Dirigente
            // 
            this.txt_NVMC_SalaA_Dirigente.Location = new System.Drawing.Point(327, 35);
            this.txt_NVMC_SalaA_Dirigente.Name = "txt_NVMC_SalaA_Dirigente";
            this.txt_NVMC_SalaA_Dirigente.Size = new System.Drawing.Size(293, 26);
            this.txt_NVMC_SalaA_Dirigente.TabIndex = 0;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Maroon;
            this.label33.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(647, 7);
            this.label33.Name = "label33";
            this.label33.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.label33.Size = new System.Drawing.Size(66, 22);
            this.label33.TabIndex = 97;
            this.label33.Text = "SALA B";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Maroon;
            this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(327, 5);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.label14.Size = new System.Drawing.Size(64, 22);
            this.label14.TabIndex = 94;
            this.label14.Text = "SALA A";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(646, 388);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(70, 16);
            this.label22.TabIndex = 93;
            this.label22.Text = "Ajudante";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(646, 342);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(83, 16);
            this.label23.TabIndex = 92;
            this.label23.Text = "Designado";
            // 
            // txt_NVMC_SalaB_QuartaParteAjudante
            // 
            this.txt_NVMC_SalaB_QuartaParteAjudante.Location = new System.Drawing.Point(646, 406);
            this.txt_NVMC_SalaB_QuartaParteAjudante.Name = "txt_NVMC_SalaB_QuartaParteAjudante";
            this.txt_NVMC_SalaB_QuartaParteAjudante.Size = new System.Drawing.Size(293, 26);
            this.txt_NVMC_SalaB_QuartaParteAjudante.TabIndex = 21;
            // 
            // txt_NVMC_SalaB_QuartaParteDesignado
            // 
            this.txt_NVMC_SalaB_QuartaParteDesignado.Location = new System.Drawing.Point(646, 360);
            this.txt_NVMC_SalaB_QuartaParteDesignado.Name = "txt_NVMC_SalaB_QuartaParteDesignado";
            this.txt_NVMC_SalaB_QuartaParteDesignado.Size = new System.Drawing.Size(293, 26);
            this.txt_NVMC_SalaB_QuartaParteDesignado.TabIndex = 20;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(646, 296);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(70, 16);
            this.label24.TabIndex = 89;
            this.label24.Text = "Ajudante";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(646, 250);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(83, 16);
            this.label25.TabIndex = 88;
            this.label25.Text = "Designado";
            // 
            // txt_NVMC_SalaB_TerceiraParteAjudante
            // 
            this.txt_NVMC_SalaB_TerceiraParteAjudante.Location = new System.Drawing.Point(646, 314);
            this.txt_NVMC_SalaB_TerceiraParteAjudante.Name = "txt_NVMC_SalaB_TerceiraParteAjudante";
            this.txt_NVMC_SalaB_TerceiraParteAjudante.Size = new System.Drawing.Size(293, 26);
            this.txt_NVMC_SalaB_TerceiraParteAjudante.TabIndex = 16;
            // 
            // txt_NVMC_SalaB_TerceiraParteDesignado
            // 
            this.txt_NVMC_SalaB_TerceiraParteDesignado.Location = new System.Drawing.Point(646, 268);
            this.txt_NVMC_SalaB_TerceiraParteDesignado.Name = "txt_NVMC_SalaB_TerceiraParteDesignado";
            this.txt_NVMC_SalaB_TerceiraParteDesignado.Size = new System.Drawing.Size(293, 26);
            this.txt_NVMC_SalaB_TerceiraParteDesignado.TabIndex = 15;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(646, 112);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(70, 16);
            this.label26.TabIndex = 85;
            this.label26.Text = "Ajudante";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(646, 66);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(83, 16);
            this.label27.TabIndex = 84;
            this.label27.Text = "Designado";
            // 
            // txt_NVMC_SalaB_PrimeiraParteAjudante
            // 
            this.txt_NVMC_SalaB_PrimeiraParteAjudante.Location = new System.Drawing.Point(646, 130);
            this.txt_NVMC_SalaB_PrimeiraParteAjudante.Name = "txt_NVMC_SalaB_PrimeiraParteAjudante";
            this.txt_NVMC_SalaB_PrimeiraParteAjudante.Size = new System.Drawing.Size(293, 26);
            this.txt_NVMC_SalaB_PrimeiraParteAjudante.TabIndex = 6;
            // 
            // txt_NVMC_SalaB_PrimeiraParteDesignado
            // 
            this.txt_NVMC_SalaB_PrimeiraParteDesignado.Location = new System.Drawing.Point(646, 84);
            this.txt_NVMC_SalaB_PrimeiraParteDesignado.Name = "txt_NVMC_SalaB_PrimeiraParteDesignado";
            this.txt_NVMC_SalaB_PrimeiraParteDesignado.Size = new System.Drawing.Size(293, 26);
            this.txt_NVMC_SalaB_PrimeiraParteDesignado.TabIndex = 5;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(646, 204);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(70, 16);
            this.label28.TabIndex = 81;
            this.label28.Text = "Ajudante";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(646, 158);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(83, 16);
            this.label29.TabIndex = 80;
            this.label29.Text = "Designado";
            // 
            // txt_NVMC_SalaB_SegundaParteAjudante
            // 
            this.txt_NVMC_SalaB_SegundaParteAjudante.Location = new System.Drawing.Point(646, 222);
            this.txt_NVMC_SalaB_SegundaParteAjudante.Name = "txt_NVMC_SalaB_SegundaParteAjudante";
            this.txt_NVMC_SalaB_SegundaParteAjudante.Size = new System.Drawing.Size(293, 26);
            this.txt_NVMC_SalaB_SegundaParteAjudante.TabIndex = 11;
            // 
            // txt_NVMC_SalaB_SegundaParteDesignado
            // 
            this.txt_NVMC_SalaB_SegundaParteDesignado.Location = new System.Drawing.Point(646, 176);
            this.txt_NVMC_SalaB_SegundaParteDesignado.Name = "txt_NVMC_SalaB_SegundaParteDesignado";
            this.txt_NVMC_SalaB_SegundaParteDesignado.Size = new System.Drawing.Size(293, 26);
            this.txt_NVMC_SalaB_SegundaParteDesignado.TabIndex = 10;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label70.Location = new System.Drawing.Point(6, 342);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(90, 16);
            this.label70.TabIndex = 77;
            this.label70.Text = "Designação";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label71.Location = new System.Drawing.Point(9, 250);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(90, 16);
            this.label71.TabIndex = 76;
            this.label71.Text = "Designação";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label72.Location = new System.Drawing.Point(9, 158);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(90, 16);
            this.label72.TabIndex = 75;
            this.label72.Text = "Designação";
            // 
            // txt_NVMC_NomeQuartaParte
            // 
            this.txt_NVMC_NomeQuartaParte.Location = new System.Drawing.Point(12, 360);
            this.txt_NVMC_NomeQuartaParte.Name = "txt_NVMC_NomeQuartaParte";
            this.txt_NVMC_NomeQuartaParte.Size = new System.Drawing.Size(294, 26);
            this.txt_NVMC_NomeQuartaParte.TabIndex = 17;
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label73.Location = new System.Drawing.Point(327, 388);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(70, 16);
            this.label73.TabIndex = 73;
            this.label73.Text = "Ajudante";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label74.Location = new System.Drawing.Point(327, 342);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(83, 16);
            this.label74.TabIndex = 72;
            this.label74.Text = "Designado";
            // 
            // txt_NVMC_SalaA_QuartaParteAjudante
            // 
            this.txt_NVMC_SalaA_QuartaParteAjudante.Location = new System.Drawing.Point(327, 406);
            this.txt_NVMC_SalaA_QuartaParteAjudante.Name = "txt_NVMC_SalaA_QuartaParteAjudante";
            this.txt_NVMC_SalaA_QuartaParteAjudante.Size = new System.Drawing.Size(293, 26);
            this.txt_NVMC_SalaA_QuartaParteAjudante.TabIndex = 19;
            // 
            // txt_NVMC_SalaA_QuartaParteDesignado
            // 
            this.txt_NVMC_SalaA_QuartaParteDesignado.Location = new System.Drawing.Point(327, 360);
            this.txt_NVMC_SalaA_QuartaParteDesignado.Name = "txt_NVMC_SalaA_QuartaParteDesignado";
            this.txt_NVMC_SalaA_QuartaParteDesignado.Size = new System.Drawing.Size(293, 26);
            this.txt_NVMC_SalaA_QuartaParteDesignado.TabIndex = 18;
            // 
            // txt_NVMC_NomeTerceiraParte
            // 
            this.txt_NVMC_NomeTerceiraParte.Location = new System.Drawing.Point(12, 268);
            this.txt_NVMC_NomeTerceiraParte.Name = "txt_NVMC_NomeTerceiraParte";
            this.txt_NVMC_NomeTerceiraParte.Size = new System.Drawing.Size(294, 26);
            this.txt_NVMC_NomeTerceiraParte.TabIndex = 12;
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label75.Location = new System.Drawing.Point(327, 296);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(70, 16);
            this.label75.TabIndex = 68;
            this.label75.Text = "Ajudante";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label76.Location = new System.Drawing.Point(327, 250);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(83, 16);
            this.label76.TabIndex = 67;
            this.label76.Text = "Designado";
            // 
            // txt_NVMC_SalaA_TerceiraParteAjudante
            // 
            this.txt_NVMC_SalaA_TerceiraParteAjudante.Location = new System.Drawing.Point(327, 314);
            this.txt_NVMC_SalaA_TerceiraParteAjudante.Name = "txt_NVMC_SalaA_TerceiraParteAjudante";
            this.txt_NVMC_SalaA_TerceiraParteAjudante.Size = new System.Drawing.Size(293, 26);
            this.txt_NVMC_SalaA_TerceiraParteAjudante.TabIndex = 14;
            // 
            // txt_NVMC_SalaA_TerceiraParteDesignado
            // 
            this.txt_NVMC_SalaA_TerceiraParteDesignado.Location = new System.Drawing.Point(327, 268);
            this.txt_NVMC_SalaA_TerceiraParteDesignado.Name = "txt_NVMC_SalaA_TerceiraParteDesignado";
            this.txt_NVMC_SalaA_TerceiraParteDesignado.Size = new System.Drawing.Size(293, 26);
            this.txt_NVMC_SalaA_TerceiraParteDesignado.TabIndex = 13;
            // 
            // txt_NVMC_NomeSegundaParte
            // 
            this.txt_NVMC_NomeSegundaParte.Location = new System.Drawing.Point(12, 176);
            this.txt_NVMC_NomeSegundaParte.Name = "txt_NVMC_NomeSegundaParte";
            this.txt_NVMC_NomeSegundaParte.Size = new System.Drawing.Size(294, 26);
            this.txt_NVMC_NomeSegundaParte.TabIndex = 7;
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label77.Location = new System.Drawing.Point(6, 66);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(90, 16);
            this.label77.TabIndex = 63;
            this.label77.Text = "Designação";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label78.Location = new System.Drawing.Point(327, 112);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(70, 16);
            this.label78.TabIndex = 62;
            this.label78.Text = "Ajudante";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label79.Location = new System.Drawing.Point(327, 66);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(83, 16);
            this.label79.TabIndex = 61;
            this.label79.Text = "Designado";
            // 
            // txt_NVMC_SalaA_PrimeiraParteAjudante
            // 
            this.txt_NVMC_SalaA_PrimeiraParteAjudante.Location = new System.Drawing.Point(327, 130);
            this.txt_NVMC_SalaA_PrimeiraParteAjudante.Name = "txt_NVMC_SalaA_PrimeiraParteAjudante";
            this.txt_NVMC_SalaA_PrimeiraParteAjudante.Size = new System.Drawing.Size(293, 26);
            this.txt_NVMC_SalaA_PrimeiraParteAjudante.TabIndex = 4;
            // 
            // txt_NVMC_SalaA_PrimeiraParteDesignado
            // 
            this.txt_NVMC_SalaA_PrimeiraParteDesignado.Location = new System.Drawing.Point(327, 84);
            this.txt_NVMC_SalaA_PrimeiraParteDesignado.Name = "txt_NVMC_SalaA_PrimeiraParteDesignado";
            this.txt_NVMC_SalaA_PrimeiraParteDesignado.Size = new System.Drawing.Size(293, 26);
            this.txt_NVMC_SalaA_PrimeiraParteDesignado.TabIndex = 3;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label80.Location = new System.Drawing.Point(327, 204);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(70, 16);
            this.label80.TabIndex = 58;
            this.label80.Text = "Ajudante";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label81.Location = new System.Drawing.Point(327, 158);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(83, 16);
            this.label81.TabIndex = 57;
            this.label81.Text = "Designado";
            // 
            // txt_NVMC_NomePrimeiraParte
            // 
            this.txt_NVMC_NomePrimeiraParte.Location = new System.Drawing.Point(12, 84);
            this.txt_NVMC_NomePrimeiraParte.Name = "txt_NVMC_NomePrimeiraParte";
            this.txt_NVMC_NomePrimeiraParte.Size = new System.Drawing.Size(294, 26);
            this.txt_NVMC_NomePrimeiraParte.TabIndex = 2;
            // 
            // txt_NVMC_SalaA_SegundaParteAjudante
            // 
            this.txt_NVMC_SalaA_SegundaParteAjudante.Location = new System.Drawing.Point(327, 222);
            this.txt_NVMC_SalaA_SegundaParteAjudante.Name = "txt_NVMC_SalaA_SegundaParteAjudante";
            this.txt_NVMC_SalaA_SegundaParteAjudante.Size = new System.Drawing.Size(293, 26);
            this.txt_NVMC_SalaA_SegundaParteAjudante.TabIndex = 9;
            // 
            // txt_NVMC_SalaA_SegundaParteDesignado
            // 
            this.txt_NVMC_SalaA_SegundaParteDesignado.Location = new System.Drawing.Point(327, 176);
            this.txt_NVMC_SalaA_SegundaParteDesignado.Name = "txt_NVMC_SalaA_SegundaParteDesignado";
            this.txt_NVMC_SalaA_SegundaParteDesignado.Size = new System.Drawing.Size(293, 26);
            this.txt_NVMC_SalaA_SegundaParteDesignado.TabIndex = 8;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.label41);
            this.tabPage8.Controls.Add(this.txt_NVMC_EBC_Leitor);
            this.tabPage8.Controls.Add(this.label40);
            this.tabPage8.Controls.Add(this.txt_NVMC_EBC_Dirigente);
            this.tabPage8.Controls.Add(this.label38);
            this.tabPage8.Controls.Add(this.txt_NVMC_Parte3_Designado);
            this.tabPage8.Controls.Add(this.txt_NVMC_Parte3_Tema);
            this.tabPage8.Controls.Add(this.txt_NVMC_Parte3_Dur);
            this.tabPage8.Controls.Add(this.label39);
            this.tabPage8.Controls.Add(this.label36);
            this.tabPage8.Controls.Add(this.txt_NVMC_Parte2_Designado);
            this.tabPage8.Controls.Add(this.txt_NVMC_Parte2_Tema);
            this.tabPage8.Controls.Add(this.txt_NVMC_Parte2_Dur);
            this.tabPage8.Controls.Add(this.label37);
            this.tabPage8.Controls.Add(this.label34);
            this.tabPage8.Controls.Add(this.txt_NVMC_Parte1_Designado);
            this.tabPage8.Controls.Add(this.txt_NVMC_Parte1_Tema);
            this.tabPage8.Controls.Add(this.txt_NVMC_Parte1_Dur);
            this.tabPage8.Controls.Add(this.label35);
            this.tabPage8.Location = new System.Drawing.Point(4, 27);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(978, 449);
            this.tabPage8.TabIndex = 2;
            this.tabPage8.Text = "NOSSA VIDA CRISTÃ";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(440, 252);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(49, 16);
            this.label41.TabIndex = 49;
            this.label41.Text = "Leitor";
            // 
            // txt_NVMC_EBC_Leitor
            // 
            this.txt_NVMC_EBC_Leitor.Location = new System.Drawing.Point(443, 270);
            this.txt_NVMC_EBC_Leitor.Name = "txt_NVMC_EBC_Leitor";
            this.txt_NVMC_EBC_Leitor.Size = new System.Drawing.Size(286, 26);
            this.txt_NVMC_EBC_Leitor.TabIndex = 11;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(54, 252);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(115, 16);
            this.label40.TabIndex = 47;
            this.label40.Text = "EBC - Dirigente";
            // 
            // txt_NVMC_EBC_Dirigente
            // 
            this.txt_NVMC_EBC_Dirigente.Location = new System.Drawing.Point(55, 270);
            this.txt_NVMC_EBC_Dirigente.Name = "txt_NVMC_EBC_Dirigente";
            this.txt_NVMC_EBC_Dirigente.Size = new System.Drawing.Size(382, 26);
            this.txt_NVMC_EBC_Dirigente.TabIndex = 10;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(440, 193);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(83, 16);
            this.label38.TabIndex = 45;
            this.label38.Text = "Designado";
            // 
            // txt_NVMC_Parte3_Designado
            // 
            this.txt_NVMC_Parte3_Designado.Location = new System.Drawing.Point(443, 211);
            this.txt_NVMC_Parte3_Designado.Name = "txt_NVMC_Parte3_Designado";
            this.txt_NVMC_Parte3_Designado.Size = new System.Drawing.Size(286, 26);
            this.txt_NVMC_Parte3_Designado.TabIndex = 8;
            // 
            // txt_NVMC_Parte3_Tema
            // 
            this.txt_NVMC_Parte3_Tema.Location = new System.Drawing.Point(111, 211);
            this.txt_NVMC_Parte3_Tema.Name = "txt_NVMC_Parte3_Tema";
            this.txt_NVMC_Parte3_Tema.Size = new System.Drawing.Size(326, 26);
            this.txt_NVMC_Parte3_Tema.TabIndex = 7;
            // 
            // txt_NVMC_Parte3_Dur
            // 
            this.txt_NVMC_Parte3_Dur.Location = new System.Drawing.Point(55, 211);
            this.txt_NVMC_Parte3_Dur.Name = "txt_NVMC_Parte3_Dur";
            this.txt_NVMC_Parte3_Dur.Size = new System.Drawing.Size(50, 26);
            this.txt_NVMC_Parte3_Dur.TabIndex = 6;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(54, 193);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(143, 16);
            this.label39.TabIndex = 41;
            this.label39.Text = "Parte 3 - Dur / Tema";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(440, 140);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(83, 16);
            this.label36.TabIndex = 40;
            this.label36.Text = "Designado";
            // 
            // txt_NVMC_Parte2_Designado
            // 
            this.txt_NVMC_Parte2_Designado.Location = new System.Drawing.Point(443, 158);
            this.txt_NVMC_Parte2_Designado.Name = "txt_NVMC_Parte2_Designado";
            this.txt_NVMC_Parte2_Designado.Size = new System.Drawing.Size(286, 26);
            this.txt_NVMC_Parte2_Designado.TabIndex = 5;
            // 
            // txt_NVMC_Parte2_Tema
            // 
            this.txt_NVMC_Parte2_Tema.Location = new System.Drawing.Point(111, 158);
            this.txt_NVMC_Parte2_Tema.Name = "txt_NVMC_Parte2_Tema";
            this.txt_NVMC_Parte2_Tema.Size = new System.Drawing.Size(326, 26);
            this.txt_NVMC_Parte2_Tema.TabIndex = 4;
            // 
            // txt_NVMC_Parte2_Dur
            // 
            this.txt_NVMC_Parte2_Dur.Location = new System.Drawing.Point(55, 158);
            this.txt_NVMC_Parte2_Dur.Name = "txt_NVMC_Parte2_Dur";
            this.txt_NVMC_Parte2_Dur.Size = new System.Drawing.Size(50, 26);
            this.txt_NVMC_Parte2_Dur.TabIndex = 3;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(54, 140);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(143, 16);
            this.label37.TabIndex = 36;
            this.label37.Text = "Parte 2 - Dur / Tema";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(440, 88);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(83, 16);
            this.label34.TabIndex = 35;
            this.label34.Text = "Designado";
            // 
            // txt_NVMC_Parte1_Designado
            // 
            this.txt_NVMC_Parte1_Designado.Location = new System.Drawing.Point(443, 106);
            this.txt_NVMC_Parte1_Designado.Name = "txt_NVMC_Parte1_Designado";
            this.txt_NVMC_Parte1_Designado.Size = new System.Drawing.Size(286, 26);
            this.txt_NVMC_Parte1_Designado.TabIndex = 2;
            // 
            // txt_NVMC_Parte1_Tema
            // 
            this.txt_NVMC_Parte1_Tema.Location = new System.Drawing.Point(111, 106);
            this.txt_NVMC_Parte1_Tema.Name = "txt_NVMC_Parte1_Tema";
            this.txt_NVMC_Parte1_Tema.Size = new System.Drawing.Size(326, 26);
            this.txt_NVMC_Parte1_Tema.TabIndex = 1;
            // 
            // txt_NVMC_Parte1_Dur
            // 
            this.txt_NVMC_Parte1_Dur.Location = new System.Drawing.Point(55, 106);
            this.txt_NVMC_Parte1_Dur.Name = "txt_NVMC_Parte1_Dur";
            this.txt_NVMC_Parte1_Dur.Size = new System.Drawing.Size(50, 26);
            this.txt_NVMC_Parte1_Dur.TabIndex = 0;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(54, 88);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(143, 16);
            this.label35.TabIndex = 31;
            this.label35.Text = "Parte 1 - Dur / Tema";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(426, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nossa Vida e Ministério Cristão";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Size = new System.Drawing.Size(1010, 539);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reunião Pública";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_RP_Discurso_Cong);
            this.panel3.Controls.Add(this.label48);
            this.panel3.Controls.Add(this.txt_RP_Discurso_Orador);
            this.panel3.Controls.Add(this.label47);
            this.panel3.Controls.Add(this.txt_RP_Discurso_Tema);
            this.panel3.Controls.Add(this.label46);
            this.panel3.Controls.Add(this.label42);
            this.panel3.Controls.Add(this.label43);
            this.panel3.Controls.Add(this.txt_RP_Sentinela_Leitor);
            this.panel3.Controls.Add(this.label44);
            this.panel3.Controls.Add(this.txt_RP_Presidente);
            this.panel3.Controls.Add(this.label45);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(15, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(989, 519);
            this.panel3.TabIndex = 2;
            // 
            // txt_RP_Discurso_Cong
            // 
            this.txt_RP_Discurso_Cong.Location = new System.Drawing.Point(82, 309);
            this.txt_RP_Discurso_Cong.Name = "txt_RP_Discurso_Cong";
            this.txt_RP_Discurso_Cong.Size = new System.Drawing.Size(578, 26);
            this.txt_RP_Discurso_Cong.TabIndex = 4;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(81, 291);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(102, 16);
            this.label48.TabIndex = 41;
            this.label48.Text = "Congregação";
            // 
            // txt_RP_Discurso_Orador
            // 
            this.txt_RP_Discurso_Orador.Location = new System.Drawing.Point(82, 260);
            this.txt_RP_Discurso_Orador.Name = "txt_RP_Discurso_Orador";
            this.txt_RP_Discurso_Orador.Size = new System.Drawing.Size(578, 26);
            this.txt_RP_Discurso_Orador.TabIndex = 3;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(81, 242);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(57, 16);
            this.label47.TabIndex = 39;
            this.label47.Text = "Orador";
            // 
            // txt_RP_Discurso_Tema
            // 
            this.txt_RP_Discurso_Tema.Location = new System.Drawing.Point(82, 207);
            this.txt_RP_Discurso_Tema.Name = "txt_RP_Discurso_Tema";
            this.txt_RP_Discurso_Tema.Size = new System.Drawing.Size(578, 26);
            this.txt_RP_Discurso_Tema.TabIndex = 2;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(81, 189);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(119, 16);
            this.label46.TabIndex = 37;
            this.label46.Text = "Discurso - Tema";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.Maroon;
            this.label42.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.White;
            this.label42.Location = new System.Drawing.Point(423, 106);
            this.label42.Name = "label42";
            this.label42.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.label42.Size = new System.Drawing.Size(189, 22);
            this.label42.TabIndex = 36;
            this.label42.Text = "ESTUDO DE A SENTINELA";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.Maroon;
            this.label43.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.White;
            this.label43.Location = new System.Drawing.Point(81, 106);
            this.label43.Name = "label43";
            this.label43.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.label43.Size = new System.Drawing.Size(146, 22);
            this.label43.TabIndex = 35;
            this.label43.Text = "REUNIÃO PÚBLICA";
            // 
            // txt_RP_Sentinela_Leitor
            // 
            this.txt_RP_Sentinela_Leitor.Location = new System.Drawing.Point(424, 154);
            this.txt_RP_Sentinela_Leitor.Name = "txt_RP_Sentinela_Leitor";
            this.txt_RP_Sentinela_Leitor.Size = new System.Drawing.Size(236, 26);
            this.txt_RP_Sentinela_Leitor.TabIndex = 1;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(423, 136);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(49, 16);
            this.label44.TabIndex = 33;
            this.label44.Text = "Leitor";
            // 
            // txt_RP_Presidente
            // 
            this.txt_RP_Presidente.Location = new System.Drawing.Point(82, 154);
            this.txt_RP_Presidente.Name = "txt_RP_Presidente";
            this.txt_RP_Presidente.Size = new System.Drawing.Size(336, 26);
            this.txt_RP_Presidente.TabIndex = 0;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(81, 136);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(85, 16);
            this.label45.TabIndex = 31;
            this.label45.Text = "Presidente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Reunião Pública";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.panel5);
            this.tabPage5.Location = new System.Drawing.Point(4, 27);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage5.Size = new System.Drawing.Size(1010, 539);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Desigação Serviço";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label30);
            this.panel5.Controls.Add(this.label32);
            this.panel5.Controls.Add(this.label83);
            this.panel5.Controls.Add(this.txt_DS_Transporte_FS);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Controls.Add(this.txt_DS_Indicador_FS);
            this.panel5.Controls.Add(this.label54);
            this.panel5.Controls.Add(this.label53);
            this.panel5.Controls.Add(this.txt_DS_Audio_FS);
            this.panel5.Controls.Add(this.label31);
            this.panel5.Controls.Add(this.txt_DS_Video_FS);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.txt_DS_Marcador_Tempo);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.txt_DS_Transporte_MS);
            this.panel5.Controls.Add(this.label69);
            this.panel5.Controls.Add(this.txt_DS_Limpeza_Dirigente);
            this.panel5.Controls.Add(this.txt_DS_Limpeza_Grupo);
            this.panel5.Controls.Add(this.label68);
            this.panel5.Controls.Add(this.label67);
            this.panel5.Controls.Add(this.txt_DS_Brigada_Brigadista2);
            this.panel5.Controls.Add(this.txt_DS_Brigada_Brigadista1);
            this.panel5.Controls.Add(this.label66);
            this.panel5.Controls.Add(this.txt_DS_Brigada_Lider);
            this.panel5.Controls.Add(this.label65);
            this.panel5.Controls.Add(this.label63);
            this.panel5.Controls.Add(this.txt_DS_Brigada_ChefeTurno);
            this.panel5.Controls.Add(this.label64);
            this.panel5.Controls.Add(this.txt_DS_Audio_MS);
            this.panel5.Controls.Add(this.label60);
            this.panel5.Controls.Add(this.txt_DS_Video_MS);
            this.panel5.Controls.Add(this.txt_DS_Indicador_MS);
            this.panel5.Controls.Add(this.label58);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(6, 13);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(998, 519);
            this.panel5.TabIndex = 0;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Maroon;
            this.label30.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(661, 194);
            this.label30.Name = "label30";
            this.label30.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.label30.Size = new System.Drawing.Size(157, 22);
            this.label30.TabIndex = 100;
            this.label30.Text = "Áudio (Fim Semana)";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Maroon;
            this.label32.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(335, 194);
            this.label32.Name = "label32";
            this.label32.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.label32.Size = new System.Drawing.Size(167, 22);
            this.label32.TabIndex = 99;
            this.label32.Text = "Áudio (Meio Semana)";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label83.Location = new System.Drawing.Point(337, 327);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(181, 16);
            this.label83.TabIndex = 79;
            this.label83.Text = "Designado (Fim Semana)";
            // 
            // txt_DS_Transporte_FS
            // 
            this.txt_DS_Transporte_FS.Location = new System.Drawing.Point(340, 345);
            this.txt_DS_Transporte_FS.MaxLength = 50;
            this.txt_DS_Transporte_FS.Name = "txt_DS_Transporte_FS";
            this.txt_DS_Transporte_FS.Size = new System.Drawing.Size(318, 26);
            this.txt_DS_Transporte_FS.TabIndex = 9;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Maroon;
            this.label19.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(661, 57);
            this.label19.Name = "label19";
            this.label19.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.label19.Size = new System.Drawing.Size(194, 22);
            this.label19.TabIndex = 76;
            this.label19.Text = "INDICADOR (Fim Semana)";
            // 
            // txt_DS_Indicador_FS
            // 
            this.txt_DS_Indicador_FS.Location = new System.Drawing.Point(662, 84);
            this.txt_DS_Indicador_FS.MaxLength = 50;
            this.txt_DS_Indicador_FS.Name = "txt_DS_Indicador_FS";
            this.txt_DS_Indicador_FS.Size = new System.Drawing.Size(318, 26);
            this.txt_DS_Indicador_FS.TabIndex = 7;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(663, 280);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(83, 16);
            this.label54.TabIndex = 73;
            this.label54.Text = "Designado";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(334, 281);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(191, 16);
            this.label53.TabIndex = 72;
            this.label53.Text = "Designado (Meio Semana)";
            // 
            // txt_DS_Audio_FS
            // 
            this.txt_DS_Audio_FS.Location = new System.Drawing.Point(662, 220);
            this.txt_DS_Audio_FS.MaxLength = 50;
            this.txt_DS_Audio_FS.Name = "txt_DS_Audio_FS";
            this.txt_DS_Audio_FS.Size = new System.Drawing.Size(318, 26);
            this.txt_DS_Audio_FS.TabIndex = 5;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Maroon;
            this.label31.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(661, 120);
            this.label31.Name = "label31";
            this.label31.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.label31.Size = new System.Drawing.Size(156, 22);
            this.label31.TabIndex = 68;
            this.label31.Text = "Vídeo (Fim Semana)";
            // 
            // txt_DS_Video_FS
            // 
            this.txt_DS_Video_FS.Location = new System.Drawing.Point(662, 147);
            this.txt_DS_Video_FS.MaxLength = 50;
            this.txt_DS_Video_FS.Name = "txt_DS_Video_FS";
            this.txt_DS_Video_FS.Size = new System.Drawing.Size(318, 26);
            this.txt_DS_Video_FS.TabIndex = 3;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Maroon;
            this.label17.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(666, 256);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.label17.Size = new System.Drawing.Size(133, 22);
            this.label17.TabIndex = 65;
            this.label17.Text = "MARCAR TEMPO";
            // 
            // txt_DS_Marcador_Tempo
            // 
            this.txt_DS_Marcador_Tempo.Location = new System.Drawing.Point(666, 297);
            this.txt_DS_Marcador_Tempo.MaxLength = 50;
            this.txt_DS_Marcador_Tempo.Name = "txt_DS_Marcador_Tempo";
            this.txt_DS_Marcador_Tempo.Size = new System.Drawing.Size(318, 26);
            this.txt_DS_Marcador_Tempo.TabIndex = 64;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Maroon;
            this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(337, 256);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.label15.Size = new System.Drawing.Size(182, 22);
            this.label15.TabIndex = 63;
            this.label15.Text = "ARRANJO TRANSPORTE";
            // 
            // txt_DS_Transporte_MS
            // 
            this.txt_DS_Transporte_MS.Location = new System.Drawing.Point(337, 299);
            this.txt_DS_Transporte_MS.MaxLength = 50;
            this.txt_DS_Transporte_MS.Name = "txt_DS_Transporte_MS";
            this.txt_DS_Transporte_MS.Size = new System.Drawing.Size(318, 26);
            this.txt_DS_Transporte_MS.TabIndex = 8;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label69.Location = new System.Drawing.Point(6, 114);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(73, 16);
            this.label69.TabIndex = 61;
            this.label69.Text = "Dirigente";
            // 
            // txt_DS_Limpeza_Dirigente
            // 
            this.txt_DS_Limpeza_Dirigente.Location = new System.Drawing.Point(9, 131);
            this.txt_DS_Limpeza_Dirigente.MaxLength = 50;
            this.txt_DS_Limpeza_Dirigente.Name = "txt_DS_Limpeza_Dirigente";
            this.txt_DS_Limpeza_Dirigente.Size = new System.Drawing.Size(318, 26);
            this.txt_DS_Limpeza_Dirigente.TabIndex = 1;
            // 
            // txt_DS_Limpeza_Grupo
            // 
            this.txt_DS_Limpeza_Grupo.Location = new System.Drawing.Point(9, 84);
            this.txt_DS_Limpeza_Grupo.MaxLength = 50;
            this.txt_DS_Limpeza_Grupo.Name = "txt_DS_Limpeza_Grupo";
            this.txt_DS_Limpeza_Grupo.Size = new System.Drawing.Size(318, 26);
            this.txt_DS_Limpeza_Grupo.TabIndex = 0;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label68.Location = new System.Drawing.Point(8, 67);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(52, 16);
            this.label68.TabIndex = 58;
            this.label68.Text = "Grupo";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.BackColor = System.Drawing.Color.Maroon;
            this.label67.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label67.ForeColor = System.Drawing.Color.White;
            this.label67.Location = new System.Drawing.Point(8, 40);
            this.label67.Name = "label67";
            this.label67.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.label67.Size = new System.Drawing.Size(78, 22);
            this.label67.TabIndex = 57;
            this.label67.Text = "LIMPEZA";
            // 
            // txt_DS_Brigada_Brigadista2
            // 
            this.txt_DS_Brigada_Brigadista2.Location = new System.Drawing.Point(10, 350);
            this.txt_DS_Brigada_Brigadista2.MaxLength = 50;
            this.txt_DS_Brigada_Brigadista2.Name = "txt_DS_Brigada_Brigadista2";
            this.txt_DS_Brigada_Brigadista2.Size = new System.Drawing.Size(318, 26);
            this.txt_DS_Brigada_Brigadista2.TabIndex = 56;
            // 
            // txt_DS_Brigada_Brigadista1
            // 
            this.txt_DS_Brigada_Brigadista1.Location = new System.Drawing.Point(10, 318);
            this.txt_DS_Brigada_Brigadista1.MaxLength = 50;
            this.txt_DS_Brigada_Brigadista1.Name = "txt_DS_Brigada_Brigadista1";
            this.txt_DS_Brigada_Brigadista1.Size = new System.Drawing.Size(318, 26);
            this.txt_DS_Brigada_Brigadista1.TabIndex = 55;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.Location = new System.Drawing.Point(8, 301);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(87, 16);
            this.label66.TabIndex = 54;
            this.label66.Text = "Brigadistas";
            // 
            // txt_DS_Brigada_Lider
            // 
            this.txt_DS_Brigada_Lider.Location = new System.Drawing.Point(10, 270);
            this.txt_DS_Brigada_Lider.MaxLength = 50;
            this.txt_DS_Brigada_Lider.Name = "txt_DS_Brigada_Lider";
            this.txt_DS_Brigada_Lider.Size = new System.Drawing.Size(318, 26);
            this.txt_DS_Brigada_Lider.TabIndex = 53;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.Location = new System.Drawing.Point(8, 253);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(44, 16);
            this.label65.TabIndex = 52;
            this.label65.Text = "Lider";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.BackColor = System.Drawing.Color.Maroon;
            this.label63.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.ForeColor = System.Drawing.Color.White;
            this.label63.Location = new System.Drawing.Point(8, 173);
            this.label63.Name = "label63";
            this.label63.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.label63.Size = new System.Drawing.Size(129, 22);
            this.label63.TabIndex = 51;
            this.label63.Text = "BRIG. INCÊNDIO";
            // 
            // txt_DS_Brigada_ChefeTurno
            // 
            this.txt_DS_Brigada_ChefeTurno.Location = new System.Drawing.Point(8, 217);
            this.txt_DS_Brigada_ChefeTurno.MaxLength = 50;
            this.txt_DS_Brigada_ChefeTurno.Name = "txt_DS_Brigada_ChefeTurno";
            this.txt_DS_Brigada_ChefeTurno.Size = new System.Drawing.Size(318, 26);
            this.txt_DS_Brigada_ChefeTurno.TabIndex = 50;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.Location = new System.Drawing.Point(6, 200);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(116, 16);
            this.label64.TabIndex = 49;
            this.label64.Text = "Chefe de Turno";
            // 
            // txt_DS_Audio_MS
            // 
            this.txt_DS_Audio_MS.Location = new System.Drawing.Point(335, 220);
            this.txt_DS_Audio_MS.MaxLength = 50;
            this.txt_DS_Audio_MS.Name = "txt_DS_Audio_MS";
            this.txt_DS_Audio_MS.Size = new System.Drawing.Size(318, 26);
            this.txt_DS_Audio_MS.TabIndex = 4;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.BackColor = System.Drawing.Color.Maroon;
            this.label60.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.ForeColor = System.Drawing.Color.White;
            this.label60.Location = new System.Drawing.Point(335, 120);
            this.label60.Name = "label60";
            this.label60.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.label60.Size = new System.Drawing.Size(166, 22);
            this.label60.TabIndex = 45;
            this.label60.Text = "Vídeo (Meio Semana)";
            // 
            // txt_DS_Video_MS
            // 
            this.txt_DS_Video_MS.Location = new System.Drawing.Point(335, 147);
            this.txt_DS_Video_MS.MaxLength = 50;
            this.txt_DS_Video_MS.Name = "txt_DS_Video_MS";
            this.txt_DS_Video_MS.Size = new System.Drawing.Size(318, 26);
            this.txt_DS_Video_MS.TabIndex = 2;
            // 
            // txt_DS_Indicador_MS
            // 
            this.txt_DS_Indicador_MS.Location = new System.Drawing.Point(334, 84);
            this.txt_DS_Indicador_MS.MaxLength = 50;
            this.txt_DS_Indicador_MS.Name = "txt_DS_Indicador_MS";
            this.txt_DS_Indicador_MS.Size = new System.Drawing.Size(318, 26);
            this.txt_DS_Indicador_MS.TabIndex = 6;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.BackColor = System.Drawing.Color.Maroon;
            this.label58.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.ForeColor = System.Drawing.Color.White;
            this.label58.Location = new System.Drawing.Point(333, 57);
            this.label58.Name = "label58";
            this.label58.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.label58.Size = new System.Drawing.Size(208, 22);
            this.label58.TabIndex = 41;
            this.label58.Text = "INDICADOR  (Meio Semana)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(331, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Designações de Serviço";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel4);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Size = new System.Drawing.Size(1010, 539);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Saídas de campo";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txt_SC_Comercial);
            this.panel4.Controls.Add(this.label57);
            this.panel4.Controls.Add(this.label55);
            this.panel4.Controls.Add(this.txt_SC_Residencial);
            this.panel4.Controls.Add(this.label56);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(5, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(999, 525);
            this.panel4.TabIndex = 2;
            // 
            // txt_SC_Comercial
            // 
            this.txt_SC_Comercial.Location = new System.Drawing.Point(8, 130);
            this.txt_SC_Comercial.Name = "txt_SC_Comercial";
            this.txt_SC_Comercial.Size = new System.Drawing.Size(194, 26);
            this.txt_SC_Comercial.TabIndex = 51;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.Location = new System.Drawing.Point(7, 113);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(78, 16);
            this.label57.TabIndex = 50;
            this.label57.Text = "Comercial";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.BackColor = System.Drawing.Color.Maroon;
            this.label55.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.ForeColor = System.Drawing.Color.White;
            this.label55.Location = new System.Drawing.Point(5, 44);
            this.label55.Name = "label55";
            this.label55.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.label55.Size = new System.Drawing.Size(77, 22);
            this.label55.TabIndex = 49;
            this.label55.Text = "SÁBADO";
            // 
            // txt_SC_Residencial
            // 
            this.txt_SC_Residencial.Location = new System.Drawing.Point(6, 87);
            this.txt_SC_Residencial.Name = "txt_SC_Residencial";
            this.txt_SC_Residencial.Size = new System.Drawing.Size(194, 26);
            this.txt_SC_Residencial.TabIndex = 48;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(5, 70);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(90, 16);
            this.label56.TabIndex = 47;
            this.label56.Text = "Residencial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Saídas de Campo";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnProxSemana, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSemanaAnt, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSemana, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1018, 34);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnProxSemana
            // 
            this.btnProxSemana.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnProxSemana.Location = new System.Drawing.Point(971, 3);
            this.btnProxSemana.Name = "btnProxSemana";
            this.btnProxSemana.Size = new System.Drawing.Size(44, 28);
            this.btnProxSemana.TabIndex = 3;
            this.btnProxSemana.Text = ">";
            this.btnProxSemana.UseVisualStyleBackColor = true;
            this.btnProxSemana.Click += new System.EventHandler(this.btnProxSemana_Click);
            // 
            // btnSemanaAnt
            // 
            this.btnSemanaAnt.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSemanaAnt.Location = new System.Drawing.Point(3, 3);
            this.btnSemanaAnt.Name = "btnSemanaAnt";
            this.btnSemanaAnt.Size = new System.Drawing.Size(44, 28);
            this.btnSemanaAnt.TabIndex = 2;
            this.btnSemanaAnt.Text = "<";
            this.btnSemanaAnt.UseVisualStyleBackColor = true;
            this.btnSemanaAnt.Click += new System.EventHandler(this.btnSemanaAnt_Click);
            // 
            // lblSemana
            // 
            this.lblSemana.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSemana.AutoSize = true;
            this.lblSemana.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemana.Location = new System.Drawing.Point(336, 2);
            this.lblSemana.Name = "lblSemana";
            this.lblSemana.Size = new System.Drawing.Size(346, 29);
            this.lblSemana.TabIndex = 0;
            this.lblSemana.Text = "10 à 15 de Novembro de 2016";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.btnSalvar, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnFolhaNvmc, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnFechar, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnGerarQuadro, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 640);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1024, 33);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalvar.Location = new System.Drawing.Point(515, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(250, 27);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnFolhaNvmc
            // 
            this.btnFolhaNvmc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnFolhaNvmc.Location = new System.Drawing.Point(3, 3);
            this.btnFolhaNvmc.Name = "btnFolhaNvmc";
            this.btnFolhaNvmc.Size = new System.Drawing.Size(250, 27);
            this.btnFolhaNvmc.TabIndex = 14;
            this.btnFolhaNvmc.Text = "Folha desingnação";
            this.btnFolhaNvmc.UseVisualStyleBackColor = true;
            this.btnFolhaNvmc.Click += new System.EventHandler(this.btnFolhaNvmc_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnFechar.Location = new System.Drawing.Point(771, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(250, 27);
            this.btnFechar.TabIndex = 5;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnGerarQuadro
            // 
            this.btnGerarQuadro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGerarQuadro.Location = new System.Drawing.Point(259, 3);
            this.btnGerarQuadro.Name = "btnGerarQuadro";
            this.btnGerarQuadro.Size = new System.Drawing.Size(250, 27);
            this.btnGerarQuadro.TabIndex = 13;
            this.btnGerarQuadro.Text = "Quadro anuncios";
            this.btnGerarQuadro.UseVisualStyleBackColor = true;
            this.btnGerarQuadro.Click += new System.EventHandler(this.btnGerarQuadro_Click);
            // 
            // Quadro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 673);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Quadro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quadro de anuncios";
            this.Load += new System.EventHandler(this.QuadroAnuncios_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_Ano)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_Mes)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private Panel panel4;
        private Label label4;
        private Panel panel5;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private CheckBox chk_Congresso;
        private CheckBox chk_Assembleia;
        private CheckBox chk_VisitaSup;
        private CheckBox chk_SalaB;
        private CheckBox chk_PrimeiraSemana;
        private TabControl tabControl2;
        private TabPage tabPage6;
        private Label label12;
        private TextBox txt_NVMC_DiscursoDesignado;
        private TextBox txt_NVMC_DiscursoTema;
        private Label label11;
        private TextBox txt_NVMC_Joias;
        private Label label13;
        private TextBox txt_NVMC_Presidente;
        private Label label10;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private Label label21;
        private Label label20;
        private Label label34;
        private TextBox txt_NVMC_Parte1_Designado;
        private TextBox txt_NVMC_Parte1_Tema;
        private TextBox txt_NVMC_Parte1_Dur;
        private Label label35;
        private Label label38;
        private TextBox txt_NVMC_Parte3_Designado;
        private TextBox txt_NVMC_Parte3_Tema;
        private TextBox txt_NVMC_Parte3_Dur;
        private Label label39;
        private Label label36;
        private TextBox txt_NVMC_Parte2_Designado;
        private TextBox txt_NVMC_Parte2_Tema;
        private TextBox txt_NVMC_Parte2_Dur;
        private Label label37;
        private Label label41;
        private TextBox txt_NVMC_EBC_Leitor;
        private Label label40;
        private TextBox txt_NVMC_EBC_Dirigente;
        private Label label42;
        private Label label43;
        private TextBox txt_RP_Sentinela_Leitor;
        private Label label44;
        private TextBox txt_RP_Presidente;
        private Label label45;
        private TextBox txt_RP_Discurso_Cong;
        private Label label48;
        private TextBox txt_RP_Discurso_Orador;
        private Label label47;
        private TextBox txt_RP_Discurso_Tema;
        private Label label46;
        private TextBox txt_SC_Comercial;
        private Label label57;
        private Label label55;
        private TextBox txt_SC_Residencial;
        private Label label56;
        private TextBox txt_DS_Audio_MS;
        private Label label60;
        private TextBox txt_DS_Video_MS;
        private TextBox txt_DS_Indicador_MS;
        private Label label58;
        private TextBox txt_DS_Brigada_Brigadista1;
        private Label label66;
        private TextBox txt_DS_Brigada_Lider;
        private Label label65;
        private Label label63;
        private TextBox txt_DS_Brigada_ChefeTurno;
        private Label label64;
        private TextBox txt_DS_Brigada_Brigadista2;
        private Label label67;
        private Label label69;
        private TextBox txt_DS_Limpeza_Dirigente;
        private TextBox txt_DS_Limpeza_Grupo;
        private Label label68;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblSemana;
        private Button btnProxSemana;
        private Button btnSemanaAnt;
        private Label label50;
        private NumericUpDown n_Ano;
        private Label label49;
        private NumericUpDown n_Mes;
        private Label label52;
        private Label label51;
        private Panel pnlCor2;
        private Panel pnlCor1;
        private ColorDialog colorDialog1;
        private ColorDialog colorDialog2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnSalvar;
        private Button btnFolhaNvmc;
        private Button btnFechar;
        private Button btnGerarQuadro;
        private Label label15;
        private TextBox txt_DS_Transporte_MS;
        private Label label17;
        private TextBox txt_DS_Marcador_Tempo;
        private Panel panel6;
        private Label label70;
        private Label label71;
        private Label label72;
        private TextBox txt_NVMC_NomeQuartaParte;
        private Label label73;
        private Label label74;
        private TextBox txt_NVMC_SalaA_QuartaParteAjudante;
        private TextBox txt_NVMC_SalaA_QuartaParteDesignado;
        private TextBox txt_NVMC_NomeTerceiraParte;
        private Label label75;
        private Label label76;
        private TextBox txt_NVMC_SalaA_TerceiraParteAjudante;
        private TextBox txt_NVMC_SalaA_TerceiraParteDesignado;
        private TextBox txt_NVMC_NomeSegundaParte;
        private Label label77;
        private Label label78;
        private Label label79;
        private TextBox txt_NVMC_SalaA_PrimeiraParteAjudante;
        private TextBox txt_NVMC_SalaA_PrimeiraParteDesignado;
        private Label label80;
        private Label label81;
        private TextBox txt_NVMC_NomePrimeiraParte;
        private TextBox txt_NVMC_SalaA_SegundaParteAjudante;
        private TextBox txt_NVMC_SalaA_SegundaParteDesignado;
        private Label label33;
        private Label label14;
        private Label label22;
        private Label label23;
        private TextBox txt_NVMC_SalaB_QuartaParteAjudante;
        private TextBox txt_NVMC_SalaB_QuartaParteDesignado;
        private Label label24;
        private Label label25;
        private TextBox txt_NVMC_SalaB_TerceiraParteAjudante;
        private TextBox txt_NVMC_SalaB_TerceiraParteDesignado;
        private Label label26;
        private Label label27;
        private TextBox txt_NVMC_SalaB_PrimeiraParteAjudante;
        private TextBox txt_NVMC_SalaB_PrimeiraParteDesignado;
        private Label label28;
        private Label label29;
        private TextBox txt_NVMC_SalaB_SegundaParteAjudante;
        private TextBox txt_NVMC_SalaB_SegundaParteDesignado;
        private TextBox txt_DS_Audio_FS;
        private Label label31;
        private TextBox txt_DS_Video_FS;
        private Label label54;
        private Label label53;
        private TextBox txt_NVMC_SalaB_Leitura;
        private TextBox txt_NVMC_SalaA_Leitura;
        private Label label16;
        private TextBox txt_NVMC_SalaB_Dirigente;
        private TextBox txt_NVMC_SalaA_Dirigente;
        private TextBox txt_DS_Indicador_FS;
        private Label label19;
        private Label label83;
        private TextBox txt_DS_Transporte_FS;
        private TextBox txt_NVMC_Oracao_Final;
        private Label label85;
        private TextBox txt_NVMC_Oracao_Inicial;
        private Label label84;
        private Label label30;
        private Label label32;
        private TextBox txtReuniaoMeioSemana;
        private TextBox txtReuniaoFimSemana;
    }
}