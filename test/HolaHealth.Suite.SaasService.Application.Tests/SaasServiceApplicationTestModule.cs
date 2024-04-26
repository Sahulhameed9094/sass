using HolaHealth.Suite.SaasService.Application;
using Volo.Abp.Modularity;

namespace HolaHealth.Suite.SaasService;

[DependsOn(
    typeof(SaasServiceApplicationModule),
    typeof(SaasServiceDomainTestModule)
    )]
public class SaasServiceApplicationTestModule : AbpModule
{

}
