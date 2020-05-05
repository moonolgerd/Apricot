using System.Collections.Generic;

namespace Apricot.Services
{
    interface IApricotService
    {
        IEnumerable<Apricot> GetApricots();
    }

    public class ApricotService : IApricotService
    {
        public IEnumerable<Apricot> GetApricots()
        {
            return new List<Apricot>
            { new Apricot {
                Name = "Common Apricot",
                Family = "Apricots"
            } };
        }
    }

    public class Apricot
    {
        public string Name { get; set; }
        public string Family { get; set; }
    }
}
