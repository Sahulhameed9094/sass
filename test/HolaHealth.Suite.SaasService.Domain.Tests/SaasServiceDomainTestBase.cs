using Volo.Abp.Modularity;

namespace HolaHealth.Suite.SaasService;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class SaasServiceDomainTestBase<TStartupModule> : SaasServiceTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
