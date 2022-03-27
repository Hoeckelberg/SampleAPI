using Reiseziele;
using ReiseZiele.Infrastructure;

namespace ReiseZiele
{
    public class ReiseZielRepo
    {
        private List<ReiseZiel> _reiseList;
        private readonly DataContext context;

        public ReiseZielRepo(DataContext context)
        {
            this.context = context;
            //_reiseList = new List<ReiseZiel>()
            //{
            //    new ReiseZiel("Test", "ABC"),
            //    new ReiseZiel("ADAD", "AAXAX"),
            //    new ReiseZiel("Test2", "........")
            //};
        }
        public List<GetReiseZielDTO> GetAll()
        {
            //List<GetReiseZielDTO> _reiseListDTO = new(); // shortcut -> List<GetReiseZielDTO>();
            //foreach (ReiseZiel item in _reiseList)
            //{
            //    _reiseListDTO.Add(new GetReiseZielDTO(item.Id, item.Name, item.Description));
            //}

            throw new NotImplementedException(); // return _reiseListDTO;
        }
        public GetReiseZielDTO GetById(int id)
        {
            var result = _reiseList.Find(x => x.Id == id);
            if (result != null)
            {
                return new GetReiseZielDTO(result.Id, result.Name, result.Description);
            }

            return null;
        }
        public PostReiseZielDTO Create(PostReiseZielDTO postReiseZielDTO)
        {
            ReiseZiel reiseZiel = new ReiseZiel(postReiseZielDTO.Name, postReiseZielDTO.Description);
            _reiseList.Add(reiseZiel);
            return new PostReiseZielDTO(reiseZiel.Name, reiseZiel.Description);
        }
        public void DeleteById(int id)
        {
            var result = context.ReiseZiele.Find(x => x.Id == id); //(_reiseList.Find(x => x.Id == id));
            if (result != null)
            {
                _reiseList.Remove(result);
            }
            context.ReiseZiele.Remove(result);
        }
        public UpdateReiseZielDTO Update(int id, UpdateReiseZielDTO updateReiseZielDTO)
        {
            var result = _reiseList.Find(x => x.Id == id);

            if(result != null)
            {
                result.Name = updateReiseZielDTO.Name;
                result.Description = updateReiseZielDTO.Description;

                return new UpdateReiseZielDTO(result.Id, result.Name, result.Description);
            }
            return null;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
