using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using FinancieraCore2020.Dominio.Repositorios;

namespace FinancieraCore2020.Datos.EF.Repositorios
{
    public class Repositorio<T> : IRepositorio<T> where T : class
    {
        protected readonly FinancieraContexto Contexto;
        public Repositorio(FinancieraContexto _contexto)
        {
            Contexto = _contexto;
        }
        public void Agregar(T _entidad)
        {
            Contexto.Set<T>().Add(_entidad);
        }

        public T BuscarPorId(int id)
        {
            return Contexto.Set<T>().Find(id);
        }

        public void GuardarCambios()
        {
            Contexto.SaveChanges();
        }

        public IEnumerable<T> Listar()
        {
            return Contexto.Set<T>();
        }

        public IEnumerable<T> ListarPor(Expression<Func<T, bool>> _predicado)
        {
            return Contexto.Set<T>().Where(_predicado);
        }
    }
}