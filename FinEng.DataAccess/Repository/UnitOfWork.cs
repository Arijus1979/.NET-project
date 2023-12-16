using FinEng.DataAccess.Data;
using FinEng.DataAccess.Repository.IRepository;

namespace FinEng.DataAccess.Repository;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _db;

    public UnitOfWork(ApplicationDbContext db)
    {
        _db = db;
        ApplicationUser = new ApplicationUserRepository(_db);
        ShoppingCart = new ShoppingCartRepository(_db);
        Category = new CategoryRepository(_db);
        Product = new ProductRepository(_db);
        OrderHeader = new OrderHeaderRepository(_db);
        OrderDetail = new OrderDetailRepository(_db);
    }

    public ICategoryRepository Category { get; }
    public IProductRepository Product { get; }
    public IShoppingCartRepository ShoppingCart { get; }
    public IApplicationUserRepository ApplicationUser { get; }
    public IOrderHeaderRepository OrderHeader { get; }
    public IOrderDetailRepository OrderDetail { get; }

    public void Save()
    {
        _db.SaveChanges();
    }
}