using StreetSizzle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreetSizzle.Modules.Interface
{
    public interface IContact
    {
        void addInquiry(ContactModel obj);
    }
}
