using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLevel
{
    internal interface IRepository
    {
        bool CheckMail(string mail);
        void Add(string mail);
    }
}
