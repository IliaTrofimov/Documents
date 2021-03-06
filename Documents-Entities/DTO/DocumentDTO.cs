using System;


namespace Documents_Entities.DTO
{
    public partial class DocumentDTO
    {      
        public int Id { get; set; }

        public string Name { get; set; }

        public int TemplateId { get; set; }

        public string TemplateName { get; set; }

        public int Type { get; set; }

        public DateTime UpdateDate { get; set; }

        public DateTime? ExpireDate { get; set; }

        public int AuthorId { get; set; }
        public string AuthorName { get; set; }

    }
}
