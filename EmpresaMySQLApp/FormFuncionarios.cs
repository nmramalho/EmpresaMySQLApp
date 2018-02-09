using System;
using System.Windows.Forms;

namespace EmpresaMySQLApp
{
    public partial class FormFuncionarios : Form
    {
        private OperacoesBD opBD;
        private Funcionario funcionario;

        public FormFuncionarios()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            TestaLigacaoBDIniciaForm();
        }

        /// <summary>
        /// Médodo responsável por testar a ligação à base de dados e inicializar os valores dos controlos no formulário
        /// </summary>
        private void TestaLigacaoBDIniciaForm()
        {
            opBD = new OperacoesBD();

            if (!opBD.TestarLigacao())
            {
                MessageBox.Show("Não é possível estabelecer a ligação com o servidor",
                "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                groupBoxFuncionario.Hide();
                groupBoxFuncionarios.Hide();
            }
            else
            {
                IniciaForm();
            }
        }

        /// <summary>
        /// Método responsável por inicializar o formulário
        /// </summary>
        private void IniciaForm()
        {
            comboBoxDepartamento.DataSource = opBD.ListaDeDepartamentos();
            comboBoxDepartamento.ValueMember = "Id";
            comboBoxDepartamento.DisplayMember = "Nome";

            textBoxIdDepartamento.Text = comboBoxDepartamento.SelectedValue.ToString();

            dataGridViewFuncionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewFuncionarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFuncionarios.ReadOnly = true;
            dataGridViewFuncionarios.MultiSelect = false;
            dataGridViewFuncionarios.AllowUserToAddRows = false;

            AtualizaDataGridView();
        }


        /// <summary>
        /// Método responsável por atualizar a  DataGridView com os dados provenientes da tabela da base de dados
        /// </summary>
        private void AtualizaDataGridView()
        {
            opBD.CriaListaDeFuncionarios();
            try
            {
                dataGridViewFuncionarios.DataSource = opBD.dsListaDeFuncionarios.Tables[0];
            }
            catch (Exception)
            {

                MessageBox.Show("Não é possível aceder à tabela \"funcionario\"",
                "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        /// <summary>
        /// Método responsável por atualizar a textbox textBoxIdDepartamento com o valor do id do 
        /// departamento, que corresponde à chave primária da tabela departamento.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxIdDepartamento.Text = comboBoxDepartamento.SelectedValue.ToString();
        }

        /// <summary>
        ///  Método associado ao botão para inserir um novo funcionário na base de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonInsere_Click(object sender, EventArgs e)
        {
            funcionario = new Funcionario();
            funcionario.IdDepartamento = textBoxIdDepartamento.Text;
            funcionario.Nome = textBoxNome.Text;

            string resultado = opBD.InsereFuncionario(funcionario);

            MessageBox.Show("Id do novo funcionário: " + resultado,
                  "Resultado da operação", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        /// <summary>
        /// Método associado ao botão para atualizar a DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAtualizarDataGridView_Click(object sender, EventArgs e)
        {
            AtualizaDataGridView();
        }


        /// <summary>
        ///  Método associado ao botão para atualizar os dados do funcionário vom base na seleção da DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewFuncionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // atualizar combobox de acordo com o funcionário selecionado
            comboBoxDepartamento.SelectedIndex = comboBoxDepartamento.FindStringExact(dataGridViewFuncionarios.SelectedRows[0].Cells[2].Value.ToString());

            // criar novo funcionário com os dados da selecção
            funcionario = new Funcionario();
            funcionario.ID = Convert.ToInt32(dataGridViewFuncionarios.SelectedRows[0].Cells[0].Value);
            funcionario.IdDepartamento = comboBoxDepartamento.SelectedValue.ToString();
            funcionario.Nome = dataGridViewFuncionarios.SelectedRows[0].Cells[1].Value.ToString();

            // atualizar valores dos controlos do formulário
            textBoxIdFuncionario.Text = funcionario.ID.ToString();
            textBoxIdDepartamento.Text = funcionario.IdDepartamento;
            textBoxNome.Text = funcionario.Nome;
            
        }


        /// <summary>
        /// Método associado ao botão para atualizar os dados do funcionário na base de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAtualiza_Click(object sender, EventArgs e)
        {

            if ((String.IsNullOrEmpty(textBoxIdFuncionario.Text)))
                return;

            funcionario = new Funcionario();
            funcionario.ID = Convert.ToInt32(textBoxIdFuncionario.Text);
            funcionario.IdDepartamento = textBoxIdDepartamento.Text;
            funcionario.Nome = textBoxNome.Text;

            string resultado = opBD.AtualizaFuncionario(funcionario);

            MessageBox.Show(resultado,
                  "Resultado da operação", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        /// <summary>
        /// Método associado ao botão para eliminar um registo de funcionário da base de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonElimina_Click(object sender, EventArgs e)
        {
           // funcionario = new Funcionario();
           // funcionario.ID = Convert.ToInt32(textBoxIdFuncionario.Text);

            string resultado = opBD.ApagaFuncionario(funcionario);

            MessageBox.Show(resultado,
                  "Resultado da operação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            AtualizaDataGridView();
        }
    }
}
