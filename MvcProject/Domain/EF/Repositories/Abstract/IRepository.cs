namespace Domain.EF.Repositories.Abstract
{
    public interface IRepository
    {
        void Delete(int id);
        void Save(); 
    }
}