using Microsoft.EntityFrameworkCore;
using CookieStandAspNet.Data;
using CookieStandAspNet.Models;

namespace CookieStandAspNet.Models
{
    public class CookieStandService : ICookieStand
    {
        private CookieStandDbContext _context;

        public CookieStandService(CookieStandDbContext cookieStandDbContext)
        {
            _context = cookieStandDbContext;
        }

        public async Task<CookieStand> Create(CookieStand cookieStand)
        {
            _context.Entry(cookieStand).State = EntityState.Added;

            await _context.SaveChangesAsync();

            return cookieStand;
        }

        public async Task<List<CookieStand>> GetCookieStands()
        {
            var cookieStand = await _context.CookieStand.ToListAsync();
            return cookieStand;
        }

        public async Task<CookieStand> GetCookieStand(int id)
        {
            CookieStand cookieStand = await _context.CookieStand.FindAsync(id);
            return cookieStand;
        }

        public async Task<CookieStand> UpdateCookieStand(int id, CookieStand cookieStand)
        {
            _context.Entry(cookieStand).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return cookieStand;
        }

        public async Task Delete(int id)
        {
            CookieStand cookieStand = await GetCookieStand(id);
            _context.Entry(cookieStand).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }
    }
}
