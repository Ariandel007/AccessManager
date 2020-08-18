using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AccessManager.Dtos
{
    public class UserUpdateDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string State { get; set; }

        public DateTime Updated { get; set; }

        public UserUpdateDto()
        {
            this.Updated = DateTime.Now;
        }

    }
}
