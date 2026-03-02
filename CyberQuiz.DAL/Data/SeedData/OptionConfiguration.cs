using CyberQuiz.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CyberQuiz.DAL.Data.SeedData
{
    public class OptionConfiguration : IEntityTypeConfiguration<OptionModel>
    {
        public void Configure(EntityTypeBuilder<OptionModel> builder)
        {
            builder.HasData(
                // Fråga 1: Primary purpose of a firewall
                new OptionModel { Id = 1, Text = "To monitor and control incoming and outgoing network traffic based on predetermined security rules.(R)", IsCorrect = true, QuestionModelId = 1 },
                new OptionModel { Id = 2, Text = "To encrypt all data stored on a computer's hard drive.", IsCorrect = false, QuestionModelId = 1 },
                new OptionModel { Id = 3, Text = "To permanently delete malware and viruses from an infected system.", IsCorrect = false, QuestionModelId = 1 },

                // Fråga 2: Operates at the network layer (IP/Ports)
                new OptionModel { Id = 4, Text = "Packet-filtering firewall.(R)", IsCorrect = true, QuestionModelId = 2 },
                new OptionModel { Id = 5, Text = "Web application firewall (WAF).", IsCorrect = false, QuestionModelId = 2 },
                new OptionModel { Id = 6, Text = "Next-generation firewall (NGFW).", IsCorrect = false, QuestionModelId = 2 },

                // Fråga 3: Common method to inspect/filter traffic
                new OptionModel { Id = 7, Text = "Stateful inspection.(R)", IsCorrect = true, QuestionModelId = 3 },
                new OptionModel { Id = 8, Text = "Phishing simulation.", IsCorrect = false, QuestionModelId = 3 },
                new OptionModel { Id = 9, Text = "Password hashing.", IsCorrect = false, QuestionModelId = 3 },

                // Fråga 4: Designed to protect a specific application or service
                new OptionModel { Id = 10, Text = "Application-level gateway (Proxy firewall) / WAF.(R)", IsCorrect = true, QuestionModelId = 4 },
                new OptionModel { Id = 11, Text = "Hardware-based packet firewall.", IsCorrect = false, QuestionModelId = 4 },
                new OptionModel { Id = 12, Text = "Stateless network firewall.", IsCorrect = false, QuestionModelId = 4 },

                // Fråga 5: Difference between stateful and stateless
                new OptionModel { Id = 13, Text = "Stateful firewalls track the operating state of connections, while stateless firewalls examine each packet individually.(R)", IsCorrect = true, QuestionModelId = 5 },
                new OptionModel { Id = 14, Text = "Stateful firewalls are only used in home networks, while stateless firewalls are for enterprise environments.", IsCorrect = false, QuestionModelId = 5 },
                new OptionModel { Id = 15, Text = "Stateful firewalls encrypt data in transit, while stateless firewalls only encrypt data at rest.", IsCorrect = false, QuestionModelId = 5 },

                // Fråga 6: Typically used to protect a home network
                new OptionModel { Id = 16, Text = "A broadband router with a built-in hardware NAT/firewall.(R)", IsCorrect = true, QuestionModelId = 6 },
                new OptionModel { Id = 17, Text = "An enterprise-grade Web Application Firewall (WAF).", IsCorrect = false, QuestionModelId = 6 },
                new OptionModel { Id = 18, Text = "A dedicated Deep Packet Inspection (DPI) server.", IsCorrect = false, QuestionModelId = 6 },

                // Fråga 7: Purpose of a demilitarized zone (DMZ)
                new OptionModel { Id = 19, Text = "To expose public-facing services to an untrusted network while keeping the internal local network secure.(R)", IsCorrect = true, QuestionModelId = 7 },
                new OptionModel { Id = 20, Text = "To completely block all incoming and outgoing internet traffic during maintenance.", IsCorrect = false, QuestionModelId = 7 },
                new OptionModel { Id = 21, Text = "To create a high-speed bypass lane that skips all security checks for VIP users.", IsCorrect = false, QuestionModelId = 7 },

                // Fråga 8: Analyze and filter based on content of data packets
                new OptionModel { Id = 22, Text = "Deep Packet Inspection (DPI) firewall.(R)", IsCorrect = true, QuestionModelId = 8 },
                new OptionModel { Id = 23, Text = "Stateless packet-filtering firewall.", IsCorrect = false, QuestionModelId = 8 },
                new OptionModel { Id = 24, Text = "Circuit-level gateway.", IsCorrect = false, QuestionModelId = 8 },

                // Fråga 9: Role in preventing unauthorized access
                new OptionModel { Id = 25, Text = "It acts as a barrier that blocks unauthorized connection attempts from external sources.(R)", IsCorrect = true, QuestionModelId = 9 },
                new OptionModel { Id = 26, Text = "It automatically resets user passwords if they are suspected to be compromised.", IsCorrect = false, QuestionModelId = 9 },
                new OptionModel { Id = 27, Text = "It physically disconnects the network cable when a threat is detected.", IsCorrect = false, QuestionModelId = 9 },

                // Fråga 10: Enterprise environments for advanced threats
                new OptionModel { Id = 28, Text = "Next-Generation Firewall (NGFW).(R)", IsCorrect = true, QuestionModelId = 10 },
                new OptionModel { Id = 29, Text = "Software firewall bundled with a standard operating system.", IsCorrect = false, QuestionModelId = 10 },
                new OptionModel { Id = 30, Text = "A basic layer 3 packet-filtering router.", IsCorrect = false, QuestionModelId = 10 },

                // Fråga 11: What does VPN stand for
                new OptionModel { Id = 31, Text = "Virtual Private Network.(R)", IsCorrect = true, QuestionModelId = 11 },
                new OptionModel { Id = 32, Text = "Visual Processing Node.", IsCorrect = false, QuestionModelId = 11 },
                new OptionModel { Id = 33, Text = "Verified Public Network.", IsCorrect = false, QuestionModelId = 11 },

                // Fråga 12: Primary purpose of a VPN
                new OptionModel { Id = 34, Text = "To create a secure, encrypted connection over a less secure network like the internet.(R)", IsCorrect = true, QuestionModelId = 12 },
                new OptionModel { Id = 35, Text = "To permanently delete viruses and malware from a local machine.", IsCorrect = false, QuestionModelId = 12 },
                new OptionModel { Id = 36, Text = "To boost the physical hardware speed of an internet connection.", IsCorrect = false, QuestionModelId = 12 },

                // Fråga 13: Type of VPN to connect to private network over internet
                new OptionModel { Id = 37, Text = "Remote access VPN.(R)", IsCorrect = true, QuestionModelId = 13 },
                new OptionModel { Id = 38, Text = "Local Area Network (LAN) VPN.", IsCorrect = false, QuestionModelId = 13 },
                new OptionModel { Id = 39, Text = "Hardware-only VPN.", IsCorrect = false, QuestionModelId = 13 },

                // Fråga 14: Difference between site-to-site and remote access
                new OptionModel { Id = 40, Text = "Site-to-site connects entire networks together, while remote access connects individual devices to a network.(R)", IsCorrect = true, QuestionModelId = 14 },
                new OptionModel { Id = 41, Text = "Site-to-site is only for home use, while remote access is exclusively for large enterprises.", IsCorrect = false, QuestionModelId = 14 },
                new OptionModel { Id = 42, Text = "Site-to-site does not use encryption, while remote access requires heavy encryption.", IsCorrect = false, QuestionModelId = 14 },

                // Fråga 15: Protocol commonly used for secure VPN connections
                new OptionModel { Id = 43, Text = "IPsec (Internet Protocol Security) or OpenVPN.(R)", IsCorrect = true, QuestionModelId = 15 },
                new OptionModel { Id = 44, Text = "HTTP (Hypertext Transfer Protocol).", IsCorrect = false, QuestionModelId = 15 },
                new OptionModel { Id = 45, Text = "FTP (File Transfer Protocol).", IsCorrect = false, QuestionModelId = 15 },

                // Fråga 16: Purpose of encryption in a VPN
                new OptionModel { Id = 46, Text = "To scramble data so that unauthorized parties cannot read it if intercepted.(R)", IsCorrect = true, QuestionModelId = 16 },
                new OptionModel { Id = 47, Text = "To compress files so they download faster over the network.", IsCorrect = false, QuestionModelId = 16 },
                new OptionModel { Id = 48, Text = "To prevent the user's device from overheating during heavy network usage.", IsCorrect = false, QuestionModelId = 16 },

                // Fråga 17: VPN typically used by businesses to connect multiple offices
                new OptionModel { Id = 49, Text = "Site-to-site VPN.(R)", IsCorrect = true, QuestionModelId = 17 },
                new OptionModel { Id = 50, Text = "Personal consumer VPN.", IsCorrect = false, QuestionModelId = 17 },
                new OptionModel { Id = 51, Text = "Proxy-only VPN.", IsCorrect = false, QuestionModelId = 17 },

                // Fråga 18: Role in protecting user privacy and anonymity
                new OptionModel { Id = 52, Text = "It masks the user's real IP address and encrypts their internet traffic.(R)", IsCorrect = true, QuestionModelId = 18 },
                new OptionModel { Id = 53, Text = "It automatically blocks all cookies and browser trackers.", IsCorrect = false, QuestionModelId = 18 },
                new OptionModel { Id = 54, Text = "It makes the user completely immune to all types of phishing attacks.", IsCorrect = false, QuestionModelId = 18 },

                // Fråga 19: Designed to provide secure access to a specific application
                new OptionModel { Id = 55, Text = "Per-App VPN (or Application-level VPN).(R)", IsCorrect = true, QuestionModelId = 19 },
                new OptionModel { Id = 56, Text = "Full-tunnel network VPN.", IsCorrect = false, QuestionModelId = 19 },
                new OptionModel { Id = 57, Text = "Intranet VPN.", IsCorrect = false, QuestionModelId = 19 },

                // Fråga 20: Difference between VPN and proxy server
                new OptionModel { Id = 58, Text = "A VPN encrypts all network traffic, while a proxy server typically only routes traffic and often lacks encryption.(R)", IsCorrect = true, QuestionModelId = 20 },
                new OptionModel { Id = 59, Text = "A proxy server is always paid, while a VPN is always open-source and free.", IsCorrect = false, QuestionModelId = 20 },
                new OptionModel { Id = 60, Text = "A VPN only works on mobile devices, while a proxy server only works on desktop computers.", IsCorrect = false, QuestionModelId = 20 },

                // Fråga 21: Primary purpose of an intrusion detection system (IDS)
                new OptionModel { Id = 61, Text = "To monitor a network for malicious activity and generate alerts.(R)", IsCorrect = true, QuestionModelId = 21 },
                new OptionModel { Id = 62, Text = "To automatically encrypt all outgoing network traffic.", IsCorrect = false, QuestionModelId = 21 },
                new OptionModel { Id = 63, Text = "To act as a physical barrier against unauthorized hardware.", IsCorrect = false, QuestionModelId = 21 },

                // Fråga 22: Type of IDS that analyzes network traffic
                new OptionModel { Id = 64, Text = "Network-based Intrusion Detection System (NIDS).(R)", IsCorrect = true, QuestionModelId = 22 },
                new OptionModel { Id = 65, Text = "Host-based Intrusion Detection System (HIDS).", IsCorrect = false, QuestionModelId = 22 },
                new OptionModel { Id = 66, Text = "Web Application Firewall (WAF).", IsCorrect = false, QuestionModelId = 22 },

                // Fråga 23: Difference between signature-based and anomaly-based
                new OptionModel { Id = 67, Text = "Signature compares known patterns; anomaly looks for unusual deviations.(R)", IsCorrect = true, QuestionModelId = 23 },
                new OptionModel { Id = 68, Text = "Signature monitors incoming traffic; anomaly monitors outgoing.", IsCorrect = false, QuestionModelId = 23 },
                new OptionModel { Id = 69, Text = "Signature requires internet; anomaly works entirely offline.", IsCorrect = false, QuestionModelId = 23 },

                // Fråga 24: Designed to detect and prevent attacks in real-time
                new OptionModel { Id = 70, Text = "Intrusion Prevention System (IPS) or Active IDS.(R)", IsCorrect = true, QuestionModelId = 24 },
                new OptionModel { Id = 71, Text = "Passive IDS.", IsCorrect = false, QuestionModelId = 24 },
                new OptionModel { Id = 72, Text = "Honeypot.", IsCorrect = false, QuestionModelId = 24 },

                // Fråga 25: Role of an IDS in a layered security approach
                new OptionModel { Id = 73, Text = "It acts as an internal alarm for breaches that bypass outer defenses.(R)", IsCorrect = true, QuestionModelId = 25 },
                new OptionModel { Id = 74, Text = "It routes all internet traffic for the organization.", IsCorrect = false, QuestionModelId = 25 },
                new OptionModel { Id = 75, Text = "It is responsible for managing user passwords.", IsCorrect = false, QuestionModelId = 25 },

                // Fråga 26: Typically used in enterprise environments to monitor network traffic
                new OptionModel { Id = 76, Text = "A distributed Network-based Intrusion Detection System (NIDS).(R)", IsCorrect = true, QuestionModelId = 26 },
                new OptionModel { Id = 77, Text = "A standalone personal antivirus scanner.", IsCorrect = false, QuestionModelId = 26 },
                new OptionModel { Id = 78, Text = "A basic stateless hardware router.", IsCorrect = false, QuestionModelId = 26 },

                // Fråga 27: Difference between IDS and IPS
                new OptionModel { Id = 79, Text = "An IDS only detects threats; an IPS actively blocks them.(R)", IsCorrect = true, QuestionModelId = 27 },
                new OptionModel { Id = 80, Text = "An IDS is hardware-based; an IPS is software-based.", IsCorrect = false, QuestionModelId = 27 },
                new OptionModel { Id = 81, Text = "An IDS protects databases; an IPS protects web browsers.", IsCorrect = false, QuestionModelId = 27 },

                // Fråga 28: Analyze and filter based on content of data packets
                new OptionModel { Id = 82, Text = "Deep Packet Inspection (DPI) enabled IDS.(R)", IsCorrect = true, QuestionModelId = 28 },
                new OptionModel { Id = 83, Text = "A standard Layer 3 packet sniffer.", IsCorrect = false, QuestionModelId = 28 },
                new OptionModel { Id = 84, Text = "Circuit-level gateway.", IsCorrect = false, QuestionModelId = 28 },

                // Fråga 29: Purpose of a honeypot in an IDS architecture
                new OptionModel { Id = 85, Text = "A decoy system to lure attackers and safely study their methods.(R)", IsCorrect = true, QuestionModelId = 29 },
                new OptionModel { Id = 86, Text = "To permanently store encrypted backups of sensitive data.", IsCorrect = false, QuestionModelId = 29 },
                new OptionModel { Id = 87, Text = "To speed up legitimate user traffic by caching files.", IsCorrect = false, QuestionModelId = 29 },

                // Fråga 30: Designed to detect and prevent insider threats
                new OptionModel { Id = 88, Text = "Host-based Intrusion Detection System (HIDS) or UEBA.(R)", IsCorrect = true, QuestionModelId = 30 },
                new OptionModel { Id = 89, Text = "Perimeter firewall.", IsCorrect = false, QuestionModelId = 30 },
                new OptionModel { Id = 90, Text = "Site-to-site VPN.", IsCorrect = false, QuestionModelId = 30 },

                // Fråga 31: What is symmetric encryption in cybersecurity?
                new OptionModel { Id = 91, Text = "Encryption where the same secret key is used to encrypt and decrypt data.(R)", IsCorrect = true, QuestionModelId = 31 },
                new OptionModel { Id = 92, Text = "Encryption using a public key to encrypt and private to decrypt.", IsCorrect = false, QuestionModelId = 31 },
                new OptionModel { Id = 93, Text = "A one-way mathematical hashing method.", IsCorrect = false, QuestionModelId = 31 },

                // Fråga 32: Primary characteristic of symmetric encryption
                new OptionModel { Id = 94, Text = "It is typically much faster than asymmetric encryption.(R)", IsCorrect = true, QuestionModelId = 32 },
                new OptionModel { Id = 95, Text = "It requires two mathematically linked keys.", IsCorrect = false, QuestionModelId = 32 },
                new OptionModel { Id = 96, Text = "It is completely immune to brute-force attacks.", IsCorrect = false, QuestionModelId = 32 },

                // Fråga 33: Algorithm commonly used for symmetric encryption
                new OptionModel { Id = 97, Text = "Advanced Encryption Standard (AES).(R)", IsCorrect = true, QuestionModelId = 33 },
                new OptionModel { Id = 98, Text = "Rivest-Shamir-Adleman (RSA).", IsCorrect = false, QuestionModelId = 33 },
                new OptionModel { Id = 99, Text = "Elliptic Curve Cryptography (ECC).", IsCorrect = false, QuestionModelId = 33 },

                // Fråga 34: Difference between symmetric and asymmetric encryption
                new OptionModel { Id = 100, Text = "Symmetric uses one shared key; asymmetric uses a public/private key pair.(R)", IsCorrect = true, QuestionModelId = 34 },
                new OptionModel { Id = 101, Text = "Symmetric is for digital signatures; asymmetric is for data storage.", IsCorrect = false, QuestionModelId = 34 },
                new OptionModel { Id = 102, Text = "Symmetric encryption is significantly slower than asymmetric.", IsCorrect = false, QuestionModelId = 34 },

                // Fråga 35: Role of a secret key in symmetric encryption
                new OptionModel { Id = 103, Text = "The single piece of information required by both parties to lock and unlock data.(R)", IsCorrect = true, QuestionModelId = 35 },
                new OptionModel { Id = 104, Text = "A key publicly shared with anyone.", IsCorrect = false, QuestionModelId = 35 },
                new OptionModel { Id = 105, Text = "A digital certificate to verify sender identity.", IsCorrect = false, QuestionModelId = 35 },

                // Fråga 36: Designed to provide strong security with a small key size
                new OptionModel { Id = 106, Text = "Lightweight cryptography or stream ciphers (like RC4).(R)", IsCorrect = true, QuestionModelId = 36 },
                new OptionModel { Id = 107, Text = "RSA-4096.", IsCorrect = false, QuestionModelId = 36 },
                new OptionModel { Id = 108, Text = "SHA-256.", IsCorrect = false, QuestionModelId = 36 },

                // Fråga 37: Purpose of a block cipher in symmetric encryption
                new OptionModel { Id = 109, Text = "To encrypt data in fixed-size chunks (blocks) rather than bit-by-bit.(R)", IsCorrect = true, QuestionModelId = 37 },
                new OptionModel { Id = 110, Text = "To block unauthorized IP addresses.", IsCorrect = false, QuestionModelId = 37 },
                new OptionModel { Id = 111, Text = "To compress data before sending.", IsCorrect = false, QuestionModelId = 37 },

                // Fråga 38: Designed to provide strong security with a large key size
                new OptionModel { Id = 112, Text = "AES-256.(R)", IsCorrect = true, QuestionModelId = 38 },
                new OptionModel { Id = 113, Text = "Data Encryption Standard (DES).", IsCorrect = false, QuestionModelId = 38 },
                new OptionModel { Id = 114, Text = "Message-Digest algorithm 5 (MD5).", IsCorrect = false, QuestionModelId = 38 },

                // Fråga 39: Role of a key exchange protocol in symmetric encryption
                new OptionModel { Id = 115, Text = "To securely share the single secret key over an insecure channel.(R)", IsCorrect = true, QuestionModelId = 39 },
                new OptionModel { Id = 116, Text = "To constantly change the block size.", IsCorrect = false, QuestionModelId = 39 },
                new OptionModel { Id = 117, Text = "To publicly broadcast the encryption key.", IsCorrect = false, QuestionModelId = 39 },

                // Fråga 40: Designed to provide strong security with a variable key size
                new OptionModel { Id = 118, Text = "Algorithms like Blowfish or RC4.(R)", IsCorrect = true, QuestionModelId = 40 },
                new OptionModel { Id = 119, Text = "AES-128.", IsCorrect = false, QuestionModelId = 40 },
                new OptionModel { Id = 120, Text = "SHA-1.", IsCorrect = false, QuestionModelId = 40 },

                // Fråga 41: What is asymmetric encryption?
                new OptionModel { Id = 121, Text = "Encryption that uses a linked pair of keys—a public key and a private key.(R)", IsCorrect = true, QuestionModelId = 41 },
                new OptionModel { Id = 122, Text = "Encryption using a single shared secret key.", IsCorrect = false, QuestionModelId = 41 },
                new OptionModel { Id = 123, Text = "A one-way non-reversible hashing function.", IsCorrect = false, QuestionModelId = 41 },

                // Fråga 42: Primary characteristic of asymmetric encryption
                new OptionModel { Id = 124, Text = "Allows secure communication without sharing a secret key beforehand.(R)", IsCorrect = true, QuestionModelId = 42 },
                new OptionModel { Id = 125, Text = "Processes data much faster than symmetric encryption.", IsCorrect = false, QuestionModelId = 42 },
                new OptionModel { Id = 126, Text = "Requires a physical meeting to exchange passwords.", IsCorrect = false, QuestionModelId = 42 },

                // Fråga 43: Algorithm commonly used for asymmetric encryption
                new OptionModel { Id = 127, Text = "RSA (Rivest-Shamir-Adleman).(R)", IsCorrect = true, QuestionModelId = 43 },
                new OptionModel { Id = 128, Text = "AES (Advanced Encryption Standard).", IsCorrect = false, QuestionModelId = 43 },
                new OptionModel { Id = 129, Text = "SHA-256.", IsCorrect = false, QuestionModelId = 43 },

                // Fråga 44: Difference between asymmetric and symmetric encryption
                new OptionModel { Id = 130, Text = "Asymmetric uses a key pair; symmetric uses a single shared key.(R)", IsCorrect = true, QuestionModelId = 44 },
                new OptionModel { Id = 131, Text = "Asymmetric is only for local storage.", IsCorrect = false, QuestionModelId = 44 },
                new OptionModel { Id = 132, Text = "Asymmetric is significantly faster than symmetric.", IsCorrect = false, QuestionModelId = 44 },

                // Fråga 45: Role of a public key in asymmetric encryption
                new OptionModel { Id = 133, Text = "It is freely shared to encrypt data or verify a digital signature.(R)", IsCorrect = true, QuestionModelId = 45 },
                new OptionModel { Id = 134, Text = "It is kept secret and decrypts the message.", IsCorrect = false, QuestionModelId = 45 },
                new OptionModel { Id = 135, Text = "It resets unauthorized access logs.", IsCorrect = false, QuestionModelId = 45 },

                // Fråga 46: Designed to provide strong security with a small key size
                new OptionModel { Id = 136, Text = "Elliptic Curve Cryptography (ECC).(R)", IsCorrect = true, QuestionModelId = 46 },
                new OptionModel { Id = 137, Text = "Data Encryption Standard (DES).", IsCorrect = false, QuestionModelId = 46 },
                new OptionModel { Id = 138, Text = "Blowfish.", IsCorrect = false, QuestionModelId = 46 },

                // Fråga 47: Purpose of a digital signature in asymmetric encryption
                new OptionModel { Id = 139, Text = "To verify a message's authenticity and integrity.(R)", IsCorrect = true, QuestionModelId = 47 },
                new OptionModel { Id = 140, Text = "To encrypt the hard drive on logout.", IsCorrect = false, QuestionModelId = 47 },
                new OptionModel { Id = 141, Text = "To compress files before sending over a network.", IsCorrect = false, QuestionModelId = 47 },

                // Fråga 48: Designed to provide strong security with a large key size
                new OptionModel { Id = 142, Text = "RSA with key sizes of 2048 bits or higher.(R)", IsCorrect = true, QuestionModelId = 48 },
                new OptionModel { Id = 143, Text = "AES with a 256-bit key.", IsCorrect = false, QuestionModelId = 48 },
                new OptionModel { Id = 144, Text = "Triple DES (3DES).", IsCorrect = false, QuestionModelId = 48 },

                // Fråga 49: Role of a key exchange protocol in asymmetric encryption
                new OptionModel { Id = 145, Text = "To securely establish a shared symmetric key (e.g., Diffie-Hellman).(R)", IsCorrect = true, QuestionModelId = 49 },
                new OptionModel { Id = 146, Text = "To translate IPv4 to IPv6.", IsCorrect = false, QuestionModelId = 49 },
                new OptionModel { Id = 147, Text = "To block malware IP addresses.", IsCorrect = false, QuestionModelId = 49 },

                // Fråga 50: Designed to provide strong security with a variable key size
                new OptionModel { Id = 148, Text = "RSA, which allows variable key sizes (e.g., 1024, 2048).(R)", IsCorrect = true, QuestionModelId = 50 },
                new OptionModel { Id = 149, Text = "Stream ciphers like RC4.", IsCorrect = false, QuestionModelId = 50 },
                new OptionModel { Id = 150, Text = "Block ciphers like AES.", IsCorrect = false, QuestionModelId = 50 },

                // Fråga 51: What is hashing in cybersecurity?
                new OptionModel { Id = 151, Text = "A one-way mathematical process that converts data into a fixed-size string.(R)", IsCorrect = true, QuestionModelId = 51 },
                new OptionModel { Id = 152, Text = "A two-way encryption method using public and private keys.", IsCorrect = false, QuestionModelId = 51 },
                new OptionModel { Id = 153, Text = "A technique to compress files for faster network transmission.", IsCorrect = false, QuestionModelId = 51 },

                // Fråga 52: Primary purpose of hashing in cybersecurity
                new OptionModel { Id = 154, Text = "To verify data integrity and securely store passwords.(R)", IsCorrect = true, QuestionModelId = 52 },
                new OptionModel { Id = 155, Text = "To securely transmit encryption keys over the internet.", IsCorrect = false, QuestionModelId = 52 },
                new OptionModel { Id = 156, Text = "To permanently erase data from a hard drive.", IsCorrect = false, QuestionModelId = 52 },

                // Fråga 53: Algorithm commonly used for hashing
                new OptionModel { Id = 157, Text = "SHA-256 (Secure Hash Algorithm 256).(R)", IsCorrect = true, QuestionModelId = 53 },
                new OptionModel { Id = 158, Text = "AES (Advanced Encryption Standard).", IsCorrect = false, QuestionModelId = 53 },
                new OptionModel { Id = 159, Text = "RSA (Rivest-Shamir-Adleman).", IsCorrect = false, QuestionModelId = 53 },

                // Fråga 54: Difference between hashing and encryption
                new OptionModel { Id = 160, Text = "Hashing is one-way for data integrity, while encryption is two-way for confidentiality.(R)", IsCorrect = true, QuestionModelId = 54 },
                new OptionModel { Id = 161, Text = "Hashing uses public keys, while encryption uses shared keys.", IsCorrect = false, QuestionModelId = 54 },
                new OptionModel { Id = 162, Text = "Hashing is only for emails, while encryption is only for databases.", IsCorrect = false, QuestionModelId = 54 },

                // Fråga 55: Role of a hash function in hashing
                new OptionModel { Id = 163, Text = "It mathematically converts an input of any length into a fixed-size output.(R)", IsCorrect = true, QuestionModelId = 55 },
                new OptionModel { Id = 164, Text = "It decrypts messages back into plain text.", IsCorrect = false, QuestionModelId = 55 },
                new OptionModel { Id = 165, Text = "It assigns a random, hidden IP address to devices.", IsCorrect = false, QuestionModelId = 55 },

                // Fråga 56: Designed to provide strong security with a small output size
                new OptionModel { Id = 166, Text = "Lightweight hash functions designed for IoT and constrained environments.(R)", IsCorrect = true, QuestionModelId = 56 },
                new OptionModel { Id = 167, Text = "SHA-512, which compresses its output to save space.", IsCorrect = false, QuestionModelId = 56 },
                new OptionModel { Id = 168, Text = "RSA-2048.", IsCorrect = false, QuestionModelId = 56 },

                // Fråga 57: Purpose of a salt in hashing
                new OptionModel { Id = 169, Text = "To add random data before hashing, preventing rainbow table attacks.(R)", IsCorrect = true, QuestionModelId = 57 },
                new OptionModel { Id = 170, Text = "To speed up the hashing process for large databases.", IsCorrect = false, QuestionModelId = 57 },
                new OptionModel { Id = 171, Text = "To allow administrators to reverse the hash to the original password.", IsCorrect = false, QuestionModelId = 57 },

                // Fråga 58: Designed to provide strong security with a large output size
                new OptionModel { Id = 172, Text = "SHA-512.(R)", IsCorrect = true, QuestionModelId = 58 },
                new OptionModel { Id = 173, Text = "MD5.", IsCorrect = false, QuestionModelId = 58 },
                new OptionModel { Id = 174, Text = "CRC32.", IsCorrect = false, QuestionModelId = 58 },

                // Fråga 59: Role of a key stretching algorithm in hashing
                new OptionModel { Id = 175, Text = "To intentionally slow down the hashing process, making brute-force attacks harder.(R)", IsCorrect = true, QuestionModelId = 59 },
                new OptionModel { Id = 176, Text = "To automatically increase the length of a short password.", IsCorrect = false, QuestionModelId = 59 },
                new OptionModel { Id = 177, Text = "To stretch the hash output across multiple servers.", IsCorrect = false, QuestionModelId = 59 },

                // Fråga 60: Designed to provide strong security with a variable output size
                new OptionModel { Id = 178, Text = "Extendable-Output Functions (XOFs), like SHAKE128 or SHAKE256.(R)", IsCorrect = true, QuestionModelId = 60 },
                new OptionModel { Id = 179, Text = "SHA-256, which dynamically changes its digest size.", IsCorrect = false, QuestionModelId = 60 },
                new OptionModel { Id = 180, Text = "AES-GCM.", IsCorrect = false, QuestionModelId = 60 },

                // Fråga 61: What is SQL injection?
                new OptionModel { Id = 181, Text = "A vulnerability where an attacker interferes with an application's database queries.(R)", IsCorrect = true, QuestionModelId = 61 },
                new OptionModel { Id = 182, Text = "A standard method to safely encrypt database passwords.", IsCorrect = false, QuestionModelId = 61 },
                new OptionModel { Id = 183, Text = "A tool developers use to speed up slow database connections.", IsCorrect = false, QuestionModelId = 61 },

                // Fråga 62: Primary purpose of SQL injection?
                new OptionModel { Id = 184, Text = "To view, modify, or delete unauthorized data in a database.(R)", IsCorrect = true, QuestionModelId = 62 },
                new OptionModel { Id = 185, Text = "To trick users into clicking malicious email links.", IsCorrect = false, QuestionModelId = 62 },
                new OptionModel { Id = 186, Text = "To permanently physically damage the server's hard drive.", IsCorrect = false, QuestionModelId = 62 },

                // Fråga 63: Type of attack commonly used?
                new OptionModel { Id = 187, Text = "Entering malicious SQL commands into input fields like login forms.(R)", IsCorrect = true, QuestionModelId = 63 },
                new OptionModel { Id = 188, Text = "Sending millions of fake network packets to crash the server.", IsCorrect = false, QuestionModelId = 63 },
                new OptionModel { Id = 189, Text = "Guessing user passwords using a dictionary file.", IsCorrect = false, QuestionModelId = 63 },

                // Fråga 64: Difference between SQLi and other injections?
                new OptionModel { Id = 190, Text = "SQL injection specifically targets relational databases, not the OS or web browser.(R)", IsCorrect = true, QuestionModelId = 64 },
                new OptionModel { Id = 191, Text = "SQL injection only works on mobile applications.", IsCorrect = false, QuestionModelId = 64 },
                new OptionModel { Id = 192, Text = "SQL injection is a legal technique used for data backups.", IsCorrect = false, QuestionModelId = 64 },

                // Fråga 65: Role of input validation?
                new OptionModel { Id = 193, Text = "It ensures only safe, expected characters are accepted by the application.(R)", IsCorrect = true, QuestionModelId = 65 },
                new OptionModel { Id = 194, Text = "It automatically translates all input into HTML code.", IsCorrect = false, QuestionModelId = 65 },
                new OptionModel { Id = 195, Text = "It physically blocks IP addresses from unknown countries.", IsCorrect = false, QuestionModelId = 65 },

                // Fråga 66: Designed to extract data?
                new OptionModel { Id = 196, Text = "UNION-based or Error-based SQL injection.(R)", IsCorrect = true, QuestionModelId = 66 },
                new OptionModel { Id = 197, Text = "Ransomware data injection.", IsCorrect = false, QuestionModelId = 66 },
                new OptionModel { Id = 198, Text = "Cross-Site Scripting (XSS).", IsCorrect = false, QuestionModelId = 66 },

                // Fråga 67: Purpose of parameterized queries?
                new OptionModel { Id = 199, Text = "They separate the SQL code from the user's data, making malicious input harmless.(R)", IsCorrect = true, QuestionModelId = 67 },
                new OptionModel { Id = 200, Text = "They delete the entire database if an attack is detected.", IsCorrect = false, QuestionModelId = 67 },
                new OptionModel { Id = 201, Text = "They compress the database size for faster loading times.", IsCorrect = false, QuestionModelId = 67 },

                // Fråga 68: Designed to modify data?
                new OptionModel { Id = 202, Text = "Injecting UPDATE, INSERT, or DELETE statements.(R)", IsCorrect = true, QuestionModelId = 68 },
                new OptionModel { Id = 203, Text = "Using the SELECT statement to read tables.", IsCorrect = false, QuestionModelId = 68 },
                new OptionModel { Id = 204, Text = "Using the PING command to test network speed.", IsCorrect = false, QuestionModelId = 68 },

                // Fråga 69: Role of a Web Application Firewall (WAF)?
                new OptionModel { Id = 205, Text = "It inspects incoming web traffic and blocks known SQL attack patterns.(R)", IsCorrect = true, QuestionModelId = 69 },
                new OptionModel { Id = 206, Text = "It unplugs the database server when it gets too hot.", IsCorrect = false, QuestionModelId = 69 },
                new OptionModel { Id = 207, Text = "It forces users to change their database passwords every 30 days.", IsCorrect = false, QuestionModelId = 69 },

                // Fråga 70: Designed to execute arbitrary commands?
                new OptionModel { Id = 208, Text = "Exploiting database features like xp_cmdshell to run OS commands.(R)", IsCorrect = true, QuestionModelId = 70 },
                new OptionModel { Id = 209, Text = "Phishing SQL injection.", IsCorrect = false, QuestionModelId = 70 },
                new OptionModel { Id = 210, Text = "Man-in-the-middle SQL injection.", IsCorrect = false, QuestionModelId = 70 },

                // Fråga 71: What is cross-site scripting (XSS)?
                new OptionModel { Id = 211, Text = "Injecting malicious scripts into otherwise benign and trusted websites.(R)", IsCorrect = true, QuestionModelId = 71 },
                new OptionModel { Id = 212, Text = "Overloading a server with traffic to crash it.", IsCorrect = false, QuestionModelId = 71 },
                new OptionModel { Id = 213, Text = "Intercepting data between a database and a web server.", IsCorrect = false, QuestionModelId = 71 },

                // Fråga 72: Primary purpose of XSS?
                new OptionModel { Id = 214, Text = "To execute malicious code in a victim's web browser.(R)", IsCorrect = true, QuestionModelId = 72 },
                new OptionModel { Id = 215, Text = "To gain direct administrative access to the backend database.", IsCorrect = false, QuestionModelId = 72 },
                new OptionModel { Id = 216, Text = "To crack user passwords using brute force.", IsCorrect = false, QuestionModelId = 72 },

                // Fråga 73: Type of attack commonly used?
                new OptionModel { Id = 217, Text = "Injecting malicious JavaScript payloads.(R)", IsCorrect = true, QuestionModelId = 73 },
                new OptionModel { Id = 218, Text = "Executing unauthorized SQL database queries.", IsCorrect = false, QuestionModelId = 73 },
                new OptionModel { Id = 219, Text = "Exploiting hardware router misconfigurations.", IsCorrect = false, QuestionModelId = 73 },

                // Fråga 74: Difference between XSS and other injections?
                new OptionModel { Id = 220, Text = "XSS targets the user's browser, while SQLi targets the backend database.(R)", IsCorrect = true, QuestionModelId = 74 },
                new OptionModel { Id = 221, Text = "XSS only affects mobile apps, while SQLi affects desktop apps.", IsCorrect = false, QuestionModelId = 74 },
                new OptionModel { Id = 222, Text = "XSS requires physical access to the target machine.", IsCorrect = false, QuestionModelId = 74 },

                // Fråga 75: Role of input validation?
                new OptionModel { Id = 223, Text = "It ensures only safe, expected characters are processed by the application.(R)", IsCorrect = true, QuestionModelId = 75 },
                new OptionModel { Id = 224, Text = "It automatically blocks IP addresses from unknown locations.", IsCorrect = false, QuestionModelId = 75 },
                new OptionModel { Id = 225, Text = "It automatically encrypts user passwords in the database.", IsCorrect = false, QuestionModelId = 75 },

                // Fråga 76: Designed to steal user credentials?
                new OptionModel { Id = 226, Text = "A payload that accesses document.cookie to steal active session tokens.(R)", IsCorrect = true, QuestionModelId = 76 },
                new OptionModel { Id = 227, Text = "A payload that permanently deletes database tables.", IsCorrect = false, QuestionModelId = 76 },
                new OptionModel { Id = 228, Text = "A payload that resets the user's home internet router.", IsCorrect = false, QuestionModelId = 76 },

                // Fråga 77: Purpose of output encoding?
                new OptionModel { Id = 229, Text = "It converts special characters into safe HTML entities so they display safely instead of executing.(R)", IsCorrect = true, QuestionModelId = 77 },
                new OptionModel { Id = 230, Text = "It compresses website images for faster loading times.", IsCorrect = false, QuestionModelId = 77 },
                new OptionModel { Id = 231, Text = "It hides the website's source code from visitors.", IsCorrect = false, QuestionModelId = 77 },

                // Fråga 78: Designed to deface a website?
                new OptionModel { Id = 232, Text = "Stored XSS, where the malicious script is permanently saved on the server and shown to all visitors.(R)", IsCorrect = true, QuestionModelId = 78 },
                new OptionModel { Id = 233, Text = "Phishing XSS, where users are tricked via email.", IsCorrect = false, QuestionModelId = 78 },
                new OptionModel { Id = 234, Text = "Hardware XSS, targeting the physical server components.", IsCorrect = false, QuestionModelId = 78 },

                // Fråga 79: Role of a content security policy (CSP)?
                new OptionModel { Id = 235, Text = "It restricts which external scripts can be loaded and executed by the browser.(R)", IsCorrect = true, QuestionModelId = 79 },
                new OptionModel { Id = 236, Text = "It automatically updates the server's operating system.", IsCorrect = false, QuestionModelId = 79 },
                new OptionModel { Id = 237, Text = "It physically blocks users from taking screenshots of the website.", IsCorrect = false, QuestionModelId = 79 },

                // Fråga 80: Designed to execute arbitrary scripts in a user's browser?
                new OptionModel { Id = 238, Text = "Reflected XSS, where the script bounces off the web server directly to the victim via a crafted link.(R)", IsCorrect = true, QuestionModelId = 80 },
                new OptionModel { Id = 239, Text = "Ransomware XSS, which encrypts the user's hard drive.", IsCorrect = false, QuestionModelId = 80 },
                new OptionModel { Id = 240, Text = "DDoS XSS, which crashes the victim's computer hardware.", IsCorrect = false, QuestionModelId = 80 },

                // Fråga 81: What is CSRF?
                new OptionModel { Id = 241, Text = "An attack that forces an authenticated user to execute unwanted actions on a web application.(R)", IsCorrect = true, QuestionModelId = 81 },
                new OptionModel { Id = 242, Text = "A method used by developers to securely encrypt data in transit.", IsCorrect = false, QuestionModelId = 81 },
                new OptionModel { Id = 243, Text = "A technique used to optimize backend database queries.", IsCorrect = false, QuestionModelId = 81 },

                // Fråga 82: Primary purpose of CSRF?
                new OptionModel { Id = 244, Text = "To trick a victim's browser into performing actions they didn't intend, like transferring funds.(R)", IsCorrect = true, QuestionModelId = 82 },
                new OptionModel { Id = 245, Text = "To physically damage the target server's hard drives.", IsCorrect = false, QuestionModelId = 82 },
                new OptionModel { Id = 246, Text = "To directly extract encrypted passwords from the database.", IsCorrect = false, QuestionModelId = 82 },

                // Fråga 83: Type of attack commonly used?
                new OptionModel { Id = 247, Text = "Social engineering, like sending a malicious link, to trigger the forged request.(R)", IsCorrect = true, QuestionModelId = 83 },
                new OptionModel { Id = 248, Text = "Brute-forcing admin passwords.", IsCorrect = false, QuestionModelId = 83 },
                new OptionModel { Id = 249, Text = "Man-in-the-middle physical cable tapping.", IsCorrect = false, QuestionModelId = 83 },

                // Fråga 84: Difference between CSRF and other injections (like XSS)?
                new OptionModel { Id = 250, Text = "CSRF exploits the site's trust in the browser, while XSS exploits the user's trust in the site.(R)", IsCorrect = true, QuestionModelId = 84 },
                new OptionModel { Id = 251, Text = "CSRF only targets mobile applications.", IsCorrect = false, QuestionModelId = 84 },
                new OptionModel { Id = 252, Text = "CSRF relies entirely on hardware failure.", IsCorrect = false, QuestionModelId = 84 },

                // Fråga 85: Role of input validation in preventing CSRF?
                new OptionModel { Id = 253, Text = "It offers minimal protection, as forged CSRF requests often contain perfectly valid input data.(R)", IsCorrect = true, QuestionModelId = 85 },
                new OptionModel { Id = 254, Text = "It is the only guaranteed way to stop CSRF attacks completely.", IsCorrect = false, QuestionModelId = 85 },
                new OptionModel { Id = 255, Text = "It automatically disconnects the attacker's IP address.", IsCorrect = false, QuestionModelId = 85 },

                // Fråga 86: Designed to steal user credentials?
                new OptionModel { Id = 256, Text = "Login CSRF, where an attacker logs the victim into the attacker's account to capture their activity.(R)", IsCorrect = true, QuestionModelId = 86 },
                new OptionModel { Id = 257, Text = "Ransomware CSRF.", IsCorrect = false, QuestionModelId = 86 },
                new OptionModel { Id = 258, Text = "Hardware CSRF.", IsCorrect = false, QuestionModelId = 86 },

                // Fråga 87: Purpose of anti-CSRF tokens?
                new OptionModel { Id = 259, Text = "To ensure the request originated from the legitimate app by requiring a unique, unpredictable hidden value.(R)", IsCorrect = true, QuestionModelId = 87 },
                new OptionModel { Id = 260, Text = "To automatically compress HTTP requests to save bandwidth.", IsCorrect = false, QuestionModelId = 87 },
                new OptionModel { Id = 261, Text = "To block all incoming internet traffic during maintenance.", IsCorrect = false, QuestionModelId = 87 },

                // Fråga 88: Designed to perform unauthorized actions?
                new OptionModel { Id = 262, Text = "State-changing requests, such as updating an email address or changing a password.(R)", IsCorrect = true, QuestionModelId = 88 },
                new OptionModel { Id = 263, Text = "Bandwidth-draining requests.", IsCorrect = false, QuestionModelId = 88 },
                new OptionModel { Id = 264, Text = "Network ping requests.", IsCorrect = false, QuestionModelId = 88 },

                // Fråga 89: Role of a Web Application Firewall (WAF)?
                new OptionModel { Id = 265, Text = "It can inspect HTTP headers (like Referer or Origin) to block requests from unexpected external domains.(R)", IsCorrect = true, QuestionModelId = 89 },
                new OptionModel { Id = 266, Text = "It unplugs the server if multiple CSRF attacks are detected.", IsCorrect = false, QuestionModelId = 89 },
                new OptionModel { Id = 267, Text = "It forces all users to use two-factor authentication.", IsCorrect = false, QuestionModelId = 89 },

                // Fråga 90: Designed to execute arbitrary commands on a server?
                new OptionModel { Id = 268, Text = "CSRF itself doesn't execute commands directly, but it can trigger administrative functions if the victim is an admin.(R)", IsCorrect = true, QuestionModelId = 90 },
                new OptionModel { Id = 269, Text = "Buffer-overflow CSRF.", IsCorrect = false, QuestionModelId = 90 },
                new OptionModel { Id = 270, Text = "Shell-shock CSRF.", IsCorrect = false, QuestionModelId = 90 }
            );
        }
    }
}
