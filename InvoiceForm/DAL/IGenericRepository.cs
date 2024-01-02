namespace InvoiceForm.DAL
{
    public interface IGenericRepository<TEntity> : IDisposable
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(decimal id);
        IEnumerable<TEntity> GetWithPredicate(Func<TEntity, bool> predicate);
        void Add(TEntity entity);
        void Delete(decimal entityId);
        void Update(TEntity entity);
        void Save();
    }
}
