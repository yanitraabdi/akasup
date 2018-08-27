using System;
using System.Collections.Generic;

namespace Pusaka.Model
{
    public partial class Category
    {
        public long CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string ImageFile { get; set; }
        public string Tag { get; set; }
        public string Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public byte[] ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
    }

    public class ListCategory : ExceptionModel
    {
        public ListCategory()
        {
            listCategory = new List<Category>();
        }
        public IEnumerable<Category> listCategory { get; set; }
    }

    public class SingleCategory : ExceptionModel
    {
        public SingleCategory()
        {
            Category = new Category();
        }
        public Category Category { get; set; }
    }
}
