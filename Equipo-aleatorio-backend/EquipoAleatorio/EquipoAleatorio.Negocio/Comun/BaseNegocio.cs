namespace EquipoAleatorio.Negocio.Comun
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using EquipoAleatorio.Negocio.Comun.Interfaces;

    public class BaseNegocio<T> : IBaseNegocio<T> where T : class
    { 
        public IEnumerable<T> Buscar(Expression<Func<T, bool>> expresion)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Consultar()
        {
            throw new NotImplementedException();
        }

        public void Crear(T entidad)
        {
            throw new NotImplementedException();
        }
        
        public void Crear(IEnumerable<T> entidad)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(T entidad)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(IEnumerable<T> lista)
        {
            throw new NotImplementedException();
        }
    }
}
