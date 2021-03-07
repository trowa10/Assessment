using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AssessmentPersistence.Entities.LookUpTables
{
    [ExcludeFromCodeCoverage]
    public class Dom
    {
        public Dom()
        {
            this.DateTimeUtc = DateTime.UtcNow;
        }

        [Key]
        public int DomId { get; set; }
        public int ElementId { get; set; }
        public DomElement DomElement { get; set; }
        public int TypeId { get; set; }
        public DomType DomType { get; set; }
        public string DataType { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Style { get; set; }
        public string Group { get; set; }
        public bool IsRequired { get; set; }
        public bool Enabled { get; set; }
        public string PlaceHolder { get; set; }
        public string Value { get; set; }
        public int TableRow { get; set; }
        /* ForAnswer 
          will be used to determine if the dom element
          is for answers e.g. labels,headers is false while
          textbox,textarea,radio that are used for answering is true
        */
        public bool ForAnswer { get; set; }
        public DateTime DateTimeUtc { get; set; }

        public IReadOnlyCollection<CategoryDom> CategoryDoms { get; set; }
        public IReadOnlyCollection<QuestionnaireDom> QuestionnaireDoms { get; set; }
    }
}
