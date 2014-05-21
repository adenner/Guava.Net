using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guava.Net.Base
{
    /// <summary>
    /// Static convenience methods that help a method or constructor check whether it was invoked correctly
    /// (Whether its preconditions have been met).
    /// </summary>
    public static class Preconditions
    {

        /// <summary>
        /// Ensure that an object reference passed as a parameter to the calling method is not null.
        /// </summary>
        public static T CheckNotNull<T>(this T reference)
        {
            if (reference == null)
                throw new NullReferenceException();
            return reference;
        }

        /// <summary>
        /// Ensure that an object reference passed as a parameter to the calling method is not null.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="reference">Reference to object</param>
        /// <param name="errorMessageTemplate">Template for the exception message should the check fail.</param>
        /// <param name="errorMessageArgs">The arguments to be substituted into the message template.</param>
        /// <returns>The non-null reference that was validated.</returns>
        public static T CheckNotNull<T>(this T reference, string errorMessageTemplate, params object[] errorMessageArgs)
        {
            if (reference == null)
                throw new NullReferenceException(String.Format(errorMessageTemplate, errorMessageArgs));
            return reference;
        }

        public static void CheckArgument(bool expression)
        {
            if (!expression)
                throw new ArgumentException();
        }

        /// <summary>
        /// Ensures the true of an expression involving one or more parameters to a calling method.
        /// </summary>
        /// <param name="expression">Boolean expression</param>
        /// <param name="errorMessage">Exception message to use when check fails.</param>
        public static void CheckArgument(bool expression, object errorMessage)
        {
            if (!expression)
                throw new ArgumentException(errorMessage.ToString());
        }

        public static void CheckArgument(bool expression, string errorMessageTemplate, params object[] errorMessageArgs)
        {
            if (!expression)
                throw new ArgumentException();
        }
    }
}
