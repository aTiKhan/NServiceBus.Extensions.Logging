namespace NServiceBus.Extensions.Logging
{
    using NServiceBus.Logging;

    /// <summary>
    /// Configure NServiceBus logging messages to use a logging based on Microsoft.Logging.Extensions.  Use by calling <see cref="LogManager.Use{T}"/> the T is <see cref="NLogFactory"/>.
    /// </summary>
    public class ExtensionLogging<T> : LoggingFactoryDefinition where T : Microsoft.Extensions.Logging.ILoggerFactory, new()
    {
        /// <summary>
        /// <see cref="LoggingFactoryDefinition.GetLoggingFactory"/>.
        /// </summary>
        protected override ILoggerFactory GetLoggingFactory()
        {
            return new ExtensionsLoggerFactory(new T());
        }
    }
}