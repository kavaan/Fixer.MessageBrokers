using System;
using System.Collections.Generic;
using System.Text;

namespace Fixer.MessageBrokers
{
    public interface ICorrelationContextAccessor
    {
        object CorrelationContext { get; set; }
    }
}
