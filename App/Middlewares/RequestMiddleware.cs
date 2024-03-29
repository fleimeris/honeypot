using App.Context.Models;
using AppContext = App.Context.AppContext;

namespace App.Middlewares;

public class RequestMiddleware
{
    private readonly RequestDelegate _next;

    public RequestMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        var appContext = context.RequestServices.GetRequiredService<AppContext>();
        var request = context.Request;
        request.EnableBuffering();

        string? body = null;
        if (request.ContentLength is > 0)
        {
            try
            {
                body = await new StreamReader(request.Body).ReadToEndAsync();
            }
            catch
            {
                // ignored
            }
        }

        string? ip = null;
        if (request.Headers.TryGetValue("X-Forwarded-For", out var header))
            ip = header;
        else if (request.Headers.TryGetValue("X-Real-Ip", out var requestHeader))
            ip = requestHeader;

        var entity = new Inquiry
        {
            Id = Guid.NewGuid(),
            UserAgent = request.Headers.UserAgent.ToString(),
            Referer = request.Headers.Referer.ToString(),
            HttpMethod = request.Method,
            Endpoint = request.Path,
            Ip = ip,
            Cookies = request.Headers.Cookie.ToString(),
            Host = request.Headers.Host.ToString(),
            Query = request.QueryString.ToString(),
            Body = body,
            DateCaptured = DateTime.UtcNow
        };

        await appContext.AddAsync(entity);
        await appContext.SaveChangesAsync();

        await _next(context);
    }
}