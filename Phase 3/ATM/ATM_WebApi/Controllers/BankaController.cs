using DatabaseAccess;
using DatabaseAccess.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace ATM_WebApi.Controllers;


[ApiController]
[Route("[controller]")]
public class BankaController : ControllerBase
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

    [HttpGet]
    [Route("PreuzmiBanku/{id}")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult GetBank(int id)
    {
        try
        {
            return new JsonResult(DataProvider.VratiBanku(id));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost]
    [Route("DodajBanku")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult AddBanka([FromBody]BankaView banka)
    {
        try
        {
            DataProvider.DodajBanku(banka);
            return Ok("Uspesno ste dodali novu banku!");

        }
        catch(Exception ex)
        {
            return BadRequest(ex.ToString());
        }
    }

    [HttpPut]
    [Route("IzmeniBanku/{id}")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult ChangeBanku([FromBody]BankaView banka, int id)
    {
        try
        {
            if (id <= 0)
            {
                return BadRequest("Invalid bank ID.");
            }

            banka.SetId(id); // Ensure the ID from the route is set in the BankaView object
            DataProvider.IzmeniBanku(banka);
            return Ok("Uspesno ste izmenili banku!");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.ToString());
        }
    }

    [HttpDelete]
    [Route("IzbrisiBanku/{id}")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult DeleteBanku(int id)
    {
        try
        {
            DataProvider.IzbrisiBanku(id); 
            return Ok("Uspesno ste izbrisali banku!");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.ToString());
        }
    }
}
