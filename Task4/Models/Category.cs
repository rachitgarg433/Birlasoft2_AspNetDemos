﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Task4.Areas.Models
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }
        [Display(Name = "Name of the Category")]
        [Required(ErrorMessage = "{0} cannot be empty.")]
        [StringLength(60, ErrorMessage = "{0} cannot have more than {1} characters.")]
        public string CategoryName { get; set; }


        #region Navigation Properties to the Transaction Model - Book

        public ICollection<Book> Books { get; set; }

        #endregion

    }
}


/*********************************************
        CREATE TABLE [Categories]
        (
	        [CategoryId] int NOT NULL IDENTITY(1,1)
	        , [CategoryName] varchar(60) NOT NULL
	        , CONSTRAINT [PK_Categoryies] PRIMARY KEY ( [CategoryId] ASC )
        )
        GO
**********/