using System.Collections.Generic;
using System.IO;

namespace MVC_Usuário.Models
{
    public class Usuario
    {
        public string Nome { get; set; }
        public int Senha { get; set; }
        public string Email { get; set; }
        public int ID  { get; set; }

        private const string PATH = "Database/Usuario.csv";

        public Usuario(){

            string pasta = PATH.Split("/")[0];

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }
            
            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
        }

        public List<Usuario> Ler()
        {
            List<Usuario> usuarios = new List<Usuario>();

            string[] linhasUsuarios = File.ReadAllLines(PATH);

            foreach (string item in linhasUsuarios)
            {
                string[] atributos = item.Split(";");

                Usuario _usuario = new Usuario();
                _usuario.Nome = atributos[0];
                _usuario.Senha = int.Parse(atributos[1]);
                _usuario.Email = atributos[2];
                _usuario.ID = int.Parse(atributos[3]);

                usuarios.Add(_usuario);
            }

            return usuarios;
        }

        public string PrepararLinhasCSV(Usuario _usuario){
            return $"{_usuario.Nome};{_usuario.Senha};{_usuario.Email};{_usuario.Senha}";
        }

        public void InserirUsuario(Usuario usuario){
            string[] linhas = { PrepararLinhasCSV(usuario) };

            File.AppendAllLines(PATH, linhas);
        }


    }
}