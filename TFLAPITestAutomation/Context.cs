using RestSharp;

namespace TaskManagementAPITestAutomation.SetUp
{
    public class Context
    {
        string baseUrl = " https://reqres.in/api";     
        public string content = string.Empty;
        public string statusCodeString = string.Empty;
        public int statusCode;

        public void GetMethod(string resource)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest(resource, Method.GET);
            var result = client.Execute(request);
            content = result.Content;
            statusCode = (int)result.StatusCode;
            statusCodeString = result.StatusCode.ToString();
        }

        public void PostMethod(string resource, object body)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest(resource, Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(body);
            request.AddHeader("Content-Type", "application/json");
            var result = client.Execute(request);
            content = result.Content;
            statusCode = (int)result.StatusCode;
            statusCodeString = result.StatusCode.ToString();
        }

        public void PutMethod(string resource, object body)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest(resource, Method.PUT);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(body);
            request.AddHeader("Content-Type", "application/json");
            var result = client.Execute(request);
            statusCodeString = result.StatusCode.ToString();
        }

        public void DeleteMethod(string resource)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest(resource, Method.DELETE);
            var result = client.Execute(request);
            statusCodeString = result.StatusCode.ToString();
        }
    }
}
