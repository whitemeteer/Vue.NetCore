/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *Repository提供数据库操作，如果要增加数据库操作请在当前目录下Partial文件夹CQB_BASE_STEPRepository编写代码
 */
using VOL.App.IRepositories;
using VOL.Core.BaseProvider;
using VOL.Core.EFDbContext;
using VOL.Core.Extensions.AutofacManager;
using VOL.Entity.DomainModels;

namespace VOL.App.Repositories
{
    public partial class CQB_BASE_STEPRepository : RepositoryBase<CQB_BASE_STEP> , ICQB_BASE_STEPRepository
    {
    public CQB_BASE_STEPRepository(VOLContext dbContext)
    : base(dbContext)
    {

    }
    public static ICQB_BASE_STEPRepository Instance
    {
      get {  return AutofacContainerModule.GetService<ICQB_BASE_STEPRepository>(); } }
    }
}
