/*
 *Author：jxx
 *Contact：283591387@qq.com
 *代码由框架生成,此处任何更改都可能导致被代码生成器覆盖
 *所有业务编写全部应在Partial文件夹下CQB_BASE_ASSYSTEP_ItemDetailService与ICQB_BASE_ASSYSTEP_ItemDetailService中编写
 */
using VOL.App.IRepositories;
using VOL.App.IServices;
using VOL.Core.BaseProvider;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.App.Services
{
    public partial class CQB_BASE_ASSYSTEP_ItemDetailService : ServiceBase<CQB_BASE_ASSYSTEP_ItemDetail, ICQB_BASE_ASSYSTEP_ItemDetailRepository>
    , ICQB_BASE_ASSYSTEP_ItemDetailService, IDependency
    {
    public CQB_BASE_ASSYSTEP_ItemDetailService(ICQB_BASE_ASSYSTEP_ItemDetailRepository repository)
    : base(repository)
    {
    Init(repository);
    }
    public static ICQB_BASE_ASSYSTEP_ItemDetailService Instance
    {
      get { return AutofacContainerModule.GetService<ICQB_BASE_ASSYSTEP_ItemDetailService>(); } }
    }
 }
