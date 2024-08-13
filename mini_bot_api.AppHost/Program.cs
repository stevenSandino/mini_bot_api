var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.mini_bot_api_ApiService>("apiservice");

builder.AddProject<Projects.mini_bot_api_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
