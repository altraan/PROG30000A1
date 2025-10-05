using System.Collections.Generic;

namespace Assign1PROG30000.Models
{
    public static class RequestRepository
    {
        private static List<EquipmentRequest> _requests = new List<EquipmentRequest>();
        private static int _nextId = 1; 

        public static void Add(EquipmentRequest request)
        {
            request.Id = _nextId++;  
            _requests.Add(request);
        }

        public static IEnumerable<EquipmentRequest> GetAll()
        {
            return _requests;
        }
    }
}
