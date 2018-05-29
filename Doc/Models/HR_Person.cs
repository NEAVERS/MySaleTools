using System;
using System.Collections.Generic;

namespace Test.Models
{
    public partial class HR_Person
    {
        public string typeID { get; set; }
        public string parID { get; set; }
        public Nullable<int> level { get; set; }
        public Nullable<int> sonnum { get; set; }
        public Nullable<int> soncount { get; set; }
        public Nullable<bool> delete { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string LoginName { get; set; }
        public string password { get; set; }
        public Nullable<int> Sex { get; set; }
        public Nullable<int> Age { get; set; }
        public string IDCard { get; set; }
        public string University { get; set; }
        public string Speciality { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string BirthDay { get; set; }
        public Nullable<int> Tall { get; set; }
        public string Intro { get; set; }
        public int PersonStatus_ID { get; set; }
        public string Postion_ID { get; set; }
        public string Hukou { get; set; }
        public string Polity { get; set; }
        public Nullable<int> Marriage { get; set; }
        public string Degree { get; set; }
        public string GraduateDate { get; set; }
        public string Address { get; set; }
        public string AccessionDate { get; set; }
        public string OldMonthlyPay { get; set; }
        public string WantPay { get; set; }
        public Nullable<int> LimitID { get; set; }
        public string Remark { get; set; }
        public string PyCode { get; set; }
    }
}
