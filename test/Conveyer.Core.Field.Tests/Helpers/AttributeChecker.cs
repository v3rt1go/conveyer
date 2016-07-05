using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Conveyer.Core.Field.Tests.Helpers
{
    public static class AttributeChecker
    {
        public static TY GetDefaultValue<TY, TC>(string propertyName)
        {
            var property = typeof(TC).GetProperty(propertyName);

            var attribute = property?
                .GetCustomAttribute(typeof(DefaultValueAttribute))
                    as DefaultValueAttribute;

            return (TY)attribute?.Value;
        }
    }
}
