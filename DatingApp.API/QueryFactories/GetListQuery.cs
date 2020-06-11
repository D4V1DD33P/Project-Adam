using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.QueryFactories
{
    public class GetListQuery : IQuery<List<Value>>
    {
        private readonly DataContext context;

        public GetListQuery(DataContext context)
        {
            this.context = context;

        }

        public async Task<List<Value>> ExecuteAsync()
        {
            var valueList = await this.context.Values.ToListAsync(); 
            return valueList; 
         }
    }
}