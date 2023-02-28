using PokemonReviewApp.Models;

namespace PokemonReviewApp.interfaces
{
    public interface ICategory
    {
        ICollection<Category> GetCategories();
        Category GetCategory(int id);
        ICollection<Pokemon> GetPokemonByCategory(int categoryId);
        bool CategoriesExists(int Id);
    }
}
