using DatabaseAccess;
using DatabaseAccess.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace ATM_WebApi.Controllers;


[ApiController]
[Route("[controller]")]
public class FilijalaController : ControllerBase
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

    [HttpGet]
    [Route("PreuzmiFilijaleOdBanke/{bankaId}")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult GetFilijaleBanke(int bankaId)
    {
        try
        {
            return new JsonResult(DataProvider.VratiSveFilijaleOdBanke(bankaId));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet]
    [Route("PreuzmiFilijalu/{rbr}")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult GetFilijala(int rbr)
    {
        try
        {
            return new JsonResult(DataProvider.VratiFilijalu(rbr));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }


    [HttpPost]
    [Route("DodajFilijalu/{idBanke}")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<IActionResult> AddFilijala([FromBody] FilijalaView filijala, int idBanke)
    {
        try
        {
            await DataProvider.DodajFilijalu(filijala, idBanke);
            return Ok("Uspesno ste dodali novu filijalu!");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.ToString());
        }
    }

    //NE RADI
    [HttpPut]
    [Route("IzmeniFilijalu/{rbr}")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult ChangeFilijalu([FromBody] FilijalaView filijala, int rbr)
    {
        try
        {
            if (rbr <= 0)
            {
                return BadRequest("Invalidan Redni Broj filijale.");
            }

            filijala.SetRbr(rbr); // Ensure the ID from the route is set in the BankaView object
            DataProvider.IzmeniFilijalu(filijala);
            return Ok("Uspesno ste izmenili filijalu!");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.ToString());
        }
    }


    [HttpDelete]
    [Route("IzbrisiFilijalu/{redni_broj}")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public IActionResult DeleteFilijalu(int redni_broj)
    {
        try
        {
            DataProvider.IzbrisiFilijalu(redni_broj);//
            return Ok("Uspesno ste izbrisali filijalu!");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.ToString());
        }
    }



}
