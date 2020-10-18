using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudEntityFramework
{
    public  class Endereco
    {  
        [Key]
        public virtual int codigo  { get; set; }
        public virtual string rua { get; set; }
        public virtual string bairro { get; set; }
        public virtual string cidade { get; set; }
        public virtual string uf { get; set; }
        public virtual string cep { get; set; }
        public virtual string pais { get; set; }
        // [ForeignKey("idcliente_fk")]
        public  virtual int idcliente { get; set; }
        public virtual Clientes Clientes { get; set; }




    }
}
