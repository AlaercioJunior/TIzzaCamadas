using Entidades;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace Repositorio
{
    public interface IRepoPizzaria
    {
        void Inserir(Pizzaria pizzaria)
    }
    public class RepoPizzaria
    {
        private DataContext _dataContext;
        public RepoPizzaria(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Inserir(Pizzaria pizzaria)
        {
            _dataContext.Add(pizzaria);
            _dataContext.SaveChanges();

        }
    }
}
