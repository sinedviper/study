using System;
using Models.Entities;

namespace Data {
    //для получения значений бд
    public class UnitOfWork : IDisposable {
        private readonly ComicsDbContext dbContext;
        private BaseRepository<Comics> comicsRepository;
        private BaseRepository<Studio> studioRepository;
        private BaseRepository<Genre> genresRepository;
        private bool disposed = false;

        public UnitOfWork() {
            this.dbContext = new ComicsDbContext();
        }

        public BaseRepository<Comics> ComicsRepository {
            get {
                if (this.comicsRepository == null) {
                    this.comicsRepository = new BaseRepository<Comics>(dbContext);
                }

                return comicsRepository;
            }
        }

        public BaseRepository<Studio> StudioRepository {
            get {
                if (this.studioRepository == null) {
                    this.studioRepository = new BaseRepository<Studio>(dbContext);
                }

                return studioRepository;
            }
        }

        public BaseRepository<Genre> GenreRepository {
            get {
                if (this.genresRepository == null) {
                    this.genresRepository = new BaseRepository<Genre>(dbContext);
                }

                return genresRepository;
            }
        }

        public bool Save() {
            try {
                dbContext.SaveChanges();
                return true;
            } catch {
                return false;
            }
        }

        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing) {
            if (!this.disposed) {
                if (disposing) {
                    dbContext.Dispose();
                }

                disposed = true;
            }
        }
    }
}
