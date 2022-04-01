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
        public List<GetReiseZielDTO> GetAll()
        {
            var result = _repo.GetAll();
            var list = new List<GetReiseZielDTO>();
            foreach (var item in result)
            {
                list.Add(new GetReiseZielDTO()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Description = item.Description
                });
            }
            return list;
        }
        public GetReiseZielDTO GetById(int id)
        {
            var result = _repo.GetById(id);
            if (result != null)
            {
                return new GetReiseZielDTO()
                {
                    Id=result.Id,
                    Name=result.Name,
                    Description=result.Description
                };
            }
            return null;
        }
        public GetReiseZielDTO Create(PostReiseZielDTO postReiseDTO)
        {
            var result = _repo.Create(new ReiseZiel(postReiseDTO.Name, postReiseDTO.Description));
            return new GetReiseZielDTO()
            {
                Id = result.Id,
                Name = result.Name,
                Description = result.Description
            };
        }
        public void DeleteById(int id)
        {
            var result = _repo.GetById(id);
            if (result == null)
            {
                throw new Exception("Entity not found");
            }
            _repo.DeleteById(result);
        }
        public GetReiseZielDTO UpdateReiseZiel(int id, UpdateReiseZielDTO updateReiseZielDTO)
        {
            var getbyId = _repo.GetById(id);
            if (getbyId == null)
            {
                throw new Exception("ID was not found");
            }
            var result = _repo.Update(getbyId);
            return new GetReiseZielDTO()
            {
                Id = result.Id,
                Name = result.Name,
                Description = result.Description
            };
        }
    }
}
