using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQLClient
{
    public class GraphQlContext
    {
        static readonly Lazy<GraphQLHttpClient> _clientHolder = new(CreateGraphQLClient());
        public static GraphQLHttpClient Client => _clientHolder.Value;
        static GraphQLHttpClient CreateGraphQLClient()
        {

            var options = new GraphQLHttpClientOptions
            {
                EndPoint = new Uri(BackendConstants.GraphQLApiUrl),
            };

            return new GraphQLHttpClient(options, new NewtonsoftJsonSerializer());
        }

    }
}
