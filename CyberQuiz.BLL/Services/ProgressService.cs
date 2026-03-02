using CyberQuiz.BLL.Services.Interfaces;
using CyberQuiz.DAL.Models;
using CyberQuiz.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CyberQuiz.BLL.Services
{
    public class ProgressService : IProgressService
    {
        private readonly IUserProgressRepository _userProgressRepository;

        public ProgressService(IUserProgressRepository userProgressRepository)
        {
            _userProgressRepository = userProgressRepository;
        }

        public async Task<UserProgressModel?> GetSubCategoryProgress(string userId, int subCategoryId)
        {
            var progress = await _userProgressRepository.GetUserProgressByUserIdAsync(userId);
            return progress.FirstOrDefault(p => p.SubCategoryModelId == subCategoryId);
        }

        public async Task<IReadOnlyList<UserProgressModel>> GetProgressForUser(string userId)
        {
            return (await _userProgressRepository.GetUserProgressByUserIdAsync(userId)).ToList();
        }

        public async Task<UserProgressModel> UpsertProgress(string userId, int subCategoryId, double scorePercentage, bool isPassed)
        {
            var existing = await GetSubCategoryProgress(userId, subCategoryId);

            if (existing is null)
            {
                var progress = new UserProgressModel
                {
                    ApplicationUserId = userId,
                    SubCategoryModelId = subCategoryId,
                    IsCompleted = isPassed,
                    UnlockedAt = DateTime.UtcNow
                };

                await _userProgressRepository.AddProgressAsync(progress);
                return progress;
            }

            if (isPassed && !existing.IsCompleted)
            {
                existing.IsCompleted = true;
                existing.UnlockedAt = DateTime.UtcNow;
                await _userProgressRepository.UpdateProgressAsync(existing);
            }

            return existing;
        }
    }

}
