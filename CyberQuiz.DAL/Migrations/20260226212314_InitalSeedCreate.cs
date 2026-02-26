using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CyberQuiz.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitalSeedCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    UnlockThresholdPercentage = table.Column<int>(type: "int", nullable: false),
                    CategoryModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_CategoryModelId",
                        column: x => x.CategoryModelId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Quizzes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubCategoryModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quizzes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quizzes_SubCategories_SubCategoryModelId",
                        column: x => x.SubCategoryModelId,
                        principalTable: "SubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserProgress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SubCategoryModelId = table.Column<int>(type: "int", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    UnlockedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProgress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserProgress_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserProgress_SubCategories_SubCategoryModelId",
                        column: x => x.SubCategoryModelId,
                        principalTable: "SubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuizModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Quizzes_QuizModelId",
                        column: x => x.QuizModelId,
                        principalTable: "Quizzes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserScores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    QuizModelId = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    TotalQuestions = table.Column<int>(type: "int", nullable: false),
                    CompletedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserScores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserScores_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserScores_Quizzes_QuizModelId",
                        column: x => x.QuizModelId,
                        principalTable: "Quizzes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Options",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false),
                    QuestionModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Options", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Options_Questions_QuestionModelId",
                        column: x => x.QuestionModelId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "C4A682B7-878D-49C9-9DE5-A0AF381897D0", 0, "STATIC_CONCURRENCY_STAMP", "user@example.com", true, false, null, "USER@EXAMPLE.COM", "USER", "AQAAAAIAAYagAAAAEOvE+26L3R0fA3tG8s9D6nS+hX/GjD3U/g1rM3I/6aKzFjF9jR2L+Q==", null, false, "STATIC_STAMP_FOR_SEED_USER", false, "user" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Fundamentals of securing network infrastructure and communications.", "Network Security" },
                    { 2, "Principles and algorithms used to protect information through encryption.", "Cryptography" },
                    { 3, "Vulnerabilities and defenses related to web applications and browsers.", "Web Security" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryModelId", "Description", "Name", "Order", "UnlockThresholdPercentage" },
                values: new object[,]
                {
                    { 1, 1, "Filtering traffic at network boundaries.", "Firewalls", 1, 80 },
                    { 2, 1, "Virtual Private Networks and tunnelling protocols.", "VPNs", 2, 80 },
                    { 3, 1, "Detecting and responding to malicious network activity.", "Intrusion Detection", 3, 80 },
                    { 4, 2, "Encryption methods that use the same key for both encryption and decryption.", "Symmetric Encryption", 1, 80 },
                    { 5, 2, "Encryption methods that use a pair of keys: a public key for encryption and a private key for decryption.", "Asymmetric Encryption", 2, 80 },
                    { 6, 2, "One-way functions used for data integrity.", "Hashing", 3, 80 },
                    { 7, 3, "Attacks targeting database queries via user input.", "SQL Injection", 1, 80 },
                    { 8, 3, "Attacks that inject malicious scripts into web pages viewed by other users.", "Cross-Site Scripting (XSS)", 2, 80 },
                    { 9, 3, "Attacks that trick users into performing actions on a web application without their consent.", "Cross-Site Request Forgery (CSRF)", 3, 80 }
                });

            migrationBuilder.InsertData(
                table: "Quizzes",
                columns: new[] { "Id", "Description", "SubCategoryModelId", "Text" },
                values: new object[,]
                {
                    { 1, "Test your knowledge on the fundamentals of firewalls.", 1, "Firewall Basics" },
                    { 2, "Assess your understanding of various VPN protocols and their uses.", 2, "VPN Protocols" },
                    { 3, "Evaluate your grasp of IDS concepts and technologies.", 3, "Intrusion Detection Systems" },
                    { 4, "Challenge yourself with questions about popular symmetric encryption algorithms.", 4, "Symmetric Encryption Algorithms" },
                    { 5, "Test your knowledge of asymmetric encryption principles and applications.", 5, "Asymmetric Encryption Concepts" },
                    { 6, "Test your understanding of various hashing techniques and their applications.", 6, "Hashing Techniques" },
                    { 7, "Assess your knowledge of SQL injection vulnerabilities and how to prevent them.", 7, "SQL Injection Vulnerabilities" },
                    { 8, "Evaluate your understanding of cross-site scripting (XSS) attacks and how to mitigate them.", 8, "Cross-Site Scripting (XSS) Attacks" },
                    { 9, "Test your understanding of cross-site request forgery (CSRF) attacks and how to prevent them.", 9, "Cross-Site Request Forgery (CSRF) Attacks" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "QuizModelId", "Text" },
                values: new object[,]
                {
                    { 1, 1, "What is the primary purpose of a firewall in cybersecurity?" },
                    { 2, 1, "Which type of firewall operates at the network layer and filters traffic based on IP addresses and ports?" },
                    { 3, 1, "What is a common method used by firewalls to inspect and filter network traffic?" },
                    { 4, 1, "Which type of firewall is designed to protect a specific application or service?" },
                    { 5, 1, "What is the difference between a stateful and stateless firewall?" },
                    { 6, 1, "Which type of firewall is typically used to protect a home network?" },
                    { 7, 1, "What is the purpose of a demilitarized zone (DMZ) in a firewall architecture?" },
                    { 8, 1, "Which type of firewall is designed to analyze and filter traffic based on the content of the data packets?" },
                    { 9, 1, "What is the role of a firewall in preventing unauthorized access to a network?" },
                    { 10, 1, "Which type of firewall is typically used in enterprise environments to protect against advanced threats?" },
                    { 11, 2, "What does VPN stand for in cybersecurity?" },
                    { 12, 2, "What is the primary purpose of a VPN in cybersecurity?" },
                    { 13, 2, "Which type of VPN allows users to connect to a private network over the internet?" },
                    { 14, 2, "What is the difference between a site-to-site VPN and a remote access VPN?" },
                    { 15, 2, "Which protocol is commonly used for secure VPN connections?" },
                    { 16, 2, "What is the purpose of encryption in a VPN connection?" },
                    { 17, 2, "Which type of VPN is typically used by businesses to connect multiple office locations?" },
                    { 18, 2, "What is the role of a VPN in protecting user privacy and anonymity online?" },
                    { 19, 2, "Which type of VPN is designed to provide secure access to a specific application or service?" },
                    { 20, 2, "What is the difference between a VPN and a proxy server?" },
                    { 21, 3, "What is the primary purpose of an intrusion detection system (IDS) in cybersecurity?" },
                    { 22, 3, "Which type of IDS analyzes network traffic for signs of malicious activity?" },
                    { 23, 3, "What is the difference between a signature-based IDS and an anomaly-based IDS?" },
                    { 24, 3, "Which type of IDS is designed to detect and prevent attacks in real-time?" },
                    { 25, 3, "What is the role of an IDS in a layered security approach?" },
                    { 26, 3, "Which type of IDS is typically used in enterprise environments to monitor network traffic?" },
                    { 27, 3, "What is the difference between an IDS and an intrusion prevention system (IPS)?" },
                    { 28, 3, "Which type of IDS is designed to analyze and filter traffic based on the content of the data packets?" },
                    { 29, 3, "What is the purpose of a honeypot in an IDS architecture?" },
                    { 30, 3, "Which type of IDS is designed to detect and prevent insider threats?" },
                    { 31, 4, "What is symmetric encryption in cybersecurity?" },
                    { 32, 4, "What is the primary characteristic of symmetric encryption?" },
                    { 33, 4, "Which algorithm is commonly used for symmetric encryption?" },
                    { 34, 4, "What is the difference between symmetric encryption and asymmetric encryption?" },
                    { 35, 4, "What is the role of a secret key in symmetric encryption?" },
                    { 36, 4, "Which type of symmetric encryption is designed to provide strong security with a small key size?" },
                    { 37, 4, "What is the purpose of a block cipher in symmetric encryption?" },
                    { 38, 4, "Which type of symmetric encryption is designed to provide strong security with a large key size?" },
                    { 39, 4, "What is the role of a key exchange protocol in symmetric encryption?" },
                    { 40, 4, "Which type of symmetric encryption is designed to provide strong security with a variable key size?" },
                    { 41, 5, "What is asymmetric encryption in cybersecurity?" },
                    { 42, 5, "What is the primary characteristic of asymmetric encryption?" },
                    { 43, 5, "Which algorithm is commonly used for asymmetric encryption?" },
                    { 44, 5, "What is the difference between asymmetric encryption and symmetric encryption?" },
                    { 45, 5, "What is the role of a public key in asymmetric encryption?" },
                    { 46, 5, "Which type of asymmetric encryption is designed to provide strong security with a small key size?" },
                    { 47, 5, "What is the purpose of a digital signature in asymmetric encryption?" },
                    { 48, 5, "Which type of asymmetric encryption is designed to provide strong security with a large key size?" },
                    { 49, 5, "What is the role of a key exchange protocol in asymmetric encryption?" },
                    { 50, 5, "Which type of asymmetric encryption is designed to provide strong security with a variable key size?" },
                    { 51, 6, "What is hashing in cybersecurity?" },
                    { 52, 6, "What is the primary purpose of hashing in cybersecurity?" },
                    { 53, 6, "Which algorithm is commonly used for hashing?" },
                    { 54, 6, "What is the difference between hashing and encryption?" },
                    { 55, 6, "What is the role of a hash function in hashing?" },
                    { 56, 6, "Which type of hashing is designed to provide strong security with a small output size?" },
                    { 57, 6, "What is the purpose of a salt in hashing?" },
                    { 58, 6, "Which type of hashing is designed to provide strong security with a large output size?" },
                    { 59, 6, "What is the role of a key stretching algorithm in hashing?" },
                    { 60, 6, "Which type of hashing is designed to provide strong security with a variable output size?" },
                    { 61, 7, "What is SQL injection in cybersecurity?" },
                    { 62, 7, "What is the primary purpose of SQL injection in cybersecurity?" },
                    { 63, 7, "Which type of attack is commonly used in SQL injection?" },
                    { 64, 7, "What is the difference between SQL injection and other types of injection attacks?" },
                    { 65, 7, "What is the role of input validation in preventing SQL injection?" },
                    { 66, 7, "Which type of SQL injection is designed to extract data from a database?" },
                    { 67, 7, "What is the purpose of parameterized queries in preventing SQL injection?" },
                    { 68, 7, "Which type of SQL injection is designed to modify data in a database?" },
                    { 69, 7, "What is the role of a web application firewall (WAF) in preventing SQL injection?" },
                    { 70, 7, "Which type of SQL injection is designed to execute arbitrary commands on a database?" },
                    { 71, 8, "What is cross-site scripting (XSS) in cybersecurity?" },
                    { 72, 8, "What is the primary purpose of cross-site scripting (XSS) in cybersecurity?" },
                    { 73, 8, "Which type of attack is commonly used in cross-site scripting (XSS)?" },
                    { 74, 8, "What is the difference between cross-site scripting (XSS) and other types of injection attacks?" },
                    { 75, 8, "What is the role of input validation in preventing cross-site scripting (XSS)?" },
                    { 76, 8, "Which type of cross-site scripting (XSS) is designed to steal user credentials?" },
                    { 77, 8, "What is the purpose of output encoding in preventing cross-site scripting (XSS)?" },
                    { 78, 8, "Which type of cross-site scripting (XSS) is designed to deface a website?" },
                    { 79, 8, "What is the role of a content security policy (CSP) in preventing cross-site scripting (XSS)?" },
                    { 80, 8, "Which type of cross-site scripting (XSS) is designed to execute arbitrary scripts in a user's browser?" },
                    { 81, 9, "What is cross-site request forgery (CSRF) in cybersecurity?" },
                    { 82, 9, "What is the primary purpose of cross-site request forgery (CSRF) in cybersecurity?" },
                    { 83, 9, "Which type of attack is commonly used in cross-site request forgery (CSRF)?" },
                    { 84, 9, "What is the difference between cross-site request forgery (CSRF) and other types of injection attacks?" },
                    { 85, 9, "What is the role of input validation in preventing cross-site request forgery (CSRF)?" },
                    { 86, 9, "Which type of cross-site request forgery (CSRF) is designed to steal user credentials?" },
                    { 87, 9, "What is the purpose of anti-CSRF tokens in preventing cross-site request forgery (CSRF)?" },
                    { 88, 9, "Which type of cross-site request forgery (CSRF) is designed to perform unauthorized actions on behalf of a user?" },
                    { 89, 9, "What is the role of a web application firewall (WAF) in preventing cross-site request forgery (CSRF)?" },
                    { 90, 9, "Which type of cross-site request forgery (CSRF) is designed to execute arbitrary commands on a server?" }
                });

            migrationBuilder.InsertData(
                table: "Options",
                columns: new[] { "Id", "IsCorrect", "QuestionModelId", "Text" },
                values: new object[,]
                {
                    { 1, false, 1, "Option 1" },
                    { 2, true, 1, "Rätt" },
                    { 3, false, 1, "Option 3" },
                    { 4, true, 2, "Option 1" },
                    { 5, false, 2, "Option 2" },
                    { 6, false, 2, "Option 3" },
                    { 7, false, 3, "Option 1" },
                    { 8, false, 3, "Option 2" },
                    { 9, true, 3, "Rätt" },
                    { 10, false, 4, "Option 1" },
                    { 11, true, 4, "Rätt" },
                    { 12, false, 4, "Option 3" },
                    { 13, false, 5, "Option 1" },
                    { 14, false, 5, "Option 2" },
                    { 15, true, 5, "Rätt" },
                    { 16, true, 6, "Rätt" },
                    { 17, false, 6, "Option 2" },
                    { 18, false, 6, "Option 3" },
                    { 19, false, 7, "Option 1" },
                    { 20, false, 7, "Option 2" },
                    { 21, true, 7, "Rätt" },
                    { 22, false, 8, "Option 1" },
                    { 23, true, 8, "Rätt" },
                    { 24, false, 8, "Option 3" },
                    { 25, false, 9, "Option 1" },
                    { 26, true, 9, "Rätt" },
                    { 27, false, 9, "Option 3" },
                    { 28, true, 10, "Rätt" },
                    { 29, false, 10, "Option 2" },
                    { 30, false, 10, "Option 3" },
                    { 31, false, 11, "Option 1" },
                    { 32, true, 11, "Rätt" },
                    { 33, false, 11, "Option 3" },
                    { 34, false, 12, "Option 1" },
                    { 35, false, 12, "Option 2" },
                    { 36, true, 12, "Rätt" },
                    { 37, false, 13, "Option 1" },
                    { 38, true, 13, "Rätt" },
                    { 39, false, 13, "Option 3" },
                    { 40, true, 14, "Rätt" },
                    { 41, false, 14, "Option 2" },
                    { 42, false, 14, "Option 3" },
                    { 43, false, 15, "Option 1" },
                    { 44, false, 15, "Option 2" },
                    { 45, true, 15, "Rätt" },
                    { 46, false, 16, "Option 1" },
                    { 47, true, 16, "Rätt" },
                    { 48, false, 16, "Option 3" },
                    { 49, false, 17, "Option 1" },
                    { 50, false, 17, "Option 2" },
                    { 51, true, 17, "Rätt" },
                    { 52, true, 18, "Rätt" },
                    { 53, false, 18, "Option 2" },
                    { 54, false, 18, "Option 3" },
                    { 55, false, 19, "Option 1" },
                    { 56, true, 19, "Rätt" },
                    { 57, false, 19, "Option 3" },
                    { 58, false, 20, "Option 1" },
                    { 59, false, 20, "Option 2" },
                    { 60, true, 20, "Rätt" },
                    { 61, true, 21, "Rätt" },
                    { 62, false, 21, "Option 2" },
                    { 63, false, 21, "Option 3" },
                    { 64, false, 22, "Option 1" },
                    { 65, false, 22, "Option 2" },
                    { 66, true, 22, "Rätt" },
                    { 67, false, 23, "Option 1" },
                    { 68, true, 23, "Rätt" },
                    { 69, false, 23, "Option 3" },
                    { 70, false, 24, "Option 1" },
                    { 71, true, 24, "Rätt" },
                    { 72, false, 24, "Option 3" },
                    { 73, false, 25, "Option 1" },
                    { 74, true, 25, "Rätt" },
                    { 75, false, 25, "Option 3" },
                    { 76, false, 26, "Option 1" },
                    { 77, false, 26, "Option 2" },
                    { 78, true, 26, "Rätt" },
                    { 79, true, 27, "Rätt" },
                    { 80, false, 27, "Option 2" },
                    { 81, false, 27, "Option 3" },
                    { 82, false, 28, "Option 1" },
                    { 83, false, 28, "Option 2" },
                    { 84, true, 28, "Rätt" },
                    { 85, false, 29, "Option 1" },
                    { 86, true, 29, "Rätt" },
                    { 87, false, 29, "Option 3" },
                    { 88, false, 30, "Option 1" },
                    { 89, true, 30, "Rätt" },
                    { 90, false, 30, "Option 3" },
                    { 91, false, 31, "Option 1" },
                    { 92, true, 31, "Rätt" },
                    { 93, false, 31, "Option 3" },
                    { 94, false, 32, "Option 1" },
                    { 95, false, 32, "Option 2" },
                    { 96, true, 32, "Rätt" },
                    { 97, true, 33, "Rätt" },
                    { 98, false, 33, "Option 2" },
                    { 99, false, 33, "Option 3" },
                    { 100, false, 34, "Option 1" },
                    { 101, false, 34, "Option 2" },
                    { 102, true, 34, "Rätt" },
                    { 103, false, 35, "Option 1" },
                    { 104, true, 35, "Rätt" },
                    { 105, false, 35, "Option 3" },
                    { 106, false, 36, "Option 1" },
                    { 107, false, 36, "Option 2" },
                    { 108, true, 36, "Rätt" },
                    { 109, false, 37, "Option 1" },
                    { 110, true, 37, "Rätt" },
                    { 111, false, 37, "Option 3" },
                    { 112, true, 38, "Rätt" },
                    { 113, false, 38, "Option 2" },
                    { 114, false, 38, "Option 3" },
                    { 115, false, 39, "Option 1" },
                    { 116, false, 39, "Option 2" },
                    { 117, true, 39, "Rätt" },
                    { 118, false, 40, "Option 1" },
                    { 119, true, 40, "Rätt" },
                    { 120, false, 40, "Option 3" },
                    { 121, false, 41, "Option 1" },
                    { 122, true, 41, "Rätt" },
                    { 123, false, 41, "Option 3" },
                    { 124, false, 42, "Option 1" },
                    { 125, false, 42, "Option 2" },
                    { 126, true, 42, "Rätt" },
                    { 127, true, 43, "Rätt" },
                    { 128, false, 43, "Option 2" },
                    { 129, false, 43, "Option 3" },
                    { 130, false, 44, "Option 1" },
                    { 131, false, 44, "Option 2" },
                    { 132, true, 44, "Rätt" },
                    { 133, false, 45, "Option 1" },
                    { 134, true, 45, "Rätt" },
                    { 135, false, 45, "Option 3" },
                    { 136, false, 46, "Option 1" },
                    { 137, false, 46, "Option 2" },
                    { 138, true, 46, "Rätt" },
                    { 139, true, 47, "Rätt" },
                    { 140, false, 47, "Option 2" },
                    { 141, false, 47, "Option 3" },
                    { 142, false, 48, "Option 1" },
                    { 143, false, 48, "Option 2" },
                    { 144, true, 48, "Rätt" },
                    { 145, false, 49, "Option 1" },
                    { 146, true, 49, "Rätt" },
                    { 147, false, 49, "Option 3" },
                    { 148, false, 50, "Option 1" },
                    { 149, false, 50, "Option 2" },
                    { 150, true, 50, "Rätt" },
                    { 151, true, 51, "Rätt" },
                    { 152, false, 51, "Option 2" },
                    { 153, false, 51, "Option 3" },
                    { 154, false, 52, "Option 1" },
                    { 155, false, 52, "Option 2" },
                    { 156, true, 52, "Rätt" },
                    { 157, false, 53, "Option 1" },
                    { 158, true, 53, "Rätt" },
                    { 159, false, 53, "Option 3" },
                    { 160, false, 54, "Option 1" },
                    { 161, false, 54, "Option 2" },
                    { 162, true, 54, "Rätt" },
                    { 163, false, 55, "Option 1" },
                    { 164, true, 55, "Rätt" },
                    { 165, false, 55, "Option 3" },
                    { 166, false, 56, "Option 1" },
                    { 167, false, 56, "Option 2" },
                    { 168, true, 56, "Rätt" },
                    { 169, true, 57, "Rätt" },
                    { 170, false, 57, "Option 2" },
                    { 171, false, 57, "Option 3" },
                    { 172, false, 58, "Option 1" },
                    { 173, false, 58, "Option 2" },
                    { 174, true, 58, "Rätt" },
                    { 175, false, 59, "Option 1" },
                    { 176, true, 59, "Rätt" },
                    { 177, false, 59, "Option 3" },
                    { 178, false, 60, "Option 1" },
                    { 179, false, 60, "Option 2" },
                    { 180, true, 60, "Rätt" },
                    { 181, true, 61, "Rätt" },
                    { 182, false, 61, "Option 2" },
                    { 183, false, 61, "Option 3" },
                    { 184, false, 62, "Option 1" },
                    { 185, false, 62, "Option 2" },
                    { 186, true, 62, "Rätt" },
                    { 187, false, 63, "Option 1" },
                    { 188, true, 63, "Rätt" },
                    { 189, false, 63, "Option 3" },
                    { 190, false, 64, "Option 1" },
                    { 191, false, 64, "Option 2" },
                    { 192, true, 64, "Rätt" },
                    { 193, false, 65, "Option 1" },
                    { 194, true, 65, "Rätt" },
                    { 195, false, 65, "Option 3" },
                    { 196, false, 66, "Option 1" },
                    { 197, false, 66, "Option 2" },
                    { 198, true, 66, "Rätt" },
                    { 199, false, 67, "Option 1" },
                    { 200, true, 67, "Rätt" },
                    { 201, false, 67, "Option 3" },
                    { 202, false, 68, "Option 1" },
                    { 203, false, 68, "Option 2" },
                    { 204, true, 68, "Rätt" },
                    { 205, false, 69, "Option 1" },
                    { 206, true, 69, "Rätt" },
                    { 207, false, 69, "Option 3" },
                    { 208, false, 70, "Option 1" },
                    { 209, false, 70, "Option 2" },
                    { 210, true, 70, "Rätt" },
                    { 211, false, 71, "Option 1" },
                    { 212, true, 71, "Rätt" },
                    { 213, false, 71, "Option 3" },
                    { 214, false, 72, "Option 1" },
                    { 215, false, 72, "Option 2" },
                    { 216, true, 72, "Rätt" },
                    { 217, false, 73, "Option 1" },
                    { 218, true, 73, "Rätt" },
                    { 219, false, 73, "Option 3" },
                    { 220, false, 74, "Option 1" },
                    { 221, false, 74, "Option 2" },
                    { 222, true, 74, "Rätt" },
                    { 223, false, 75, "Option 1" },
                    { 224, true, 75, "Rätt" },
                    { 225, false, 75, "Option 3" },
                    { 226, false, 76, "Option 1" },
                    { 227, false, 76, "Option 2" },
                    { 228, true, 76, "Rätt" },
                    { 229, true, 77, "Rätt" },
                    { 230, false, 77, "Option 2" },
                    { 231, false, 77, "Option 3" },
                    { 232, false, 78, "Option 1" },
                    { 233, false, 78, "Option 2" },
                    { 234, true, 78, "Rätt" },
                    { 235, false, 79, "Option 1" },
                    { 236, true, 79, "Rätt" },
                    { 237, false, 79, "Option 3" },
                    { 238, false, 80, "Option 1" },
                    { 239, false, 80, "Option 2" },
                    { 240, true, 80, "Rätt" },
                    { 241, true, 81, "Rätt" },
                    { 242, false, 81, "Option 2" },
                    { 243, false, 81, "Option 3" },
                    { 244, false, 82, "Option 1" },
                    { 245, false, 82, "Option 2" },
                    { 246, true, 82, "Rätt" },
                    { 247, false, 83, "Option 1" },
                    { 248, true, 83, "Rätt" },
                    { 249, false, 83, "Option 3" },
                    { 250, false, 84, "Option 1" },
                    { 251, false, 84, "Option 2" },
                    { 252, true, 84, "Rätt" },
                    { 253, false, 85, "Option 1" },
                    { 254, true, 85, "Rätt" },
                    { 255, false, 85, "Option 3" },
                    { 256, false, 86, "Option 1" },
                    { 257, false, 86, "Option 2" },
                    { 258, true, 86, "Rätt" },
                    { 259, false, 87, "Option 1" },
                    { 260, true, 87, "Rätt" },
                    { 261, false, 87, "Option 3" },
                    { 262, false, 88, "Option 1" },
                    { 263, false, 88, "Option 2" },
                    { 264, true, 88, "Rätt" },
                    { 265, false, 89, "Option 1" },
                    { 266, true, 89, "Rätt" },
                    { 267, false, 89, "Option 3" },
                    { 268, false, 90, "Option 1" },
                    { 269, true, 90, "Rätt" },
                    { 270, false, 90, "Option 3" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Options_QuestionModelId",
                table: "Options",
                column: "QuestionModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuizModelId",
                table: "Questions",
                column: "QuizModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Quizzes_SubCategoryModelId",
                table: "Quizzes",
                column: "SubCategoryModelId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryModelId",
                table: "SubCategories",
                column: "CategoryModelId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProgress_ApplicationUserId",
                table: "UserProgress",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProgress_SubCategoryModelId",
                table: "UserProgress",
                column: "SubCategoryModelId");

            migrationBuilder.CreateIndex(
                name: "IX_UserScores_ApplicationUserId",
                table: "UserScores",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserScores_QuizModelId",
                table: "UserScores",
                column: "QuizModelId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Options");

            migrationBuilder.DropTable(
                name: "UserProgress");

            migrationBuilder.DropTable(
                name: "UserScores");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Quizzes");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
