using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Dtos
{
    /// <summary>
    /// 自然人基本数据
    /// </summary>
    public class ZNaturalPersonDto : FatherClassDto
    {
        public ZNaturalPersonDto()
        {
            ZAdministrativeCoercions = new List<ZAdministrativeCoercionDto>();
            ZAdministrativeLicensings = new List<ZAdministrativeLicensingDto>();
            ZAdministrativeRewards = new List<ZAdministrativeRewardDto>();
            ZAdministrativeSanctions = new List<ZAdministrativeSanctionDto>();
            ZDishonestExecutors = new List<ZDishonestExecutorDto>();
            ZOtherCommendations = new List<ZOtherCommendationDto>();
            ZOtherPenaltiess = new List<ZOtherPenaltiesDto>();
        }

        /// <summary>
        /// 姓名
        /// </summary>
        public string ZName { get; set; }
        /// <summary>
        /// 证件类型
        /// </summary>
        public string ZDocumentType { get; set; }
        /// <summary>
        /// 证件号码
        /// </summary>
        public string ZLdentificationNumber { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string ZCompany { get; set; }
        /// <summary>
        /// 职务
        /// </summary>
        public string ZPost { get; set; }
        /// <summary>
        /// 数据来源
        /// </summary>
        public string ZDataSources { get; set; }

        public ICollection<ZAdministrativeCoercionDto> ZAdministrativeCoercions { get; set; }
        public int ZAdministrativeCoercionCount => ZAdministrativeCoercions.Count;
        public ICollection<ZAdministrativeLicensingDto> ZAdministrativeLicensings { get; set; }
        public int ZAdministrativeLicensingCount => ZAdministrativeLicensings.Count;
        public ICollection<ZAdministrativeRewardDto> ZAdministrativeRewards { get; set; }
        public int ZAdministrativeRewardCount => ZAdministrativeRewards.Count;
        public ICollection<ZAdministrativeSanctionDto> ZAdministrativeSanctions { get; set; }
        public int ZAdministrativeSanctionCount => ZAdministrativeSanctions.Count;
        public ICollection<ZDishonestExecutorDto> ZDishonestExecutors { get; set; }
        public int ZDishonestExecutorCount => ZDishonestExecutors.Count;
        public ICollection<ZOtherCommendationDto> ZOtherCommendations { get; set; }
        public int ZOtherCommendationCount => ZOtherCommendations.Count;
        public ICollection<ZOtherPenaltiesDto> ZOtherPenaltiess { get; set; }
        public int ZOtherPenaltiesCount => ZOtherPenaltiess.Count;
    }
}
