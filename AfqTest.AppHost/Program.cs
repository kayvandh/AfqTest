var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.AfqTest_ApiService>("apiservice");

builder.AddProject<Projects.AfqTest_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
