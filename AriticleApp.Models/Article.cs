﻿using System.ComponentModel.DataAnnotations;

namespace AriticleApp.Models
{

    /// <summary>
    /// Article 모델 클래스: Articles 테이블과 일대일로 매핑
    /// </summary>
    public class Article
    {
        /// <summary>
        /// 일련번호
        /// </summary>
        
        public int Id { get; set; }

        /// <summary>
        /// 제목
        /// </summary>
        [Required]
        public string Title { get; set; }
    }
}
