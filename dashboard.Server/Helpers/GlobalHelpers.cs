namespace dashboard.server.Helpers
{
    public static class GlobalHelpers
    {
        public static string GenerateApiKey()
        {
            var guid = Guid.NewGuid();
            return guid.ToString("N");
        }
    }
}
