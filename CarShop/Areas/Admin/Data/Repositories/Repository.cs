using CarShop.Areas.Admin.Data;
using CarShop.Areas.Admin.Data.Entities;
using CarShop.Areas.Admin.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CarShop.Areas.Admin.Data.Repositories;
public class Repository<TEntity>(AppDbContext dbContext)
    : IRepository<TEntity> where TEntity : BaseEntity
{
    protected readonly AppDbContext dbContext = dbContext;
    private readonly DbSet<TEntity> _dbSet = dbContext.Set<TEntity>();

    public void Add(TEntity entity)
    {
        _dbSet.Add(entity);
        dbContext.SaveChanges();
    }

    public void Delete(int id)
    {
        var entity = _dbSet.FirstOrDefault(e => e.Id == id);
        _dbSet.Remove(entity);
        dbContext.SaveChanges();
    }

    public List<TEntity> GetAll()
    {
        var list = _dbSet.ToList();
        return list;
    }

    public TEntity GetById(int id)
    {
        var entity = _dbSet.FirstOrDefault(e => e.Id == id);
        return entity;
    }

    public void Update(TEntity entity)
    {
        _dbSet.Update(entity);
        dbContext.SaveChanges();
    }
}
