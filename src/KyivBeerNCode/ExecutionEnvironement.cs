﻿using System;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using KyivBeerNCode.Domain.Events;
using KyivBeerNCode.Infrastructure.Persistence.NHibernate;

namespace KyivBeerNCode
{
    public class ExecutionEnvironement
    {
        readonly CompositionContainer _container;

        public ExecutionEnvironement(Type uowType)
        {            
            var catalog = new TypeCatalog(
                // Infrastructure
                uowType,
                // Domain
                typeof(EventRegistrator), typeof(EventRepository));

            _container = new CompositionContainer(catalog);            
        }        

        public T Resolve<T>()
        {
            var export = _container.GetExports<T>().FirstOrDefault();
            if (export == null)
            {                
                throw new InvalidOperationException("Failed to build " + typeof(T));
                // http://blogs.msdn.com/b/dsplaisted/archive/2010/07/13/how-to-debug-and-diagnose-mef-failures.aspx :)
            }
            return export.Value;
        }

        public static ExecutionEnvironement Default()
        {
            return new ExecutionEnvironement(typeof(NHUnitOfWork));
        }
    }
}
