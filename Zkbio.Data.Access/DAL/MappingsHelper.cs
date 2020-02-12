using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Zkbio.Data.Access.Maps;
using Zkbio.Data.Access.Maps.Main;

namespace Zkbio.Data.Access.DAL
{
    public static class MappingsHelper
    {
        public static IEnumerable<IMap> GetMainMappings()
        {
            var assemblyTypes = typeof(AccTransactionMap).GetTypeInfo().Assembly.DefinedTypes;
            var mappings = assemblyTypes
                .Where(t => t.Namespace != null && t.Namespace.Contains(typeof(AccTransactionMap).Namespace))
                .Where(t => typeof(IMap).GetTypeInfo().IsAssignableFrom(t));
            mappings = mappings.Where(x => !x.IsAbstract);
            return mappings.Select(m => (IMap)Activator.CreateInstance(m.AsType())).ToArray();
        }
    }
}
