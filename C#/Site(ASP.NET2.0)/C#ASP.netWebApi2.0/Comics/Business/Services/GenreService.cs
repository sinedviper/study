using System;
using System.Collections.Generic;
using System.Linq;
using Business.DTOs;
using Data;
using Models.Entities;

namespace Business.Services {
    //Здесь описываем уже все взаимодействия с категорией жанров, что бы можно было взаимодействовать с бд
    public class GenreService {
        public IEnumerable<GenreDto> GetAll(string title = null) {
            using (UnitOfWork unitOfWork = new UnitOfWork()) {
                var genres = unitOfWork.GenreRepository.GetAll();

                if (title != null) {
                    genres = unitOfWork.GenreRepository.GetAll(x => x.Title == title);
                }

                return genres.Select(genre => new GenreDto {
                    Id = genre.Id,
                    Title = genre.Title,
                    Rating = genre.Rating,
                    AvgSize = genre.AvgSize
                });
            }
        }

        public GenreDto GetById(int id) {
            using (UnitOfWork unitOfWork = new UnitOfWork()) {
                var genre = unitOfWork.GenreRepository.GetById(id);

                return genre == null ? null : new GenreDto {
                    Id = genre.Id,
                    Title = genre.Title,
                    Rating = genre.Rating,
                    AvgSize = genre.AvgSize
                };
            }
        }

        public bool Create(GenreDto genreDto) {
            using (UnitOfWork unitOfWork = new UnitOfWork()) {
                var genre = new Genre()
                {
                    Title = genreDto.Title,
                    Rating = genreDto.Rating,
                    AvgSize = genreDto.AvgSize,
                    CreatedOn = DateTime.Now
                };

                unitOfWork.GenreRepository.Create(genre);

                return unitOfWork.Save();
            }
        }

        public bool Update(GenreDto genreDto) {
            using (UnitOfWork unitOfWork = new UnitOfWork()) {
                var result = unitOfWork.GenreRepository.GetById(genreDto.Id);

                if (result == null) {
                    return false;
                }

                result.Title = genreDto.Title;
                result.Rating = genreDto.Rating;
                result.AvgSize = genreDto.AvgSize;
                result.UpdatedOn = DateTime.Now;

                unitOfWork.GenreRepository.Update(result);

                return unitOfWork.Save();
            }
        }

        public bool Delete(int id) {
            using (UnitOfWork unitOfWork = new UnitOfWork()) {
                Genre result = unitOfWork.GenreRepository.GetById(id);

                if (result == null) {
                    return false;
                }

                unitOfWork.GenreRepository.Delete(result);
                return unitOfWork.Save();
            }
        }
    }
}
