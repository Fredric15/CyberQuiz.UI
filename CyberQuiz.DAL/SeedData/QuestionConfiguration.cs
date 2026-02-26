using CyberQuiz.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CyberQuiz.DAL.SeedData
{
    public class QuestionConfiguration : IEntityTypeConfiguration<QuestionModel>
    {
        public void Configure(EntityTypeBuilder<QuestionModel> builder)
        {
            //Firewall Quiz 1
            builder.HasData(
                new QuestionModel { Id = 1, Text = "What is the primary purpose of a firewall in cybersecurity?", QuizModelId = 1 },
                new QuestionModel { Id = 2, Text = "Which type of firewall operates at the network layer and filters traffic based on IP addresses and ports?", QuizModelId = 1 },
                new QuestionModel { Id = 3, Text = "What is a common method used by firewalls to inspect and filter network traffic?", QuizModelId = 1 },
                new QuestionModel { Id = 4, Text = "Which type of firewall is designed to protect a specific application or service?", QuizModelId = 1 },
                new QuestionModel { Id = 5, Text = "What is the difference between a stateful and stateless firewall?", QuizModelId = 1 },
                new QuestionModel { Id = 6, Text = "Which type of firewall is typically used to protect a home network?", QuizModelId = 1 },
                new QuestionModel { Id = 7, Text = "What is the purpose of a demilitarized zone (DMZ) in a firewall architecture?", QuizModelId = 1 },
                new QuestionModel { Id = 8, Text = "Which type of firewall is designed to analyze and filter traffic based on the content of the data packets?", QuizModelId = 1 },
                new QuestionModel { Id = 9, Text = "What is the role of a firewall in preventing unauthorized access to a network?", QuizModelId = 1 },
                new QuestionModel { Id = 10, Text = "Which type of firewall is typically used in enterprise environments to protect against advanced threats?", QuizModelId = 1 },
                
                //Vpn Quiz 2
                new QuestionModel { Id = 11, Text = "What does VPN stand for in cybersecurity?", QuizModelId = 2 },
                new QuestionModel { Id = 12, Text = "What is the primary purpose of a VPN in cybersecurity?", QuizModelId = 2 },
                new QuestionModel { Id = 13, Text = "Which type of VPN allows users to connect to a private network over the internet?", QuizModelId = 2 },
                new QuestionModel { Id = 14, Text = "What is the difference between a site-to-site VPN and a remote access VPN?", QuizModelId = 2 },
                new QuestionModel { Id = 15, Text = "Which protocol is commonly used for secure VPN connections?", QuizModelId = 2 },
                new QuestionModel { Id = 16, Text = "What is the purpose of encryption in a VPN connection?", QuizModelId = 2 },
                new QuestionModel { Id = 17, Text = "Which type of VPN is typically used by businesses to connect multiple office locations?", QuizModelId = 2 },
                new QuestionModel { Id = 18, Text = "What is the role of a VPN in protecting user privacy and anonymity online?", QuizModelId = 2 },
                new QuestionModel { Id = 19, Text = "Which type of VPN is designed to provide secure access to a specific application or service?", QuizModelId = 2 },
                new QuestionModel { Id = 20, Text = "What is the difference between a VPN and a proxy server?", QuizModelId = 2 },

                //Intrusion Detection Quiz 3
                new QuestionModel { Id = 21, Text = "What is the primary purpose of an intrusion detection system (IDS) in cybersecurity?", QuizModelId = 3 },
                new QuestionModel { Id = 22, Text = "Which type of IDS analyzes network traffic for signs of malicious activity?", QuizModelId = 3 },
                new QuestionModel { Id = 23, Text = "What is the difference between a signature-based IDS and an anomaly-based IDS?", QuizModelId = 3 },
                new QuestionModel { Id = 24, Text = "Which type of IDS is designed to detect and prevent attacks in real-time?", QuizModelId = 3 },
                new QuestionModel { Id = 25, Text = "What is the role of an IDS in a layered security approach?", QuizModelId = 3 },
                new QuestionModel { Id = 26, Text = "Which type of IDS is typically used in enterprise environments to monitor network traffic?", QuizModelId = 3 },
                new QuestionModel { Id = 27, Text = "What is the difference between an IDS and an intrusion prevention system (IPS)?", QuizModelId = 3 },
                new QuestionModel { Id = 28, Text = "Which type of IDS is designed to analyze and filter traffic based on the content of the data packets?", QuizModelId = 3 },
                new QuestionModel { Id = 29, Text = "What is the purpose of a honeypot in an IDS architecture?", QuizModelId = 3 },
                new QuestionModel { Id = 30, Text = "Which type of IDS is designed to detect and prevent insider threats?", QuizModelId = 3 },

                //Symmetric Encryption Quiz 4
                new QuestionModel { Id = 31, Text = "What is symmetric encryption in cybersecurity?", QuizModelId = 4 },
                new QuestionModel { Id = 32, Text = "What is the primary characteristic of symmetric encryption?", QuizModelId = 4 },
                new QuestionModel { Id = 33, Text = "Which algorithm is commonly used for symmetric encryption?", QuizModelId = 4 },
                new QuestionModel { Id = 34, Text = "What is the difference between symmetric encryption and asymmetric encryption?", QuizModelId = 4 },
                new QuestionModel { Id = 35, Text = "What is the role of a secret key in symmetric encryption?", QuizModelId = 4 },
                new QuestionModel { Id = 36, Text = "Which type of symmetric encryption is designed to provide strong security with a small key size?", QuizModelId = 4 },
                new QuestionModel { Id = 37, Text = "What is the purpose of a block cipher in symmetric encryption?", QuizModelId = 4 },
                new QuestionModel { Id = 38, Text = "Which type of symmetric encryption is designed to provide strong security with a large key size?", QuizModelId = 4 },
                new QuestionModel { Id = 39, Text = "What is the role of a key exchange protocol in symmetric encryption?", QuizModelId = 4 },
                new QuestionModel { Id = 40, Text = "Which type of symmetric encryption is designed to provide strong security with a variable key size?", QuizModelId = 4 },

                //Asymmetric Encryption Quiz 5
                new QuestionModel { Id = 41, Text = "What is asymmetric encryption in cybersecurity?", QuizModelId = 5 },
                new QuestionModel { Id = 42, Text = "What is the primary characteristic of asymmetric encryption?", QuizModelId = 5 },
                new QuestionModel { Id = 43, Text = "Which algorithm is commonly used for asymmetric encryption?", QuizModelId = 5 },
                new QuestionModel { Id = 44, Text = "What is the difference between asymmetric encryption and symmetric encryption?", QuizModelId = 5 },
                new QuestionModel { Id = 45, Text = "What is the role of a public key in asymmetric encryption?", QuizModelId = 5 },
                new QuestionModel { Id = 46, Text = "Which type of asymmetric encryption is designed to provide strong security with a small key size?", QuizModelId = 5 },
                new QuestionModel { Id = 47, Text = "What is the purpose of a digital signature in asymmetric encryption?", QuizModelId = 5 },
                new QuestionModel { Id = 48, Text = "Which type of asymmetric encryption is designed to provide strong security with a large key size?", QuizModelId = 5 },
                new QuestionModel { Id = 49, Text = "What is the role of a key exchange protocol in asymmetric encryption?", QuizModelId = 5 },
                new QuestionModel { Id = 50, Text = "Which type of asymmetric encryption is designed to provide strong security with a variable key size?", QuizModelId = 5 },

                //Hashing Quiz 6
                new QuestionModel { Id = 51, Text = "What is hashing in cybersecurity?", QuizModelId = 6 },
                new QuestionModel { Id = 52, Text = "What is the primary purpose of hashing in cybersecurity?", QuizModelId = 6 },
                new QuestionModel { Id = 53, Text = "Which algorithm is commonly used for hashing?", QuizModelId = 6 },
                new QuestionModel { Id = 54, Text = "What is the difference between hashing and encryption?", QuizModelId = 6 },
                new QuestionModel { Id = 55, Text = "What is the role of a hash function in hashing?", QuizModelId = 6 },
                new QuestionModel { Id = 56, Text = "Which type of hashing is designed to provide strong security with a small output size?", QuizModelId = 6 },
                new QuestionModel { Id = 57, Text = "What is the purpose of a salt in hashing?", QuizModelId = 6 },
                new QuestionModel { Id = 58, Text = "Which type of hashing is designed to provide strong security with a large output size?", QuizModelId = 6 },
                new QuestionModel { Id = 59, Text = "What is the role of a key stretching algorithm in hashing?", QuizModelId = 6 },
                new QuestionModel { Id = 60, Text = "Which type of hashing is designed to provide strong security with a variable output size?", QuizModelId = 6 },

                //SQL Injection Quiz 7
                new QuestionModel { Id = 61, Text = "What is SQL injection in cybersecurity?", QuizModelId = 7 },
                new QuestionModel { Id = 62, Text = "What is the primary purpose of SQL injection in cybersecurity?", QuizModelId = 7 },
                new QuestionModel { Id = 63, Text = "Which type of attack is commonly used in SQL injection?", QuizModelId = 7 },
                new QuestionModel { Id = 64, Text = "What is the difference between SQL injection and other types of injection attacks?", QuizModelId = 7 },
                new QuestionModel { Id = 65, Text = "What is the role of input validation in preventing SQL injection?", QuizModelId = 7 },
                new QuestionModel { Id = 66, Text = "Which type of SQL injection is designed to extract data from a database?", QuizModelId = 7 },
                new QuestionModel { Id = 67, Text = "What is the purpose of parameterized queries in preventing SQL injection?", QuizModelId = 7 },
                new QuestionModel { Id = 68, Text = "Which type of SQL injection is designed to modify data in a database?", QuizModelId = 7 },
                new QuestionModel { Id = 69, Text = "What is the role of a web application firewall (WAF) in preventing SQL injection?", QuizModelId = 7 },
                new QuestionModel { Id = 70, Text = "Which type of SQL injection is designed to execute arbitrary commands on a database?", QuizModelId = 7 },

                //Cross-Site Scripting (XSS) Quiz 8
                new QuestionModel { Id = 71, Text = "What is cross-site scripting (XSS) in cybersecurity?", QuizModelId = 8 },
                new QuestionModel { Id = 72, Text = "What is the primary purpose of cross-site scripting (XSS) in cybersecurity?", QuizModelId = 8 },
                new QuestionModel { Id = 73, Text = "Which type of attack is commonly used in cross-site scripting (XSS)?", QuizModelId = 8 },
                new QuestionModel { Id = 74, Text = "What is the difference between cross-site scripting (XSS) and other types of injection attacks?", QuizModelId = 8 },
                new QuestionModel { Id = 75, Text = "What is the role of input validation in preventing cross-site scripting (XSS)?", QuizModelId = 8 },
                new QuestionModel { Id = 76, Text = "Which type of cross-site scripting (XSS) is designed to steal user credentials?", QuizModelId = 8 },
                new QuestionModel { Id = 77, Text = "What is the purpose of output encoding in preventing cross-site scripting (XSS)?", QuizModelId = 8 },
                new QuestionModel { Id = 78, Text = "Which type of cross-site scripting (XSS) is designed to deface a website?", QuizModelId = 8 },
                new QuestionModel { Id = 79, Text = "What is the role of a content security policy (CSP) in preventing cross-site scripting (XSS)?", QuizModelId = 8 },
                new QuestionModel { Id = 80, Text = "Which type of cross-site scripting (XSS) is designed to execute arbitrary scripts in a user's browser?", QuizModelId = 8 },

                //Cross-Site Request Forgery (CSRF) Quiz 9
                new QuestionModel { Id = 81, Text = "What is cross-site request forgery (CSRF) in cybersecurity?", QuizModelId = 9 },
                new QuestionModel { Id = 82, Text = "What is the primary purpose of cross-site request forgery (CSRF) in cybersecurity?", QuizModelId = 9 },
                new QuestionModel { Id = 83, Text = "Which type of attack is commonly used in cross-site request forgery (CSRF)?", QuizModelId = 9 },
                new QuestionModel { Id = 84, Text = "What is the difference between cross-site request forgery (CSRF) and other types of injection attacks?", QuizModelId = 9 },
                new QuestionModel { Id = 85, Text = "What is the role of input validation in preventing cross-site request forgery (CSRF)?", QuizModelId = 9 },
                new QuestionModel { Id = 86, Text = "Which type of cross-site request forgery (CSRF) is designed to steal user credentials?", QuizModelId = 9 },
                new QuestionModel { Id = 87, Text = "What is the purpose of anti-CSRF tokens in preventing cross-site request forgery (CSRF)?", QuizModelId = 9 },
                new QuestionModel { Id = 88, Text = "Which type of cross-site request forgery (CSRF) is designed to perform unauthorized actions on behalf of a user?", QuizModelId = 9 },
                new QuestionModel { Id = 89, Text = "What is the role of a web application firewall (WAF) in preventing cross-site request forgery (CSRF)?", QuizModelId = 9 },
                new QuestionModel { Id = 90, Text = "Which type of cross-site request forgery (CSRF) is designed to execute arbitrary commands on a server?", QuizModelId = 9 }
            );
        }

    }
}
