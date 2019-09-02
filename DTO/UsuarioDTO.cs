using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UsuarioDTO
    {
        #region Atributos
        private int id;
        private string nome;
        private string sobrenome;
        #endregion

        #region Propriedades
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Sobrenome { get => sobrenome; set => sobrenome = value; }
        #endregion
    }
}
