﻿namespace SalesCommon
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        [StringLength(50)]
     
        public string Description { get; set; }

        [DataType(DataType.MultilineText)]      
        public string Remarks { get; set; }

        [Display(Name = "Image")]
        public string ImagePath { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Display(Name = "Is Available")]
        public bool IsAvailable { get; set; }

        [Display(Name = "Publish On")]
        [DataType(DataType.Date)]
        public DateTime PublishOn { get; set; }

        public string  ImageFullPath
        {
            get
            {
                if (string.IsNullOrEmpty(ImagePath))
                {
                    return  "SALES.jpg";
                }

                return $"http://192.168.0.15:555/{ImagePath.Substring(1)}";
            }
        }

        public override string ToString() => this.Description;
     
    }
}
