//this class is supposed to be named ShoppingDatabase, but it's not letting me rename it. 
using Microsoft.EntityFrameworkCore;

public class ShoppingDatabase : DbContext
{

  public ShoppingDatabase(DbContextOptions<ShoppingDatabase> options) : base(options)
  {

  }

  public virtual DbSet<ShoppingListItem> ShoppingListItems { get; set; }
}
