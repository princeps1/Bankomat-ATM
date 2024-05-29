using DatabaseAccess;
using Microsoft.AspNetCore.Mvc;

namespace ATM_WebApi.Controllers;


[ApiController]
[Route("[controller]")]
public class BankaConroller : ControllerBase
{
    [HttpGet]
    [Route("PreuzmiBanke")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult GetBanke()
    {
        try 
        {
            return new JsonResult(DataProvider.VratiSveBanke());
        }
        catch (Exception ex) 
        {
            return BadRequest(ex.Message);
        }
    }
}
