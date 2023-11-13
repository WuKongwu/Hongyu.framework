using Hongyu.framework.Common.IDependencies;

namespace Hongyu.framework.Common.Log
{
    public interface ILogHelper : IDependency
    {
        public void Info(string message, Exception exception = null);
        public void Warn(string message, Exception exception = null);
        public void Error(string message, Exception exception = null);
    }
}
