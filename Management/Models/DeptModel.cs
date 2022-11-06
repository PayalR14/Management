using Management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Management.Models
{
    public class DeptModel
    {
        public int Dept_id { get; set; }
        public string Designation { get; set; }
        public string Address { get; set; }

        public string SaveDept(DeptModel model)
        {
            string msg = "";
            ManagementEntities Db = new ManagementEntities();
            {
                var DeptData = new tblDept()
                {
                    Designation = model.Designation,
                    Address = model.Address,
                };
                Db.tblDepts.Add(DeptData);
                Db.SaveChanges();   
                return msg;
            }
        }
    }
    
}