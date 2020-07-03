using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ConnectFrontToBack.Helpers
{
    public class CustomIdentityErrors:IdentityErrorDescriber
    {
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError { 
                Code = nameof(PasswordRequiresNonAlphanumeric), 
                Description = "Используйте какие-то символы." 
            };
        }
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError
            {
                Code = nameof(PasswordTooShort),
                Description = $"Длина пароля должно составлять минимум из {length} символов."
            };
        }
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresUpper),
                Description ="Парольдолжен содержать заглавные буквы от A-Z."
            };
        }
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresUpper),
                Description = "Парольдолжен содержать строчные буквы от a-z."
            };
        }
    }
}
