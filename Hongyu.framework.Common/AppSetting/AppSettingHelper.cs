using Microsoft.Extensions.Configuration;

namespace Hongyu.framework.Common.AppSetting
{
    public static class AppSettingHelper
    {
        private static IConfiguration _configuration;

        public static void Initialize(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public static string GetValueByKey(string key)
        {
            if (_configuration == null)
            {
                throw new InvalidOperationException("You must call Initialize() method first.");
            }

            return _configuration.GetSection(key).Value;
        }
    }
}
