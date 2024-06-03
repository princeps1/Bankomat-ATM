using DatabaseAccess;
using DatabaseAccess.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace ATM_WebApi.Controllers;


[ApiController]
[Route("[controller]")]
public class ServisController : ControllerBase
{
    [HttpGet]
    [Route("PreuzmiSveServiseBankomata")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult GetServisiBankomata(int idBankomata)
    {
        try
        {
            return new JsonResult(DataProvider.VratiSveServiseOdBankomata(idBankomata));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

}
