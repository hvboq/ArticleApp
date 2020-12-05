using Dul.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ArticleApp.Models.VotedUsers
{
    public class VotedUser : AuditableBase
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "주제를 입력하세요.")]
        public string Topic { get; set; }
        [Required]
        public string Value { get; set; }
        [Required]
        public string Users { get; set; }
    }
}
