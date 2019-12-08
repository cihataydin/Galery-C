﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaleryApp.Core.DomainClasses
{
    public class User : BaseEntity
    {
        public User()
        {
            Photos = new List<Photo>();
        }
        [Required(ErrorMessage ="bu alan gerekli")]
        public string Password { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }
    }
}
