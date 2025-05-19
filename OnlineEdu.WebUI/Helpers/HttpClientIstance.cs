namespace OnlineEdu.WebUI.Helpers
{
    public static class HttpClientIstance
    {
        public static HttpClient CreatClient()
        {

            HttpClient client = new HttpClient();
            

                client.BaseAddress = new Uri("https://localhost:7247/api/");

            return client;

        }
}
    }

