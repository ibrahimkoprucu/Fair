using Fair.Entities;
using System.Collections.Generic;

namespace Fair.DataLayer
{
    // Data
    public class FairRepository
    {
        public FairRepository()
        {
            Applications = new List<Application>();
        }

        public List<Application> Applications { get; set; }

        public List<string> GetPresentationTopics()
        {
            // todo: get list from db or some other recourse
            return new List<string> { "Uygulama Yazılımı", "Donanım", "Mobil Uygulamalar" };
        }

        public bool AddApplication(Application application)
        {
            // todo: Save to database
            this.Applications.Add(application);
            return true;
        }
    }
}