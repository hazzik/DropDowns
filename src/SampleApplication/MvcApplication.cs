using MvcExtensions;
using MvcExtensions.Windsor;
using SampleApplication.Infrastructure;

namespace SampleApplication
{
    public class MvcApplication : WindsorMvcApplication
    {
        public MvcApplication()
        {
            Bootstrapper.BootstrapperTasks
                .Include<RegisterRoutes>()
                .Include<RegisterModelMetadata>();
        }
    }
}
