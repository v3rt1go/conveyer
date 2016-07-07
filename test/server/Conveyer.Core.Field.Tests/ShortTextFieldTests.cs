namespace Conveyer.Core.Field.Tests
{
    using Conveyer.Core.Field.Base;
    using Conveyer.Core.Field.Helpers;
    using Conveyer.Core.Field.Interface;
    using Conveyer.Core.Field.Types;
    using Conveyer.Core.Field.Ui;
    using System;
    using Xunit;
    using Xunit.Abstractions;

    public class ShortTextFieldTests
    {
        private readonly IUnitField _sut;
        private readonly ITestOutputHelper _helper;

        public ShortTextFieldTests(ITestOutputHelper helper)
        {
            var callerId = Guid.NewGuid();
            var unitId = Guid.NewGuid();
            _sut = new ShortTextField("Title", DisplayType.SingleLine, callerId, unitId);
            _helper = helper;
        }

        [Fact]
        public void ShouldFollowInheritanceChain()
        {
            _helper.WriteLine("Testing if implements IUnitField");
            Assert.IsAssignableFrom(typeof(IUnitField), _sut);

            _helper.WriteLine("Testing if inherits from UnitFieldBase");
            Assert.IsAssignableFrom(typeof(UnitFieldBase), _sut);
        }


        [Fact]
        public void ShouldHaveShortTextFieldType()
        {
            Assert.Equal(FieldType.ShortText, _sut.Type);
        }

        [Fact]
        public void ShouldAllowShortTextValidations()
        {
            Assert.Equal(FieldSettings.ValidationTypes["ShortText"], _sut.AllowedValidations);
        }

        [Fact]
        public void ShouldAllowShortTextDisplayTypes()
        {
            Assert.Equal(FieldSettings.DisplayTypes["ShortText"], _sut.AllowedDisplayTypes);
        }
    }
}
