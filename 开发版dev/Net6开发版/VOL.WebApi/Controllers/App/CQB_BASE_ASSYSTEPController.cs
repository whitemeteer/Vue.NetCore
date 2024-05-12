/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹CQB_BASE_ASSYSTEPController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using VOL.App.IServices;
namespace VOL.App.Controllers
{
    [Route("api/CQB_BASE_ASSYSTEP")]
    [PermissionTable(Name = "CQB_BASE_ASSYSTEP")]
    public partial class CQB_BASE_ASSYSTEPController : ApiBaseController<ICQB_BASE_ASSYSTEPService>
    {
        public CQB_BASE_ASSYSTEPController(ICQB_BASE_ASSYSTEPService service)
        : base(service)
        {
        }
    }
}

