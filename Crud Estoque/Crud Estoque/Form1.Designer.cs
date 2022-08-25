namespace Crud_Estoque
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.campo_id = new System.Windows.Forms.TextBox();
            this.campo_nome = new System.Windows.Forms.TextBox();
            this.campo_quantidade = new System.Windows.Forms.TextBox();
            this.btn_1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(272, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(248, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(194, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // campo_id
            // 
            this.campo_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.campo_id.Location = new System.Drawing.Point(351, 243);
            this.campo_id.Name = "campo_id";
            this.campo_id.Size = new System.Drawing.Size(226, 26);
            this.campo_id.TabIndex = 3;
            this.campo_id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // campo_nome
            // 
            this.campo_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.campo_nome.Location = new System.Drawing.Point(351, 292);
            this.campo_nome.Name = "campo_nome";
            this.campo_nome.Size = new System.Drawing.Size(226, 26);
            this.campo_nome.TabIndex = 4;
            this.campo_nome.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // campo_quantidade
            // 
            this.campo_quantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.campo_quantidade.Location = new System.Drawing.Point(351, 344);
            this.campo_quantidade.Name = "campo_quantidade";
            this.campo_quantidade.Size = new System.Drawing.Size(226, 26);
            this.campo_quantidade.TabIndex = 5;
            this.campo_quantidade.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.SystemColors.Control;
            this.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_1.Location = new System.Drawing.Point(686, 206);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(102, 60);
            this.btn_1.TabIndex = 6;
            this.btn_1.Text = "Cadastrar";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(291, 414);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(360, 150);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(686, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 60);
            this.button1.TabIndex = 8;
            this.button1.Text = "Exibir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_alterar
            // 
            this.btn_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_alterar.Location = new System.Drawing.Point(686, 378);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(102, 60);
            this.btn_alterar.TabIndex = 9;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_deletar
            // 
            this.btn_deletar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_deletar.Location = new System.Drawing.Point(686, 464);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(102, 60);
            this.btn_deletar.TabIndex = 10;
            this.btn_deletar.Text = "Deletar";
            this.btn_deletar.UseVisualStyleBackColor = true;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(351, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 225);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(935, 591);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.campo_quantidade);
            this.Controls.Add(this.campo_nome);
            this.Controls.Add(this.campo_id);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Mercedes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox campo_id;
        private TextBox campo_nome;
        private TextBox campo_quantidade;
        private Button btn_1;
        private DataGridView dataGridView1;
        private Button button1;
        private Button btn_alterar;
        private Button btn_deletar;
        private PictureBox pictureBox1;
    }
}