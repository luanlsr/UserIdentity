using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersApp.Domain.Interfaces.Repositories;
using UsersApp.Infra.Data.Contexts;

namespace UsersApp.Infra.Data.Repositories
{
    public class BaseRepository<TModel, TKey> : IBaseRepository<TModel, TKey>
        where TModel : class
    {
        private readonly DataContext? _dataContext;

        public BaseRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Add(TModel model)
        {
            _dataContext?.Add(model);
        }

        public void Update(TModel model)
        {
            _dataContext?.Update(model);
        }

        public void Delete(TModel model)
        {
            _dataContext?.Remove(model);
        }

        public virtual List<TModel> GetAll()
        {
            return _dataContext?.Set<TModel>().ToList();
        }

        public virtual List<TModel> GetAll(Func<TModel, bool> where)
        {
            return _dataContext?.Set<TModel>().Where(where).ToList();
        }

        public virtual TModel Get(Func<TModel, bool> where)
        {
            return _dataContext?.Set<TModel>().FirstOrDefault(where);
        }

        public virtual TModel GetById(TKey id)
        {
            return _dataContext?.Set<TModel>().Find(id);
        }

        public void Dispose()
        {
            _dataContext?.Dispose();
        }
    }
}
