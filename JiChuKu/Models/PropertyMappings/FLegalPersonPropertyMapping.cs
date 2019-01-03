using DAL.Model;
using DAL.Pagination;
using System;
using System.Collections.Generic;

namespace JiChuKu.Models.PropertyMappings
{
    public class FLegalPersonPropertyMapping : PropertyMapping
    {
        public FLegalPersonPropertyMapping() : base(
            new Dictionary<string, PropertyMappingValue>(StringComparer.OrdinalIgnoreCase)
                {
                    { nameof(FLegalPersonTest.FEnterpriseName), new PropertyMappingValue(new [] { nameof(FLegalPerson.FEnterpriseName) } )},
                    { nameof(FLegalPersonTest.FRegistrationNumber), new PropertyMappingValue(new [] { nameof(FLegalPerson.FRegistrationNumber) } )},
                    { nameof(FLegalPersonTest.FOrganizationalCode), new PropertyMappingValue(new [] { nameof(FLegalPerson.FOrganizationalCode) } )},
                    { nameof(FLegalPersonTest.FTaxRegistrationNumber), new PropertyMappingValue(new [] { nameof(FLegalPerson.FTaxRegistrationNumber) } )},
                    { nameof(FLegalPersonTest.FIDNumber), new PropertyMappingValue(new [] { nameof(FLegalPerson.FIDNumber) } )},
                    { nameof(FLegalPersonTest.FResidence), new PropertyMappingValue(new [] { nameof(FLegalPerson.FResidence) } )},
                    { nameof(FLegalPersonTest.FRegisteredCapital), new PropertyMappingValue(new [] { nameof(FLegalPerson.FRegisteredCapital) } )},
                    { nameof(FLegalPersonTest.FCurrency), new PropertyMappingValue(new [] { nameof(FLegalPerson.FCurrency) } )},
                    { nameof(FLegalPersonTest.FForeignCurrency), new PropertyMappingValue(new [] { nameof(FLegalPerson.FForeignCurrency) } )},
                    { nameof(FLegalPersonTest.FTypesOfEnterprises), new PropertyMappingValue(new [] { nameof(FLegalPerson.FTypesOfEnterprises) } )},
                    { nameof(FLegalPersonTest.FBusinessScope), new PropertyMappingValue(new [] { nameof(FLegalPerson.FBusinessScope) } )},
                    { nameof(FLegalPersonTest.FBusinessTermTo), new PropertyMappingValue(new [] { nameof(FLegalPerson.FBusinessTermTo) } )},
                    { nameof(FLegalPersonTest.FEstablishDate), new PropertyMappingValue(new [] { nameof(FLegalPerson.FEstablishDate) } )},
                    { nameof(FLegalPersonTest.FSubjectionName), new PropertyMappingValue(new [] { nameof(FLegalPerson.FSubjectionName) } )},
                    { nameof(FLegalPersonTest.FManagementState), new PropertyMappingValue(new [] { nameof(FLegalPerson.FManagementState) } )},
                    { nameof(FLegalPersonTest.FCreditCode), new PropertyMappingValue(new [] { nameof(FLegalPerson.FCreditCode) } )},
                    { nameof(FLegalPersonTest.FDataSources), new PropertyMappingValue(new [] { nameof(FLegalPerson.FDataSources) } )},
                    { nameof(FLegalPersonTest.FApprovalDate), new PropertyMappingValue(new [] { nameof(FLegalPerson.FApprovalDate) } )},
                    { nameof(FLegalPersonTest.FIndustryCode), new PropertyMappingValue(new [] { nameof(FLegalPerson.FIndustryCode) } )},
                    { nameof(FLegalPersonTest.FRegistrationAuthority), new PropertyMappingValue(new [] { nameof(FLegalPerson.FRegistrationAuthority) } )},
                    { nameof(FLegalPersonTest.FPlaceOfBusiness), new PropertyMappingValue(new [] { nameof(FLegalPerson.FPlaceOfBusiness) } )},
                    { nameof(FLegalPersonTest.FBranchIdentification), new PropertyMappingValue(new [] { nameof(FLegalPerson.FBranchIdentification) } )},
                })
        {
        }
    }
}
