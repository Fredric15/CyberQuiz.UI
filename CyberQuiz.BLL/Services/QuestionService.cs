using System;
using System.Collections.Generic;
using System.Text;

namespace CyberQuiz.BLL.Services
{
    //public class QuestionService : IQuestionService
    //{
    //    // !!ändrar till rätt databas context senare
    //    //private readonly CyberQuizDbContext _context;

    //    public QuestionService(CyberQuizDbContext context)
    //    {
    //        _context = context;
    //    }

    //    // funkar senare när jag har fått entities från DAL
    //    public async Task<IEnumerable<Question>> GetQuestionsBySubCategoryId(int subCategoryId)
    //    {
    //        return await _context.Questions
    //            .Where(q => q.SubCategoryId == subCategoryId)
    //            .Include(q => q.AnswerOptions)
    //            .ToListAsync();
    //    }
    //}
}
