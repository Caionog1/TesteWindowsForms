namespace RedeService
{
    partial class FrmRedeService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRedeService));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnAbriArquivo = new Button();
            dataGridView1 = new DataGridView();
            btnGravarLista = new Button();
            btnAdicionar = new Button();
            textNumero = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            btnCarregarGrid = new Button();
            btnCreateJson = new Button();
            dataJson = new DataGridView();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            tabPage3 = new TabPage();
            txtResultCep = new TextBox();
            btnConsultar = new Button();
            txtCep = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            tabPage4 = new TabPage();
            button1 = new Button();
            dataGridBanco = new DataGridView();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            tabPage5 = new TabPage();
            txtBaixarImagem = new TextBox();
            button2 = new Button();
            label16 = new Label();
            label4 = new Label();
            label17 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataJson).BeginInit();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridBanco).BeginInit();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(14, 55);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(862, 496);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(btnAbriArquivo);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(btnGravarLista);
            tabPage1.Controls.Add(btnAdicionar);
            tabPage1.Controls.Add(textNumero);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(854, 468);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Q1 e Q2";
            // 
            // btnAbriArquivo
            // 
            btnAbriArquivo.Location = new Point(236, 336);
            btnAbriArquivo.Name = "btnAbriArquivo";
            btnAbriArquivo.Size = new Size(100, 23);
            btnAbriArquivo.TabIndex = 8;
            btnAbriArquivo.Text = "Abrir Arquivo";
            btnAbriArquivo.UseVisualStyleBackColor = true;
            btnAbriArquivo.Click += btnAbriArquivo_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.Location = new Point(24, 138);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(312, 182);
            dataGridView1.TabIndex = 7;
            // 
            // btnGravarLista
            // 
            btnGravarLista.Location = new Point(24, 336);
            btnGravarLista.Name = "btnGravarLista";
            btnGravarLista.Size = new Size(95, 23);
            btnGravarLista.TabIndex = 6;
            btnGravarLista.Text = "Gravar Lista";
            btnGravarLista.UseVisualStyleBackColor = true;
            btnGravarLista.Click += btnGravarLista_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(261, 93);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // textNumero
            // 
            textNumero.Location = new Point(144, 94);
            textNumero.Name = "textNumero";
            textNumero.Size = new Size(100, 23);
            textNumero.TabIndex = 3;
            textNumero.KeyPress += textNumero_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 97);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 2;
            label3.Text = "Informe 1 Número:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 58);
            label2.Name = "label2";
            label2.Size = new Size(747, 15);
            label2.TabIndex = 1;
            label2.Text = "2. Agora grave os números visualizados cada 1 em uma linha em um arquivo texto na pasta raiz da  aplicação de nome numeros_ordenar.txt.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 30);
            label1.Name = "label1";
            label1.Size = new Size(502, 15);
            label1.TabIndex = 0;
            label1.Text = "1. Faça a aplicação permitir a digitação de números e mostre esses números em tela de forma ";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnCarregarGrid);
            tabPage2.Controls.Add(btnCreateJson);
            tabPage2.Controls.Add(dataJson);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(854, 468);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Q3,Q4 e Q5";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCarregarGrid
            // 
            btnCarregarGrid.Location = new Point(273, 167);
            btnCarregarGrid.Name = "btnCarregarGrid";
            btnCarregarGrid.Size = new Size(239, 23);
            btnCarregarGrid.TabIndex = 5;
            btnCarregarGrid.Text = "Grid";
            btnCarregarGrid.UseVisualStyleBackColor = true;
            btnCarregarGrid.Click += btnCarregarGrid_Click;
            // 
            // btnCreateJson
            // 
            btnCreateJson.Location = new Point(29, 167);
            btnCreateJson.Name = "btnCreateJson";
            btnCreateJson.Size = new Size(238, 23);
            btnCreateJson.TabIndex = 4;
            btnCreateJson.Text = "JSON";
            btnCreateJson.UseVisualStyleBackColor = true;
            btnCreateJson.Click += btnCreateJson_Click;
            // 
            // dataJson
            // 
            dataJson.AllowUserToAddRows = false;
            dataJson.AllowUserToDeleteRows = false;
            dataJson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataJson.Location = new Point(29, 205);
            dataJson.Name = "dataJson";
            dataJson.ReadOnly = true;
            dataJson.RowTemplate.Height = 25;
            dataJson.Size = new Size(696, 247);
            dataJson.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(29, 128);
            label7.Name = "label7";
            label7.Size = new Size(483, 15);
            label7.TabIndex = 2;
            label7.Text = "5. Crie um Grid, leia o arquivo data.json que foi gravado, e mostre os dados no Grid criado.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 90);
            label6.Name = "label6";
            label6.Size = new Size(463, 15);
            label6.TabIndex = 1;
            label6.Text = "4. Grave a lista do item 3, em um arquivo de nome data.json na pasta raiz da aplicação.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 29);
            label5.MaximumSize = new Size(700, 0);
            label5.Name = "label5";
            label5.Size = new Size(696, 45);
            label5.TabIndex = 0;
            label5.Text = resources.GetString("label5.Text");
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(txtResultCep);
            tabPage3.Controls.Add(btnConsultar);
            tabPage3.Controls.Add(txtCep);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(label8);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(854, 468);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Q6";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtResultCep
            // 
            txtResultCep.Location = new Point(53, 188);
            txtResultCep.Multiline = true;
            txtResultCep.Name = "txtResultCep";
            txtResultCep.Size = new Size(527, 216);
            txtResultCep.TabIndex = 6;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(266, 148);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(75, 23);
            btnConsultar.TabIndex = 5;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(149, 148);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(100, 23);
            txtCep.TabIndex = 4;
            txtCep.KeyPress += textNumero_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(53, 148);
            label11.Name = "label11";
            label11.Size = new Size(83, 15);
            label11.TabIndex = 3;
            label11.Text = "Informe o CEP";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(53, 115);
            label10.Name = "label10";
            label10.Size = new Size(121, 15);
            label10.TabIndex = 2;
            label10.Text = "Método: consultaCEP";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(53, 86);
            label9.Name = "label9";
            label9.Size = new Size(527, 15);
            label9.TabIndex = 1;
            label9.Text = "Endereço: https://apps.correios.com.br/SigepMasterJPA/AtendeClienteService/AtendeCliente?wsdl";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(53, 55);
            label8.Name = "label8";
            label8.Size = new Size(633, 15);
            label8.TabIndex = 0;
            label8.Text = "6. Consuma o webservice dos correios passando um CEP qualquer e mostre em tela o endereço que o mesmo retornar.";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button1);
            tabPage4.Controls.Add(dataGridBanco);
            tabPage4.Controls.Add(label15);
            tabPage4.Controls.Add(label14);
            tabPage4.Controls.Add(label13);
            tabPage4.Controls.Add(label12);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(854, 468);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Q7";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(60, 146);
            button1.Name = "button1";
            button1.Size = new Size(254, 23);
            button1.TabIndex = 5;
            button1.Text = "Consultar e Mostrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridBanco
            // 
            dataGridBanco.AllowUserToAddRows = false;
            dataGridBanco.AllowUserToDeleteRows = false;
            dataGridBanco.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridBanco.Location = new Point(56, 198);
            dataGridBanco.Name = "dataGridBanco";
            dataGridBanco.ReadOnly = true;
            dataGridBanco.RowTemplate.Height = 25;
            dataGridBanco.Size = new Size(754, 252);
            dataGridBanco.TabIndex = 4;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(56, 118);
            label15.Name = "label15";
            label15.Size = new Size(258, 15);
            label15.TabIndex = 3;
            label15.Text = "Mostre os dados de retorno da API em um Grid.";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(56, 87);
            label14.Name = "label14";
            label14.Size = new Size(233, 15);
            label14.TabIndex = 2;
            label14.Text = "URL: https://brasilapi.com.br/api/banks/v1";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(56, 58);
            label13.Name = "label13";
            label13.Size = new Size(447, 15);
            label13.TabIndex = 1;
            label13.Text = "Documentação: https://brasilapi.com.br/docs#tag/BANKS/paths/~1banks~1v1/get";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(56, 30);
            label12.Name = "label12";
            label12.Size = new Size(310, 15);
            label12.TabIndex = 0;
            label12.Text = "7. Consuma a API para buscar a lista de bancos brasileiros";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(txtBaixarImagem);
            tabPage5.Controls.Add(button2);
            tabPage5.Controls.Add(label16);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(854, 468);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Q8";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // txtBaixarImagem
            // 
            txtBaixarImagem.Location = new Point(38, 127);
            txtBaixarImagem.Multiline = true;
            txtBaixarImagem.Name = "txtBaixarImagem";
            txtBaixarImagem.Size = new Size(616, 310);
            txtBaixarImagem.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(38, 75);
            button2.Name = "button2";
            button2.Size = new Size(342, 23);
            button2.TabIndex = 1;
            button2.Text = "Baixar Imagem e Gravar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label16
            // 
            label16.Location = new Point(38, 22);
            label16.Name = "label16";
            label16.Size = new Size(727, 40);
            label16.TabIndex = 0;
            label16.Text = resources.GetString("label16.Text");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 28);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 1;
            label4.Text = "label4";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(23, 3);
            label17.Name = "label17";
            label17.Size = new Size(44, 15);
            label17.TabIndex = 2;
            label17.Text = "label17";
            // 
            // FrmRedeService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(897, 563);
            Controls.Add(label17);
            Controls.Add(label4);
            Controls.Add(tabControl1);
            Name = "FrmRedeService";
            Text = "RedeService";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataJson).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridBanco).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnGravarLista;
        private Button btnAdicionar;
        private TextBox textNumero;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private Label label4;
        private Button btnAbriArquivo;
        private DataGridView dataJson;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button btnCarregarGrid;
        private Button btnCreateJson;
        private TabPage tabPage3;
        private Label label10;
        private Label label9;
        private Label label8;
        private TextBox txtResultCep;
        private Button btnConsultar;
        private TextBox txtCep;
        private Label label11;
        private TabPage tabPage4;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label15;
        private Button button1;
        private DataGridView dataGridBanco;
        private TabPage tabPage5;
        private TextBox txtBaixarImagem;
        private Button button2;
        private Label label16;
        private Label label17;
    }
}