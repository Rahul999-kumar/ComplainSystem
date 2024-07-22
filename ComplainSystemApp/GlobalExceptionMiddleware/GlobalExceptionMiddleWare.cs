using ComplainSystem.Application.BusinessModels;
using System.Net;

namespace ComplainSystemApp.GlobalExceptionMiddleware
{
    public class GlobalExceptionMiddleWare
    {
        //Request delegate is use in global exception handling in .net core. RequestDelegate hold the reference the next request.
        private readonly RequestDelegate _next;

        //IWebHostEnvironment is use to check and paas the environment weather its is development or production. we can customize it as per our environment.
        private readonly IWebHostEnvironment _env;

        public GlobalExceptionMiddleWare(RequestDelegate next, IWebHostEnvironment env )
        {
            _next = next;
            _env = env;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {

                var response = context.Response;
                response.ContentType = "application/json";
                response.StatusCode = (Int32)HttpStatusCode.InternalServerError;
                ProblemDetails probleDetails = GetProblemDetails(ex);
                await response.WriteAsync(probleDetails.ToString());
            }
        }

        private ProblemDetails GetProblemDetails(Exception ex)
        {
            var traceID = Guid.NewGuid().ToString();
            if (_env.EnvironmentName == "Development")
            {
                return new ProblemDetails
                {
                    statusCode = (Int32)HttpStatusCode.InternalServerError,
                    title = ex.Message.ToString(),
                    message = ex.Message,
                    details = ex.Message.ToString(),
                    instance = traceID

                };
            }
            else
            {
                return new ProblemDetails
                {
                    statusCode = (Int32)HttpStatusCode.InternalServerError,
                    message = ex.Message,
                    title = "something went wrong",
                    details = @"we apologize for the inconvenince. Please let us know about the error at rahul999.kumar@gmail.com include instance id: {instance} in email.",
                    instance = traceID

                };
            }
        }
    }
}
