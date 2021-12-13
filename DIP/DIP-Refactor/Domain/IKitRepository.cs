using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Refactor.Domain
{
    interface IKitRepository
    {
        bool SaveKit(Kit kit);

        List<Kit> ListKits();
    }
}
