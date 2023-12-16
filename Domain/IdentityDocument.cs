using System;
using System.Diagnostics.CodeAnalysis;

namespace Domain
{
    public class IdentityDocument
    {
        public int Id { get; set; }
        public DocumentType DocumentType { get; set; }
        public string Number { get; set; }
        public string PlaceOfIssue { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime IssueDate { get; set; }
        public string Nationality { get; set; }
        public string Naturalness { get; set; }
        public DateTime BirthDate { get; set; }
    }
}