using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CyberQuiz.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
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
                    ScorePercentage = table.Column<double>(type: "float", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    UnlockedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    { 1, true, 1, "To monitor and control incoming and outgoing network traffic based on predetermined security rules.(R)" },
                    { 2, false, 1, "To encrypt all data stored on a computer's hard drive." },
                    { 3, false, 1, "To permanently delete malware and viruses from an infected system." },
                    { 4, true, 2, "Packet-filtering firewall.(R)" },
                    { 5, false, 2, "Web application firewall (WAF)." },
                    { 6, false, 2, "Next-generation firewall (NGFW)." },
                    { 7, true, 3, "Stateful inspection.(R)" },
                    { 8, false, 3, "Phishing simulation." },
                    { 9, false, 3, "Password hashing." },
                    { 10, true, 4, "Application-level gateway (Proxy firewall) / WAF.(R)" },
                    { 11, false, 4, "Hardware-based packet firewall." },
                    { 12, false, 4, "Stateless network firewall." },
                    { 13, true, 5, "Stateful firewalls track the operating state of connections, while stateless firewalls examine each packet individually.(R)" },
                    { 14, false, 5, "Stateful firewalls are only used in home networks, while stateless firewalls are for enterprise environments." },
                    { 15, false, 5, "Stateful firewalls encrypt data in transit, while stateless firewalls only encrypt data at rest." },
                    { 16, true, 6, "A broadband router with a built-in hardware NAT/firewall.(R)" },
                    { 17, false, 6, "An enterprise-grade Web Application Firewall (WAF)." },
                    { 18, false, 6, "A dedicated Deep Packet Inspection (DPI) server." },
                    { 19, true, 7, "To expose public-facing services to an untrusted network while keeping the internal local network secure.(R)" },
                    { 20, false, 7, "To completely block all incoming and outgoing internet traffic during maintenance." },
                    { 21, false, 7, "To create a high-speed bypass lane that skips all security checks for VIP users." },
                    { 22, true, 8, "Deep Packet Inspection (DPI) firewall.(R)" },
                    { 23, false, 8, "Stateless packet-filtering firewall." },
                    { 24, false, 8, "Circuit-level gateway." },
                    { 25, true, 9, "It acts as a barrier that blocks unauthorized connection attempts from external sources.(R)" },
                    { 26, false, 9, "It automatically resets user passwords if they are suspected to be compromised." },
                    { 27, false, 9, "It physically disconnects the network cable when a threat is detected." },
                    { 28, true, 10, "Next-Generation Firewall (NGFW).(R)" },
                    { 29, false, 10, "Software firewall bundled with a standard operating system." },
                    { 30, false, 10, "A basic layer 3 packet-filtering router." },
                    { 31, true, 11, "Virtual Private Network.(R)" },
                    { 32, false, 11, "Visual Processing Node." },
                    { 33, false, 11, "Verified Public Network." },
                    { 34, true, 12, "To create a secure, encrypted connection over a less secure network like the internet.(R)" },
                    { 35, false, 12, "To permanently delete viruses and malware from a local machine." },
                    { 36, false, 12, "To boost the physical hardware speed of an internet connection." },
                    { 37, true, 13, "Remote access VPN.(R)" },
                    { 38, false, 13, "Local Area Network (LAN) VPN." },
                    { 39, false, 13, "Hardware-only VPN." },
                    { 40, true, 14, "Site-to-site connects entire networks together, while remote access connects individual devices to a network.(R)" },
                    { 41, false, 14, "Site-to-site is only for home use, while remote access is exclusively for large enterprises." },
                    { 42, false, 14, "Site-to-site does not use encryption, while remote access requires heavy encryption." },
                    { 43, true, 15, "IPsec (Internet Protocol Security) or OpenVPN.(R)" },
                    { 44, false, 15, "HTTP (Hypertext Transfer Protocol)." },
                    { 45, false, 15, "FTP (File Transfer Protocol)." },
                    { 46, true, 16, "To scramble data so that unauthorized parties cannot read it if intercepted.(R)" },
                    { 47, false, 16, "To compress files so they download faster over the network." },
                    { 48, false, 16, "To prevent the user's device from overheating during heavy network usage." },
                    { 49, true, 17, "Site-to-site VPN.(R)" },
                    { 50, false, 17, "Personal consumer VPN." },
                    { 51, false, 17, "Proxy-only VPN." },
                    { 52, true, 18, "It masks the user's real IP address and encrypts their internet traffic.(R)" },
                    { 53, false, 18, "It automatically blocks all cookies and browser trackers." },
                    { 54, false, 18, "It makes the user completely immune to all types of phishing attacks." },
                    { 55, true, 19, "Per-App VPN (or Application-level VPN).(R)" },
                    { 56, false, 19, "Full-tunnel network VPN." },
                    { 57, false, 19, "Intranet VPN." },
                    { 58, true, 20, "A VPN encrypts all network traffic, while a proxy server typically only routes traffic and often lacks encryption.(R)" },
                    { 59, false, 20, "A proxy server is always paid, while a VPN is always open-source and free." },
                    { 60, false, 20, "A VPN only works on mobile devices, while a proxy server only works on desktop computers." },
                    { 61, true, 21, "To monitor a network for malicious activity and generate alerts.(R)" },
                    { 62, false, 21, "To automatically encrypt all outgoing network traffic." },
                    { 63, false, 21, "To act as a physical barrier against unauthorized hardware." },
                    { 64, true, 22, "Network-based Intrusion Detection System (NIDS).(R)" },
                    { 65, false, 22, "Host-based Intrusion Detection System (HIDS)." },
                    { 66, false, 22, "Web Application Firewall (WAF)." },
                    { 67, true, 23, "Signature compares known patterns; anomaly looks for unusual deviations.(R)" },
                    { 68, false, 23, "Signature monitors incoming traffic; anomaly monitors outgoing." },
                    { 69, false, 23, "Signature requires internet; anomaly works entirely offline." },
                    { 70, true, 24, "Intrusion Prevention System (IPS) or Active IDS.(R)" },
                    { 71, false, 24, "Passive IDS." },
                    { 72, false, 24, "Honeypot." },
                    { 73, true, 25, "It acts as an internal alarm for breaches that bypass outer defenses.(R)" },
                    { 74, false, 25, "It routes all internet traffic for the organization." },
                    { 75, false, 25, "It is responsible for managing user passwords." },
                    { 76, true, 26, "A distributed Network-based Intrusion Detection System (NIDS).(R)" },
                    { 77, false, 26, "A standalone personal antivirus scanner." },
                    { 78, false, 26, "A basic stateless hardware router." },
                    { 79, true, 27, "An IDS only detects threats; an IPS actively blocks them.(R)" },
                    { 80, false, 27, "An IDS is hardware-based; an IPS is software-based." },
                    { 81, false, 27, "An IDS protects databases; an IPS protects web browsers." },
                    { 82, true, 28, "Deep Packet Inspection (DPI) enabled IDS.(R)" },
                    { 83, false, 28, "A standard Layer 3 packet sniffer." },
                    { 84, false, 28, "Circuit-level gateway." },
                    { 85, true, 29, "A decoy system to lure attackers and safely study their methods.(R)" },
                    { 86, false, 29, "To permanently store encrypted backups of sensitive data." },
                    { 87, false, 29, "To speed up legitimate user traffic by caching files." },
                    { 88, true, 30, "Host-based Intrusion Detection System (HIDS) or UEBA.(R)" },
                    { 89, false, 30, "Perimeter firewall." },
                    { 90, false, 30, "Site-to-site VPN." },
                    { 91, true, 31, "Encryption where the same secret key is used to encrypt and decrypt data.(R)" },
                    { 92, false, 31, "Encryption using a public key to encrypt and private to decrypt." },
                    { 93, false, 31, "A one-way mathematical hashing method." },
                    { 94, true, 32, "It is typically much faster than asymmetric encryption.(R)" },
                    { 95, false, 32, "It requires two mathematically linked keys." },
                    { 96, false, 32, "It is completely immune to brute-force attacks." },
                    { 97, true, 33, "Advanced Encryption Standard (AES).(R)" },
                    { 98, false, 33, "Rivest-Shamir-Adleman (RSA)." },
                    { 99, false, 33, "Elliptic Curve Cryptography (ECC)." },
                    { 100, true, 34, "Symmetric uses one shared key; asymmetric uses a public/private key pair.(R)" },
                    { 101, false, 34, "Symmetric is for digital signatures; asymmetric is for data storage." },
                    { 102, false, 34, "Symmetric encryption is significantly slower than asymmetric." },
                    { 103, true, 35, "The single piece of information required by both parties to lock and unlock data.(R)" },
                    { 104, false, 35, "A key publicly shared with anyone." },
                    { 105, false, 35, "A digital certificate to verify sender identity." },
                    { 106, true, 36, "Lightweight cryptography or stream ciphers (like RC4).(R)" },
                    { 107, false, 36, "RSA-4096." },
                    { 108, false, 36, "SHA-256." },
                    { 109, true, 37, "To encrypt data in fixed-size chunks (blocks) rather than bit-by-bit.(R)" },
                    { 110, false, 37, "To block unauthorized IP addresses." },
                    { 111, false, 37, "To compress data before sending." },
                    { 112, true, 38, "AES-256.(R)" },
                    { 113, false, 38, "Data Encryption Standard (DES)." },
                    { 114, false, 38, "Message-Digest algorithm 5 (MD5)." },
                    { 115, true, 39, "To securely share the single secret key over an insecure channel.(R)" },
                    { 116, false, 39, "To constantly change the block size." },
                    { 117, false, 39, "To publicly broadcast the encryption key." },
                    { 118, true, 40, "Algorithms like Blowfish or RC4.(R)" },
                    { 119, false, 40, "AES-128." },
                    { 120, false, 40, "SHA-1." },
                    { 121, true, 41, "Encryption that uses a linked pair of keys—a public key and a private key.(R)" },
                    { 122, false, 41, "Encryption using a single shared secret key." },
                    { 123, false, 41, "A one-way non-reversible hashing function." },
                    { 124, true, 42, "Allows secure communication without sharing a secret key beforehand.(R)" },
                    { 125, false, 42, "Processes data much faster than symmetric encryption." },
                    { 126, false, 42, "Requires a physical meeting to exchange passwords." },
                    { 127, true, 43, "RSA (Rivest-Shamir-Adleman).(R)" },
                    { 128, false, 43, "AES (Advanced Encryption Standard)." },
                    { 129, false, 43, "SHA-256." },
                    { 130, true, 44, "Asymmetric uses a key pair; symmetric uses a single shared key.(R)" },
                    { 131, false, 44, "Asymmetric is only for local storage." },
                    { 132, false, 44, "Asymmetric is significantly faster than symmetric." },
                    { 133, true, 45, "It is freely shared to encrypt data or verify a digital signature.(R)" },
                    { 134, false, 45, "It is kept secret and decrypts the message." },
                    { 135, false, 45, "It resets unauthorized access logs." },
                    { 136, true, 46, "Elliptic Curve Cryptography (ECC).(R)" },
                    { 137, false, 46, "Data Encryption Standard (DES)." },
                    { 138, false, 46, "Blowfish." },
                    { 139, true, 47, "To verify a message's authenticity and integrity.(R)" },
                    { 140, false, 47, "To encrypt the hard drive on logout." },
                    { 141, false, 47, "To compress files before sending over a network." },
                    { 142, true, 48, "RSA with key sizes of 2048 bits or higher.(R)" },
                    { 143, false, 48, "AES with a 256-bit key." },
                    { 144, false, 48, "Triple DES (3DES)." },
                    { 145, true, 49, "To securely establish a shared symmetric key (e.g., Diffie-Hellman).(R)" },
                    { 146, false, 49, "To translate IPv4 to IPv6." },
                    { 147, false, 49, "To block malware IP addresses." },
                    { 148, true, 50, "RSA, which allows variable key sizes (e.g., 1024, 2048).(R)" },
                    { 149, false, 50, "Stream ciphers like RC4." },
                    { 150, false, 50, "Block ciphers like AES." },
                    { 151, true, 51, "A one-way mathematical process that converts data into a fixed-size string.(R)" },
                    { 152, false, 51, "A two-way encryption method using public and private keys." },
                    { 153, false, 51, "A technique to compress files for faster network transmission." },
                    { 154, true, 52, "To verify data integrity and securely store passwords.(R)" },
                    { 155, false, 52, "To securely transmit encryption keys over the internet." },
                    { 156, false, 52, "To permanently erase data from a hard drive." },
                    { 157, true, 53, "SHA-256 (Secure Hash Algorithm 256).(R)" },
                    { 158, false, 53, "AES (Advanced Encryption Standard)." },
                    { 159, false, 53, "RSA (Rivest-Shamir-Adleman)." },
                    { 160, true, 54, "Hashing is one-way for data integrity, while encryption is two-way for confidentiality.(R)" },
                    { 161, false, 54, "Hashing uses public keys, while encryption uses shared keys." },
                    { 162, false, 54, "Hashing is only for emails, while encryption is only for databases." },
                    { 163, true, 55, "It mathematically converts an input of any length into a fixed-size output.(R)" },
                    { 164, false, 55, "It decrypts messages back into plain text." },
                    { 165, false, 55, "It assigns a random, hidden IP address to devices." },
                    { 166, true, 56, "Lightweight hash functions designed for IoT and constrained environments.(R)" },
                    { 167, false, 56, "SHA-512, which compresses its output to save space." },
                    { 168, false, 56, "RSA-2048." },
                    { 169, true, 57, "To add random data before hashing, preventing rainbow table attacks.(R)" },
                    { 170, false, 57, "To speed up the hashing process for large databases." },
                    { 171, false, 57, "To allow administrators to reverse the hash to the original password." },
                    { 172, true, 58, "SHA-512.(R)" },
                    { 173, false, 58, "MD5." },
                    { 174, false, 58, "CRC32." },
                    { 175, true, 59, "To intentionally slow down the hashing process, making brute-force attacks harder.(R)" },
                    { 176, false, 59, "To automatically increase the length of a short password." },
                    { 177, false, 59, "To stretch the hash output across multiple servers." },
                    { 178, true, 60, "Extendable-Output Functions (XOFs), like SHAKE128 or SHAKE256.(R)" },
                    { 179, false, 60, "SHA-256, which dynamically changes its digest size." },
                    { 180, false, 60, "AES-GCM." },
                    { 181, true, 61, "A vulnerability where an attacker interferes with an application's database queries.(R)" },
                    { 182, false, 61, "A standard method to safely encrypt database passwords." },
                    { 183, false, 61, "A tool developers use to speed up slow database connections." },
                    { 184, true, 62, "To view, modify, or delete unauthorized data in a database.(R)" },
                    { 185, false, 62, "To trick users into clicking malicious email links." },
                    { 186, false, 62, "To permanently physically damage the server's hard drive." },
                    { 187, true, 63, "Entering malicious SQL commands into input fields like login forms.(R)" },
                    { 188, false, 63, "Sending millions of fake network packets to crash the server." },
                    { 189, false, 63, "Guessing user passwords using a dictionary file." },
                    { 190, true, 64, "SQL injection specifically targets relational databases, not the OS or web browser.(R)" },
                    { 191, false, 64, "SQL injection only works on mobile applications." },
                    { 192, false, 64, "SQL injection is a legal technique used for data backups." },
                    { 193, true, 65, "It ensures only safe, expected characters are accepted by the application.(R)" },
                    { 194, false, 65, "It automatically translates all input into HTML code." },
                    { 195, false, 65, "It physically blocks IP addresses from unknown countries." },
                    { 196, true, 66, "UNION-based or Error-based SQL injection.(R)" },
                    { 197, false, 66, "Ransomware data injection." },
                    { 198, false, 66, "Cross-Site Scripting (XSS)." },
                    { 199, true, 67, "They separate the SQL code from the user's data, making malicious input harmless.(R)" },
                    { 200, false, 67, "They delete the entire database if an attack is detected." },
                    { 201, false, 67, "They compress the database size for faster loading times." },
                    { 202, true, 68, "Injecting UPDATE, INSERT, or DELETE statements.(R)" },
                    { 203, false, 68, "Using the SELECT statement to read tables." },
                    { 204, false, 68, "Using the PING command to test network speed." },
                    { 205, true, 69, "It inspects incoming web traffic and blocks known SQL attack patterns.(R)" },
                    { 206, false, 69, "It unplugs the database server when it gets too hot." },
                    { 207, false, 69, "It forces users to change their database passwords every 30 days." },
                    { 208, true, 70, "Exploiting database features like xp_cmdshell to run OS commands.(R)" },
                    { 209, false, 70, "Phishing SQL injection." },
                    { 210, false, 70, "Man-in-the-middle SQL injection." },
                    { 211, true, 71, "Injecting malicious scripts into otherwise benign and trusted websites.(R)" },
                    { 212, false, 71, "Overloading a server with traffic to crash it." },
                    { 213, false, 71, "Intercepting data between a database and a web server." },
                    { 214, true, 72, "To execute malicious code in a victim's web browser.(R)" },
                    { 215, false, 72, "To gain direct administrative access to the backend database." },
                    { 216, false, 72, "To crack user passwords using brute force." },
                    { 217, true, 73, "Injecting malicious JavaScript payloads.(R)" },
                    { 218, false, 73, "Executing unauthorized SQL database queries." },
                    { 219, false, 73, "Exploiting hardware router misconfigurations." },
                    { 220, true, 74, "XSS targets the user's browser, while SQLi targets the backend database.(R)" },
                    { 221, false, 74, "XSS only affects mobile apps, while SQLi affects desktop apps." },
                    { 222, false, 74, "XSS requires physical access to the target machine." },
                    { 223, true, 75, "It ensures only safe, expected characters are processed by the application.(R)" },
                    { 224, false, 75, "It automatically blocks IP addresses from unknown locations." },
                    { 225, false, 75, "It automatically encrypts user passwords in the database." },
                    { 226, true, 76, "A payload that accesses document.cookie to steal active session tokens.(R)" },
                    { 227, false, 76, "A payload that permanently deletes database tables." },
                    { 228, false, 76, "A payload that resets the user's home internet router." },
                    { 229, true, 77, "It converts special characters into safe HTML entities so they display safely instead of executing.(R)" },
                    { 230, false, 77, "It compresses website images for faster loading times." },
                    { 231, false, 77, "It hides the website's source code from visitors." },
                    { 232, true, 78, "Stored XSS, where the malicious script is permanently saved on the server and shown to all visitors.(R)" },
                    { 233, false, 78, "Phishing XSS, where users are tricked via email." },
                    { 234, false, 78, "Hardware XSS, targeting the physical server components." },
                    { 235, true, 79, "It restricts which external scripts can be loaded and executed by the browser.(R)" },
                    { 236, false, 79, "It automatically updates the server's operating system." },
                    { 237, false, 79, "It physically blocks users from taking screenshots of the website." },
                    { 238, true, 80, "Reflected XSS, where the script bounces off the web server directly to the victim via a crafted link.(R)" },
                    { 239, false, 80, "Ransomware XSS, which encrypts the user's hard drive." },
                    { 240, false, 80, "DDoS XSS, which crashes the victim's computer hardware." },
                    { 241, true, 81, "An attack that forces an authenticated user to execute unwanted actions on a web application.(R)" },
                    { 242, false, 81, "A method used by developers to securely encrypt data in transit." },
                    { 243, false, 81, "A technique used to optimize backend database queries." },
                    { 244, true, 82, "To trick a victim's browser into performing actions they didn't intend, like transferring funds.(R)" },
                    { 245, false, 82, "To physically damage the target server's hard drives." },
                    { 246, false, 82, "To directly extract encrypted passwords from the database." },
                    { 247, true, 83, "Social engineering, like sending a malicious link, to trigger the forged request.(R)" },
                    { 248, false, 83, "Brute-forcing admin passwords." },
                    { 249, false, 83, "Man-in-the-middle physical cable tapping." },
                    { 250, true, 84, "CSRF exploits the site's trust in the browser, while XSS exploits the user's trust in the site.(R)" },
                    { 251, false, 84, "CSRF only targets mobile applications." },
                    { 252, false, 84, "CSRF relies entirely on hardware failure." },
                    { 253, true, 85, "It offers minimal protection, as forged CSRF requests often contain perfectly valid input data.(R)" },
                    { 254, false, 85, "It is the only guaranteed way to stop CSRF attacks completely." },
                    { 255, false, 85, "It automatically disconnects the attacker's IP address." },
                    { 256, true, 86, "Login CSRF, where an attacker logs the victim into the attacker's account to capture their activity.(R)" },
                    { 257, false, 86, "Ransomware CSRF." },
                    { 258, false, 86, "Hardware CSRF." },
                    { 259, true, 87, "To ensure the request originated from the legitimate app by requiring a unique, unpredictable hidden value.(R)" },
                    { 260, false, 87, "To automatically compress HTTP requests to save bandwidth." },
                    { 261, false, 87, "To block all incoming internet traffic during maintenance." },
                    { 262, true, 88, "State-changing requests, such as updating an email address or changing a password.(R)" },
                    { 263, false, 88, "Bandwidth-draining requests." },
                    { 264, false, 88, "Network ping requests." },
                    { 265, true, 89, "It can inspect HTTP headers (like Referer or Origin) to block requests from unexpected external domains.(R)" },
                    { 266, false, 89, "It unplugs the server if multiple CSRF attacks are detected." },
                    { 267, false, 89, "It forces all users to use two-factor authentication." },
                    { 268, true, 90, "CSRF itself doesn't execute commands directly, but it can trigger administrative functions if the victim is an admin.(R)" },
                    { 269, false, 90, "Buffer-overflow CSRF." },
                    { 270, false, 90, "Shell-shock CSRF." }
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
