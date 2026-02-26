using CyberQuiz.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CyberQuiz.DAL.SeedData
{
    public class SubCategoryConfiguration : IEntityTypeConfiguration<SubCategoryModel>
    {
        public void Configure(EntityTypeBuilder<SubCategoryModel> builder)
        {
            builder.HasData(
                new SubCategoryModel
                {
                    //Network Security
                    Id = 1,
                    Name = "Firewalls",
                    Description = "Filtering traffic at network boundaries.",
                    Order = 1,
                    UnlockThresholdPercentage = 80,
                    CategoryModelId = 1
                },
                new SubCategoryModel
                {
                    Id = 2,
                    Name = "VPNs",
                    Description = "Virtual Private Networks and tunnelling protocols.",
                    Order = 2,
                    UnlockThresholdPercentage = 80,
                    CategoryModelId = 1
                },
                new SubCategoryModel
                {
                    Id = 3,
                    Name = "Intrusion Detection",
                    Description = "Detecting and responding to malicious network activity.",
                    Order = 3,
                    UnlockThresholdPercentage = 80,
                    CategoryModelId = 1
                },
                
                //Cryptography
                new SubCategoryModel
                {
                    Id = 4,
                    Name = "Symmetric Encryption",
                    Description = "Encryption methods that use the same key for both encryption and decryption.",
                    Order = 1,
                    UnlockThresholdPercentage = 80,
                    CategoryModelId = 2
                },
                new SubCategoryModel
                {
                    Id = 5,
                    Name = "Asymmetric Encryption",
                    Description = "Encryption methods that use a pair of keys: a public key for encryption and a private key for decryption.",
                    Order = 2,
                    UnlockThresholdPercentage = 80,
                    CategoryModelId = 2
                },
                new SubCategoryModel
                {
                    Id = 6,
                    Name = "Hashing",
                    Description = "One-way functions used for data integrity.",
                    Order = 3,
                    UnlockThresholdPercentage = 80,
                    CategoryModelId = 2
                },

                //Web Security
                new SubCategoryModel
                {
                    Id = 7,
                    Name = "SQL Injection",
                    Description = "Attacks targeting database queries via user input.",
                    Order = 1,
                    UnlockThresholdPercentage = 80,
                    CategoryModelId = 3
                },
                new SubCategoryModel
                {
                    Id = 8,
                    Name = "Cross-Site Scripting (XSS)",
                    Description = "Attacks that inject malicious scripts into web pages viewed by other users.",
                    Order = 2,
                    UnlockThresholdPercentage = 80,
                    CategoryModelId = 3
                },
                new SubCategoryModel
                {
                    Id = 9,
                    Name = "Cross-Site Request Forgery (CSRF)",
                    Description = "Attacks that trick users into performing actions on a web application without their consent.",
                    Order = 3,
                    UnlockThresholdPercentage = 80,
                    CategoryModelId = 3
                }

            );
        }
    }
}
