/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下CQB_BASE_ASSYSTEPService与ICQB_BASE_ASSYSTEPService中编写
 */
using VOL.App.IRepositories;
using VOL.App.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.App.Services
{
    public partial class CQB_BASE_ASSYSTEPService : ServiceBase<CQB_BASE_ASSYSTEP, ICQB_BASE_ASSYSTEPRepository>
    , ICQB_BASE_ASSYSTEPService, IDependency
    {
    public CQB_BASE_ASSYSTEPService(ICQB_BASE_ASSYSTEPRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static ICQB_BASE_ASSYSTEPService Instance
    {
      get { return AutofacContainerModule.GetService<ICQB_BASE_ASSYSTEPService>(); } }
    }
 }
