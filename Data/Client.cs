using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Client
    {
        [Key,Required]
        public int Id { get; set; }

        [EmailAddress, Required]
        public string Mail { get; set; } = null!;
    }
}
