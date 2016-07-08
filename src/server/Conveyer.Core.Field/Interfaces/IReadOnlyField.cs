using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conveyer.Core.Field.Interfaces
{
    /// <summary>
    /// Adhering to the Command Query Responsibility Segregation
    /// pattern we are going to separate our command models (IField)
    /// from our query models (IReadOnlyField)
    /// </summary>
    public interface IReadOnlyField
    {
        // This interace should implement the minimum number of properties
        // and methods that relate to reading the field data
    }
}
