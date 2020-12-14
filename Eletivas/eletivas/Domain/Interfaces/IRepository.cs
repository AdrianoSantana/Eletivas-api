using System.Collections.Generic;
using eletivas.Models;

namespace eletivas.Data
{
    public interface IRepository
    {
       public void Adicionar(Eletivas eletiva);

       public bool SalvarAlteracoes();

       public List<Eletivas> buscarEletivas();

       public void Deletar(Eletivas eletiva);
    }
}