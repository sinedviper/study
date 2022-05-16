using System;
using System.Collections.Generic;
using System.Linq;
using Business.DTOs;
using Data;
using Models.Entities;

namespace Business.Services {
    //Здесь описываем уже все взаимодействия с категорией студии, что бы можно было взаимодействовать с бд
    public class StudioService {
        public IEnumerable<StudioDto> GetAll(string title = null) {
            using (UnitOfWork unitOfWork = new UnitOfWork()) {
                var studios = unitOfWork.StudioRepository.GetAll(); ;

                if (title != null) {
                    studios = unitOfWork.StudioRepository.GetAll(x => x.Title == title);
                }

                return studios.Select(studio => new StudioDto {
                    Id = studio.Id,
                    Title = studio.Title,
                    Country = studio.Country,
                    Employees = studio.Employees,
                    Capitalization = studio.Capitalization,
                });
            }
        }

        public StudioDto GetById(int id) {
            using (UnitOfWork unitOfWork = new UnitOfWork()) {
                var studio = unitOfWork.StudioRepository.GetById(id);

                return studio == null ? null : new StudioDto {
                    Id = studio.Id,
                    Title = studio.Title,
                    Country = studio.Country,
                    Employees = studio.Employees,
                    Capitalization = studio.Capitalization,
                };
            }
        }

        public bool Create(StudioDto studioDto) {
            using (UnitOfWork unitOfWork = new UnitOfWork()) {
                var studio = new Studio() {
                    Title = studioDto.Title,
                    Country = studioDto.Country,
                    Employees = studioDto.Employees,
                    Capitalization = studioDto.Capitalization,
                    CreatedOn = DateTime.Now
                };

                unitOfWork.StudioRepository.Create(studio);

                return unitOfWork.Save();
            }
        }

        public bool Update(StudioDto studioDto) {
            using (UnitOfWork unitOfWork = new UnitOfWork()) {
                var result = unitOfWork.StudioRepository.GetById(studioDto.Id);

                if (result == null) {
                    return false;
                }

                result.Title = studioDto.Title;
                result.Country = studioDto.Country;
                result.Employees = studioDto.Employees;
                result.Capitalization = studioDto.Capitalization;
                result.UpdatedOn = DateTime.Now;

                unitOfWork.StudioRepository.Update(result);

                return unitOfWork.Save();
            }
        }

        public bool Delete(int id) {
            using (UnitOfWork unitOfWork = new UnitOfWork()) {
                Studio result = unitOfWork.StudioRepository.GetById(id);

                if (result == null) {
                    return false;
                }

                unitOfWork.StudioRepository.Delete(result);
                return unitOfWork.Save();
            }
        }
    }
}
