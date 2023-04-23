using WebApplication1.Data.Models;

namespace WebApplication1.Data.Interfaces;

public interface ICarsCategory
{
    IEnumerable<Category> AllCategories { get; }
}