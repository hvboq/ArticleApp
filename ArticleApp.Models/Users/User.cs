using Dul.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace ArticleApp.Models.Users
{
    public class User : AuditableBase
    {
        /// <summary>
        /// 고유한 이메일
        /// </summary>
        [Key]
        [Required(ErrorMessage = "이메일을 입력해주세요.")]
        public string Email { get; set; }
        /// <summary>
        /// 비밀번호
        /// </summary>
        [Required(ErrorMessage = "비밀번호를 입력해주세요.")]
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
