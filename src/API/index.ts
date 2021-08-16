import { APIGatewayProxyEventV2, APIGatewayProxyResultV2, Context, Handler } from 'aws-lambda';


export const apiHandle: Handler  =  async (event: APIGatewayProxyEventV2, context: Context): Promise<APIGatewayProxyResultV2> => {
  console.log("hello from api");
  return {
    statusCode: 200
  };
}