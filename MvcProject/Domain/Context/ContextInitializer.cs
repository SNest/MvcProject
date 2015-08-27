﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using Domain.Entities;

namespace Domain.Context
{
    public class ContextInitializer : DropCreateDatabaseAlways<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<User> users = new List<User>
            {
                new User() {Role="Admin", FirstName = "Andey", LastName = "Andreev", NicName = "Andrey007", Email = "andreev@gmail.com", Password = "1234"},
                new User() {Role="User", FirstName = "Oleg", LastName = "Olegov", NicName = "Olegik", Email = "olegov@gmail.com", Password = "1234"},
                new User() {Role="User", FirstName = "Ivan", LastName = "Ivanov", NicName = "Ivanko", Email = "ivanov@gmail.com", Password = "1234"},
            };

            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();

            List<Article> articles = new List<Article>
            {
                new Article() {Title = "Title 1", Text = "The application layer is the only part of a communications process that a user sees, and even then, the user doesn't see most of the work that the application does to prepare a message for sending over a network. The layer converts a message's data from human-readable form into bits and attaches a header identifying the sending and receiving computers.The presentation layer ensures that the message is transmitted in a language that the receiving computer can interpret (often ASCII). This layer translates the language, if necessary, and then compresses and perhaps encrypts the data. It adds another header specifying the language as well as the compression and encryption schemes.The session layer opens communications and has the job of keeping straight the communications among all nodes on the network. It sets boundaries (called bracketing) for the beginning and end of the message, and establishes whether the messages will be sent half-duplex, with each computer taking turns sending and receiving, or full-duplth both computers sending and receiving at the same time. The details of these decisions are placed into a session header.The transport layer protects the data being sent. It subdivides the data into segments, creates checksum tests - mathematical sums based on the contents of data - that can be used later to determine if the data was scrambled. It can also make backup copies of the data. The transport header identifies each segment's checksum and its position in the message.The network layer selects a route for the message. It forms data into packets, counts them, and adds a header containing the sequence of packets and the address of the receiving computer.The data-link layer supervises the transmission. It confirms the checksum, then addresses and duplicates the packets. This layer keeps a copy of each packet until it receives confirmation from the next point along the route that the packet has arrived undamaged.", Date = DateTime.Now.ToLocalTime(),UserId = 1},
                new Article() {Title = "Title 2", Text = "The application layer is the only part of a communications process that a user sees, and even then, the user doesn't see most of the work that the application does to prepare a message for sending over a network. The layer converts a message's data from human-readable form into bits and attaches a header identifying the sending and receiving computers.The presentation layer ensures that the message is transmitted in a language that the receiving computer can interpret (often ASCII). This layer translates the language, if necessary, and then compresses and perhaps encrypts the data. It adds another header specifying the language as well as the compression and encryption schemes.The session layer opens communications and has the job of keeping straight the communications among all nodes on the network. It sets boundaries (called bracketing) for the beginning and end of the message, and establishes whether the messages will be sent half-duplex, with each computer taking turns sending and receiving, or full-duplth both computers sending and receiving at the same time. The details of these decisions are placed into a session header.The transport layer protects the data being sent. It subdivides the data into segments, creates checksum tests - mathematical sums based on the contents of data - that can be used later to determine if the data was scrambled. It can also make backup copies of the data. The transport header identifies each segment's checksum and its position in the message.The network layer selects a route for the message. It forms data into packets, counts them, and adds a header containing the sequence of packets and the address of the receiving computer.The data-link layer supervises the transmission. It confirms the checksum, then addresses and duplicates the packets. This layer keeps a copy of each packet until it receives confirmation from the next point along the route that the packet has arrived undamaged.", Date = DateTime.Now.ToLocalTime(),UserId = 1},
                new Article() {Title = "Title 3", Text = "The application layer is the only part of a communications process that a user sees, and even then, the user doesn't see most of the work that the application does to prepare a message for sending over a network. The layer converts a message's data from human-readable form into bits and attaches a header identifying the sending and receiving computers.The presentation layer ensures that the message is transmitted in a language that the receiving computer can interpret (often ASCII). This layer translates the language, if necessary, and then compresses and perhaps encrypts the data. It adds another header specifying the language as well as the compression and encryption schemes.The session layer opens communications and has the job of keeping straight the communications among all nodes on the network. It sets boundaries (called bracketing) for the beginning and end of the message, and establishes whether the messages will be sent half-duplex, with each computer taking turns sending and receiving, or full-duplth both computers sending and receiving at the same time. The details of these decisions are placed into a session header.The transport layer protects the data being sent. It subdivides the data into segments, creates checksum tests - mathematical sums based on the contents of data - that can be used later to determine if the data was scrambled. It can also make backup copies of the data. The transport header identifies each segment's checksum and its position in the message.The network layer selects a route for the message. It forms data into packets, counts them, and adds a header containing the sequence of packets and the address of the receiving computer.The data-link layer supervises the transmission. It confirms the checksum, then addresses and duplicates the packets. This layer keeps a copy of each packet until it receives confirmation from the next point along the route that the packet has arrived undamaged.", Date = DateTime.Now.ToLocalTime(),UserId = 1},
                new Article() {Title = "Title 4", Text = "The application layer is the only part of a communications process that a user sees, and even then, the user doesn't see most of the work that the application does to prepare a message for sending over a network. The layer converts a message's data from human-readable form into bits and attaches a header identifying the sending and receiving computers.The presentation layer ensures that the message is transmitted in a language that the receiving computer can interpret (often ASCII). This layer translates the language, if necessary, and then compresses and perhaps encrypts the data. It adds another header specifying the language as well as the compression and encryption schemes.The session layer opens communications and has the job of keeping straight the communications among all nodes on the network. It sets boundaries (called bracketing) for the beginning and end of the message, and establishes whether the messages will be sent half-duplex, with each computer taking turns sending and receiving, or full-duplth both computers sending and receiving at the same time. The details of these decisions are placed into a session header.The transport layer protects the data being sent. It subdivides the data into segments, creates checksum tests - mathematical sums based on the contents of data - that can be used later to determine if the data was scrambled. It can also make backup copies of the data. The transport header identifies each segment's checksum and its position in the message.The network layer selects a route for the message. It forms data into packets, counts them, and adds a header containing the sequence of packets and the address of the receiving computer.The data-link layer supervises the transmission. It confirms the checksum, then addresses and duplicates the packets. This layer keeps a copy of each packet until it receives confirmation from the next point along the route that the packet has arrived undamaged.", Date = DateTime.Now.ToLocalTime(),UserId = 1},
                new Article() {Title = "Title 5", Text = "The application layer is the only part of a communications process that a user sees, and even then, the user doesn't see most of the work that the application does to prepare a message for sending over a network. The layer converts a message's data from human-readable form into bits and attaches a header identifying the sending and receiving computers.The presentation layer ensures that the message is transmitted in a language that the receiving computer can interpret (often ASCII). This layer translates the language, if necessary, and then compresses and perhaps encrypts the data. It adds another header specifying the language as well as the compression and encryption schemes.The session layer opens communications and has the job of keeping straight the communications among all nodes on the network. It sets boundaries (called bracketing) for the beginning and end of the message, and establishes whether the messages will be sent half-duplex, with each computer taking turns sending and receiving, or full-duplth both computers sending and receiving at the same time. The details of these decisions are placed into a session header.The transport layer protects the data being sent. It subdivides the data into segments, creates checksum tests - mathematical sums based on the contents of data - that can be used later to determine if the data was scrambled. It can also make backup copies of the data. The transport header identifies each segment's checksum and its position in the message.The network layer selects a route for the message. It forms data into packets, counts them, and adds a header containing the sequence of packets and the address of the receiving computer.The data-link layer supervises the transmission. It confirms the checksum, then addresses and duplicates the packets. This layer keeps a copy of each packet until it receives confirmation from the next point along the route that the packet has arrived undamaged.", Date = DateTime.Now.ToLocalTime(),UserId = 1},
                new Article() {Title = "Title 6", Text = "The application layer is the only part of a communications process that a user sees, and even then, the user doesn't see most of the work that the application does to prepare a message for sending over a network. The layer converts a message's data from human-readable form into bits and attaches a header identifying the sending and receiving computers.The presentation layer ensures that the message is transmitted in a language that the receiving computer can interpret (often ASCII). This layer translates the language, if necessary, and then compresses and perhaps encrypts the data. It adds another header specifying the language as well as the compression and encryption schemes.The session layer opens communications and has the job of keeping straight the communications among all nodes on the network. It sets boundaries (called bracketing) for the beginning and end of the message, and establishes whether the messages will be sent half-duplex, with each computer taking turns sending and receiving, or full-duplth both computers sending and receiving at the same time. The details of these decisions are placed into a session header.The transport layer protects the data being sent. It subdivides the data into segments, creates checksum tests - mathematical sums based on the contents of data - that can be used later to determine if the data was scrambled. It can also make backup copies of the data. The transport header identifies each segment's checksum and its position in the message.The network layer selects a route for the message. It forms data into packets, counts them, and adds a header containing the sequence of packets and the address of the receiving computer.The data-link layer supervises the transmission. It confirms the checksum, then addresses and duplicates the packets. This layer keeps a copy of each packet until it receives confirmation from the next point along the route that the packet has arrived undamaged.", Date = DateTime.Now.ToLocalTime(),UserId = 1},
                            
            };

            articles.ForEach(a => context.Articles.Add(a));
            context.SaveChanges();
        }
    }
}
