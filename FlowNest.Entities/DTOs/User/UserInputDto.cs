using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowNest.Entities.DTOs.User
{
    public  class UserInputDto
    {
        [MinLength(5)]
        [MaxLength(30)]
        public required string UserName { get; set; } = "";

        [MinLength(6)]
        public required string Password { get; set; } = "";

        [MinLength(5)]
        public required string FirstName { get; set; } = "";

        [MinLength(5)]
        public required string LastName { get; set; } = "";
    }
}
