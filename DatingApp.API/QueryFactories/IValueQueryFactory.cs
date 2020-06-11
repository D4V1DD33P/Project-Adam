using System.Collections.Generic;
using DatingApp.API.Models;

namespace DatingApp.API.QueryFactories
{
    public interface IValueQueryFactory
    {
         public IQuery<List<Value>> GetList();
         public IQuery<Value> GetById(int id);
    }
}