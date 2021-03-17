namespace Herança.Classes
{
    public class PessoaJuridica : Pessoa
    {
        public string cnpj;
        public string inscricaoEstadual;

        public bool ValidarCNPJ(string documento)
        {
            if(documento != "" && documento.Length > 10){
                return true;
            }
            return false;
        }
    }
}