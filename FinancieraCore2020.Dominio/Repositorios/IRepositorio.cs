
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace FinancieraCore2020.Dominio.Repositorios
{
    public interface IRepositorio<T> where T : class
    {
        T BuscarPorId(int id);
        IEnumerable<T> Listar();
        IEnumerable<T> ListarPor(Expression<Func<T, bool>> _predicado);
        void Agregar(T _entidad);
        void GuardarCambios();
    }
}