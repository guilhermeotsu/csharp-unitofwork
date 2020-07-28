namespace RepositoryPattern.Data
{
  public interface IUnitOfWork
  {
    void Commit();
    void Rollback();
  }
  public class UnitOfWork : IUnitOfWork
  {
    public readonly DataContext _context;
    public UnitOfWork(DataContext context)
    {
      _context = context;
    }
    public void Commit()
    {
      _context.SaveChanges();
    }

    public void Rollback()
    {
      // Nao fazer nada caso de erro
    }
  }
}