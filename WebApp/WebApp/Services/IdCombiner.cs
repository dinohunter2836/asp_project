using WebApp.Models;

namespace WebApp.Services
{
    public class IdCombiner
    {
        public string CombineIds(string id1, string id2)
        {
            if (id1.CompareTo(id2) > 0)
            {
                return id1 + "_" + id2;
            }
            else
            {
                return id2 + "_" + id1;
            }
        }

        public string SplitIds(string combinedIds, AppUser sender)
        {
            string[] ids = combinedIds.Split('_');
            if (ids[0] == sender.Id)
            {
                return ids[1];
            }
            else
            {
                return ids[0];
            }
        }
    }
}
