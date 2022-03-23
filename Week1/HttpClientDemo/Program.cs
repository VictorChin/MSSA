// See https://aka.ms/new-console-template for more information
 try	
  {
    HttpClient client = new HttpClient();
     HttpResponseMessage response = await client.GetAsync("http://www.microsoft.com/");
     response.EnsureSuccessStatusCode();
     string responseBody = await response.Content.ReadAsStringAsync();
     // Above three lines can be replaced with new helper method below
     // string responseBody = await client.GetStringAsync(uri);

     Console.WriteLine(responseBody);
  }
  catch(HttpRequestException e)
  {
     Console.WriteLine("\nException Caught!");	
     Console.WriteLine("Message :{0} ",e.Message);
  }