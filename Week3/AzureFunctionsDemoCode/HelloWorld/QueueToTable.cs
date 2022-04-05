using System;
using System.Text.Json;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace HelloWorld
{
    public class QueueToTable
    {
        [FunctionName("QueueToTable")]
        [return: Table("victortable")]
        public Person Run([QueueTrigger("victor-items")]string myQueueItem, ILogger log)
        {
            
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
            return JsonSerializer.Deserialize<Person>(myQueueItem);
        }
    }
}
