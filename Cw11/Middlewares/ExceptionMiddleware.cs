﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Cw11.Middlewares {
    public class ExceptionMiddleware {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next) {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context) {
            try {
                await _next(context);
            } catch (Exception exc) {
                await HandleExceptionAsync(context, exc);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exc) {
            context.Response.ContentType = "application/json";

            switch (exc) {
                default:
                    context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                    return context.Response.WriteAsync(new ErrorDetail {
                        StatusCode = StatusCodes.Status500InternalServerError,
                        Message = "Wystąpił błąd..." + exc.Message
                    }.ToString());
            }
        }
    }

    internal class ErrorDetail {
        public int StatusCode { get; set; }
        public string Message { get; set; }

        public override string ToString() {
            return JsonConvert.SerializeObject(this);
        }
    }
}