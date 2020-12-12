using System;
using System.Collections.Generic;
using DataAccess.Contracts;
using Common.Entities;
using System.Data;

namespace DataAccess.Repositories
{
    public class PositionRepository : MasterRepository, IPositionRepository
    {
        //Campos
        private string TSAll;
        //Prpiedades

        //Constructores
        public PositionRepository()
        {
            TSAll = "sfe_position_all";
        }

        //Métodos o COmportamiento del Objeto
        public IEnumerable<Position> All()
        {
            var TableResult = ExecuteReader(TSAll);
            var ListPosition = new List<Position>();
            foreach(DataRow Row in TableResult.Rows)
            {
                ListPosition.Add(new Position {
                    Code = Convert.ToString(Row["code"]),
                    Name = Convert.ToString(Row["name"]),
                    Description = Convert.ToString(Row["description"]),
                });
            }
            return ListPosition;
        }

        public int Insert(Position employee)
        {
            throw new NotImplementedException();
        }

        public int Update(Position employee)
        {
            throw new NotImplementedException();
        }

        public int Destroy(int id)
        {
            throw new NotFiniteNumberException();
        }

        public int Destroy(string code)
        {
            throw new NotImplementedException();
        }
    }
}
