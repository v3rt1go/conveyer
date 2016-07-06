using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conveyer.Core.Field.Interface;
using Xunit.Abstractions;

namespace Conveyer.Core.Field.Tests.Fixtures
{
    public class CommonFieldFixture
    {
        public CommonFieldFixture()
        {
            this.CallerId = Guid.NewGuid();
            this.UnitId = Guid.NewGuid();
            this.GeneralFieldSut = new GenericField(this.CallerId, this.UnitId);
        }

        public Guid CallerId { get; private set; }
        public Guid UnitId { get; private set; }
        public IUnitField GeneralFieldSut { get; private set; }
    }
}
