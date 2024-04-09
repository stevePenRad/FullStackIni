using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistance;

namespace API.Controllers
{
    public class SectionsController : BaseApiController
    {
        private readonly DataContext _context;
        public SectionsController(DataContext context)
        {
            _context = context;            
        }

        [HttpGet] //api/sections
        public async Task<ActionResult<List<Section>>> GetSections()
        {
            return await _context.Sections.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Section>> GetSection(int id)
        {
            return await _context.Sections.FindAsync(id);
        }
    }
}