using System;
using System.Collections.Generic;
using System.Text;

namespace Pusaka.Model
{
    public class GeneralModel
    {
        public ExceptionModel Exception { get; set; }

        public GeneralModel()
        {
            Exception = new ExceptionModel();
        }

        public int CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
    }

    public class Select
    {
        public string Id { get; set; }
        public string Text { get; set; }
    }

    public class ListSelect : ExceptionModel
    {
        public ListSelect()
        {
            ListSelectData = new List<Select>();
        }
        public List<Select> ListSelectData { get; set; }
    }
}
