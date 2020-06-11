using DatingApp.API.Data;

namespace DatingApp.API
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext context;
        public UnitOfWork(DataContext context)
        {
            this.context = context;

        }

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }
    }
}