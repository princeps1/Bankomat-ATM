using DatabaseAccess;
using DatabaseAccess.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace ATM_WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class RacunController : ControllerBase
{
    [HttpGet]
    [Route("PreuzmiRacune")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult GetRacune()
    {
        try
        {
            return new JsonResult(DataProvider.VratiSveRacune());
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet]
    [Route("PreuzmiRacuneOdBanke/{bankaId}")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult GetRacuneBanke(int bankaId)
    {
        try
        {
            return new JsonResult(DataProvider.VratiSveRacuneOdBanke(bankaId));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet]
    [Route("PreuzmiRacun/{id}")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult GetRacun(int id)
    {
        try
        {
            return new JsonResult(DataProvider.VratiRacun(id));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }


    [HttpDelete]
    [Route("IzbrisiRacun/{id}")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult DeleteRacun(int id)
    {
        try
        {
            int res = DataProvider.IzbrisiRacun(id);//
            if (res == 0)
                return BadRequest("Racun sa ovim id-jem ne postoji!\n");
            else
                return Ok($"Uspesno obrisan racun sa id-jem {id}");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.ToString());
        }
    }


    //[HttpPut]
    //[Route("IzmeniRacun/{id}")]
    //[ProducesResponseType(StatusCodes.Status400BadRequest)]
    //[ProducesResponseType(StatusCodes.Status200OK)]
    //public IActionResult ChangeFilijalu([FromBody] RacunView racun, int id)
    //{
    //    try
    //    {
    //        if (id <= 0)
    //        {
    //            return BadRequest("Invalidan Redni Broj racuna.");
    //        }

    //        racun.SetRbr(id); // Ensure the ID from the route is set in the BankaView object
    //        DataProvider.IzmeniRacun(racun);
    //        return Ok("Uspesno ste izmenili racun!");
    //    }
    //    catch (Exception ex)
    //    {
    //        return BadRequest(ex.ToString());
    //    }
    //}
}
