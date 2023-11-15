namespace Hongyu.framework.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        //private readonly MSSQLDbContext myDbContext;

        //public UnitOfWork(MSSQLDbContext myDbContext)
        //{
        //    this.myDbContext = myDbContext;
        //}

        //public MSSQLDbContext GetDbContext()
        //{
        //    return myDbContext;
        //}

        //public async Task<int> SaveChangesAsync()
        //{
        //    return await myDbContext.SaveChangesAsync();
        //}
        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
