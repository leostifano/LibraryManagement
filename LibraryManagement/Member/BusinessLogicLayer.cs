using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryManagement.Member
{   // Author: Elizabeth Smikle
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
        public string Username { get; set; }
        public decimal Fees { get; set; }
        public string Password { get; set; }

        public List<BusinessLogicLayer> GetBooksByRenterId(int renterId)
        {
            return dal.GetBooksByRenterId(renterId);
        }

        public List<BusinessLogicLayer> GetRequestsById(int userId)
        {
            return dal.GetRequestsById(userId);
        }

        public List<BusinessLogicLayer> GetUserById(int userId)
        {
            return dal.GetUserById(userId);
        }

        public bool InsertRequest(BusinessLogicLayer request, int userId)
        {
            return dal.InsertRequest(request, userId);
        }

        public List<BusinessLogicLayer> GetBookHistory(int userId)
        {
            return dal.GetBookHistory(userId);
        }

        public List<BusinessLogicLayer> GetUserInfo(int userId)
        {
            return dal.GetUserInfo(userId);
        }

        public bool UpdateUser(BusinessLogicLayer user, int userId)
        {
            return dal.UpdateUser(user, userId);
        }

    }
}