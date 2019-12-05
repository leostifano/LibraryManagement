using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagement.Librarian
{
    public class dalLibrarian
    {
        // for getting list of all books, title, publisher, genre
        private dsLibrarianTableAdapters.BooksTableAdapter adpAllBooks;
        private dsLibrarian.BooksDataTable tblBooks;

        //for issue/return
        private dsLibrarianTableAdapters.BooksInfoTableAdapter adpInfo;
        private dsLibrarian.Books1DataTable tblYourBooks;

        // for paying off fees
        private dsLibrarianTableAdapters.UsersTableAdapter adpUsers;
        private dsLibrarian.UsersDataTable tblUsers;

        //for getting all issued books
        private dsLibrarianTableAdapters.IssuedBooksTableAdapter adpIssuedBooks;
        private dsLibrarian.IssuedDataTable tblIssuedBooks;

        //for overdue books
        private dsLibrarianTableAdapters.OverdueBooksTableAdapter adpOverdue;
        private dsLibrarian.OverdueDataTable tblOverdue;

        //this list can be used by all methods
        private List<bllLibrarian> lstBooks;

        public dalLibrarian()
        {
            // for getting list of all books, title, publisher, genre
            adpAllBooks = new dsLibrarianTableAdapters.BooksTableAdapter();
            tblBooks = new dsLibrarian.BooksDataTable();



            lstBooks = null;
        }

        // for Generate a report of all the books / authors / publishers and categories
        public List<bllLibrarian> GetAllBooks()
        {
            // this method is from the dataset, we defined it in the query builder (remember 2nd row method name)
            tblBooks = adpAllBooks.GetBooks();

            // if table is actually populated with stuff
            if (tblBooks.Count > 0)
            {
                //make a new list
                lstBooks = new List<bllLibrarian>();

                foreach (var row in lstBooks)
                {
                    // make a var with the typecast of the list (BusinessLOgicLayer)
                    bllLibrarian book = new bllLibrarian();

                    // [typecast var].[property from businesslogiclayer.cs] = [for each var name].[SQL columns name]
                    book.BookId = row.BookId;
                    book.Title = row.Title;
                    book.Publisher = row.Publisher;
                    book.Genre = row.Genre;
                   
                    // product is fully loaded with all the information from the row

                    // Adds the product item into the list
                    lstBooks.Add(book);
                }// end of for each

            }// end of if

            // since this is after the if block, it can return either NULL (if there are no items in query)
            // or return the list fully loaded of all the items
            return lstBooks;
        }

        public List<bllLibrarian> SearchByTitle(string title)
        {
            // this method is from the dataset, we defined it in the query builder (remember 2nd row method name)
            tblBooks = adpAllBooks.SearchByTitle(title);

            // if table is actually populated with stuff
            if (tblBooks.Count > 0)
            {
                //make a new list
                lstBooks = new List<bllLibrarian>();

                foreach (var row in lstBooks)
                {
                    // make a var with the typecast of the list (BusinessLOgicLayer)
                    bllLibrarian book = new bllLibrarian();

                    // [typecast var].[property from businesslogiclayer.cs] = [for each var name].[SQL columns name]
                    book.BookId = row.BookId;
                    book.Title = row.Title;
                    book.Publisher = row.Publisher;
                    book.Genre = row.Genre;

                    // product is fully loaded with all the information from the row

                    // Adds the product item into the list
                    lstBooks.Add(book);
                }// end of for each

            }// end of if

            // since this is after the if block, it can return either NULL (if there are no items in query)
            // or return the list fully loaded of all the items
            return lstBooks;
        }

        public List<bllLibrarian> SearchByAuthor(string author)
        {
            // this method is from the dataset, we defined it in the query builder (remember 2nd row method name)
            tblBooks = adpAllBooks.SearchByAuthor(author);

            // if table is actually populated with stuff
            if (tblBooks.Count > 0)
            {
                //make a new list
                lstBooks = new List<bllLibrarian>();

                foreach (var row in lstBooks)
                {
                    // make a var with the typecast of the list (BusinessLOgicLayer)
                    bllLibrarian book = new bllLibrarian();

                    // [typecast var].[property from businesslogiclayer.cs] = [for each var name].[SQL columns name]
                    book.BookId = row.BookId;
                    book.Title = row.Title;
                    book.Publisher = row.Publisher;
                    book.Genre = row.Genre;

                    // product is fully loaded with all the information from the row

                    // Adds the product item into the list
                    lstBooks.Add(book);
                }// end of for each

            }// end of if

            // since this is after the if block, it can return either NULL (if there are no items in query)
            // or return the list fully loaded of all the items
            return lstBooks;
        }

        public List<bllLibrarian> SearchByPublisher(string publisher)
        {
            // this method is from the dataset, we defined it in the query builder (remember 2nd row method name)
            tblBooks = adpAllBooks.SearchByPublisher(publisher);

            // if table is actually populated with stuff
            if (tblBooks.Count > 0)
            {
                //make a new list
                lstBooks = new List<bllLibrarian>();

                foreach (var row in lstBooks)
                {
                    // make a var with the typecast of the list (BusinessLOgicLayer)
                    bllLibrarian book = new bllLibrarian();

                    // [typecast var].[property from businesslogiclayer.cs] = [for each var name].[SQL columns name]
                    book.BookId = row.BookId;
                    book.Title = row.Title;
                    book.Publisher = row.Publisher;
                    book.Genre = row.Genre;

                    // product is fully loaded with all the information from the row

                    // Adds the product item into the list
                    lstBooks.Add(book);
                }// end of for each

            }// end of if

            // since this is after the if block, it can return either NULL (if there are no items in query)
            // or return the list fully loaded of all the items
            return lstBooks;
        }

        public List<bllLibrarian> SearchByGenre(string genre)
        {
            // this method is from the dataset, we defined it in the query builder (remember 2nd row method name)
            tblBooks = adpAllBooks.SearchByGenre(genre);

            // if table is actually populated with stuff
            if (tblBooks.Count > 0)
            {
                //make a new list
                lstBooks = new List<bllLibrarian>();

                foreach (var row in lstBooks)
                {
                    // make a var with the typecast of the list (BusinessLOgicLayer)
                    bllLibrarian book = new bllLibrarian();

                    // [typecast var].[property from businesslogiclayer.cs] = [for each var name].[SQL columns name]
                    book.BookId = row.BookId;
                    book.Title = row.Title;
                    book.Publisher = row.Publisher;
                    book.Genre = row.Genre;

                    // product is fully loaded with all the information from the row

                    // Adds the product item into the list
                    lstBooks.Add(book);
                }// end of for each

            }// end of if

            // since this is after the if block, it can return either NULL (if there are no items in query)
            // or return the list fully loaded of all the items
            return lstBooks;
        }

        // for Generate report for all issued books
        public List<bllLibrarian> GetAllIssuedBooks()
        {
            // this method is from the dataset, we defined it in the query builder (remember 2nd row method name)
            tblIssuedBooks = adpIssuedBooks.GetBooksIfIssued();

            // if table is actually populated with stuff
            if (tblIssuedBooks.Count > 0)
            {
                //make a new list
                lstBooks = new List<bllLibrarian>();

                foreach (var row in lstBooks)
                {
                    // make a var with the typecast of the list (BusinessLOgicLayer)
                    bllLibrarian book = new bllLibrarian();

                    // [typecast var].[property from businesslogiclayer.cs] = [for each var name].[SQL columns name]
                    book.BookId = row.BookId;
                    book.Title = row.Title;
                    book.Author = row.Author;
                    book.RentedBy = row.RentedBy;

                    // product is fully loaded with all the information from the row

                    // Adds the product item into the list
                    lstBooks.Add(book);
                }// end of for each

            }// end of if

            // since this is after the if block, it can return either NULL (if there are no items in query)
            // or return the list fully loaded of all the items
            return lstBooks;
        }

        // for Generate report for all overdue
        public List<bllLibrarian> GetAllOverdueBooks()
        {
            // this method is from the dataset, we defined it in the query builder (remember 2nd row method name)
            tblOverdue = adpOverdue.GetAllOverdueBooks();

            // if table is actually populated with stuff
            if (tblOverdue.Count > 0)
            {
                //make a new list
                lstBooks = new List<bllLibrarian>();

                foreach (var row in lstBooks)
                {
                    // make a var with the typecast of the list (BusinessLOgicLayer)
                    bllLibrarian book = new bllLibrarian();

                    // [typecast var].[property from businesslogiclayer.cs] = [for each var name].[SQL columns name]
                    book.RentedBy = row.RentedBy;
                    book.UserId = row.UserId;
                    book.Fee = row.Fee;
                    book.BookId = row.BookId;
                    book.Title = row.Title;

                    // product is fully loaded with all the information from the row

                    // Adds the product item into the list
                    lstBooks.Add(book);
                }// end of for each

            }// end of if

            // since this is after the if block, it can return either NULL (if there are no items in query)
            // or return the list fully loaded of all the items
            return lstBooks;
        }

        
        // FOR pay fee
        public bool PayFee(bllLibrarian user)
        {
            int result = adpUsers.Update(user.Username, user.Password, user.Role, user.Fee, user.UserId );
            return result == 1;
        }

        // for issuing a book
        public bool IssueReturnBook(bllLibrarian book)
        {
            int result = adpInfo.Update(book.Title, book.Author, book.Genre, book.RentedBy, book.DueBy, book.Publisher, book.BookId);
            return result == 1;
        }

        public List<bllLibrarian> GetBookById(int username)
        {
            // this method is from the dataset, we defined it in the query builder (remember 2nd row method name)
            tblYourBooks = adpInfo.GetBooksByUsername(username);

            // if table is actually populated with stuff
            if (tblYourBooks.Count > 0)
            {
                //make a new list
                lstBooks = new List<bllLibrarian>();

                foreach (var row in lstBooks)
                {
                    // make a var with the typecast of the list (BusinessLOgicLayer)
                    bllLibrarian book = new bllLibrarian();

                    // [typecast var].[property from businesslogiclayer.cs] = [for each var name].[SQL columns name]
                    book.BookId = row.BookId;
                    book.Title = row.Title;
                    book.Author = row.Author;
                    book.Genre = row.Genre;
                    book.RentedBy = row.RentedBy;
                    book.DueBy = row.DueBy;
                    book.Publisher = row.Publisher;

                    // product is fully loaded with all the information from the row

                    // Adds the product item into the list
                    lstBooks.Add(book);
                }// end of for each

            }// end of if

            // since this is after the if block, it can return either NULL (if there are no items in query)
            // or return the list fully loaded of all the items
            return lstBooks;
        }
    }
}