using Microsoft.Extensions.Logging;

namespace _01_DI.Service
{
    public class B : IB
    {
        public B(ILogger<B> logger, IA aService)
        {
            logger.LogInformation(aService.CalculateSum(1, 2).ToString());
        }

        //public B(ILogger<B> logger, IServiceProvider serviceProvider)

        //{
        //    using var scope = serviceProvider.CreateScope();
        //    var aService = scope.ServiceProvider.GetRequiredService<IA>();
        //    logger.LogInformation(aService.CalculateSum(1, 2).ToString());
        //}
    }
}
