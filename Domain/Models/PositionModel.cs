using System;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Contracts;
using Common.Entities;
using DataAccess.Repositories;
using Domain.ValueObjects;

namespace Domain.Models
{
    public class PositionModel
    {
        private string CodeModel;
        private string NameModel;
        private string DescriptionModel;

        private IPositionRepository positionRepository;
        public EntityState EState { private get; set; }

        private List<PositionModel> listPositions;

        //PROPIEDADES/MODELO DE VISTA/ VALIDACIONES
        public string Code { get => CodeModel; set => CodeModel = value; }
        public string Name { get => NameModel; set => NameModel = value; }
        public string Description { get => DescriptionModel; set => DescriptionModel = value; }
        

        public PositionModel()
        {
            positionRepository = new PositionRepository();
        }

        public List<PositionModel> All()
        {
            var positionDataModel = positionRepository.All();
            listPositions = new List<PositionModel>();
            foreach(Position position in positionDataModel)
            {
                listPositions.Add(new PositionModel {
                    Code = position.Code,
                    Name = position.Name,
                    Description = position.Description,
                });
            }
            return listPositions;
        }

    }
}
