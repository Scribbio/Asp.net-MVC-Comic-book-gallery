using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



/**
 * We can think of this class as a central location, or repository, for storing and
 * managing our comic book model instances. Let's name this class ComicBook Repository. 
 * By organizing our data access code in this way, we're implementing the Repository Design Pattern. 
 * Creating a design where we don't repeat ourselves allows for our classes to naturally be more tightly focused. 
 * Each class should have a single responsibility, or concern, and not overlap with any other classes on our website. 
 * This is known as the separation of concerns design principle. Separating concerns also helps make our 
 * website easier to maintain. With our improved design, if we wanted how our comic book model instances 
 * are created or retrieved, we'd only need to change the comic book repository class.
 * 

 */

namespace ComicBookGallery.Data
{
    public class ComicBookRepository
    {
        //By making this field static, we're associating it with the ComicBook -
        //repository class instead of the individual object instances of this class. 
        private static ComicBook[] _comicBooks = new ComicBook[]
        {
            new ComicBook()
            {
                Id = 1,
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives...<strong>will Peter Parker?</strong></p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Dan Slott", Role = "Script" },
                    new Artist() { Name = "Humberto Ramos", Role = "Pencils" },
                    new Artist() { Name = "Victor Olazaba", Role = "Inks" },
                    new Artist() { Name = "Edgar Delgado", Role = "Colors" },
                    new Artist() { Name = "Chris Eliopoulos", Role = "Letters" },
                },
                Favorite = false
            },
            new ComicBook()
            {
                Id = 2,
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 657,
                DescriptionHtml = "<p><strong>FF: THREE TIE-IN.</strong> Spider-Man visits the FF for a very private wake--just for family.</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Dan Slott", Role = "Script" },
                    new Artist() { Name = "Marcos Martin", Role = "Pencils" },
                    new Artist() { Name = "Marcos Martin", Role = "Inks" },
                    new Artist() { Name = "Muntsa Vicente", Role = "Colors" },
                    new Artist() { Name = "Joe Caramagna", Role = "Letters" }
                },
                Favorite = false
            },
            new ComicBook()
            {
                Id = 3,
                SeriesTitle = "Bone",
                IssueNumber = 50,
                DescriptionHtml = "<p><strong>The Dungeon & The Parapet, Part 1.</strong> Thorn is discovered by Lord Tarsil and the corrupted Stickeaters and thrown into a dungeon with Fone Bone. As she sleeps, a message comes to her about the mysterious \"Crown of Horns\".</p>",
                Artists = new Artist[]
                {
                    new Artist() { Name = "Jeff Smith", Role = "Script" },
                    new Artist() { Name = "Jeff Smith", Role = "Pencils" },
                    new Artist() { Name = "Jeff Smith", Role = "Inks" },
                    new Artist() { Name = "Jeff Smith", Role = "Letters" }
                },
                Favorite = false
            }
        };

        public ComicBook[] GetComicBooks()
        {
            return _comicBooks;
        }

        public ComicBook getComicBook(int id)
        {
            ComicBook comicBookToReturn = null;

            foreach (var comicBook in _comicBooks)
            {
                if (comicBook.Id == id)
                {
                    comicBookToReturn = comicBook;

                    break;
                }
            }

            return comicBookToReturn;
        }
    }

}
