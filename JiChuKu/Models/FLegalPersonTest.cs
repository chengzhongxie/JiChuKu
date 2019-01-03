using DAL.Bases;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JiChuKu.Models
{
    /// <summary>
    /// 法人基本数据
    /// </summary>
    public class FLegalPersonTest : EntityBase
    {
        /// <summary>
        /// 企业名称
        /// </summary>
        public string FEnterpriseName { get; set; }
        /// <summary>
        /// 工商注册号
        /// </summary>
        public string FRegistrationNumber { get; set; }
        /// <summary>
        /// 组织机构代码
        /// </summary>
        public string FOrganizationalCode { get; set; }
        /// <summary>
        /// 税务登记号
        /// </summary>
        public string FTaxRegistrationNumber { get; set; }
        /// <summary>
        /// 身份证号
        /// </summary>
        public string FIDNumber { get; set; }
        /// <summary>
        /// 住所
        /// </summary>
        public string FResidence { get; set; }
        /// <summary>
        /// 注册资本（金）
        /// </summary>
        public string FRegisteredCapital { get; set; }
        /// <summary>
        /// 注册资本中外币
        /// </summary>
        public string FCurrency { get; set; }
        /// <summary>
        /// 外币币种
        /// </summary>
        public string FForeignCurrency { get; set; }
        /// <summary>
        /// 企业类型
        /// </summary>
        public string FTypesOfEnterprises { get; set; }
        /// <summary>
        /// 经营范围
        /// </summary>
        public string FBusinessScope { get; set; }
        /// <summary>
        /// 经营期限至
        /// </summary>
        public string FBusinessTermTo { get; set; }
        /// <summary>
        /// 成立日期
        /// </summary>
        public string FEstablishDate { get; set; }
        /// <summary>
        /// 隶属企业名称
        /// </summary>
        public string FSubjectionName { get; set; }
        /// <summary>
        /// 经营状态
        /// </summary>
        public string FManagementState { get; set; }
        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        public string FCreditCode { get; set; }
        /// <summary>
        /// 数据来源
        /// </summary>
        public string FDataSources { get; set; }
        /// <summary>
        /// 核准日期
        /// </summary>
        public string FApprovalDate { get; set; }
        /// <summary>
        /// 行业代码
        /// </summary>
        public string FIndustryCode { get; set; }
        /// <summary>
        /// 登记机关
        /// </summary>
        public string FRegistrationAuthority { get; set; }
        /// <summary>
        /// 经营场所
        /// </summary>
        public string FPlaceOfBusiness { get; set; }
        /// <summary>
        /// 分支机构标识
        /// </summary>
        public string FBranchIdentification { get; set; }

        /// <summary>
        /// 行政强制F集合
        /// </summary>
        public ICollection<FAdministrativeCoercionTest> FAdministrativeCoercions { get; set; }
        /// <summary>
        /// 行政检查F集合
        /// </summary>
        public ICollection<FAdministrativeExaminationTest> FAdministrativeExaminations { get; set; }
        /// <summary>
        /// 行政许可F集合
        /// </summary>
        public ICollection<FAdministrativeLicensingTest> FAdministrativeLicensings { get; set; }
        /// <summary>
        /// 行政奖励F集合
        /// </summary>
        public ICollection<FAdministrativeRewardTest> FAdministrativeRewards { get; set; }
        /// <summary>
        /// 行政处罚F集合
        /// </summary>
        public ICollection<FAdministrativeSanctionTest> FAdministrativeSanctions { get; set; }
        /// <summary>
        /// 失信被执行人F集合
        /// </summary>
        public ICollection<FDishonestExecutorTest> FDishonestExecutors { get; set; }
        /// <summary>
        /// 其他表彰F集合
        /// </summary>
        public ICollection<FOtherCommendationTest> FOtherCommendations { get; set; }
        /// <summary>
        /// 其他处罚F集合
        /// </summary>
        public ICollection<FOtherPenaltiesTest> FOtherPenaltiess { get; set; }
    }

    public class FLegalPersonTestValidator : AbstractValidator<FLegalPersonTest>
    {
        public FLegalPersonTestValidator()
        {
            RuleFor(x => x.FEnterpriseName).NotEmpty()
                .WithName("企业名称").WithMessage("{PropertyName}是必须填写的")
                .MaximumLength(50).WithMessage("{PropertyName}的最大长度是{MaxLength}");
            RuleForEach(x => x.FAdministrativeCoercions).SetValidator(new FAdministrativeCoercionTestValidator());
        }
    }
}
