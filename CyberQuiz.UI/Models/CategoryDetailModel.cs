namespace CyberQuiz.UI.Models;

public class CategoryDetailModel
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public IEnumerable<SubCategoryModel> SubCategories { get; set; } = [];
}
