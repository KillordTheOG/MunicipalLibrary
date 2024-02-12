using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MunicipalLibrary.Models
{
    public class Member
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}