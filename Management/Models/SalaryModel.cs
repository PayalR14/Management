using Management.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Management.Models
{
    public class SalaryModel
    {
        public int Id { get; set; }
        public string Designation { get; set; }
        public string salary { get; set; }

        public string SaveSalary(SalaryModel model)
        {
            string msg = "";
            ManagementEntities Db=new ManagementEntities();
            {
                var SalaryData = new tblSalary()
                {
                    Designation = model.Designation,
                    salary = model.salary,
                };
                Db.tblSalaries.Add(SalaryData);
                Db.SaveChanges();   
                return msg;
            }
        }
        public List<SalaryModel>GetSalaryList()
        {
            ManagementEntities Db = new ManagementEntities();
            List<SalaryModel>lstSalary=new List<SalaryModel>();
            var SalaryList = Db.tblSalaries.ToList();
            if(SalaryList!=null)
            {
                foreach(var Salary in SalaryList)
                {
                     lstSalary.Add(new SalaryModel()
                    {
                        Id=Salary.Id,
                        Designation = Salary.Designation,
                        salary = Salary.salary,

                    });
                }
            }
            return lstSalary;
        }

    }
}