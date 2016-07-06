namespace Conveyer.Core.Field.Tests
{
    using Conveyer.Core.Field.Types;
    using Conveyer.Core.Field.Ui;
    using Conveyer.Core.Field.Validations;
    using Conveyer.Core.Field.Tests.Fixtures;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Xunit;
    using Xunit.Abstractions;

    [Collection("CommonField test collection")]
    public class GenericFieldTests
    {
        private readonly CommonFieldFixture _fx;
        private readonly ITestOutputHelper _helper;

        public GenericFieldTests(ITestOutputHelper helper, CommonFieldFixture fixture)
        {
            _fx = fixture;
            _helper = helper;
        }

        [Fact]
        public void ShouldCreateNewWithoutFieldType()
        {
            var sut = new GenericField("Name", DisplayType.Button, _fx.CallerId, _fx.UnitId);
            Assert.NotNull(sut);

            _helper.WriteLine("Testing if set values are correctly applied");
            Assert.Equal("Name", sut.DisplayValue);
            Assert.Equal(DisplayType.Button, sut.DisplayType);
        }

        [Fact]
        public void ShouldCreateNewWithFieldType()
        {
            var sut = new GenericField(FieldType.Boolean, "Enabled", DisplayType.Flag, _fx.CallerId, _fx.UnitId);
            Assert.NotNull(sut);

            _helper.WriteLine("Testing if set values are correctly applied");
            Assert.Equal(FieldType.Boolean, sut.Type);
            Assert.Equal("Enabled", sut.DisplayValue);
            Assert.Equal(DisplayType.Flag, sut.DisplayType);
        }

        [Fact]
        public void ShouldAllowAnyDisplayType()
        {
            IEnumerable<DisplayType> allDisplayTypes = Enum.GetValues(typeof(DisplayType)).Cast<DisplayType>();
            Assert.Equal(allDisplayTypes, _fx.GeneralFieldSut.AllowedDisplayTypes);
        }

        [Fact]
        public void ShouldAllowAnyValidationType()
        {
            IEnumerable<ValidationType> allValidationTypes = Enum.GetValues(typeof(ValidationType)).Cast<ValidationType>();
            Assert.Equal(allValidationTypes, _fx.GeneralFieldSut.AllowedValidations);
        }
    }
}
