using System;
using System.Collections.Generic;

namespace Pusaka.Model
{
    public partial class Missions
    {
        public long MissionsId { get; set; }
        public long CategoryId { get; set; }
        public string MisName { get; set; }
        public string MisImage { get; set; }
        public string MisDesc { get; set; }
        public string MisAttr { get; set; }
        public int ReviewCount { get; set; }
        public double RatingAvg { get; set; }
        public string City { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public byte TimeZone { get; set; }
        public DateTime DayStart { get; set; }
        public DateTime DayEnd { get; set; }
        public int MisStatus { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }

    public class ListMissions : ExceptionModel
    {
        public ListMissions()
        {
            listMissions = new List<Missions>();
        }
        public IEnumerable<Missions> listMissions { get; set; }
    }

    public class SingleMissions : ExceptionModel
    {
        public SingleMissions()
        {
            Missions = new Missions();
        }
        public Missions Missions { get; set; }
    }
}
