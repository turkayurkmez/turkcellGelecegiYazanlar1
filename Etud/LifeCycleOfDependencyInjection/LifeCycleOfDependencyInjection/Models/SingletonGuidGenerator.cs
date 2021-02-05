using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeCycleOfDependencyInjection.Models
{
    public class SingletonGuidGenerator : GuidBase, ISingletonGuidGenerator
    {       
       
        public Guid GeneratedGuid => guid;
    }

    public class ScopedGuidGenerator : GuidBase,IScopedGuidGenerator
    {
        public Guid GeneratedGuid => guid;
    }

    public class TransientGuidGenerator : GuidBase, ITransientGuidGenerator
    {
        public Guid GeneratedGuid => guid;
    }

}
