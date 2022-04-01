using Reiseziele;
using ReiseZiele.Infrastructure;

namespace ReiseZiele
{
    public class ReiseZielRepo
    {
        //private List<ReiseZiel> _reiseList;
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
        public List<ReiseZiel> GetAll()
        {
            return context.ReiseZiele.ToList();
        }
        public ReiseZiel GetById(int id)
        {
            var result = context.ReiseZiele.Find(id);
            //if (result != null)
            //{
            //    return new GetReiseZielDTO(result.Id, result.Name, result.Description);
            //}
            //return null;
            return result;
        }
        public ReiseZiel Create(ReiseZiel postReiseZiel)
        {
            ReiseZiel reiseZiel = new ReiseZiel(postReiseZiel.Name, postReiseZiel.Description);
            //_reiseList.Add(reiseZiel);
            //return new PostReiseZielDTO(reiseZiel.Name, reiseZiel.Description);
            var entityEntry = context.ReiseZiele.Add(reiseZiel);
            context.SaveChanges();
            return entityEntry.Entity;
        }
        public void DeleteById(ReiseZiel reiseZiel)
        {
            //var result = context.ReiseZiele.Find(id); //(_reiseList.Find(x => x.Id == id));
            //if (result != null)
            //{
            //    //_reiseList.Remove(result);
            //    context.ReiseZiele.Remove(result);
            //    context.SaveChanges();
            //}
            //throw new Exception("ID was not found");
            context.ReiseZiele.Remove(reiseZiel);
            context.SaveChanges();
        }
        public ReiseZiel Update(ReiseZiel reiseZiel)
        {
            //var result = context.ReiseZiele.Find(id); //_reiseList.Find(x => x.Id == id);

            //if(result != null)
            //{
            //    result.Name = updateReiseZielDTO.Name;
            //    result.Description = updateReiseZielDTO.Description;
            //    //context.ReiseZiele.Update(updateReiseZielDTO);
            //    context.SaveChanges();
            //    return new UpdateReiseZielDTO(result.Id, result.Name, result.Description);
            //}
            var result = context.ReiseZiele.Update(reiseZiel);
            context.SaveChanges();
            return result.Entity;
        }
    }
}
