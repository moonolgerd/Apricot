using Apricot.Data;
using Grpc.Net.Client;
using Grpc.Net.Client.Web;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using static Apricot.Data.ApricotService;

namespace Apricot.Services
{
    interface IApricotService
    {
        Task<IEnumerable<Data.Apricot>> GetApricots();
    }

    public class ApricotService : IApricotService
    {
        public async Task<IEnumerable<Data.Apricot>> GetApricots()
        {
            var handler = new GrpcWebHandler(GrpcWebMode.GrpcWebText, new HttpClientHandler());
            using var channel = GrpcChannel.ForAddress("https://localhost:5001", new GrpcChannelOptions
            {
                HttpClient = new HttpClient(handler)
            });
            var client = new ApricotServiceClient(channel);

            var reply = await client.GetApricotsAsync(new ApricotRequest());
            return reply.Apricots.AsEnumerable();
        }
    }
}
