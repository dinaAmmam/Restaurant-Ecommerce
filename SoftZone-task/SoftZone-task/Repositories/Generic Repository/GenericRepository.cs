using SoftZone_task.Data;

namespace SoftZone_task.Repositories.Generic_Repository;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
{
    private protected readonly SoftZoneDBContext _context;
    public GenericRepository(SoftZoneDBContext context)
    {
        _context = context;
    }
    
    public void Create(TEntity entity)
    {
        _context.Set<TEntity>().Add(entity);
    }
    public List<TEntity> GetAll()
    {
        return _context.Set<TEntity>().ToList();
    }
    public TEntity GetById(int id)
    {
        return _context.Set<TEntity>().Find(id);
    }
    public int SaveChanges()
    {
        return _context.SaveChanges();
    }
    public void Update(TEntity entity)
    {
        _context.Update(entity);
    }
    public void Delete(int id)
    {
        var entityToDelete=GetById(id);
        if (entityToDelete != null)
        {
            _context.Set<TEntity>().Remove(entityToDelete);
        }
    }
}