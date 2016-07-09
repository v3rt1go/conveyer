using System;
using System.Collections.Generic;
using Conveyer.Core.Utilities;
using Xunit;

namespace Conveyer.Core.Tests
{
    [Trait("Category", "Exception handling tests")]
    public class GuardTests
    {
        private IEnumerable<object[]> NullOrEmptyData
        {
            get
            {
                yield return new object[] {null, Guid.Empty, "arg1"};
                yield return new object[] {Guid.Empty, Guid.Empty, "arg2"};
                yield return new object[] {"", string.Empty, "arg3"};
            }
        }

        private IEnumerable<object[]> AnyNullOrEmptyData
        {
            get
            {
                yield return new object[]
                {
                    new object[] { null, Guid.Empty, "arg1" },
                    new object[] { Guid.Empty, Guid.Empty, "arg2" },
                    new object[] { "", string.Empty, "arg3" }
                };
            }
        }

        [Fact]
        public void ShouldThrowIfNull()
        {
            object nullArg;
            Assert.Throws(typeof(ArgumentNullException), () => Guard.ThrowIfNull(null, nameof(nullArg)));
        }

        [Theory]
        [InlineData(new object[] { null, "arg1"}, new object[] {null, "arg2"}, new object[] {null, "arg3"})]
        [InlineData(new object[] { null, "arg1" }, new object[] { "2", "arg2" }, new object[] { null, "arg3" })]
        [InlineData(new object[] { 1, "arg1" }, new object[] { null, "arg2" }, new object[] { "3", "arg3" })]
        public void ShouldThrowIfAnyNull(object[] arg1, object[] arg2, object[] arg3)
        {
            Assert.Throws(typeof(ArgumentNullException), () => Guard.ThrowIfNull(arg1, arg2, arg3));
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        [InlineData("   ")]
        public void ShouldThrowIfNullOrEmptyOrWhiteSpace(string arg)
        {
            Assert.Throws(typeof(ArgumentException), () => Guard.ThrowIfNullEmptyOrWhiteSpace(arg, nameof(arg)));
        }

        [Theory]
        [InlineData(new string[] { "", "arg1" }, new string[] { null, "arg2" }, new string[] {"   ", "arg3"})]
        [InlineData(new string[] {null, "arg1"}, new string[] {"123", "arg2"}, new string[] {"", "arg3"})]
        [InlineData(new string[] {"asd", "arg1"}, new string[] {"   ", "arg2"}, new string[] {null, "arg3"})]
        public void ShouldThrowIfAnyNullOrEmptyOrWhiteSpace(string[] arg1, string[] arg2, string[] arg3)
        {
            Assert.Throws(typeof(ArgumentException), () => Guard.ThrowIfNullEmptyOrWhiteSpace(arg1, arg2, arg3));
        }

        [Theory, MemberData("NullOrEmptyData")]
        public void ShouldThrowIfNullOrEqual(object arg1, object arg2, string arg3)
        {
            Assert.Throws(typeof(ArgumentException), () => Guard.ThrowIfNullOrEqual(arg1, arg2, arg3));
        }

        [Theory, MemberData("AnyNullOrEmptyData")]
        public void ShouldThrowIfAnyNullOrEqual(object[] arg1, object[] arg2, object[] arg3)
        {
            Assert.Throws(typeof(ArgumentException), () => Guard.ThrowIfNullOrEqual(arg1, arg2, arg3));
        }

        [Theory]
        [InlineData(5f, 5f, "arg1")]
        [InlineData("asd", "asd", "arg2")]
        [InlineData(true, true, "arg3")]
        public void ShouldThrowIfEqual(object arg1, object arg2, string argName)
        {
            Assert.Throws(typeof(ArgumentException), () => Guard.ThrowIfEqual(arg1, arg2, argName));
        }

        [Fact]
        public void ShouldThrowAnyIfEqual()
        {

        }

        [Theory]
        [InlineData(5f, 10f, "arg1")]
        [InlineData("asd", "xyz", "arg2")]
        [InlineData(true, false, "arg3")]
        public void ShouldThrowIfNotEqual(object arg1, object arg2, string argName)
        {
            Assert.Throws(typeof(ArgumentException), () => Guard.ThrowIfNotEqual(arg1, arg2, argName));
        }

        [Fact]
        public void ShouldThrowIfAnyNotEqual()
        {

        }

        [Fact]
        public void ShouldThrowIfGreaterThen()
        {

        }

        [Fact]
        public void ShouldThrowIfAnyGreaterThen()
        {

        }

        [Fact]
        public void ShouldThrowIfLessThen()
        {

        }

        [Fact]
        public void ShouldThrowIfAnyLessThen()
        {

        }
    }
}
