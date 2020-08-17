using System;
using System.Collections.Generic;
using System.Text;

namespace Fixer.MessageBrokers
{
    public interface IMessagePropertiesAccessor
    {
        IMessageProperties MessageProperties { get; set; }
    }
}
