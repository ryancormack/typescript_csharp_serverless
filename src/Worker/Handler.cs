using System.Net;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;

[assembly:LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]
namespace Worker
{
    public class Handler
    {
       public APIGatewayProxyResponse Handle(APIGatewayProxyRequest request, ILambdaContext context)
       {
           context.Logger.Log("Hello from C#");
           return new APIGatewayProxyResponse()
           {
               StatusCode = (int)HttpStatusCode.OK
           };
       }
    }
}
