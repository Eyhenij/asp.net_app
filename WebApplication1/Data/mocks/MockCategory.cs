using WebApplication1.Data.Interfaces;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.mocks;

public class MockCategory : ICarsCategory
{
    public IEnumerable<Category> AllCategories
    {
        get
        {
            return new List<Category>
            {
                new Category
                {
                    categoryName = "ElectroCars",
                    desc = "Description for ElectroCars category",
                },
                
                new Category
                {
                    categoryName = "ClassicCars",
                    desc = "Description for ClassicCars category",
                }
            };
        }
    }
}