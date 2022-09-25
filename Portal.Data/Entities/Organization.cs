using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Data.Entities
{
    public class Organization
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int? IdentityProviderId { get; set; }
        public virtual IdentityProvider? IdentityProvider { get; set; }
    }
}
