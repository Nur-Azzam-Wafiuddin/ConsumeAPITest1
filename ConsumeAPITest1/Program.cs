using ConsumeAPITest1;
using Newtonsoft.Json;
using RestSharp;
using System.Net;
using System.Text.Json.Nodes;
using System.Collections.Generic;
using System.Text.Json;

SendProduct jsonData = new SendProduct();
jsonData.Name = "Bob";
jsonData.isAvailable = true;

var jsonDataReady = JsonConvert.SerializeObject(jsonData);

var getId = 1;
var postUrl = "http://localhost:7100/api/Product/" + getId;
var client = new RestClient();
var request = new RestRequest()
{
    Resource = postUrl
};

request.AddHeader("Content-Type", "application/json");
request.AddHeader("Accept", "application/xml");
request.AddJsonBody(jsonDataReady);

var response = client.Put(request);
/*
var response = client.Get(request);

List<Product> obj = JsonConvert.DeserializeObject<List<Product>>(response.Content);
Console.WriteLine(obj[0]);
*/






