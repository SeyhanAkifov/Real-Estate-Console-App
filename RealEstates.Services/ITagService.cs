namespace RealEstates.Services
{
    public interface ITagService
    {

        public void Add(string name, int? importance = null);


        void BulkTagToProperties();
    }
}
