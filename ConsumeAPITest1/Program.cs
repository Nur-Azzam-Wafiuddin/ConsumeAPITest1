using ConsumeAPITest1;
using Newtonsoft.Json;
using RestSharp;
using System.Net;
using System.Text.Json.Nodes;
using System.Collections.Generic;
using System.Text.Json;
/*
SendProduct jsonData = new SendProduct();
jsonData.name = "Bob";
jsonData.isAvailable = true;
*/
SendAccount sendAccount = new SendAccount();
sendAccount.name = "gifto";
sendAccount.username = "giftor";
sendAccount.password = "giftor";
sendAccount.productHistory = new List<ProductHistory>() { };

//var jsonDataReady = JsonConvert.SerializeObject(jsonData);
var sendAccountJson = JsonConvert.SerializeObject(sendAccount);

//var getId = 1;
var postUrl = "http://localhost:7100/api/Account/";
var client = new RestClient();
var request = new RestRequest()
{
    Resource = postUrl
};

request.AddHeader("Content-Type", "application/json");
request.AddHeader("Accept", "application/xml");
request.AddJsonBody(sendAccountJson);

var response = client.Post(request);
/*
var response = client.Get(request);

List<Product> obj = JsonConvert.DeserializeObject<List<Product>>(response.Content);
Console.WriteLine(obj[0]);
*/






