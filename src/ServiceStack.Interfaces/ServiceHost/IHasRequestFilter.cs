﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceStack.ServiceHost
{
    /// <summary>
    /// This interface can be implemented by an attribute
    /// which adds an request filter for the specific request DTO the attribute marked.
    /// </summary>
    public interface IHasRequestFilter
    {
        /// <summary>
        /// The request filter is executed before the service.
        /// </summary>
        /// <param name="req">The http request wrapper</param>
        /// <param name="res">The http response wrapper</param>
        /// <param name="requestDto">The request DTO</param>
        void RequestFilter(IHttpRequest req, IHttpResponse res, object requestDto);
    }
}
