using Newtonsoft.Json;

namespace Hongyu.yu.framework.Middlewares
{
    public class RequRespLogMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<RequRespLogMiddleware> _logger;
        public RequRespLogMiddleware(RequestDelegate next, ILogger<RequRespLogMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var request = await FormatRequest(context.Request);

            _logger.LogInformation(request);

            var originalBodyStream = context.Response.Body;

            using (var responseBody = new MemoryStream())
            {
                context.Response.Body = responseBody;

                await _next(context);

                var response = await FormatResponse(context.Response);

                _logger.LogInformation(response);
                 await responseBody.CopyToAsync(originalBodyStream);
            }
        }

        private async Task<string> FormatRequest(HttpRequest request)
        {
            request.EnableBuffering();

            var body = await new StreamReader(request.Body).ReadToEndAsync();
            var formattedBody = FormatJson(body);

            request.Body.Position = 0;

            return $"Request: {request.Scheme} {request.Host}{request.Path} {request.QueryString} {formattedBody}";
        }

        private async Task<string> FormatResponse(HttpResponse response)
        {
            response.Body.Seek(0, SeekOrigin.Begin);

            var body = await new StreamReader(response.Body).ReadToEndAsync();
            var formattedBody = FormatJson(body);

            response.Body.Seek(0, SeekOrigin.Begin);

            return $"Response: {response.StatusCode}: {formattedBody}";
        }

        private string FormatJson(string json)
        {
            if (string.IsNullOrEmpty(json))
            {
                return string.Empty;
            }

            try
            {
                var obj = JsonConvert.DeserializeObject(json);
                return JsonConvert.SerializeObject(obj);
            }
            catch
            {
                return json;
            }
        }
    }
}
