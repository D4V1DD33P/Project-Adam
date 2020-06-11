using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.QueryFactories
{
    public class GetByIdQuery : IQuery<Value>
    {
        private readonly DataContext context;
        private readonly int id;

        public GetByIdQuery(DataContext context, int id)
        {
            this.id = id;
            this.context = context;

        }
        public async Task<Value> ExecuteAsync()
        {
            var val = await this.context.Values.FirstOrDefaultAsync(x => x.Id == this.id); 
            return val; 
        }
    }
}