/*
 *接口编写处...
*如果接口需要做Action的权限验证，请在Action上使用属性
*如: [ApiActionPermission("CQB_BASE_ASSYSTEP_ItemDetail",Enums.ActionPermissionOptions.Search)]
 */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using VOL.Entity.DomainModels;
using VOL.App.IServices;

namespace VOL.App.Controllers
{
    public partial class CQB_BASE_ASSYSTEP_ItemDetailController
    {
        private readonly ICQB_BASE_ASSYSTEP_ItemDetailService _service;//访问业务代码
        private readonly IHttpContextAccessor _httpContextAccessor;

        [ActivatorUtilitiesConstructor]
        public CQB_BASE_ASSYSTEP_ItemDetailController(
            ICQB_BASE_ASSYSTEP_ItemDetailService service,
            IHttpContextAccessor httpContextAccessor
        )
        : base(service)
        {
            _service = service;
            _httpContextAccessor = httpContextAccessor;
        }
    }
}
