using System;
using System.Collections;
using System.Diagnostics;

namespace Conveyer.Core.Utilities
{
    public static class Guard
    {
        /// <summary>
        /// Ensures that the argument passed is not null
        /// </summary>
        /// <param name="arg">The argument</param>
        /// <param name="argName">The argument name (nameof())</param>
        [DebuggerStepThrough]
        public static void ThrowIfNull(object arg, string argName)
        {
            if (arg == null)
                throw new ArgumentNullException(argName);
        }

        /// <summary>
        /// Ensures that any of the arguments passed are not null
        /// </summary>
        /// <param name="args">The arguments and their names [[obj1, nameof(obj1)], [obj2, nameof(obj2)]]</param>
        public static void ThrowIfNull(params object[][] args)
        {
            foreach (object[] arg in args)
                ThrowIfNull(arg[0], (string)arg[1]);
        }

        [DebuggerStepThrough]
        public static void ThrowIfNullEmptyOrWhiteSpace(string arg, string argName)
        {

        }

        public static void ThrowIfNullEmptyOrWhiteSpace(params string[][] args)
        {

        }

        [DebuggerStepThrough]
        public static void ThrowIfNullOrEqual(object arg, object compareTo, string argName)
        {

        }

        public static void ThrowIfNullOrEqual(params object[][] args)
        {

        }

        [DebuggerStepThrough]
        public static void ThrowIfEqual(object arg, object compareTo, string argName)
        {

        }

        public static void ThrowIfEqual(params object[][] args)
        {

        }

        [DebuggerStepThrough]
        public static void ThrowIfNotEqual(object arg, object compareTo, string argName)
        {

        }

        public static void ThrowIfNotEqual(params object[][] args)
        {

        }

        [DebuggerStepThrough]
        public static void ThrowIfGreaterThen(object arg, object compareTo, string argName)
        {

        }

        public static void ThrowIfGreaterThen(params object[][] args)
        {

        }

        [DebuggerStepThrough]
        public static void ThrowIfLessThen(object arg, object compareTo, string argName)
        {

        }

        public static void ThrowIfLessThen(params object[][] args)
        {

        }
    }
}
