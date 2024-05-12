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
    [Entity(TableCnName = "CQB_BASE_STEP",TableName = "CQB_BASE_STEP")]
    public partial class CQB_BASE_STEP:BaseEntity
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
       ///
       /// </summary>
       [Display(Name ="MES_STEP_LIST")]
       [Column(TypeName="nvarchar(max)")]
       [Editable(true)]
       public string MES_STEP_LIST { get; set; }

       /// <summary>
       ///制程
       /// </summary>
       [Display(Name ="制程")]
       [MaxLength(200)]
       [Column(TypeName="nvarchar(200)")]
       [Editable(true)]
       public string PROCESS { get; set; }

       /// <summary>
       ///封装类型
       /// </summary>
       [Display(Name ="封装类型")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string PKGType { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="PKG_GROUP")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string PKG_GROUP { get; set; }

       /// <summary>
       ///长别
       /// </summary>
       [Display(Name ="长别")]
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
       [Display(Name ="WAFER_THICKNESS")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string WAFER_THICKNESS { get; set; }

       /// <summary>
       ///是否 GaAs?
       /// </summary>
       [Display(Name ="是否 GaAs?")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string IS_GAAS { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="WAFER_SURFACE_STRUCTURE")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string WAFER_SURFACE_STRUCTURE { get; set; }

       /// <summary>
       ///特殊作业
       /// </summary>
       [Display(Name ="特殊作业")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string SPE_DIEATTACH_METHOD { get; set; }

       /// <summary>
       ///判断作业次数
       /// </summary>
       [Display(Name ="判断作业次数")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string DIE_ATTACH { get; set; }

       /// <summary>
       ///
       /// </summary>
       [Display(Name ="AUTO_FLAG")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string AUTO_FLAG { get; set; }

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
       ///SBS层数
       /// </summary>
       [Display(Name ="SBS层数")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string SBS_PLIES { get; set; }

       /// <summary>
       ///电镀类型
       /// </summary>
       [Display(Name ="电镀类型")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string PLATING_TYPE { get; set; }

       /// <summary>
       ///LF是否贴膜
       /// </summary>
       [Display(Name ="LF是否贴膜")]
       [MaxLength(50)]
       [Column(TypeName="nvarchar(50)")]
       [Editable(true)]
       public string TAPE_SHAPE { get; set; }

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