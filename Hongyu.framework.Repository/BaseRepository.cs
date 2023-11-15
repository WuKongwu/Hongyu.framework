using Hongyu.framework.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
//using System.Data.Entity;

namespace Hongyu.framework.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : class, new()
    {
        //protected IUnitOfWork _unitOfWork;
     //   protected IRepository<T> _currentRepository;
        MSSQLDbContext _dbContext;   
        public BaseRepository(/*, IUnitOfWork unitOfWork, IRepository<T> currentRepository*/) {
            _dbContext = new MSSQLDbContext();
            //_unitOfWork = unitOfWork;
            //_currentRepository = currentRepository;
        }
        //public async ValueTask<EntityEntry<T>> Insert(T entity)
        //{
        //    return await _dbContext.Set<T>().AddAsync(entity);
        //}

        //public void Update(T entity)
        //{
        //    _dbContext.Set<T>().Update(entity);
        //}

        //public async Task<int> Update(Expression<Func<T, bool>> where, Expression<Func<T, T>> entity)
        //{
        //    return await _dbContext.Set<T>().Where(where).UpdateAsync(entity);
        //}

        //public async Task<int> Delete(Expression<Func<T, bool>> whereLambda)
        //{
        //    return await _dbContext.Set<T>().Where(whereLambda).DeleteAsync();
        //}
        //public async Task<bool> IsExist(Expression<Func<T, bool>> whereLambda)
        //{
        //    return await _dbContext.Set<T>().AnyAsync(whereLambda);
        //}

        ////public async Task<T> GetEntity(Expression<Func<T, bool>> whereLambda)
        ////{
        ////    return await _dbContext.Set<T>().AsNoTracking().FirstOrDefaultAsync(whereLambda);
        ////}

        public async Task<List<T>> Select()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        //public async Task<List<T>> Select(Expression<Func<T, bool>> whereLambda)
        //{
        //    return await _dbContext.Set<T>().Where(whereLambda).ToListAsync();
        //}

        //public async Task<Tuple<List<T>, int>> Select<S>(int pageSize, int pageIndex, Expression<Func<T, bool>> whereLambda, Expression<Func<T, S>> orderByLambda, bool isAsc)
        //{
        //    var total = await _dbContext.Set<T>().Where(whereLambda).CountAsync();

        //    if (isAsc)
        //    {
        //        var entities = await _dbContext.Set<T>().Where(whereLambda)
        //                              .OrderBy<T, S>(orderByLambda)
        //                              .Skip(pageSize * (pageIndex - 1))
        //                              .Take(pageSize).ToListAsync();

        //        return new Tuple<List<T>, int>(entities, total);
        //    }
        //    else
        //    {
        //        var entities = await _dbContext.Set<T>().Where(whereLambda)
        //                              .OrderByDescending<T, S>(orderByLambda)
        //                              .Skip(pageSize * (pageIndex - 1))
        //                              .Take(pageSize).ToListAsync();

        //        return new Tuple<List<T>, int>(entities, total);
        //    }
        //}

        //public Task<int> Update(Expression<Func<T, bool>> whereLambda, Expression<Func<T, T>> entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<int> Delete(Expression<Func<T, bool>> whereLambda)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<T> GetEntity(Expression<Func<T, bool>> whereLambda)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(T entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<bool> IsExist(Expression<Func<T, bool>> whereLambda)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<List<T>> Select()
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<List<T>> Select(Expression<Func<T, bool>> whereLambda)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<Tuple<List<T>, int>> Select<S>(int pageSize, int pageIndex, Expression<Func<T, bool>> whereLambda, Expression<Func<T, S>> orderByLambda, bool isAsc)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
