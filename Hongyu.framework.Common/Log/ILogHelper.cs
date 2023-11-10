using Hongyu.yu.framework.Extensions.Interfaces;

namespace Hongyu.framework.Common.Log
{
    public interface ILogHelper: IDependency
    {
        public void Info(string message, Exception exception = null);
        public void Warn(string message, Exception exception = null);
        public void Error(string message, Exception exception = null);
    }
}
