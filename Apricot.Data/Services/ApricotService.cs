using Grpc.Core;
using System.Threading.Tasks;
using static Apricot.Data.ApricotService;

namespace Apricot.Data.Services
{
    public class ApricotService : ApricotServiceBase
    {
        public override Task<ApricotReply> GetApricots(ApricotRequest request, ServerCallContext context)
        {
            var reply = new ApricotReply();
            reply.Apricots.Add(new Apricot { Name = "Apricot", Family = "Apricot" });
            reply.Apricots.Add(new Apricot { Name = "Red Apricot", Family = "Apricot" });
            reply.Apricots.Add(new Apricot { Name = "Orange Apricot", Family = "Apricot" });
            return Task.FromResult(reply);
        }
    }
}
