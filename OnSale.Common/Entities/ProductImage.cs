using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnSale.Common.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }

        [MaxLength(50, ErrorMessage = "The Filed {0} must contain less than {1} characteres")]
        [Required]

        [Display(Name = "Image")]
        public Guid ImageId { get; set; }

        //TODO: Pending to put the correct paths
        [Display(Name = "Image")]
        public string ImageFullPath => ImageId == Guid.Empty
            ? $"https://localhost:44396/images/no-image.png"
            : $"https://onsale.blob.core.windows.net/products/{ImageId}";
    }

}
