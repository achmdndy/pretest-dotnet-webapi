using Microsoft.AspNetCore.Mvc;
using LockerFloorFinder.Helpers;
using LockerFloorFinder.Services;

namespace LockerFloorFinder.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LockerController : ControllerBase
    {
        [HttpGet("{lockerNumber}")]
        public IActionResult GetFloor(int lockerNumber)
        {
            if (lockerNumber < 1)
            {
                var errorResponse = ResponseHelper.CreateResponse(
                    status: "Error",
                    message: "Nomor loker harus lebih besar dari 0.",
                    error: "InvalidLockerNumber",
                    data: (int?)null
                );
                return BadRequest(errorResponse);
            }

            int floor = LockerService.GetFloor(lockerNumber);
            var successResponse = ResponseHelper.CreateResponse(
                status: "Success",
                message: "Nomor lantai berhasil ditemukan.",
                error: null,
                data: floor
            );
            return Ok(successResponse);
        }
    }
}
