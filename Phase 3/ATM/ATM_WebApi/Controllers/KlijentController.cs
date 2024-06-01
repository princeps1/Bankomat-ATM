using DatabaseAccess;
using DatabaseAccess.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace ATM_WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class KlijentController : ControllerBase
{
    [HttpGet]
    [Route("PreuzmiKlijente")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult GetBanke()
    {
        try
        {
            return new JsonResult(DataProvider.VratiSveKlijente());
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete]
    [Route("IzbrisiKlijenta/{id}")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult DeleteBanku(int id)
    {
        try
        {
            int res = DataProvider.IzbrisiKlijenta(id);//
            if (res == 0)
                return BadRequest("Klijent sa ovim id-jem ne postoji!\n");
            else
                return Ok($"Uspesno obrisan klijenta sa id-jem {id}");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.ToString());
        }
    }
}
