using System.Collections.Generic;

namespace CslAppEFFilterInclude.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Sales> Sales { get; set; }
    }
}
