using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBook.Models
{
    public class AddressModel
    {
        [Required] public int AddressModelID { get; set; }
        [Required] public string Name { get; set; }
    }
}
