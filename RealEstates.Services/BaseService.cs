using AutoMapper;
using RealEstates.Services.Profiler;

namespace RealEstates.Services
{
    public abstract class BaseService
    {
        protected IMapper Mapper { get; private set; }
        public BaseService()
        {
            InitializeAutoMapper();
        }

        private void InitializeAutoMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<RealEstateProfiler>();
            });

            this.Mapper = config.CreateMapper();
        }
    }
}
