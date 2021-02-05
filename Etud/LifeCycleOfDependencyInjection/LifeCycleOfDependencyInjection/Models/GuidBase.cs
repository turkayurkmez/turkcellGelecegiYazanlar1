using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeCycleOfDependencyInjection.Models
{
    public abstract class GuidBase
    {
        protected Guid guid;
        public GuidBase()
        {
            guid = Guid.NewGuid();
        }

    }
}
