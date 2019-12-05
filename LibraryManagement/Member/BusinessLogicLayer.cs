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
            return dal.GetRequestsById(userId);
        }
    }
}