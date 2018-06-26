using System;
using System.Collections.Generic;

namespace Pusaka.Model
{
    public partial class Students
    {
        public long RowId { get; set; }
        public string StudentId { get; set; }
        public string UserId { get; set; }
        public long SchoolId { get; set; }
        public string ClassOfYear { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }

        public Schools School { get; set; }
        public Users User { get; set; }
    }

    public class ListStudents : ExceptionModel
    {
        public ListStudents()
        {
            listStudents = new List<Students>();
        }
        public IEnumerable<Students> listStudents { get; set; }
    }

    public class SingleStudents : ExceptionModel
    {
        public SingleStudents()
        {
            Students = new Students();
        }
        public Students Students { get; set; }
    }
}
