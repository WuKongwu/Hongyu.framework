using Hongyu.yu.framework.Middlewares;

namespace Hongyu.framework.Middlewares
{
    public static class MiddlewareHelpers
    {  
        /// <summary>
       /// 请求响应中间件
       /// </summary>
       /// <param name="app"></param>
       /// <returns></returns>
        public static IApplicationBuilder UseRequRespLogMiddle(this IApplicationBuilder app)
        {
            return app.UseMiddleware<RequRespLogMiddleware>();
        }
        /// <summary>
         /// 依赖注入自动注入
         /// </summary>
         /// <param name="app"></param>
         /// <returns></returns>
        public static IApplicationBuilder UseAutoRegisterMiddle(this IApplicationBuilder app)
        {
            return app.UseMiddleware<AutoRegisterMiddleware>();
        }
    }
}
