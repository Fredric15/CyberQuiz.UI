using CyberQuiz.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CyberQuiz.BLL.Services.Interfaces
{
    public interface IProgressService
    {

        Task<UserProgressModel?> GetSubCategoryProgress(string userId, int subCategoryId);
        Task<IReadOnlyList<UserProgressModel>> GetProgressForUser(string userId);
        Task<UserProgressModel> UpsertProgress(string userId, int subCategoryId, double scorePercentage, bool isPassed);
    }
}
