using Reiseziele;

namespace ReiseZiele.Infrastructure
{
    public interface IReiseZiel
    {
        List<GetReiseZielDTO> GetAll();
        GetReiseZielDTO GetById(int id);
        PostReiseZielDTO Create(PostReiseZielDTO dTO);
        UpdateReiseZielDTO Update(int id, UpdateReiseZielDTO dTO);
        void DeleteById(int id);
        void Save();
    }
}
