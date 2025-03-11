var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.ProductManagement_Api>("productmanagement-api");

builder.Build().Run();
