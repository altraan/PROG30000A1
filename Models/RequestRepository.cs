using System.Collections.Generic;
using Assign1PROG30000.Models.Repository;

namespace Assign1PROG30000.Models
{
    public class RequestRepository : IRequestRepository
    {
        private readonly List<EquipmentRequest> _requests = new List<EquipmentRequest>();
        private static int _nextId = 1; 

        public void Add(EquipmentRequest request)
        {
            request.Id = _nextId++;  
            _requests.Add(request);
        }

        public IEnumerable<EquipmentRequest> GetAll()
        {
            return _requests;
        }

        public IEnumerable<EquipmentRequest> GetPending()
        {
            return _requests.Where(r => r.Status == "Pending");
        }

        public void UpdateStatus(EquipmentRequest request)
        {
            _requests.Add(request);
        }

    }
}
