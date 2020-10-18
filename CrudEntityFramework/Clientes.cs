using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudEntityFramework
{
   public class Clientes
    {
        [Key]
        public virtual int Codigo { get; set; }
        public virtual string nome{ get; set; }
        public virtual string email{ get; set; }
        public virtual string cpf { get; set; }
        public virtual string whatsapp{ get; set; }
        public virtual string datanascimento { get; set; }
        public virtual ICollection<Endereco> Enderecos { get; set; }








    }
}
