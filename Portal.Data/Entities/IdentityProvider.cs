using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Data.Entities
{
    public class IdentityProvider
    {
        [Key]
        public int Id { get; set; }
        public string ClientId { get; set; }
        public string TenantId { get; set; }

    }
}
