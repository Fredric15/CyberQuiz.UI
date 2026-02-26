using CyberQuiz.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CyberQuiz.DAL.SeedData
{
    public class OptionConfiguration : IEntityTypeConfiguration<OptionModel>
    {
        public void Configure(EntityTypeBuilder<OptionModel> builder)
        {
            builder.HasData(
                //Alternativ för fråga 1
                new OptionModel { Id = 1, Text = "Option 1", IsCorrect = false, QuestionModelId = 1 },
                new OptionModel { Id = 2, Text = "Rätt", IsCorrect = true, QuestionModelId = 1 },
                new OptionModel { Id = 3, Text = "Option 3", IsCorrect = false, QuestionModelId = 1 },

                //Alternativ för fråga 2
                new OptionModel { Id = 4, Text = "Option 1", IsCorrect = true, QuestionModelId = 2 },
                new OptionModel { Id = 5, Text = "Option 2", IsCorrect = false, QuestionModelId = 2 },
                new OptionModel { Id = 6, Text = "Option 3", IsCorrect = false, QuestionModelId = 2 },

                //Alternativ för fråga 3
                new OptionModel { Id = 7, Text = "Option 1", IsCorrect = false, QuestionModelId = 3 },
                new OptionModel { Id = 8, Text = "Option 2", IsCorrect = false, QuestionModelId = 3 },
                new OptionModel { Id = 9, Text = "Rätt", IsCorrect = true, QuestionModelId = 3 },

                //Alternativ för fråga 4
                new OptionModel { Id = 10, Text = "Option 1", IsCorrect = false, QuestionModelId = 4 },
                new OptionModel { Id = 11, Text = "Rätt", IsCorrect = true, QuestionModelId = 4 },
                new OptionModel { Id = 12, Text = "Option 3", IsCorrect = false, QuestionModelId = 4 },

                //Alternativ för fråga 5
                new OptionModel { Id = 13, Text = "Option 1", IsCorrect = false, QuestionModelId = 5 },
                new OptionModel { Id = 14, Text = "Option 2", IsCorrect = false, QuestionModelId = 5 },
                new OptionModel { Id = 15, Text = "Rätt", IsCorrect = true, QuestionModelId = 5 },

                //Alternativ för fråga 6
                new OptionModel { Id = 16, Text = "Rätt", IsCorrect = true, QuestionModelId = 6 },
                new OptionModel { Id = 17, Text = "Option 2", IsCorrect = false, QuestionModelId = 6 },
                new OptionModel { Id = 18, Text = "Option 3", IsCorrect = false, QuestionModelId = 6 },

                //Alternativ för fråga 7
                new OptionModel { Id = 19, Text = "Option 1", IsCorrect = false, QuestionModelId = 7 },
                new OptionModel { Id = 20, Text = "Option 2", IsCorrect = false, QuestionModelId = 7 },
                new OptionModel { Id = 21, Text = "Rätt", IsCorrect = true, QuestionModelId = 7 },

                //Alternativ för fråga 8
                new OptionModel { Id = 22, Text = "Option 1", IsCorrect = false, QuestionModelId = 8 },
                new OptionModel { Id = 23, Text = "Rätt", IsCorrect = true, QuestionModelId = 8 },
                new OptionModel { Id = 24, Text = "Option 3", IsCorrect = false, QuestionModelId = 8 },

                //Alternativ för fråga 9
                new OptionModel { Id = 25, Text = "Option 1", IsCorrect = false, QuestionModelId = 9 },
                new OptionModel { Id = 26, Text = "Rätt", IsCorrect = true, QuestionModelId = 9 },
                new OptionModel { Id = 27, Text = "Option 3", IsCorrect = false, QuestionModelId = 9 },

                //Alternativ för fråga 10
                new OptionModel { Id = 28, Text = "Rätt", IsCorrect = true, QuestionModelId = 10 },
                new OptionModel { Id = 29, Text = "Option 2", IsCorrect = false, QuestionModelId = 10 },
                new OptionModel { Id = 30, Text = "Option 3", IsCorrect = false, QuestionModelId = 10 },

                //Alternativ för fråga 11
                new OptionModel { Id = 31, Text = "Option 1", IsCorrect = false, QuestionModelId = 11 },
                new OptionModel { Id = 32, Text = "Rätt", IsCorrect = true, QuestionModelId = 11 },
                new OptionModel { Id = 33, Text = "Option 3", IsCorrect = false, QuestionModelId = 11 },

                //Alternativ för fråga 12
                new OptionModel { Id = 34, Text = "Option 1", IsCorrect = false, QuestionModelId = 12 },
                new OptionModel { Id = 35, Text = "Option 2", IsCorrect = false, QuestionModelId = 12 },
                new OptionModel { Id = 36, Text = "Rätt", IsCorrect = true, QuestionModelId = 12 },

                //Alternativ för fråga 13
                new OptionModel { Id = 37, Text = "Option 1", IsCorrect = false, QuestionModelId = 13 },
                new OptionModel { Id = 38, Text = "Rätt", IsCorrect = true, QuestionModelId = 13 },
                new OptionModel { Id = 39, Text = "Option 3", IsCorrect = false, QuestionModelId = 13 },

                //Alternativ för fråga 14
                new OptionModel { Id = 40, Text = "Rätt", IsCorrect = true, QuestionModelId = 14 },
                new OptionModel { Id = 41, Text = "Option 2", IsCorrect = false, QuestionModelId = 14 },
                new OptionModel { Id = 42, Text = "Option 3", IsCorrect = false, QuestionModelId = 14 },

                //Alternativ för fråga 15
                new OptionModel { Id = 43, Text = "Option 1", IsCorrect = false, QuestionModelId = 15 },
                new OptionModel { Id = 44, Text = "Option 2", IsCorrect = false, QuestionModelId = 15 },
                new OptionModel { Id = 45, Text = "Rätt", IsCorrect = true, QuestionModelId = 15 },

                //Alternativ för fråga 16
                new OptionModel { Id = 46, Text = "Option 1", IsCorrect = false, QuestionModelId = 16 },
                new OptionModel { Id = 47, Text = "Rätt", IsCorrect = true, QuestionModelId = 16 },
                new OptionModel { Id = 48, Text = "Option 3", IsCorrect = false, QuestionModelId = 16 },

                //Alternativ för fråga 17
                new OptionModel { Id = 49, Text = "Option 1", IsCorrect = false, QuestionModelId = 17 },
                new OptionModel { Id = 50, Text = "Option 2", IsCorrect = false, QuestionModelId = 17 },
                new OptionModel { Id = 51, Text = "Rätt", IsCorrect = true, QuestionModelId = 17 },

                //Alternativ för fråga 18
                new OptionModel { Id = 52, Text = "Rätt", IsCorrect = true, QuestionModelId = 18 },
                new OptionModel { Id = 53, Text = "Option 2", IsCorrect = false, QuestionModelId = 18 },
                new OptionModel { Id = 54, Text = "Option 3", IsCorrect = false, QuestionModelId = 18 },

                //Alternativ för fråga 19
                new OptionModel { Id = 55, Text = "Option 1", IsCorrect = false, QuestionModelId = 19 },
                new OptionModel { Id = 56, Text = "Rätt", IsCorrect = true, QuestionModelId = 19 },
                new OptionModel { Id = 57, Text = "Option 3", IsCorrect = false, QuestionModelId = 19 },

                //Alternativ för fråga 20
                new OptionModel { Id = 58, Text = "Option 1", IsCorrect = false, QuestionModelId = 20 },
                new OptionModel { Id = 59, Text = "Option 2", IsCorrect = false, QuestionModelId = 20 },
                new OptionModel { Id = 60, Text = "Rätt", IsCorrect = true, QuestionModelId = 20 },

                //Alternativ för fråga 21
                new OptionModel { Id = 61, Text = "Rätt", IsCorrect = true, QuestionModelId = 21 },
                new OptionModel { Id = 62, Text = "Option 2", IsCorrect = false, QuestionModelId = 21 },
                new OptionModel { Id = 63, Text = "Option 3", IsCorrect = false, QuestionModelId = 21 },

                //Alternativ för fråga 22
                new OptionModel { Id = 64, Text = "Option 1", IsCorrect = false, QuestionModelId = 22 },
                new OptionModel { Id = 65, Text = "Option 2", IsCorrect = false, QuestionModelId = 22 },
                new OptionModel { Id = 66, Text = "Rätt", IsCorrect = true, QuestionModelId = 22 },

                //Alternativ för fråga 23
                new OptionModel { Id = 67, Text = "Option 1", IsCorrect = false, QuestionModelId = 23 },
                new OptionModel { Id = 68, Text = "Rätt", IsCorrect = true, QuestionModelId = 23 },
                new OptionModel { Id = 69, Text = "Option 3", IsCorrect = false, QuestionModelId = 23 },

                //Alternativ för fråga 24
                new OptionModel { Id = 70, Text = "Option 1", IsCorrect = false, QuestionModelId = 24 },
                new OptionModel { Id = 71, Text = "Rätt", IsCorrect = true, QuestionModelId = 24 },
                new OptionModel { Id = 72, Text = "Option 3", IsCorrect = false, QuestionModelId = 24 },

                //Alternativ för fråga 25
                new OptionModel { Id = 73, Text = "Option 1", IsCorrect = false, QuestionModelId = 25 },
                new OptionModel { Id = 74, Text = "Rätt", IsCorrect = true, QuestionModelId = 25 },
                new OptionModel { Id = 75, Text = "Option 3", IsCorrect = false, QuestionModelId = 25 },

                //Alternativ för fråga 26
                new OptionModel { Id = 76, Text = "Option 1", IsCorrect = false, QuestionModelId = 26 },
                new OptionModel { Id = 77, Text = "Option 2", IsCorrect = false, QuestionModelId = 26 },
                new OptionModel { Id = 78, Text = "Rätt", IsCorrect = true, QuestionModelId = 26 },

                //Alternativ för fråga 27
                new OptionModel { Id = 79, Text = "Rätt", IsCorrect = true, QuestionModelId = 27 },
                new OptionModel { Id = 80, Text = "Option 2", IsCorrect = false, QuestionModelId = 27 },
                new OptionModel { Id = 81, Text = "Option 3", IsCorrect = false, QuestionModelId = 27 },

                //Alternativ för fråga 28
                new OptionModel { Id = 82, Text = "Option 1", IsCorrect = false, QuestionModelId = 28 },
                new OptionModel { Id = 83, Text = "Option 2", IsCorrect = false, QuestionModelId = 28 },
                new OptionModel { Id = 84, Text = "Rätt", IsCorrect = true, QuestionModelId = 28 },

                //Alternativ för fråga 29
                new OptionModel { Id = 85, Text = "Option 1", IsCorrect = false, QuestionModelId = 29 },
                new OptionModel { Id = 86, Text = "Rätt", IsCorrect = true, QuestionModelId = 29 },
                new OptionModel { Id = 87, Text = "Option 3", IsCorrect = false, QuestionModelId = 29 },
                
                //Alternativ för fråga 30
                new OptionModel { Id = 88, Text = "Option 1", IsCorrect = false, QuestionModelId = 30 },
                new OptionModel { Id = 89, Text = "Rätt", IsCorrect = true, QuestionModelId = 30 },
                new OptionModel { Id = 90, Text = "Option 3", IsCorrect = false, QuestionModelId = 30 },

                //Alternativ för fråga 31
                new OptionModel { Id = 91, Text = "Option 1", IsCorrect = false, QuestionModelId = 31 },
                new OptionModel { Id = 92, Text = "Rätt", IsCorrect = true, QuestionModelId = 31 },
                new OptionModel { Id = 93, Text = "Option 3", IsCorrect = false, QuestionModelId = 31 },

                //Alternativ för fråga 32
                new OptionModel { Id = 94, Text = "Option 1", IsCorrect = false, QuestionModelId = 32 },
                new OptionModel { Id = 95, Text = "Option 2", IsCorrect = false, QuestionModelId = 32 },
                new OptionModel { Id = 96, Text = "Rätt", IsCorrect = true, QuestionModelId = 32 },

                //Alternativ för fråga 33
                new OptionModel { Id = 97, Text = "Rätt", IsCorrect = true, QuestionModelId = 33 },
                new OptionModel { Id = 98, Text = "Option 2", IsCorrect = false, QuestionModelId = 33 },
                new OptionModel { Id = 99, Text = "Option 3", IsCorrect = false, QuestionModelId = 33 },

                //Alternativ för fråga 34
                new OptionModel { Id = 100, Text = "Option 1", IsCorrect = false, QuestionModelId = 34 },
                new OptionModel { Id = 101, Text = "Option 2", IsCorrect = false, QuestionModelId = 34 },
                new OptionModel { Id = 102, Text = "Rätt", IsCorrect = true, QuestionModelId = 34 },

                //Alternativ för fråga 35
                new OptionModel { Id = 103, Text = "Option 1", IsCorrect = false, QuestionModelId = 35 },
                new OptionModel { Id = 104, Text = "Rätt", IsCorrect = true, QuestionModelId = 35 },
                new OptionModel { Id = 105, Text = "Option 3", IsCorrect = false, QuestionModelId = 35 },

                //Alternativ för fråga 36
                new OptionModel { Id = 106, Text = "Option 1", IsCorrect = false, QuestionModelId = 36 },
                new OptionModel { Id = 107, Text = "Option 2", IsCorrect = false, QuestionModelId = 36 },
                new OptionModel { Id = 108, Text = "Rätt", IsCorrect = true, QuestionModelId = 36 },

                //Alternativ för fråga 37
                new OptionModel { Id = 109, Text = "Option 1", IsCorrect = false, QuestionModelId = 37 },
                new OptionModel { Id = 110, Text = "Rätt", IsCorrect = true, QuestionModelId = 37 },
                new OptionModel { Id = 111, Text = "Option 3", IsCorrect = false, QuestionModelId = 37 },

                //Alternativ för fråga 38
                new OptionModel { Id = 112, Text = "Rätt", IsCorrect = true, QuestionModelId = 38 },
                new OptionModel { Id = 113, Text = "Option 2", IsCorrect = false, QuestionModelId = 38 },
                new OptionModel { Id = 114, Text = "Option 3", IsCorrect = false, QuestionModelId = 38 },

                //Alternativ för fråga 39
                new OptionModel { Id = 115, Text = "Option 1", IsCorrect = false, QuestionModelId = 39 },
                new OptionModel { Id = 116, Text = "Option 2", IsCorrect = false, QuestionModelId = 39 },
                new OptionModel { Id = 117, Text = "Rätt", IsCorrect = true, QuestionModelId = 39 },

                //Alternativ för fråga 40
                new OptionModel { Id = 118, Text = "Option 1", IsCorrect = false, QuestionModelId = 40 },
                new OptionModel { Id = 119, Text = "Rätt", IsCorrect = true, QuestionModelId = 40 },
                new OptionModel { Id = 120, Text = "Option 3", IsCorrect = false, QuestionModelId = 40 },

                //Alternativ för fråga 41
                new OptionModel { Id = 121, Text = "Option 1", IsCorrect = false, QuestionModelId = 41 },
                new OptionModel { Id = 122, Text = "Rätt", IsCorrect = true, QuestionModelId = 41 },
                new OptionModel { Id = 123, Text = "Option 3", IsCorrect = false, QuestionModelId = 41 },

                //Alternativ för fråga 42
                new OptionModel { Id = 124, Text = "Option 1", IsCorrect = false, QuestionModelId = 42 },
                new OptionModel { Id = 125, Text = "Option 2", IsCorrect = false, QuestionModelId = 42 },
                new OptionModel { Id = 126, Text = "Rätt", IsCorrect = true, QuestionModelId = 42 },

                //Alternativ för fråga 43
                new OptionModel { Id = 127, Text = "Rätt", IsCorrect = true, QuestionModelId = 43 },
                new OptionModel { Id = 128, Text = "Option 2", IsCorrect = false, QuestionModelId = 43 },
                new OptionModel { Id = 129, Text = "Option 3", IsCorrect = false, QuestionModelId = 43 },

                //Alternativ för fråga 44
                new OptionModel { Id = 130, Text = "Option 1", IsCorrect = false, QuestionModelId = 44 },
                new OptionModel { Id = 131, Text = "Option 2", IsCorrect = false, QuestionModelId = 44 },
                new OptionModel { Id = 132, Text = "Rätt", IsCorrect = true, QuestionModelId = 44 },

                //Alternativ för fråga 45
                new OptionModel { Id = 133, Text = "Option 1", IsCorrect = false, QuestionModelId = 45 },
                new OptionModel { Id = 134, Text = "Rätt", IsCorrect = true, QuestionModelId = 45 },
                new OptionModel { Id = 135, Text = "Option 3", IsCorrect = false, QuestionModelId = 45 },

                //Alternativ för fråga 46
                new OptionModel { Id = 136, Text = "Option 1", IsCorrect = false, QuestionModelId = 46 },
                new OptionModel { Id = 137, Text = "Option 2", IsCorrect = false, QuestionModelId = 46 },
                new OptionModel { Id = 138, Text = "Rätt", IsCorrect = true, QuestionModelId = 46 },

                //Alternativ för fråga 47
                new OptionModel { Id = 139, Text = "Rätt", IsCorrect = true, QuestionModelId = 47 },
                new OptionModel { Id = 140, Text = "Option 2", IsCorrect = false, QuestionModelId = 47 },
                new OptionModel { Id = 141, Text = "Option 3", IsCorrect = false, QuestionModelId = 47 },

                //Alternativ för fråga 48
                new OptionModel { Id = 142, Text = "Option 1", IsCorrect = false, QuestionModelId = 48 },
                new OptionModel { Id = 143, Text = "Option 2", IsCorrect = false, QuestionModelId = 48 },
                new OptionModel { Id = 144, Text = "Rätt", IsCorrect = true, QuestionModelId = 48 },

                //Alternativ för fråga 49
                new OptionModel { Id = 145, Text = "Option 1", IsCorrect = false, QuestionModelId = 49 },
                new OptionModel { Id = 146, Text = "Rätt", IsCorrect = true, QuestionModelId = 49 },
                new OptionModel { Id = 147, Text = "Option 3", IsCorrect = false, QuestionModelId = 49 },

                //Alternativ för fråga 50
                new OptionModel { Id = 148, Text = "Option 1", IsCorrect = false, QuestionModelId = 50 },
                new OptionModel { Id = 149, Text = "Option 2", IsCorrect = false, QuestionModelId = 50 },
                new OptionModel { Id = 150, Text = "Rätt", IsCorrect = true, QuestionModelId = 50 },

                //Alternativ för fråga 51
                new OptionModel { Id = 151, Text = "Rätt", IsCorrect = true, QuestionModelId = 51 },
                new OptionModel { Id = 152, Text = "Option 2", IsCorrect = false, QuestionModelId = 51 },
                new OptionModel { Id = 153, Text = "Option 3", IsCorrect = false, QuestionModelId = 51 },

                //Alternativ för fråga 52
                new OptionModel { Id = 154, Text = "Option 1", IsCorrect = false, QuestionModelId = 52 },
                new OptionModel { Id = 155, Text = "Option 2", IsCorrect = false, QuestionModelId = 52 },
                new OptionModel { Id = 156, Text = "Rätt", IsCorrect = true, QuestionModelId = 52 },

                //Alternativ för fråga 53
                new OptionModel { Id = 157, Text = "Option 1", IsCorrect = false, QuestionModelId = 53 },
                new OptionModel { Id = 158, Text = "Rätt", IsCorrect = true, QuestionModelId = 53 },
                new OptionModel { Id = 159, Text = "Option 3", IsCorrect = false, QuestionModelId = 53 },

                //Alternativ för fråga 54
                new OptionModel { Id = 160, Text = "Option 1", IsCorrect = false, QuestionModelId = 54 },
                new OptionModel { Id = 161, Text = "Option 2", IsCorrect = false, QuestionModelId = 54 },
                new OptionModel { Id = 162, Text = "Rätt", IsCorrect = true, QuestionModelId = 54 },

                //Alternativ för fråga 55
                new OptionModel { Id = 163, Text = "Option 1", IsCorrect = false, QuestionModelId = 55 },
                new OptionModel { Id = 164, Text = "Rätt", IsCorrect = true, QuestionModelId = 55 },
                new OptionModel { Id = 165, Text = "Option 3", IsCorrect = false, QuestionModelId = 55 },

                //Alternativ för fråga 56
                new OptionModel { Id = 166, Text = "Option 1", IsCorrect = false, QuestionModelId = 56 },
                new OptionModel { Id = 167, Text = "Option 2", IsCorrect = false, QuestionModelId = 56 },
                new OptionModel { Id = 168, Text = "Rätt", IsCorrect = true, QuestionModelId = 56 },

                //Alternativ för fråga 57
                new OptionModel { Id = 169, Text = "Rätt", IsCorrect = true, QuestionModelId = 57 },
                new OptionModel { Id = 170, Text = "Option 2", IsCorrect = false, QuestionModelId = 57 },
                new OptionModel { Id = 171, Text = "Option 3", IsCorrect = false, QuestionModelId = 57 },

                //Alternativ för fråga 58
                new OptionModel { Id = 172, Text = "Option 1", IsCorrect = false, QuestionModelId = 58 },
                new OptionModel { Id = 173, Text = "Option 2", IsCorrect = false, QuestionModelId = 58 },
                new OptionModel { Id = 174, Text = "Rätt", IsCorrect = true, QuestionModelId = 58 },

                //Alternativ för fråga 59
                new OptionModel { Id = 175, Text = "Option 1", IsCorrect = false, QuestionModelId = 59 },
                new OptionModel { Id = 176, Text = "Rätt", IsCorrect = true, QuestionModelId = 59 },
                new OptionModel { Id = 177, Text = "Option 3", IsCorrect = false, QuestionModelId = 59 },

                //Alternativ för fråga 60

                new OptionModel { Id = 178, Text = "Option 1", IsCorrect = false, QuestionModelId = 60 },
                new OptionModel { Id = 179, Text = "Option 2", IsCorrect = false, QuestionModelId = 60 },
                new OptionModel { Id = 180, Text = "Rätt", IsCorrect = true, QuestionModelId = 60 },

                //Alternativ för fråga 61
                new OptionModel { Id = 181, Text = "Rätt", IsCorrect = true, QuestionModelId = 61 },
                new OptionModel { Id = 182, Text = "Option 2", IsCorrect = false, QuestionModelId = 61 },
                new OptionModel { Id = 183, Text = "Option 3", IsCorrect = false, QuestionModelId = 61 },

                //Alternativ för fråga 62
                new OptionModel { Id = 184, Text = "Option 1", IsCorrect = false, QuestionModelId = 62 },
                new OptionModel { Id = 185, Text = "Option 2", IsCorrect = false, QuestionModelId = 62 },
                new OptionModel { Id = 186, Text = "Rätt", IsCorrect = true, QuestionModelId = 62 },

                //Alternativ för fråga 63
                new OptionModel { Id = 187, Text = "Option 1", IsCorrect = false, QuestionModelId = 63 },
                new OptionModel { Id = 188, Text = "Rätt", IsCorrect = true, QuestionModelId = 63 },
                new OptionModel { Id = 189, Text = "Option 3", IsCorrect = false, QuestionModelId = 63 },

                //Alternativ för fråga 64
                new OptionModel { Id = 190, Text = "Option 1", IsCorrect = false, QuestionModelId = 64 },
                new OptionModel { Id = 191, Text = "Option 2", IsCorrect = false, QuestionModelId = 64 },
                new OptionModel { Id = 192, Text = "Rätt", IsCorrect = true, QuestionModelId = 64 },

                //Alternativ för fråga 65
                new OptionModel { Id = 193, Text = "Option 1", IsCorrect = false, QuestionModelId = 65 },
                new OptionModel { Id = 194, Text = "Rätt", IsCorrect = true, QuestionModelId = 65 },
                new OptionModel { Id = 195, Text = "Option 3", IsCorrect = false, QuestionModelId = 65 },

                //Alternativ för fråga 66
                new OptionModel { Id = 196, Text = "Option 1", IsCorrect = false, QuestionModelId = 66 },
                new OptionModel { Id = 197, Text = "Option 2", IsCorrect = false, QuestionModelId = 66 },
                new OptionModel { Id = 198, Text = "Rätt", IsCorrect = true, QuestionModelId = 66 },

                //Alternativ för fråga 67
                new OptionModel { Id = 199, Text = "Option 1", IsCorrect = false, QuestionModelId = 67 },
                new OptionModel { Id = 200, Text = "Rätt", IsCorrect = true, QuestionModelId = 67 },
                new OptionModel { Id = 201, Text = "Option 3", IsCorrect = false, QuestionModelId = 67 },

                //Alternativ för fråga 68
                new OptionModel { Id = 202, Text = "Option 1", IsCorrect = false, QuestionModelId = 68 },
                new OptionModel { Id = 203, Text = "Option 2", IsCorrect = false, QuestionModelId = 68 },
                new OptionModel { Id = 204, Text = "Rätt", IsCorrect = true, QuestionModelId = 68 },

                //Alternativ för fråga 69
                new OptionModel { Id = 205, Text = "Option 1", IsCorrect = false, QuestionModelId = 69 },
                new OptionModel { Id = 206, Text = "Rätt", IsCorrect = true, QuestionModelId = 69 },
                new OptionModel { Id = 207, Text = "Option 3", IsCorrect = false, QuestionModelId = 69 },

                //Alternativ för fråga 70
                new OptionModel { Id = 208, Text = "Option 1", IsCorrect = false, QuestionModelId = 70 },
                new OptionModel { Id = 209, Text = "Option 2", IsCorrect = false, QuestionModelId = 70 },
                new OptionModel { Id = 210, Text = "Rätt", IsCorrect = true, QuestionModelId = 70 },

                //Alternativ för fråga 71
                new OptionModel { Id = 211, Text = "Option 1", IsCorrect = false, QuestionModelId = 71 },
                new OptionModel { Id = 212, Text = "Rätt", IsCorrect = true, QuestionModelId = 71 },
                new OptionModel { Id = 213, Text = "Option 3", IsCorrect = false, QuestionModelId = 71 },

                //Alternativ för fråga 72
                new OptionModel { Id = 214, Text = "Option 1", IsCorrect = false, QuestionModelId = 72 },
                new OptionModel { Id = 215, Text = "Option 2", IsCorrect = false, QuestionModelId = 72 },
                new OptionModel { Id = 216, Text = "Rätt", IsCorrect = true, QuestionModelId = 72 },

                //Alternativ för fråga 73
                new OptionModel { Id = 217, Text = "Option 1", IsCorrect = false, QuestionModelId = 73 },
                new OptionModel { Id = 218, Text = "Rätt", IsCorrect = true, QuestionModelId = 73 },
                new OptionModel { Id = 219, Text = "Option 3", IsCorrect = false, QuestionModelId = 73 },

                //Alternativ för fråga 74
                new OptionModel { Id = 220, Text = "Option 1", IsCorrect = false, QuestionModelId = 74 },
                new OptionModel { Id = 221, Text = "Option 2", IsCorrect = false, QuestionModelId = 74 },
                new OptionModel { Id = 222, Text = "Rätt", IsCorrect = true, QuestionModelId = 74 },

                //Alternativ för fråga 75
                new OptionModel { Id = 223, Text = "Option 1", IsCorrect = false, QuestionModelId = 75 },
                new OptionModel { Id = 224, Text = "Rätt", IsCorrect = true, QuestionModelId = 75 },
                new OptionModel { Id = 225, Text = "Option 3", IsCorrect = false, QuestionModelId = 75 },

                //Alternativ för fråga 76
                new OptionModel { Id = 226, Text = "Option 1", IsCorrect = false, QuestionModelId = 76 },
                new OptionModel { Id = 227, Text = "Option 2", IsCorrect = false, QuestionModelId = 76 },
                new OptionModel { Id = 228, Text = "Rätt", IsCorrect = true, QuestionModelId = 76 },

                //Alternativ för fråga 77
                new OptionModel { Id = 229, Text = "Rätt", IsCorrect = true, QuestionModelId = 77 },
                new OptionModel { Id = 230, Text = "Option 2", IsCorrect = false, QuestionModelId = 77 },
                new OptionModel { Id = 231, Text = "Option 3", IsCorrect = false, QuestionModelId = 77 },

                //Alternativ för fråga 78
                new OptionModel { Id = 232, Text = "Option 1", IsCorrect = false, QuestionModelId = 78 },
                new OptionModel { Id = 233, Text = "Option 2", IsCorrect = false, QuestionModelId = 78 },
                new OptionModel { Id = 234, Text = "Rätt", IsCorrect = true, QuestionModelId = 78 },

                //Alternativ för fråga 79
                new OptionModel { Id = 235, Text = "Option 1", IsCorrect = false, QuestionModelId = 79 },
                new OptionModel { Id = 236, Text = "Rätt", IsCorrect = true, QuestionModelId = 79 },
                new OptionModel { Id = 237, Text = "Option 3", IsCorrect = false, QuestionModelId = 79 },

                //Alternativ för fråga 80
                new OptionModel { Id = 238, Text = "Option 1", IsCorrect = false, QuestionModelId = 80 },
                new OptionModel { Id = 239, Text = "Option 2", IsCorrect = false, QuestionModelId = 80 },
                new OptionModel { Id = 240, Text = "Rätt", IsCorrect = true, QuestionModelId = 80 },

                //Alternativ för fråga 81
                new OptionModel { Id = 241, Text = "Rätt", IsCorrect = true, QuestionModelId = 81 },
                new OptionModel { Id = 242, Text = "Option 2", IsCorrect = false, QuestionModelId = 81 },
                new OptionModel { Id = 243, Text = "Option 3", IsCorrect = false, QuestionModelId = 81 },

                //Alternativ för fråga 82
                new OptionModel { Id = 244, Text = "Option 1", IsCorrect = false, QuestionModelId = 82 },
                new OptionModel { Id = 245, Text = "Option 2", IsCorrect = false, QuestionModelId = 82 },
                new OptionModel { Id = 246, Text = "Rätt", IsCorrect = true, QuestionModelId = 82 },

                //Alternativ för fråga 83
                new OptionModel { Id = 247, Text = "Option 1", IsCorrect = false, QuestionModelId = 83 },
                new OptionModel { Id = 248, Text = "Rätt", IsCorrect = true, QuestionModelId = 83 },
                new OptionModel { Id = 249, Text = "Option 3", IsCorrect = false, QuestionModelId = 83 },

                //Alternativ för fråga 84
                new OptionModel { Id = 250, Text = "Option 1", IsCorrect = false, QuestionModelId = 84 },
                new OptionModel { Id = 251, Text = "Option 2", IsCorrect = false, QuestionModelId = 84 },
                new OptionModel { Id = 252, Text = "Rätt", IsCorrect = true, QuestionModelId = 84 },

                //Alternativ för fråga 85
                new OptionModel { Id = 253, Text = "Option 1", IsCorrect = false, QuestionModelId = 85 },
                new OptionModel { Id = 254, Text = "Rätt", IsCorrect = true, QuestionModelId = 85 },
                new OptionModel { Id = 255, Text = "Option 3", IsCorrect = false, QuestionModelId = 85 },

                //Alternativ för fråga 86
                new OptionModel { Id = 256, Text = "Option 1", IsCorrect = false, QuestionModelId = 86 },
                new OptionModel { Id = 257, Text = "Option 2", IsCorrect = false, QuestionModelId = 86 },
                new OptionModel { Id = 258, Text = "Rätt", IsCorrect = true, QuestionModelId = 86 },

                //Alternativ för fråga 87
                new OptionModel { Id = 259, Text = "Option 1", IsCorrect = false, QuestionModelId = 87 },
                new OptionModel { Id = 260, Text = "Rätt", IsCorrect = true, QuestionModelId = 87 },
                new OptionModel { Id = 261, Text = "Option 3", IsCorrect = false, QuestionModelId = 87 },

                //Alternativ för fråga 88
                new OptionModel { Id = 262, Text = "Option 1", IsCorrect = false, QuestionModelId = 88 },
                new OptionModel { Id = 263, Text = "Option 2", IsCorrect = false, QuestionModelId = 88 },
                new OptionModel { Id = 264, Text = "Rätt", IsCorrect = true, QuestionModelId = 88 },

                //Alternativ för fråga 89
                new OptionModel { Id = 265, Text = "Option 1", IsCorrect = false, QuestionModelId = 89 },
                new OptionModel { Id = 266, Text = "Rätt", IsCorrect = true, QuestionModelId = 89 },
                new OptionModel { Id = 267, Text = "Option 3", IsCorrect = false, QuestionModelId = 89 },

                //Alternativ för fråga 90
                new OptionModel { Id = 268, Text = "Option 1", IsCorrect = false, QuestionModelId = 90 },
                new OptionModel { Id = 269, Text = "Rätt", IsCorrect = true, QuestionModelId = 90 },
                new OptionModel { Id = 270, Text = "Option 3", IsCorrect = false, QuestionModelId = 90 }
            );
        }
    }
}
