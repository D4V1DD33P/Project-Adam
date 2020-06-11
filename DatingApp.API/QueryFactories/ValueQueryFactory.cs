using System.Collections.Generic;
using DatingApp.API.Data;
using DatingApp.API.Models;

namespace DatingApp.API.QueryFactories
{
    public class ValueQueryFactory : IValueQueryFactory
    {
        private readonly DataContext context;
        public ValueQueryFactory(DataContext context)
        {
            this.context = context;

        }
        public IQuery<Value> GetById(int id)
        {
            return new GetByIdQuery(this.context, id);
        }

        public IQuery<List<Value>> GetList()
        {

            return new GetListQuery(this.context); 
        }
    }
}