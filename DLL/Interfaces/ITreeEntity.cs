using DAL.Bases;
using System.Collections.Generic;

namespace DAL.Interfaces
{
    public interface ITreeEntity<T> where T : EntityBase
    {
        int? ParentId { get; set; }
        string AncestorIds { get; set; }
        bool IsAbstract { get; set; }
        int Level { get; }
        T Parent { get; set; }
        ICollection<T> Children { get; set; }
    }
}
