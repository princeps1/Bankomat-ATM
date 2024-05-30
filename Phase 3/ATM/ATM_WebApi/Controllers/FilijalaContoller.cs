using DatabaseAccess;
using DatabaseAccess.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace ATM_WebApi.Controllers;


[ApiController]
[Route("[controller]")]
public class FilijalaConroller : ControllerBase
{
    [HttpGet]
    [Route("PreuzmiFilijale")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult GetFilijale()
    {
        try
        {
            return new JsonResult(DataProvider.VratiSveFilijale());
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

}
