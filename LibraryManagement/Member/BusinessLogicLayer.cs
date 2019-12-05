using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagement.Member
{
    public class BusinessLogicLayer
    {
        private DataAccessLayer dal;

        public BusinessLogicLayer()
        {
            dal = new DataAccessLayer();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string DueDate { get; set; }
        public string Publisher { get; set; }
        public string RequestType { get; set; }
        public string RequestStatus { get; set; }

        public List<BusinessLogicLayer> GetBooksByRenterId(int renterId)
        {
            return dal.GetBooksByRenterId(renterId);
        }

        public List<BusinessLogicLayer> GetRequestsById(int userId)
        {
            return dal.GetRequestsById(userId);private LibraryDBDataSetTableAdapters.BooksTableAdapter adpBooks;
        private LibraryDBDataSet.BooksDataTable tblBooks;
        private List<BusinessLogicLayer> lstBooks;

        private LibraryDBDataSetTableAdapters.RequestsTableAdapter adpRequests;
        private LibraryDBDataSet.RequestsDataTable tblRequests;
        private List<BusinessLogicLayer> lstRequests;

        public DataAccessLayer()
        {
            adpBooks = new LibraryDBDataSetTableAdapters.BooksTableAdapter();
            tblBooks = new LibraryDBDataSet.BooksDataTable();
            lstBooks = null;

            adpRequests = new LibraryDBDataSetTableAdapters.RequestsTableAdapter();
            tblRequests = new LibraryDBDataSet.RequestsDataTable();
            lstRequests = null;
        }

        public List<BusinessLogicLayer> GetBooksByRenterId(int renterId)
        {
            tblBooks = adpBooks.GetBooksByRenterId(renterId);

            if (tblBooks.Count > 0)
            {
                lstBooks = new List<BusinessLogicLayer>();

                foreach (var row in tblBooks)
                {
                    BusinessLogicLayer book = new BusinessLogicLayer();

                    book.Id = row.BookId;
                    book.Title = row.Title;
                    book.Genre = row.Genre;
                    book.Author = row.Author;
                    book.DueDate = row.DueBy.ToString();

                    lstBooks.Add(book);
                }
            }
            return lstBooks;
        }

        public List<BusinessLogicLayer> GetRequestsById(int id)
        {
            tblRequests = adpRequests.GetRequestsByUserId(id);

            if (tblRequests.Count > 0)
            {
                lstRequests = new List<BusinessLogicLayer>();

                foreach (var row in tblRequests)
                {
                    BusinessLogicLayer request = new BusinessLogicLayer();

                    request.Id = row.BookId;
                    request.RequestType = row.RequestType;
                    request.RequestStatus = row.RequestStatus;

                    lstRequests.Add(request);
                }
            }
            return lstRequests;
        }
    }
    private LibraryDBDataSetTableAdapters.BooksTableAdapter adpBooks;
    private LibraryDBDataSet.BooksDataTable tblBooks;
    private List<BusinessLogicLayer> lstBooks;

    private LibraryDBDataSetTableAdapters.RequestsTableAdapter adpRequests;
    private LibraryDBDataSet.RequestsDataTable tblRequests;
    private List<BusinessLogicLayer> lstRequests;

    public DataAccessLayer()
    {
        adpBooks = new LibraryDBDataSetTableAdapters.BooksTableAdapter();
        tblBooks = new LibraryDBDataSet.BooksDataTable();
        lstBooks = null;

        adpRequests = new LibraryDBDataSetTableAdapters.RequestsTableAdapter();
        tblRequests = new LibraryDBDataSet.RequestsDataTable();
        lstRequests = null;
    }

    public List<BusinessLogicLayer> GetBooksByRenterId(int renterId)
    {
        tblBooks = adpBooks.GetBooksByRenterId(renterId);

        if (tblBooks.Count > 0)
        {
            lstBooks = new List<BusinessLogicLayer>();

            foreach (var row in tblBooks)
            {
                BusinessLogicLayer book = new BusinessLogicLayer();

                book.Id = row.BookId;
                book.Title = row.Title;
                book.Genre = row.Genre;
                book.Author = row.Author;
                book.DueDate = row.DueBy.ToString();

                lstBooks.Add(book);
            }
        }
        return lstBooks;
    }

    public List<BusinessLogicLayer> GetRequestsById(int id)
    {
        tblRequests = adpRequests.GetRequestsByUserId(id);

        if (tblRequests.Count > 0)
        {
            lstRequests = new List<BusinessLogicLayer>();

            foreach (var row in tblRequests)
            {
                BusinessLogicLayer request = new BusinessLogicLayer();

                request.Id = row.BookId;
                request.RequestType = row.RequestType;
                request.RequestStatus = row.RequestStatus;

                lstRequests.Add(request);
            }
        }
        return lstRequests;
    }
}
}
    }
}