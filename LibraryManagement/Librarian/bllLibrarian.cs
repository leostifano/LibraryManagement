using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagement.Librarian
{
    public class bllLibrarian
    {
        private dalLibrarian dal;

        public bllLibrarian()
        {
            dal = new dalLibrarian();
        }

        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int RentedBy { get; set; }
        public DateTime DueBy { get; set; }
        public string Publisher { get; set; }
        public int UserId { get; set; }
        public string RequestType { get; set; }
        public string RequestStatus { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public int Fee { get; set; }


        // for Generate a report of all the books / authors / publishers and categories
        public List<bllLibrarian> GetAllProducts()
        {
            return dal.GetAllBooks();
        }

        public List<bllLibrarian> SearchByTitle(string title)
        {
            return dal.SearchByTitle(title);
        }

        public List<bllLibrarian> SearchByAuthor(string author)
        {
            return dal.SearchByAuthor(author);
        }

        public List<bllLibrarian> SearchByPublisher(string publisher)
        {
            return dal.SearchByPublisher(publisher);
        }

        public List<bllLibrarian> SearchByGenre(string genre)
        {
            return dal.SearchByGenre(genre);
        }

        public List<bllLibrarian> GetAllIssuedBooks()
        {
            return dal.GetAllIssuedBooks();
        }

        public List<bllLibrarian> GetAllOverdueBooks()
        {
            return dal.GetAllOverdueBooks();
        }

        // for issuing/ returning book
        public bool InsertReturnBook(bllLibrarian book)
        {
            return dal.IssueReturnBook(book);
        }

        // for paying fees
        public bool PayFees(bllLibrarian user)
        {
            return dal.PayFee(user);
        }

        public List<bllLibrarian> GetBookById(int id)
        {
            return dal.GetBookById(id);
        }

    }
}