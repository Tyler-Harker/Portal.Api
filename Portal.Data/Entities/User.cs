using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Data.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public virtual Organization Organization { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
    }
}
