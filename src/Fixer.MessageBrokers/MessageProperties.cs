using System;
using System.Collections.Generic;
using System.Text;

namespace Fixer.MessageBrokers
{
    public class MessageProperties : IMessageProperties
    {
        public string MessageId { get; set; }
        public string CorrelationId { get; set; }
        public long Timestamp { get; set; }
    }
}
