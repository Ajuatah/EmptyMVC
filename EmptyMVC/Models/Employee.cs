using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmptyMVC.Models
{
    //this represent an entity in the database
    public  class Employee // entity in database
    {
        public  int EmployeeID { get; set; }//column in database
        public string EmployeeName { get; set; }
        public string Address { get; set; }
        public DateTime DataOfJoing { get; set; }
        public int MaritalStatus { get; set; }
        public bool IsEligibleFOrLoan { get; set; }
        public decimal Salary { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}