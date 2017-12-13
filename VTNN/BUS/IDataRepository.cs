using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public interface IDataRepository<T>
    {
        T Get_By_ID(Int64 p_iAutoID);
        IList<T> Get_List_All();
        Int64 Insert(T Entity);
        void Updated(T Entity);
        void Deleted(Int64 p_iAutoID, string p_strLast_Updated_By);
    }
}
