// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Runtime.Serialization;

namespace Microsoft.Azure.Devices.Common.Exceptions
{
    /// <summary>
    /// The exception that is thrown when the rate of incoming requests exceeds the throttling limit set by IoT Hub.
    /// </summary>
    [Serializable]
    public sealed class IotHubThrottledException : IotHubException
    {
        /// <summary>
        /// Creates an instance of <see cref="IotHubThrottledException"/> with the value of the
        /// maximum allowed count of active requests and marks it as non-transient.
        /// </summary>
        /// <param name="maximumBatchCount">The maximum allowed count of active requests.</param>
        public IotHubThrottledException(int maximumBatchCount)
            : this($"Device Container has exceeded maximum number of allowed active requests: {maximumBatchCount}.")
        {
        }

        /// <summary>
        /// Creates an instance of <see cref="IotHubThrottledException"/> with a specified error message and
        /// a reference to the inner exception that caused this exception, and marks it as non-transient.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        /// <param name="innerException">The exception that is the cause of the current exception.</param>
        public IotHubThrottledException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        internal IotHubThrottledException()
            : base()
        {
        }

        internal IotHubThrottledException(string message)
            : base(message)
        {
        }

        private IotHubThrottledException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
