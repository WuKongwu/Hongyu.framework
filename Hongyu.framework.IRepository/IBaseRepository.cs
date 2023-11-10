namespace Hongyu.framework.IRepository
{
    public interface IBaseRepository<T> where T : class
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="t"></param>
        void AddEntity(T t);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="t"></param>
        void DeleteEntity(T t);

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="t"></param>
        void UpdateEntity(T t);

        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        IQueryable<T> GetAll();
    }
}
