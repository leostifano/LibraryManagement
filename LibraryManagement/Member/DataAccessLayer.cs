using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagement.Member
{
    // Author: Elizabeth Smikle
    public class DataAccessLayer
    {
        private LibraryDBDataSetTableAdapters.BooksTableAdapter adpBooks;
        private LibraryDBDataSet.BooksDataTable tblBooks;
        private List<BusinessLogicLayer> lstBooks;

        private LibraryDBDataSetTableAdapters.RequestsTableAdapter adpRequests;
        private LibraryDBDataSet.RequestsDataTable tblRequests;
        private List<BusinessLogicLayer> lstRequests;

        private LibraryDBDataSetTableAdapters.UsersTableAdapter adpUsers;
        private LibraryDBDataSet.UsersDataTable tblUsers;
        private List<BusinessLogicLayer> lstUsers;
        public DataAccessLayer()
        {
            adpBooks = new LibraryDBDataSetTableAdapters.BooksTableAdapter();
            tblBooks = new LibraryDBDataSet.BooksDataTable();
            lstBooks = null;

            adpRequests = new LibraryDBDataSetTableAdapters.RequestsTableAdapter();
            tblRequests = new LibraryDBDataSet.RequestsDataTable();
            lstRequests = null;

            adpUsers = new LibraryDBDataSetTableAdapters.UsersTableAdapter();
            tblUsers = new LibraryDBDataSet.UsersDataTable();
            lstUsers = null;
        }

        public List<BusinessLogicLayer> GetBooksByRenterId(int renterId)
        {
            tblBooks = adpBooks.GetBooksByRenterId(renterId);

            if(tblBooks.Count > 0)
            {
                lstBooks = new List<BusinessLogicLayer>();

                foreach(var row in tblBooks)
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

        public List<BusinessLogicLayer> GetUserById(int id)
        {
            tblUsers = adpUsers.GetUserById(id);

            if (tblUsers.Count == 1)
            {
                lstUsers = new List<BusinessLogicLayer>();

                foreach (var row in tblUsers)
                {
                    BusinessLogicLayer user = new BusinessLogicLayer();

                    user.Username = row.Username;
                    user.Fees = row.Fees;
                   
                    lstUsers.Add(user);
                }
            }
            return lstUsers;
        }

        public bool InsertRequest(BusinessLogicLayer request, int userId)
        {
            int result = adpRequests.Insert(request.Id, request.RequestType, request.RequestStatus, userId);

            return result == 1;
        }

        public List<BusinessLogicLayer> GetRequestsByType(string type, int userId)
        {
            tblRequests = adpRequests.GetReqByIdAndType(userId, type);

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

        public List<BusinessLogicLayer> GetBookHistory(int userId)
        {
            
            tblBooks = adpBooks.GetBookHistory("Return", userId, "Issue");

            if (tblBooks.Count > 0)
            {
                lstRequests = new List<BusinessLogicLayer>();

                foreach (var row in tblBooks)
                {
                    BusinessLogicLayer book = new BusinessLogicLayer();

                    book.Id = row.BookId;
                    book.Title = row.Title;
                    book.Author = row.Author;
                    book.Genre = row.Genre;
                    book.Publisher = row.Publisher;

                    lstBooks.Add(book);
                }
            }
            return lstBooks;
        }

        public List<BusinessLogicLayer> GetUserInfo(int userId)
        {
            tblUsers = adpUsers.GetUserById(userId);
            if(tblUsers.Count == 1)
            {
                lstUsers = new List<BusinessLogicLayer>();

                BusinessLogicLayer user = new BusinessLogicLayer();
                user.Username = tblUsers[0].Username;
                user.Password = tblUsers[0].Password;

                lstUsers.Add(user);
            }
            return lstUsers;
        }

        public bool UpdateUser(BusinessLogicLayer user, int userId)
        {
            int result = adpUsers.Update(user.Username, user.Fees, user.Password, userId);
            return result == 1;
        }
    }
}