﻿using System;
using System.Net;

namespace Intercom.Exceptions
{
    public class ClientException<T> : Exception
    {
        private static string ClientName => $"{typeof(T).Name}";

        /// <summary>
        /// The HTTP status code([RFC7231], Section 6) generated by the origin server for this occurrence of the problem.
        /// </summary>
        public virtual HttpStatusCode StatusCode { get; set; }
        public object Details { get; set; }

        public ClientException(string message)
            : base($"{message} (Client='{ClientName}')")
        {
        }

        public ClientException(string message, Exception ex)
            : base($"{message} (Client='{ClientName}')", ex)
        {
        }

        public ClientException(string message, object details)
            : base($"{message} (Client='{ClientName}')")
        {
            Details = details;
        }

        public ClientException(string message, int? status, object details)
            : base($"{message} (Client='{ClientName}')")
        {
            Details = details;
            StatusCode = status != null ? (HttpStatusCode)status : HttpStatusCode.InternalServerError;
        }
    }
}
