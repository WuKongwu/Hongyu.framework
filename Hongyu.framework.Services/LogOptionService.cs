using Hongyu.framework.Application.Interfaces;
using Hongyu.framework.Common.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hongyu.framework.Application
{
    public class LogOptionService: ILogOptionService
    {
        private readonly ILogHelper _logHelper;

        public LogOptionService(ILogHelper logHelper)
        {
            _logHelper = logHelper; 
        }

        public void LogInfo(string msg)
        {
            _logHelper.Info(msg);   
        }
    }
}
