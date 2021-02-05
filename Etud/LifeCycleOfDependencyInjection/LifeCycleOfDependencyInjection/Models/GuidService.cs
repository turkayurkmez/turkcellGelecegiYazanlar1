using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeCycleOfDependencyInjection.Models
{
    public class GuidService
    {
       
        public GuidService(ISingletonGuidGenerator singleton, IScopedGuidGenerator scoped, ITransientGuidGenerator transient)
        {
            SingletonGuid = singleton;
            ScopedGuidGenerator = scoped;
            TransientGuidGenerator = transient;
        }

        public ISingletonGuidGenerator SingletonGuid { get; set; }
        public IScopedGuidGenerator ScopedGuidGenerator { get; set; }
        public ITransientGuidGenerator TransientGuidGenerator { get; set; }
    }
}
