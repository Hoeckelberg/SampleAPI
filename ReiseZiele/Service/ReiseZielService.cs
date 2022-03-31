using Reiseziele;

namespace ReiseZiele.Service
{
    public class ReiseZielService
    {
        private readonly ReiseZielRepo _repo;
        public ReiseZielService(ReiseZielRepo repo)
        {
            _repo = repo;
        }
        public IEnumerable<GetReiseZielDTO> GetAll()
        {
            var result = _repo.GetAll();
            return (IEnumerable<GetReiseZielDTO>)result;
        }
        public GetReiseZielDTO GetById(int id)
        {
            var result = _repo.GetById(id);
            if (result != null)
            {
                return new GetReiseZielDTO(result.Id, result.Name, result.Description);
            }
            return null;
        }
        public PostReiseZielDTO Create(ReiseZiel postReise)
        {
            //var result = _repo.Create(postReise);
            return new PostReiseZielDTO(postReise.Name, postReise.Description);
        }
        public GetReiseZielDTO DeleteById(int id)
        {
            var result = "test";//_repo.DeleteById(id);
            if (result != null)
            {

            }
            throw new NotImplementedException();
        }
    }
}
