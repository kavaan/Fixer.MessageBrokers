﻿using System;
using System.Threading.Tasks;

namespace Fixer.MessageBrokers
{
    public interface IBusPublisher
    {
        Task PublishAsync<T>(T message, string messageId = null, string correlationId = null,
            object context = null) where T : class;
    }
}
