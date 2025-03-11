var builder = DistributedApplication.CreateBuilder(args);


builder.AddProject<Projects.Product_Api>("product-api");


builder.Build().Run();
