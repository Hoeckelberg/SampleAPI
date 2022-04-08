using ReiseZiele.Model;
using ReiseZiele.Repo;

namespace ReiseZiele.Service
{
    public class PilotService
    {
        private readonly PilotRepository _pilotRepository;

        public PilotService(PilotRepository pilotRepository)
        {
            _pilotRepository = pilotRepository;
        }

        public Pilot GetPilotById(int id)
        {
            return _pilotRepository.GetById(id);
        }
    }
}
