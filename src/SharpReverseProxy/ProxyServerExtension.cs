﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Options;

namespace SharpReverseProxy {
    public static class ProxyExtension {

        /// <summary>
        /// Sends request to remote server as specified in options
        /// </summary>
        /// <param name="app"></param>
        /// <param name="proxyOptions">Options and rules for proxy actions</param>
        /// <returns></returns>
        public static IApplicationBuilder UseProxy(this IApplicationBuilder app, ProxyOptions proxyOptions) {
            return app.UseMiddleware<ProxyMiddleware>(Options.Create(proxyOptions));
        }
    }
}
