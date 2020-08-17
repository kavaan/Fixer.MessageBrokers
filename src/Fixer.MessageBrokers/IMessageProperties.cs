using System;
using System.Collections.Generic;
using System.Text;

namespace Fixer.MessageBrokers
{
    public interface IMessageProperties
    {
        string MessageId { get; }
        string CorrelationId { get; }
        long Timestamp { get; }
    }
}
