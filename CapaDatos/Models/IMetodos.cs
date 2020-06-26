using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Models
{
    interface IMetodos
    {
        void Insert();
        void Update(int id);
        void Delete(int id);

        DataTable Select();
    }
}
