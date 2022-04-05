using System;
using System.Text.Json;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;


namespace HelloWorld
{
    public class TimerSample
    {
        static int Counter = 0;
        [FunctionName("TimerSample")]
        [return: Queue("victor-items")]
        public string Run([TimerTrigger("* */10 * * * *")]TimerInfo myTimer, ILogger log)
        {
            Counter++;
            Person p = new Person() {
                Id = DateTime.Now.Millisecond,
                Name = Guid.NewGuid().ToString(),
                Description = Counter.ToString() +"--"+DateTime.Now.ToLongDateString() };

            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
            return JsonSerializer.Serialize(p);
        }
    }
}
