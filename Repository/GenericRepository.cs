using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_PlakDükkanı.Context;

namespace WFA_PlakDükkanı.Repository
{
    public class GenericRepository<TEntity> where TEntity : class, new()
    {
        public AppDbContext context;

        public GenericRepository()
        {
            context = new AppDbContext();
        }

        public List<TEntity> GetAll()
        {
            return context.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            try
            {
                return context.Set<TEntity>().Find(id);
            }
            catch (Exception)
            {
                throw new Exception("Kayıt bulunamadı");
            }
        }

        public int RepAdd(TEntity entity)
        {
            try
            {
                context.Set<TEntity>().Add(entity);
                return context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Ekleme işlemi başarısız oldu");
            }
        }

        public int RepUpdate(TEntity entity)
        {
            try
            {
                context.Set<TEntity>().Update(entity);
                return context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Güncelleme işlemi başarısız oldu");
            }
        }

        public int RepUpdateByID(int id)
        {
            {
                try
                {
                    context.Set<TEntity>().Update(context.Set<TEntity>().Find(id));
                    return context.SaveChanges();
                }
                catch (Exception)
                {
                    throw new Exception("Güncelleme işlemi başarısız oldu");
                }
            }
        }

        public int RepDelete(TEntity entity)
        {
            try
            {
                context.Set<TEntity>().Remove(entity);
                return context.SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Silinemedi");
            }
        }

        public int RepDeleteByID(int id)
        {
            try
            {
                TEntity entity = context.Set<TEntity>().Find(id);
                context.Set<TEntity>().Remove(entity);
                return context.SaveChanges();
            }
            catch
            {
                throw new Exception("Silemedik");
            }
        }
    }
}
