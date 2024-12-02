using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net.Http.Headers;

namespace Bank_Account_Validation_2_Final.APIClient
{
    public class ACHCheckPrescreenLiteClient
    {
        private const string apiName = "ACHCheckPrescreenLite";

        private readonly MBBaseClient client;

        public ACHCheckPrescreenLiteClient(MBBaseClient mbClient)
        {
            this.client = mbClient;
        }

        public JsonObject GetReport(string JSONRequestModel)
        {
            var url = new Uri(client.BaseAddress + apiName + "/GetReport");
            var content = new StringContent(JSONRequestModel, Encoding.UTF8, "application/json");
            var response = client.PostAsync(url, content).Result;
            var result = JsonSerializer.Deserialize<JsonObject>(response.Content.ReadAsStream());
            return result;
        }

        public JsonObject GetArchiveReport(string AppId)
        {
            var url = new Uri(client.BaseAddress + apiName + "/GetArchiveReport?AppId=" + AppId);
            var response = client.GetAsync(url).Result;
            var result = JsonSerializer.Deserialize<JsonObject>(response.Content.ReadAsStream());
            return result;
        }

        public JsonObject GetReportPerformance(string JSONRequestModel)
        {
            var url = new Uri(client.BaseAddress + apiName + "/ReportPerformance");
            var content = new StringContent(JSONRequestModel);
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = client.PostAsync(url, content).Result;
            var resposp = response.Content.ReadAsStringAsync().Result;
            var result = JsonSerializer.Deserialize<JsonObject>(response.Content.ReadAsStream());
             
            return result;
        }
    }
}
