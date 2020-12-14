using System.Collections.Generic;
using System.Linq;
using eletivas.Models;
using Microsoft.EntityFrameworkCore;

namespace eletivas.Data
{
  public class Repository : IRepository
  {
    private readonly EletivasContext _context;
    public Repository(EletivasContext context)
    {
        _context = context;
    }

    public bool SalvarAlteracoes()
    {
        return _context.SaveChanges() > 0 ? true : false;
    }
    public void Adicionar(Eletivas eletiva)
    {
      _context.Add(eletiva);
    }

    public List<Eletivas> buscarEletivas()
    {
      return _context.Eletivas.ToList<Eletivas>();
    }

    public void Deletar(Eletivas eletiva)
    {
        _context.Remove(eletiva);
    }
  }
}