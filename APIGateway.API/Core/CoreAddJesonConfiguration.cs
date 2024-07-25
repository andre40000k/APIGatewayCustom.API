namespace APIGateway.API.Core
{
    public static class CoreAddJesonConfiguration
    {
        public static ConfigurationManager AddJesons(this ConfigurationManager builder)
        {
            builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("httpMetodsRequests.json", optional: false, reloadOnChange: true);

            return builder;
        }
    }
}
