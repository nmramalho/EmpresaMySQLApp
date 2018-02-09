namespace EmpresaMySQLApp
{
    class Departamento
    {

        private string id;
        private string nome;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public Departamento()
        {
            id = "";
            nome = "";
        }

        public Departamento(string nId, string nNome)
        {
            id = nId;
            nome = nNome;
        }
    }
}
