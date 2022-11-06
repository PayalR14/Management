using Management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Management.Models
{
    public class EmpModel
    {
        public int Id { get; set; }
        public string Emp_name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string SaveEmp(EmpModel model)
        {
            string msg = "";
            ManagementEntities Db = new ManagementEntities();
            var ManagementData = new tblEmp()
            {
                Emp_name = model.Emp_name,
                Email = model.Email,
                Address = model.Address,
            };
            Db.tblEmps.Add(ManagementData);
            Db.SaveChanges();
            return msg;
        }
    }
}