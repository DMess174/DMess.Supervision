using DMess.Supervision.CommonModel.Models.Factories;
using DMess.Supervision.ModelAPI;
using System;
using System.Collections.Generic;

namespace DMess.Supervision.CommonModel.Models
{
    public class Employee : AuditableEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string PhotoPath { get; set; }
        public DateTime BirthDate { get; set; }
        public Account Account { get; set; }
        public Post Post { get; set; }
        public ICollection<Factory> Factories { get; set; }
        public SubdivisionDepartment Department { get; set; }
    }
}
