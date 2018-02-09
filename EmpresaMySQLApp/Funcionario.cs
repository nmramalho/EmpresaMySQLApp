namespace EmpresaMySQLApp
{
    class Funcionario
    {
        private int id;
        private string idDepartamento;
        private string nome;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string IdDepartamento
        {
            get { return idDepartamento; }
            set { idDepartamento = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public Funcionario()
        {
            id = 0;
            idDepartamento = "";
            nome = "";
        }

        public Funcionario(string nIdDepartamento, string nNome)
        {
            idDepartamento = nIdDepartamento;
            nome = nNome;
        }

        public Funcionario(int nID, string nIdDepartamento, string nNome)
        {
            id = nID;
            idDepartamento = nIdDepartamento;
            nome = nNome;
        }
 
    }
}
