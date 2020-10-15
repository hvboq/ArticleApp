﻿using Dul.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace ArticleApp.Models
{

    /// <summary>
    /// Article 모델 클래스: Articles 테이블과 일대일로 매핑
    /// </summary>
    public class Article : AuditableBase
    {
        /// <summary>
        /// 일련번호
        /// </summary>
        
        public int Id { get; set; }

        /// <summary>
        /// 제목
        /// </summary>
        [Required(ErrorMessage ="제목을 입력하세요.")]
        public string Title { get; set; }
    }
}
