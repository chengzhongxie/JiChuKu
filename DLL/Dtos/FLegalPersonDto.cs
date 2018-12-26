using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Dtos
{
    /// <summary>
    /// 法人基本数据
    /// </summary>
    public class FLegalPersonDto : FatherClassDto
    {
        public FLegalPersonDto()
        {
            FAdministrativeCoercions = new List<FAdministrativeCoercionDto>();
            FAdministrativeExaminations = new List<FAdministrativeExaminationDto>();
            FAdministrativeLicensings = new List<FAdministrativeLicensingDto>();
            FAdministrativeRewards = new List<FAdministrativeRewardDto>();
            FAdministrativeSanctions = new List<FAdministrativeSanctionDto>();
            FDishonestExecutors = new List<FDishonestExecutorDto>();
            FOtherCommendations = new List<FOtherCommendationDto>();
            FOtherPenaltiess = new List<FOtherPenaltiesDto>();
        }

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

        public ICollection<FAdministrativeCoercionDto> FAdministrativeCoercions { get; set; }
        public int FAdministrativeCoercionCount => FAdministrativeCoercions.Count;
        public ICollection<FAdministrativeExaminationDto> FAdministrativeExaminations { get; set; }
        public int FAdministrativeExaminationCount => FAdministrativeExaminations.Count;
        public ICollection<FAdministrativeLicensingDto> FAdministrativeLicensings { get; set; }
        public int FAdministrativeLicensingCount => FAdministrativeLicensings.Count;
        public ICollection<FAdministrativeRewardDto> FAdministrativeRewards { get; set; }
        public int FAdministrativeRewardCount => FAdministrativeRewards.Count;
        public ICollection<FAdministrativeSanctionDto> FAdministrativeSanctions { get; set; }
        public int FAdministrativeSanctionCount => FAdministrativeSanctions.Count;
        public ICollection<FDishonestExecutorDto> FDishonestExecutors { get; set; }
        public int FDishonestExecutorCount => FDishonestExecutors.Count;
        public ICollection<FOtherCommendationDto> FOtherCommendations { get; set; }
        public int FOtherCommendationCount => FOtherCommendations.Count;
        public ICollection<FOtherPenaltiesDto> FOtherPenaltiess { get; set; }
        public int FOtherPenaltiesCount => FOtherPenaltiess.Count;
    }
}
