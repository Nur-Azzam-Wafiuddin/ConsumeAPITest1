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
sendAccount.name = "Giftor";
sendAccount.username = "Giftor";
sendAccount.password = "Leong";
sendAccount.productCart = new List<SendProductCart>()
{
    new SendProductCart(){name = "Boson", approval = "Pending", borrowPeriodStart = "12-12-12", borrowPeriodEnd = "13-13-13", accountId = null},
    new SendProductCart(){name = "Wison", approval = "Pending", borrowPeriodStart = "12-12-12", borrowPeriodEnd = "13-13-13", accountId = null},
    new SendProductCart(){name = "Camera", approval = "Pending", borrowPeriodStart = "12-12-12", borrowPeriodEnd = "13-13-13", accountId = null},
};

sendAccount.productHistory = new List<SendProductHistory>()
{
    new SendProductHistory(){name = "Boson", borrowPeriodStart = "12-12-12", borrowPeriodEnd = "13-13-13", accountId = null},
};

//var jsonDataReady = JsonConvert.SerializeObject(jsonData);
var sendAccountJson = JsonConvert.SerializeObject(sendAccount);

var getId = 2;
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

List<Account> obj = JsonConvert.DeserializeObject<List<Account>>(response.Content);
Console.WriteLine(obj[0]);
*/






