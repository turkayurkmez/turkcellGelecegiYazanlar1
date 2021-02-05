using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeCycleOfDependencyInjection.Models
{
    public interface IGuidGenerator
    {
        public Guid GeneratedGuid { get; }
    }

    public interface ITransientGuidGenerator: IGuidGenerator
    {

    }

    public interface IScopedGuidGenerator : IGuidGenerator
    {

    }
    public interface ISingletonGuidGenerator : IGuidGenerator
    {

    }



}

