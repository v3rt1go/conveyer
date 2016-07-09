using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conveyer.Core.Field.Helpers;

namespace Conveyer.Core.TestConsole
{
    using Conveyer.Core.Field;
    public class Program
    {
        public static void Main(string[] args)
        {
            var systemAccountId = Guid.NewGuid();
            var dummyUnitId = Guid.NewGuid();

            var simpleCtor = new GenericField(systemAccountId, dummyUnitId);
            var fullCtor = new GenericField(FieldType.Email, "Email", DisplayType.Email, systemAccountId, dummyUnitId);

            var textCtor2 = new ShortTextField(systemAccountId, dummyUnitId);
            var textCtor3 = new ShortTextField("Name", DisplayType.Email, systemAccountId, dummyUnitId);
        }
    }
}
