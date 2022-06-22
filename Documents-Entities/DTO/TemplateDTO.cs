using System;

namespace Documents_Entities.DTO
{
    public partial class TemplateDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime? UpdateDate { get; set; }

        public bool Depricated { get; set; }

        public string TemplateType { get; set; }

        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
    }
}
