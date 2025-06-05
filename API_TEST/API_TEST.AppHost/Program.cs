var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.API_TEST>("api-test");

builder.Build().Run();
