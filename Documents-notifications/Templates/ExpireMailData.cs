using System;

namespace Documents_notifications.Templates
{
    partial class ExpireMail
    {
        private int DocumentId;
        private string BaseUrl;
        private string Firstname;
        private string Fathersname;
        private string DocumentName;
        private DateTime? Expire;

        public ExpireMail(Documents_Entities.Entities.Document document, string baseUrl)
        {
            DocumentName = document.Name;
            DocumentId = document.Id;
            Firstname = document.Author.Firstname;
            Fathersname = document.Author.Fathersname;
            Expire = document.ExpireDate;
            BaseUrl = baseUrl;
        }
    }
}
