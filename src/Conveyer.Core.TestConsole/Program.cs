using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conveyer.Core.Field.Types;
using Conveyer.Core.Field.Ui;

namespace Conveyer.Core.TestConsole
{
    using Conveyer.Core.Field;
    public class Program
    {
        public static void Main(string[] args)
        {
            var systemAccountId = Guid.NewGuid();
            var dummyUnitId = Guid.NewGuid();

            var defaultCtor = new GenericField();
            var simpleCtor = new GenericField(systemAccountId, dummyUnitId);
            var fullCtor = new GenericField(systemAccountId, FieldType.Email, "Email", DisplayType.Email, dummyUnitId);
        }
    }
}
