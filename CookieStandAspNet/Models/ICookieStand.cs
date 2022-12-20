using CookieStandAspNet.Models;

namespace CookieStandAspNet.Models
{
    public interface ICookieStand
    {
        //Create
        Task<CookieStand> Create(CookieStand cookieStand);

        //Get All
        Task<List<CookieStand>> GetCookieStands();

        //Get by Id
        Task<CookieStand> GetCookieStand(int id);

        //Update
        Task<CookieStand> UpdateCookieStand(int id, CookieStand cookieStand);
        //Delete
        Task Delete(int id);
    }
}
