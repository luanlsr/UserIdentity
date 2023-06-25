using FluentValidation;
using System.Net;
using UsersApp.API.Models;
using UsersApp.Domain.Exceptions.Auth;
using UsersApp.Domain.Exceptions.User;

namespace UsersApp.API.Middlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate? _next;

        public ExceptionMiddleware(RequestDelegate? next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (EmailAllReadyExistsException e)
            {
                await HandleExceptionAsync(context, e);
            }
            catch (DeniedAccessException e)
            {
                await HandleExceptionAsync(context, e);
            }
            catch (UserNotFoundException e)
            {
                await HandleExceptionAsync(context, e);
            }
            catch (NoRegistredUserException e)
            {
                await HandleExceptionAsync(context, e);
            }
            catch (ValidationException e)
            {
                await HandleExceptionAsync(context, e);
            }
            catch (Exception e)
            {
                await HandleExceptionAsync(context, e);
            }
        }
        public async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {

            context.Response.StatusCode = exception switch
            {
                EmailAllReadyExistsException => (int)HttpStatusCode.BadRequest,
                DeniedAccessException => (int)HttpStatusCode.Unauthorized,
                UserNotFoundException => (int)HttpStatusCode.NotFound,
                _ => (int)HttpStatusCode.InternalServerError
            };

            context.Response.ContentType = "application/json";

            var model = new ErrorViewModel();
            model.StatusCode = context.Response.StatusCode;
            model.Message = exception.Message;

            await context.Response.WriteAsync(model.ToString());
        }
    }
}
