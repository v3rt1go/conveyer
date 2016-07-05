using Conveyer.Core.Field.State;
using Conveyer.Core.Field.Tests.Helpers;

namespace Conveyer.Core.Field.Tests
{
    using System;
    using Conveyer.Core.Field.Base;
    using Conveyer.Core.Field.Interface;
    using Conveyer.Core.Field.Types;
    using Conveyer.Core.Field.Ui;
    using Xunit;
    using Xunit.Abstractions;

    public class GenericFieldTests
    {
        private readonly Guid _callerId;
        private readonly Guid _unitId;
        private readonly IUnitField _sut;
        private readonly ITestOutputHelper _helper;

        public GenericFieldTests(ITestOutputHelper helper)
        {
            _helper = helper;
            _callerId = Guid.NewGuid();
            _unitId = Guid.NewGuid();
            _sut = new GenericField(_callerId, _unitId);
        }

        [Fact]
        public void ShouldFollowInheritanceChain()
        {
            _helper.WriteLine("Testing if implements IUnitField");
            Assert.IsAssignableFrom(typeof(IUnitField), _sut);

            _helper.WriteLine("Testing if inherits from UnitFieldBase");
            Assert.IsAssignableFrom(typeof(UnitFieldBase), _sut);
        }

        // TODO: Refactor this to a theory so we can test that all ctors throw
        [Fact]
        public void ShouldThrowIfCallerIdIsEmpty()
        {

            _helper.WriteLine("Testing if ArgumentException is thrown");
            Assert.Throws(typeof(ArgumentException), () => new GenericField(_callerId, new Guid()));
            var exception = Assert.Throws<ArgumentException>(() => new GenericField(new Guid(), _unitId));

            _helper.WriteLine("Testing if the exception message is correct");
            Assert.StartsWith("Please provide a valid Caller Id", exception.Message);
        }

        // TODO: Refactor this to a theory so we can test that all ctors throw
        [Fact]
        public void ShouldThrowIfBelongsToIsEmpty()
        {
            _helper.WriteLine("Testing if ArgumentException is thrown");
            Assert.Throws(typeof(ArgumentException), () => new GenericField(_callerId, new Guid()));

            _helper.WriteLine("Testing if exception message is correct");
            var exception = Assert.Throws<ArgumentException>(() => new GenericField(_callerId, Guid.Empty));
            Assert.StartsWith("Please provide a valid Unit Id", exception.Message);
        }

        [Fact]
        public void ShouldCreateNewWithCallerIdAndBelongsTo()
        {
            Assert.IsType(typeof(GenericField), _sut);

            _helper.WriteLine("Testing if callerId and unitId are assigned");
            Assert.Equal(_callerId, _sut.CreatedBy);
            Assert.Equal(_unitId, _sut.UnitId);
        }

        [Fact]
        public void ShouldCreateNewWithoutFieldType()
        {
            var sut = new GenericField("Name", DisplayType.Button, _callerId, _unitId);
            Assert.NotNull(sut);

            _helper.WriteLine("Testing if set values are correctly applied");
            Assert.Equal("Name", sut.DisplayValue);
            Assert.Equal(DisplayType.Button, sut.DisplayType);
        }

        [Fact]
        public void ShouldCreateNewWithFieldType()
        {
            var sut = new GenericField(FieldType.Boolean, "Enabled", DisplayType.Flag, _callerId, _unitId);
            Assert.NotNull(sut);

            _helper.WriteLine("Testing if set values are correctly applied");
            Assert.Equal(FieldType.Boolean, sut.Type);
            Assert.Equal("Enabled", sut.DisplayValue);
            Assert.Equal(DisplayType.Flag, sut.DisplayType);
        }

        [Fact]
        public void ShouldApplyDefaultValues()
        {
            _helper.WriteLine("Testing if default values are correctly applied");

            Assert.Equal(AttributeChecker.GetDefaultValue<FieldType, UnitFieldBase>("Type"), _sut.Type);
            Assert.Equal(AttributeChecker.GetDefaultValue<FieldState, UnitFieldBase>("State"), _sut.State);
            Assert.Equal(AttributeChecker.GetDefaultValue<int, UnitFieldBase>("Version"), _sut.Version);
        }

        [Fact]
        public void ShouldAllowAnyFieldType()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void ShouldAllowAnyDisplayType()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void ShouldAllowAnyValidationType()
        {
            throw new NotImplementedException();
        }
    }
}
