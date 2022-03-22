﻿namespace EquipoAleatorio.AccesoDatos.Context
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using EquipoAleatorio.AccesoDatos.Context.Interfaces;

    public class RepositorioGenerico<T> : IRepositorioGenerico<T> where T : class
    {
        protected readonly ApplicationDbContext contexto;

        public RepositorioGenerico(ApplicationDbContext contexto)
        {
            this.contexto = contexto;
        }

        public void Crear(T entidad)
        {
            contexto.Set<T>().Add(entidad);
            GuardarCambiosContexto();
        }

        public void Crear(IEnumerable<T> lista)
        {
            contexto.Set<T>().AddRange(lista);
            GuardarCambiosContexto();
        }

        public IEnumerable<T> Buscar(Expression<Func<T, bool>> expresion)
        {
            return contexto.Set<T>().Where(expresion);
        }

        public IEnumerable<T> Consultar()
        {
            return contexto.Set<T>().ToList();
        }

        public void Eliminar(T entidad)
        {
            contexto.Set<T>().Remove(entidad);
            GuardarCambiosContexto();
        }

        public void Eliminar(IEnumerable<T> lista)
        {
            contexto.Set<T>().RemoveRange(lista);
            GuardarCambiosContexto();
        }

        private void GuardarCambiosContexto()
        {
            contexto.SaveChanges();
        }
    }
}
