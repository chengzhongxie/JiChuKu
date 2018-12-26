using DAL.Model;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JiChuKu.Models
{
    /// <summary>
    /// 行政强制F集合
    /// </summary>
    public class FAdministrativeCoercionTest: FatherClassTest
    {
        /// <summary>
        /// 行政强制执行决定书文号
        /// </summary>
        public string FBookNumber { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string FEntryName { get; set; }
        /// <summary>
        /// 行政机关
        /// </summary>
        public string FAdministrativeOrgan { get; set; }
        /// <summary>
        /// 强制内容
        /// </summary>
        public string FMandatoryContent { get; set; }
        /// <summary>
        /// 执行日期
        /// </summary>
        public string FExecutionDate { get; set; }
        /// <summary>
        /// 法人基本数据id
        /// </summary>
        public string FLegalPersonID { get; set; }
        /// <summary>
        /// 法人基本数据
        /// </summary>
        public FLegalPersonTest FLegalPerson { get; set; }
    }
    public class FAdministrativeCoercionTestValidator : AbstractValidator<FAdministrativeCoercionTest>
    {
        public FAdministrativeCoercionTestValidator()
        {
            RuleFor(x => x.FBookNumber).NotEmpty()
                .WithName("行政强制执行决定书文号").WithMessage("{PropertyName}是必须填写的")
                .MaximumLength(50).WithMessage("{PropertyName}的最大长度是{MaxLength}");
        }
    }
}
