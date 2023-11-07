namespace SistemaDeCadastros
{
    public partial class Form1 : Form
    {

        List<Pessoa> pessoas;
        public Form1()
        {
            InitializeComponent();
            pessoas = new List<Pessoa>();
            comboEstadoCivil.Items.Add("Casado");
            comboEstadoCivil.Items.Add("Solteiro");
            comboEstadoCivil.Items.Add("Viuvo");

            comboEstadoCivil.SelectedIndex = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CadEditar_Click(object sender, EventArgs e)
        {

            int index = -1;

            foreach (Pessoa pessoa in pessoas)
            {
                if (pessoa.Name == txtName.Text)
                {
                    index = pessoas.IndexOf(pessoa);
                }
            }

            if (txtName.Text == "")
            {
                MessageBox.Show("Preencha o campo nome");
                txtName.Focus();
                return;
            }

            if (maskedTel.Text == "(  )      -")
            {
                MessageBox.Show("Preencha o campo telefone");
                maskedTel.Focus();
                return;
            }

            char sexo;

            if (radioM.Checked)
            {
                sexo = 'M';
            }
            else if (radioF.Checked)
            {
                sexo = 'F';
            }
            else if (radioLGBT.Checked)
            {
                sexo = 'L';
            }
            else
            {
                sexo = 'O';
            }


            Pessoa p = new Pessoa();
            p.Name = txtName.Text;
            p.Telefone = maskedTel.Text;
            p.Sexo = sexo;
            p.VeiculoProprio = checkVeiculo.Checked;
            p.EstadoCivil = comboEstadoCivil.SelectedItem.ToString();
            p.CasaPropria = checkCasa.Checked;

            if (index < 0)
            {
                pessoas.Add(p);
            }
            else
            {
                pessoas[index] = p;
            }

            btnLimpar_Click(btnLimpar, EventArgs.Empty);
            ListarPessoas();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int index = listaPessoas.SelectedIndex;
            pessoas.RemoveAt(index);
            ListarPessoas();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            maskedTel.Text = "";
            comboEstadoCivil.SelectedIndex = 0;
            checkCasa.Checked = false;
            checkVeiculo.Checked = false;
            radioF.Checked = false;
            radioM.Checked = true;
            radioLGBT.Checked = false;
            radioOutro.Checked = false;
            txtName.Focus();
        }

        private void ListarPessoas()
        {
            listaPessoas.Items.Clear();

            foreach (Pessoa p in pessoas)
            {

                listaPessoas.Items.Add(p.Name);


            }
        }

        private void listaPessoas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listaPessoas.SelectedIndex;

            Pessoa p = pessoas[index];


            txtName.Text = p.Name;
            dateNascimento.Text = p.DataNascimento;
            comboEstadoCivil.SelectedItem = p.EstadoCivil;
            maskedTel.Text = p.Telefone;
            checkCasa.Checked = p.CasaPropria;
            checkVeiculo.Checked = p.VeiculoProprio;

            switch (p.Sexo)
            {
                case 'M':
                    radioM.Checked = true;
                    break;

                case 'F':
                    radioF.Checked = true;
                    break;

                case 'L':
                    radioLGBT.Checked = true;
                    break;

                case 'O':
                    radioOutro.Checked = true;
                    break;

            }


        }
    }
}