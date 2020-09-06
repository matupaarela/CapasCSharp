using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contracts
{
    public interface IGenericRepository<Entity> where Entity:class
    {
        int Insert(Entity entity);
        int Update(Entity entity);
        int Destroy(int id);
        IEnumerable<Entity> All();
    }
}
