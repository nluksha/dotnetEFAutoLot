using DotNetEFAutoLot.DAL.EF;
using DotNetEFAutoLot.DAL.Models.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetEFAutoLot.DAL.Repositories
{
    public class BaseRepository<T> : IDisposable, IRepository<T> where T : EntityBase, new()
    {
        private readonly DbSet<T> table;
        private readonly AutoLotEntities db;
        private bool disposedValue;

        protected AutoLotEntities Context => db;

        public BaseRepository()
        {
            db = new AutoLotEntities();
            table = db.Set<T>();
        }

        public int Add(T entity)
        {
            throw new NotImplementedException();
        }

        public int AddRange(IList<T> entities)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id, byte[] timeStamp)
        {
            throw new NotImplementedException();
        }

        public int Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public List<T> ExecuteQuery(string sql)
        {
            throw new NotImplementedException();
        }

        public List<T> ExecuteQuery(string sql, object[] sqlParametersObjects)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetOne(int? id)
        {
            throw new NotImplementedException();
        }

        public int Save(T entity)
        {
            throw new NotImplementedException();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    db.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        ~BaseRepository()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
