using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TrackingApi.Data;
using TrackingApi.Models;

namespace TrackingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IssueController : ControllerBase
    {
        private readonly IssueDbContext _context;
        public IssueController(IssueDbContext context) => _context = context;


        [HttpGet]
        public async Task<IEnumerable<Issue>> GetIssues()
        {
            return await _context.Issues.ToListAsync();
        }

        [HttpDelete("{issueId}")]
        public async Task<IActionResult> DeleteIssueById(int issueId)
        {
            var issue = await _context.Issues.FirstOrDefaultAsync(x => x.Id == issueId);

            if (issue == null)
            {
                return BadRequest();
            }

            _context.Issues.Remove(issue);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
