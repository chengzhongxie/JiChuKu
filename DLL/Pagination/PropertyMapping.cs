using DAL.Bases;
using System;
using System.Collections.Generic;

namespace DAL.Pagination
{
    public abstract class PropertyMapping
    {
        public Dictionary<string, PropertyMappingValue> MappingDictionary { get; }

        protected PropertyMapping(Dictionary<string, PropertyMappingValue> mappingDictionary)
        {
            MappingDictionary = mappingDictionary;
            MappingDictionary[nameof(EntityBase.Id)] = new PropertyMappingValue(new List<string> { nameof(EntityBase.Id) });
            MappingDictionary[nameof(EntityBase.ZUpdateTimestamp)] = new PropertyMappingValue(new List<string> { nameof(EntityBase.ZUpdateTimestamp) });
            MappingDictionary[nameof(EntityBase.Remarks)] = new PropertyMappingValue(new List<string> { nameof(EntityBase.Remarks) });
            MappingDictionary[nameof(EntityBase.State)] = new PropertyMappingValue(new List<string> { nameof(EntityBase.State) });
            MappingDictionary[nameof(EntityBase.CreateTime)] = new PropertyMappingValue(new List<string> { nameof(EntityBase.CreateTime) });
            MappingDictionary[nameof(EntityBase.CreatePerson)] = new PropertyMappingValue(new List<string> { nameof(EntityBase.CreatePerson) });
            MappingDictionary[nameof(EntityBase.UpdateTime)] = new PropertyMappingValue(new List<string> { nameof(EntityBase.UpdateTime) });
            MappingDictionary[nameof(EntityBase.UpdatePerson)] = new PropertyMappingValue(new List<string> { nameof(EntityBase.UpdatePerson) });
            MappingDictionary[nameof(EntityBase.Version)] = new PropertyMappingValue(new List<string> { nameof(EntityBase.Version) });
        }

        public bool ValidMappingExistsFor(string fields)
        {
            if (string.IsNullOrWhiteSpace(fields))
            {
                return true;
            }

            var fieldsAfterSplit = fields.Split(',');
            foreach (var field in fieldsAfterSplit)
            {
                var trimmedField = field.Trim();
                var indexOfFirstSpace = trimmedField.IndexOf(" ", StringComparison.Ordinal);
                var propertyName = indexOfFirstSpace == -1 ?
                    trimmedField : trimmedField.Remove(indexOfFirstSpace);
                if (!MappingDictionary.ContainsKey(propertyName))
                {
                    return false;
                }
            }
            return true;
        }
    }
}