﻿using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace OvOv.Serilog.Filter
{
    public class MvcGlobalExceptionFilter : IExceptionFilter
    {
        private readonly ILogger _logger;

        public MvcGlobalExceptionFilter(ILoggerFactory logger)
        {
            _logger = logger.CreateLogger("MvcGlobalExceptionFilter");
        }

        public void OnException(ExceptionContext context)
        {
            // 全局异常的错误处理
            _logger.LogInformation("test");
            _logger.LogError(context.Exception, "全局异常");
        }
    }
}
