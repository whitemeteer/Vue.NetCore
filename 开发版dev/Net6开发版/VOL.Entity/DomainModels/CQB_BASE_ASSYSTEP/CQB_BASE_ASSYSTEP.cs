/*
 *代码由框架生成,任何更改都可能导致被代码生成器覆盖
 *如果数据库字段发生变化，请在代码生器重新生成此Model
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VOL.Entity.SystemModels;

namespace VOL.Entity.DomainModels
{
    [Entity(TableCnName = "CQB_BASE_ASSYSTEP",TableName = "CQB_BASE_ASSYSTEP")]
    public partial class CQB_BASE_ASSYSTEP:BaseEntity
    {
        /// <summary>
       ///主键
       /// </summary>
       [Key]
       [Display(Name ="主键")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       [Required(AllowEmptyStrings=false)]
       public string ID { get; set; }

       /// <summary>
       ///导入版本
       /// </summary>
       [Display(Name ="导入版本")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string ImportVersion { get; set; }

       /// <summary>
       ///站点
       /// </summary>
       [Display(Name ="站点")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string STEPNAME { get; set; }

       /// <summary>
       ///是否计算
       /// </summary>
       [Display(Name ="是否计算")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string IS_MATH { get; set; }

       /// <summary>
       ///是否外包
       /// </summary>
       [Display(Name ="是否外包")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string IS_OUTSOURCING { get; set; }

       /// <summary>
       ///制程
       /// </summary>
       [Display(Name ="制程")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string PROCESS { get; set; }

       /// <summary>
       ///晶圆尺寸
       /// </summary>
       [Display(Name ="晶圆尺寸")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string WAFER_SIZE { get; set; }

       /// <summary>
       ///厂别
       /// </summary>
       [Display(Name ="厂别")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string PLANT { get; set; }

       /// <summary>
       ///客户代码
       /// </summary>
       [Display(Name ="客户代码")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string CUSTOMER { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="AUTOFLAG")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string AUTOFLAG { get; set; }

       /// <summary>
       ///封装体分组
       /// </summary>
       [Display(Name ="封装体分组")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string PKG_GROUP { get; set; }

       /// <summary>
       ///SBS层数
       /// </summary>
       [Display(Name ="SBS层数")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string SBS_PLIES { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="LF_LO")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string LF_LO { get; set; }

       /// <summary>
       ///电镀类型
       /// </summary>
       [Display(Name ="电镀类型")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string PLATING_TYPE { get; set; }

       /// <summary>
       ///金线类型
       /// </summary>
       [Display(Name ="金线类型")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string WIRE_TYPE { get; set; }

       /// <summary>
       ///特殊作业
       /// </summary>
       [Display(Name ="特殊作业")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string SPE_DIEATTACH_METHOD { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="W_MIN_PKGSIZE")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string W_MIN_PKGSIZE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="W_MAX_PKGSIZE")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string W_MAX_PKGSIZE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="W_MIN_DIESIZE")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string W_MIN_DIESIZE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="W_MAX_DIESIZE")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string W_MAX_DIESIZE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="L_MIN_DIESIZE")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string L_MIN_DIESIZE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="L_MAX_DIESIZE")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string L_MAX_DIESIZE { get; set; }

       /// <summary>
       ///是否加热
       /// </summary>
       [Display(Name ="是否加热")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string IS_WARM { get; set; }

       /// <summary>
       ///MATERIAL_TYPE
       /// </summary>
       [Display(Name ="MATERIAL_TYPE")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string MATERIAL_TYPE { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="STRIP_SIZE_Y")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string STRIP_SIZE_Y { get; set; }

       /// <summary>
       ///设备型号
       /// </summary>
       [Display(Name ="设备型号")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string M_ID { get; set; }

       /// <summary>
       ///烤箱箱体数量
       /// </summary>
       [Display(Name ="烤箱箱体数量")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string M_WARM_COUNT { get; set; }

       /// <summary>
       ///MMR
       /// </summary>
       [Display(Name ="MMR")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string M_MMR { get; set; }

       /// <summary>
       ///RQD
       /// </summary>
       [Display(Name ="RQD")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string M_RQD { get; set; }

       /// <summary>
       ///COEE
       /// </summary>
       [Display(Name ="COEE")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string M_COEE { get; set; }

       /// <summary>
       ///PRICE
       /// </summary>
       [Display(Name ="PRICE")]
       [DisplayFormat(DataFormatString="18,2")]
       [Column(TypeName="decimal")]
       [Editable(true)]
       public decimal? M_PRICE { get; set; }

       /// <summary>
       ///CONSIGN
       /// </summary>
       [Display(Name ="CONSIGN")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string M_CONSIGN { get; set; }

       /// <summary>
       ///辅助设备+Tooling
       /// </summary>
       [Display(Name ="辅助设备+Tooling")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string AMT_ID { get; set; }

       /// <summary>
       ///辅助设备+Tooling价格
       /// </summary>
       [Display(Name ="辅助设备+Tooling价格")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string AMT_PRICE { get; set; }

       /// <summary>
       ///辅助设备+Tooling委托
       /// </summary>
       [Display(Name ="辅助设备+Tooling委托")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string AMT_CONSIGN { get; set; }

       /// <summary>
       ///铸模槽价格
       /// </summary>
       [Display(Name ="铸模槽价格")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string MOLD_CHASE_PRICE { get; set; }

       /// <summary>
       ///铸模槽委托
       /// </summary>
       [Display(Name ="铸模槽委托")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string MOLD_CHASE_CONSIGN { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CreateDate")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? CreateDate { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CreateUserId")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string CreateUserId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="CreateUserName")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string CreateUserName { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ModifyDate")]
       [Column(TypeName="datetime")]
       [Editable(true)]
       public DateTime? ModifyDate { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ModifyUserId")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string ModifyUserId { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="ModifyUserName")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string ModifyUserName { get; set; }

       /// <summary>
       ///Y,N
       /// </summary>
       [Display(Name ="Y,N")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       public string Status { get; set; }

       /// <summary>
       ///Y,N
       /// </summary>
       [Display(Name ="Y,N")]
       [MaxLength(1)]
       [Column(TypeName="char(1)")]
       [Editable(true)]
       public string DeleteMark { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Reference1")]
       [MaxLength(50)]
       [Column(TypeName="varchar(50)")]
       [Editable(true)]
       public string Reference1 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Reference2")]
       [MaxLength(100)]
       [Column(TypeName="varchar(100)")]
       [Editable(true)]
       public string Reference2 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Reference3")]
       [MaxLength(200)]
       [Column(TypeName="varchar(200)")]
       [Editable(true)]
       public string Reference3 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Reference4")]
       [MaxLength(400)]
       [Column(TypeName="varchar(400)")]
       [Editable(true)]
       public string Reference4 { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="Reference5")]
       [Column(TypeName="varchar(max)")]
       [Editable(true)]
       public string Reference5 { get; set; }

       
    }
}