using System;
using System.Collections.Generic;
using System.Linq;
using Business.DTOs;
using Data;
using Models.Entities;

namespace Business.DTOs {
    //Здесь описываем уже все взаимодействия с категорией комиксов, что бы можно было взаимодействовать с бд
    public class ComicsService {
        public IEnumerable<ComicsDto> GetAll(string title = null) {
            using (UnitOfWork unitOfWork = new UnitOfWork()) {
                var comics = unitOfWork.ComicsRepository.GetAll();

                if (title != null) {
                    comics = unitOfWork.ComicsRepository.GetAll(x => x.Title == title);
                }

                var result = comics.Select(comics => new ComicsDto {
                    Id = comics.Id,
                    Title = comics.Title,
                    Price = comics.Price,
                    Genre = new GenreDto {
                        Id = comics.GenreId,
                        Title = comics.Genre.Title,
                        Rating = comics.Genre.Rating,
                        AvgSize = comics.Genre.AvgSize
                    },
                    Studio = new StudioDto {
                        Id = comics.StudioId,
                        Title = comics.Studio.Title,
                        Country = comics.Studio.Country,
                        Employees = comics.Studio.Employees,
                        Capitalization = comics.Studio.Capitalization,
                    }
                }).ToList();

                return result;
            }
        }

        public ComicsDto GetById(int id) {
            using (UnitOfWork unitOfWork = new UnitOfWork()) {
                var comics = unitOfWork.ComicsRepository.GetById(id);

                return comics == null ? null : new ComicsDto {
                    Id = comics.Id,
                    Title = comics.Title,
                    Price = comics.Price,
                    Genre = new GenreDto {
                        Id = comics.GenreId,
                        Title = comics.Genre.Title,
                        Rating = comics.Genre.Rating,
                        AvgSize = comics.Genre.AvgSize
                    },
                    Studio = new StudioDto {
                        Id = comics.StudioId,
                        Title = comics.Studio.Title,
                        Country = comics.Studio.Country,
                        Employees = comics.Studio.Employees,
                        Capitalization = comics.Studio.Capitalization,
                    }
                };
            }
        }

        public bool Create(ComicsDto comicsDto) {
            using (UnitOfWork unitOfWork = new UnitOfWork()) {
                var comics = new Comics() {
                    Price = comicsDto.Price,
                    GenreId = comicsDto.GenreId,
                    StudioId = comicsDto.StudioId,
                    Title = comicsDto.Title,
                    CreatedOn = DateTime.Now
                };

                unitOfWork.ComicsRepository.Create(comics);

                return unitOfWork.Save();
            }
        }

        public bool Update(ComicsDto comicsDto) {
            using (UnitOfWork unitOfWork = new UnitOfWork()) {
                var result = unitOfWork.ComicsRepository.GetById(comicsDto.Id);

                if (result == null) {
                    return false;
                }

                result.Price = comicsDto.Price;
                result.GenreId = comicsDto.GenreId;
                result.StudioId = comicsDto.StudioId;
                result.Title = comicsDto.Title;
                result.UpdatedOn = DateTime.Now;

                unitOfWork.ComicsRepository.Update(result);

                return unitOfWork.Save();
            }
        }

        public bool Delete(int id) {
            using (UnitOfWork unitOfWork = new UnitOfWork()) {
                Comics result = unitOfWork.ComicsRepository.GetById(id);

                if (result == null) {
                    return false;
                }

                unitOfWork.ComicsRepository.Delete(result);

                return unitOfWork.Save();
            }
        }
    }
}
