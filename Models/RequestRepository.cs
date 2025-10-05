using System.Collections.Generic;

namespace Assign1PROG30000.Models
{
    public static class RequestRepository
    {
        private static List<EquipmentRequest> _requests = new List<EquipmentRequest>();

        public static void Add(EquipmentRequest request)
        {
            _requests.Add(request);
        }

        public static IEnumerable<EquipmentRequest> GetAll()
        {
            return _requests;
        }
    }
}
