using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudEntityFramework
{
   public class Dados
    {

        public  void preencherGrid()
        {
            BDcontext bd = new BDcontext();

            var consulta = (from cliente in bd.Clientes
                            join endereco in bd.Endereco on cliente.Codigo equals endereco.idcliente


                            //where e.OwnerID == user.UID
                            select new
                            {
                                Nome = cliente.nome,
                                Cpf = cliente.cpf,
                                Whatsapp = cliente.whatsapp,
                                Email = cliente.email,
                                Cidade = endereco.cidade,
                                UF = endereco.uf



                            }).Take(1000);


       

        }


    }
}
