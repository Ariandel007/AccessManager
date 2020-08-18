using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AccessManager.Dtos
{
    public class UserCreateDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "Deberias especificar una contraseña entre 4 y 8 caracteres")]
        public string Password { get; set; }

        public string State { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }


        public UserCreateDto()
        {
            this.State = "Active";
            this.Created = DateTime.Now;
            this.Updated = DateTime.Now;
        }
    }
}
