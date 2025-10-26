using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanGameProject
{
    public interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}