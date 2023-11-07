namespace SistemaDeCadastros
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
            txtTel = new Label();
            txtNascimento = new Label();
            txtEstadoCivil = new Label();
            txtNome = new Label();
            txtName = new TextBox();
            dateNascimento = new DateTimePicker();
            comboEstadoCivil = new ComboBox();
            maskedTel = new MaskedTextBox();
            checkCasa = new CheckBox();
            checkVeiculo = new CheckBox();
            groupBox1 = new GroupBox();
            radioOutro = new RadioButton();
            radioLGBT = new RadioButton();
            radioF = new RadioButton();
            radioM = new RadioButton();
            listaPessoas = new ListBox();
            CadEditar = new Button();
            btnExcluir = new Button();
            btnLimpar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtTel
            // 
            txtTel.AutoSize = true;
            txtTel.Font = new Font("Alef", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtTel.Location = new Point(12, 172);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(60, 18);
            txtTel.TabIndex = 0;
            txtTel.Text = "Telefone";
            // 
            // txtNascimento
            // 
            txtNascimento.AutoSize = true;
            txtNascimento.Font = new Font("Alef", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNascimento.Location = new Point(12, 85);
            txtNascimento.Name = "txtNascimento";
            txtNascimento.Size = new Size(109, 18);
            txtNascimento.TabIndex = 1;
            txtNascimento.Text = "Data Nascimento";
            // 
            // txtEstadoCivil
            // 
            txtEstadoCivil.AutoSize = true;
            txtEstadoCivil.Font = new Font("Alef", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtEstadoCivil.Location = new Point(12, 135);
            txtEstadoCivil.Name = "txtEstadoCivil";
            txtEstadoCivil.Size = new Size(74, 18);
            txtEstadoCivil.TabIndex = 2;
            txtEstadoCivil.Text = "Estado Civil";
            // 
            // txtNome
            // 
            txtNome.AutoSize = true;
            txtNome.Font = new Font("Alef", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(12, 43);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(43, 18);
            txtNome.TabIndex = 3;
            txtNome.Text = "Nome";
            // 
            // txtName
            // 
            txtName.Font = new Font("Alef", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(126, 36);
            txtName.Name = "txtName";
            txtName.Size = new Size(419, 25);
            txtName.TabIndex = 4;
            // 
            // dateNascimento
            // 
            dateNascimento.Font = new Font("Alef", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateNascimento.Location = new Point(126, 78);
            dateNascimento.Name = "dateNascimento";
            dateNascimento.Size = new Size(419, 25);
            dateNascimento.TabIndex = 5;
            // 
            // comboEstadoCivil
            // 
            comboEstadoCivil.Font = new Font("Alef", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            comboEstadoCivil.FormattingEnabled = true;
            comboEstadoCivil.Location = new Point(127, 127);
            comboEstadoCivil.Name = "comboEstadoCivil";
            comboEstadoCivil.Size = new Size(418, 26);
            comboEstadoCivil.TabIndex = 6;
            // 
            // maskedTel
            // 
            maskedTel.Font = new Font("Alef", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTel.Location = new Point(127, 169);
            maskedTel.Mask = "(00) 00000-0000";
            maskedTel.Name = "maskedTel";
            maskedTel.Size = new Size(418, 25);
            maskedTel.TabIndex = 7;
            // 
            // checkCasa
            // 
            checkCasa.AutoSize = true;
            checkCasa.Location = new Point(127, 220);
            checkCasa.Name = "checkCasa";
            checkCasa.Size = new Size(127, 19);
            checkCasa.TabIndex = 8;
            checkCasa.Text = "possui casa propria";
            checkCasa.UseVisualStyleBackColor = true;
            // 
            // checkVeiculo
            // 
            checkVeiculo.AutoSize = true;
            checkVeiculo.Location = new Point(127, 245);
            checkVeiculo.Name = "checkVeiculo";
            checkVeiculo.Size = new Size(101, 19);
            checkVeiculo.TabIndex = 9;
            checkVeiculo.Text = "possui veiculo";
            checkVeiculo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioOutro);
            groupBox1.Controls.Add(radioLGBT);
            groupBox1.Controls.Add(radioF);
            groupBox1.Controls.Add(radioM);
            groupBox1.Location = new Point(127, 273);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(418, 100);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sexo";
            // 
            // radioOutro
            // 
            radioOutro.AutoSize = true;
            radioOutro.Location = new Point(325, 44);
            radioOutro.Name = "radioOutro";
            radioOutro.Size = new Size(56, 19);
            radioOutro.TabIndex = 3;
            radioOutro.Text = "Outro";
            radioOutro.UseVisualStyleBackColor = true;
            // 
            // radioLGBT
            // 
            radioLGBT.AutoSize = true;
            radioLGBT.Location = new Point(228, 44);
            radioLGBT.Name = "radioLGBT";
            radioLGBT.Size = new Size(79, 19);
            radioLGBT.TabIndex = 2;
            radioLGBT.Text = "LGBTQIA+";
            radioLGBT.TextAlign = ContentAlignment.MiddleRight;
            radioLGBT.UseVisualStyleBackColor = true;
            // 
            // radioF
            // 
            radioF.AutoSize = true;
            radioF.Location = new Point(135, 44);
            radioF.Name = "radioF";
            radioF.Size = new Size(75, 19);
            radioF.TabIndex = 1;
            radioF.Text = "Feminino";
            radioF.TextAlign = ContentAlignment.MiddleCenter;
            radioF.UseVisualStyleBackColor = true;
            // 
            // radioM
            // 
            radioM.AutoSize = true;
            radioM.Checked = true;
            radioM.Location = new Point(37, 44);
            radioM.Name = "radioM";
            radioM.Size = new Size(80, 19);
            radioM.TabIndex = 0;
            radioM.TabStop = true;
            radioM.Text = "Masculino";
            radioM.TextAlign = ContentAlignment.MiddleCenter;
            radioM.UseVisualStyleBackColor = true;
            // 
            // listaPessoas
            // 
            listaPessoas.FormattingEnabled = true;
            listaPessoas.ItemHeight = 15;
            listaPessoas.Location = new Point(127, 521);
            listaPessoas.Name = "listaPessoas";
            listaPessoas.Size = new Size(418, 139);
            listaPessoas.TabIndex = 11;
            listaPessoas.MouseDoubleClick += listaPessoas_MouseDoubleClick;
            // 
            // CadEditar
            // 
            CadEditar.Location = new Point(29, 405);
            CadEditar.Name = "CadEditar";
            CadEditar.Size = new Size(176, 61);
            CadEditar.TabIndex = 12;
            CadEditar.Text = "Cadastrar/Alterar";
            CadEditar.UseVisualStyleBackColor = true;
            CadEditar.Click += CadEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(264, 405);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(176, 61);
            btnExcluir.TabIndex = 13;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(499, 405);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(176, 61);
            btnLimpar.TabIndex = 14;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 672);
            Controls.Add(btnLimpar);
            Controls.Add(btnExcluir);
            Controls.Add(CadEditar);
            Controls.Add(listaPessoas);
            Controls.Add(groupBox1);
            Controls.Add(checkVeiculo);
            Controls.Add(checkCasa);
            Controls.Add(maskedTel);
            Controls.Add(comboEstadoCivil);
            Controls.Add(dateNascimento);
            Controls.Add(txtName);
            Controls.Add(txtNome);
            Controls.Add(txtEstadoCivil);
            Controls.Add(txtNascimento);
            Controls.Add(txtTel);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtTel;
        private Label txtNascimento;
        private Label txtEstadoCivil;
        private Label txtNome;
        private TextBox txtName;
        private DateTimePicker dateNascimento;
        private ComboBox comboEstadoCivil;
        private MaskedTextBox maskedTel;
        private CheckBox checkCasa;
        private CheckBox checkVeiculo;
        private GroupBox groupBox1;
        private RadioButton radioOutro;
        private RadioButton radioLGBT;
        private RadioButton radioF;
        private RadioButton radioM;
        private ListBox listaPessoas;
        private Button CadEditar;
        private Button btnExcluir;
        private Button btnLimpar;
    }
}