﻿
using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    [MetadataType(typeof(BaseCodeMetadata))]
    public partial class BaseCode
    {
    }

    public partial class BaseCodeMetadata
    {
        [Required(ErrorMessage = "Please enter : Id")]
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter : 代码类型")]
        [Display(Name = "代码类型")]
        [MaxLength(20)]
        public string CodeType { get; set; }

        [Required(ErrorMessage = "Please enter : 描述")]
        [Display(Name = "描述")]
        [MaxLength(50)]
        public string Description { get; set; }

    }
}
