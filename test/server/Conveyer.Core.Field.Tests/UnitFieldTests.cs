using Conveyer.Core.Field.Helpers;

namespace Conveyer.Core.Field.Tests
{
    using Conveyer.Core.Field.Base;
    using Interfaces;
    using Conveyer.Core.Field.Tests.Helpers;
    using Conveyer.Core.Field.Tests.Fixtures;
    using Conveyer.Core.State;
    using System;
    using System.Collections.Generic;
    using Xunit;
    using Xunit.Abstractions;

    [Collection("CommonField test collection")]
    public class UnitFieldTests
    {
        private readonly CommonFieldFixture _fx;
        private readonly ITestOutputHelper _helper;

        private UnitFieldTests(ITestOutputHelper helper, CommonFieldFixture fixture)
        {
            _fx = fixture;
            _helper = helper;
        }

        private static IEnumerable<object[]> BlankCallerId
        {
            get
            {
                yield return new object[] { (Func<GenericField>)(() => new GenericField(new Guid(), Guid.NewGuid())) };
                yield return new object[] { (Func<GenericField>)(() => new GenericField("foo", DisplayType.Button, new Guid(), Guid.NewGuid())) };
                yield return new object[] { (Func<GenericField>)(() => new GenericField(FieldType.Boolean, "foosa", DisplayType.Button, Guid.Empty, Guid.NewGuid())) };
            }
        }

        private static IEnumerable<object[]> BlankUnitId
        {
            get
            {
                yield return new object[] { (Func<GenericField>)(() => new GenericField(Guid.NewGuid(), new Guid())) };
                yield return new object[] { (Func<GenericField>)(() => new GenericField("foo", DisplayType.Button, Guid.NewGuid(), new Guid())) };
                yield return new object[] { (Func<GenericField>)(() => new GenericField(FieldType.Boolean, "foosa", DisplayType.Button, Guid.NewGuid(), Guid.Empty)) };
            }
        }

        [Fact]
        public void ShouldFollowInheritanceChain()
        {
            _helper.WriteLine("Testing if implements IField");
            Assert.IsAssignableFrom(typeof(IField), _fx.GeneralFieldSut);

            _helper.WriteLine("Testing if inherits from FieldBase");
            Assert.IsAssignableFrom(typeof(FieldBase), _fx.GeneralFieldSut);
        }

        [Theory, MemberData("BlankCallerId")]
        public void ShouldThrowIfCallerIdIsEmpty(Func<object> testcode)
        {
            _helper.WriteLine("Testing if ArgumentException is thrown");
            Assert.Throws(typeof(ArgumentException), testcode);

            _helper.WriteLine("Testing if the exception message is correct");
            var exception = Assert.Throws<ArgumentException>(testcode);
            Assert.StartsWith("Please provide a valid Caller Id", exception.Message);
        }

        [Theory, MemberData("BlankUnitId")]
        public void ShouldThrowIfUnitIdIsEmpty(Func<object> testcode)
        {
            _helper.WriteLine("Testing if ArgumentException is thrown");
            Assert.Throws(typeof(ArgumentException), testcode);

            _helper.WriteLine("Testing if exception message is correct");
            var exception = Assert.Throws<ArgumentException>(testcode);
            Assert.StartsWith("Please provide a valid Unit Id", exception.Message);
        }

        [Fact]
        public void ShouldCreateNewWithCallerIdAndBelongsTo()
        {
            Assert.IsType(typeof(GenericField), _fx.GeneralFieldSut);

            _helper.WriteLine("Testing if callerId and unitId are assigned");
            Assert.Equal(_fx.CallerId, _fx.GeneralFieldSut.CreatedBy);
            Assert.Equal(_fx.UnitId, _fx.GeneralFieldSut.UnitId);
        }

        [Fact]
        public void ShouldApplyDefaultValues()
        {
            _helper.WriteLine("Testing if default values are correctly applied");
            Assert.Equal(AttributeChecker.GetDefaultValue<FieldState, FieldBase>("State"), _fx.GeneralFieldSut.State);
            Assert.Equal(AttributeChecker.GetDefaultValue<FieldType, FieldBase>("Type"), _fx.GeneralFieldSut.Type);
            Assert.Equal(AttributeChecker.GetDefaultValue<DisplayType, FieldBase>("DisplayType"), _fx.GeneralFieldSut.DisplayType);
            Assert.Equal(AttributeChecker.GetDefaultValue<int, FieldBase>("Version"), _fx.GeneralFieldSut.Version);
            Assert.Equal(AttributeChecker.GetDefaultValue<AccessModifier, FieldBase>("Access"), _fx.GeneralFieldSut.Access);
        }

        [Fact]
        public void ShouldApplyValidCreatedDate()
        {
            _helper.WriteLine("Testing if CreatedAt is the same as current date");
            Assert.Equal(DateTime.Now.ToString("g"), _fx.GeneralFieldSut.CreatedAt.ToString("g"));
        }
    }
}
