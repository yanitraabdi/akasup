using System;
using System.Collections.Generic;

namespace Pusaka.Model
{
    public partial class Schools
    {
        public Schools()
        {
            SchoolAdmin = new HashSet<SchoolAdmin>();
            SchoolProfile = new HashSet<SchoolProfile>();
            Students = new HashSet<Students>();
        }

        public long SchoolId { get; set; }
        public byte SchoolType { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }

        public ICollection<SchoolAdmin> SchoolAdmin { get; set; }
        public ICollection<SchoolProfile> SchoolProfile { get; set; }
        public ICollection<Students> Students { get; set; }
    }

    public class ListSchools : ExceptionModel
    {
        public ListSchools()
        {
            listSchools = new List<Schools>();
        }
        public IEnumerable<Schools> listSchools { get; set; }
    }

    public class SingleSchools : ExceptionModel
    {
        public SingleSchools()
        {
            Schools = new Schools();
        }
        public Schools Schools { get; set; }
    }
}
