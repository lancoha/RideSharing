using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RideSharing.Data;
using RideSharing.Models;

namespace RideSharing.Controllers_Api
{
    [Route("api/v1/RideRequest")]
    [ApiController]
    public class RideRequestApiController : ControllerBase
    {
        private readonly RideSharingContext _context;

        public RideRequestApiController(RideSharingContext context)
        {
            _context = context;
        }

        // GET: api/RideRequestApi
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RideRequest>>> GetRideRequests()
        {
            return await _context.RideRequests.ToListAsync();
        }

        // GET: api/RideRequestApi/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RideRequest>> GetRideRequest(int id)
        {
            var rideRequest = await _context.RideRequests.FindAsync(id);

            if (rideRequest == null)
            {
                return NotFound();
            }

            return rideRequest;
        }

        // PUT: api/RideRequestApi/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRideRequest(int id, RideRequest rideRequest)
        {
            if (id != rideRequest.Id)
            {
                return BadRequest();
            }

            _context.Entry(rideRequest).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RideRequestExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/RideRequestApi
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<RideRequest>> PostRideRequest(RideRequest rideRequest)
        {
            _context.RideRequests.Add(rideRequest);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRideRequest", new { id = rideRequest.Id }, rideRequest);
        }

        // DELETE: api/RideRequestApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRideRequest(int id)
        {
            var rideRequest = await _context.RideRequests.FindAsync(id);
            if (rideRequest == null)
            {
                return NotFound();
            }

            _context.RideRequests.Remove(rideRequest);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RideRequestExists(int id)
        {
            return _context.RideRequests.Any(e => e.Id == id);
        }
    }
}
