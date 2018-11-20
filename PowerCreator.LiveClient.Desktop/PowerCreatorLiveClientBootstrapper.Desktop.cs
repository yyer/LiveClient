﻿using Microsoft.Practices.Prism.Logging;
using PowerCreator.LiveClient.Log;

namespace PowerCreator.LiveClient.Desktop
{
    public partial class Bootstrapper
    {
        private readonly LoggerAdapter _logger = new LoggerAdapter();

        protected override ILoggerFacade CreateLogger()
        {
            return _logger;
        }
    }
}
