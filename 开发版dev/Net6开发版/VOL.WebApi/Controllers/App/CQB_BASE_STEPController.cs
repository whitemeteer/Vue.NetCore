/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果要增加方法请在当前目录下Partial文件夹CQB_BASE_STEPController编写
 */
using Microsoft.AspNetCore.Mvc;
using VOL.Core.Controllers.Basic;
using VOL.Entity.AttributeManager;
using VOL.App.IServices;
namespace VOL.App.Controllers
{
    [Route("api/CQB_BASE_STEP")]
    [PermissionTable(Name = "CQB_BASE_STEP")]
    public partial class CQB_BASE_STEPController : ApiBaseController<ICQB_BASE_STEPService>
    {
        public CQB_BASE_STEPController(ICQB_BASE_STEPService service)
        : base(service)
        {
        }
    }
}

