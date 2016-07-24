using Org.Apache.Http.Client;
using System;
using System.IO;
using System.Threading.Tasks;

namespace PokeAPI
{
    public class HttpClientDefaultAdapter : IHttpClientAdapter
    {

        public Task<Stream> GetStreamAsync(Uri    requestUri) => GetStreamAsync(requestUri);
        public Task<string> GetStringAsync(string requestUri) => GetStringAsync(requestUri);
    }
}
