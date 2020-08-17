using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Fixer.MessageBrokers
{
    public interface IBusSubscriber
    {
        IBusSubscriber Subscribe<T>(Func<IServiceProvider, T, object, Task> handle) where T : class;
    }
}
