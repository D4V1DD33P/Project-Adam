using System.Linq;
using DatingApp.API.Data;

namespace DatingApp.API.Repositories
{
    public class ValueRepository : IValueRepository
    {
        private readonly DataContext context;
        public ValueRepository(DataContext context)
        {
            this.context = context;

        }
        public void UpdateValue(int id, string name)
        {
            var val = this.context.Values.FirstOrDefault(x => x.Id == id);
            val.Name = name; 
        }
    }
}