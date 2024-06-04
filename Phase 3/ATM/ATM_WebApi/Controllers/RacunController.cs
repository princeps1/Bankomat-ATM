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


    [HttpPut]
    [Route("IzmeniRacun/{id}")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult ChangeRacun([FromBody] RacunView racun, int id)
    {
        try
        {
            if (id <= 0)
            {
                return BadRequest("Invalidan Id racuna.");
            }



            racun.SetRbr(id);
            int res = DataProvider.IzmeniRacun(racun);
            if (res == 0)
                return Ok("Uspesno ste izmenili racun!");
            else if (res == -1)
                return BadRequest("Pokusavate da promenite tip ili valutu gde to nije moguce");
            else
                return BadRequest("Ne postoji");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.ToString());
        }
    }


    [HttpPost]
    [Route("DodajRacun/{idBanke}/{idKlijenta}")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> AddRacun([FromBody] RacunView racun, int idBanke,int idKlijenta)
    {
        try
        {
            int res = await DataProvider.DodajRacun(racun, idBanke,idKlijenta);
            if (res == 0)
                return Ok("Uspesno ste dodali novi racun!");
            else
                return BadRequest("Ne postoji banka ili klijent sa navedenim ID-jem u bazi podataka");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.ToString());
        }
    }
}
