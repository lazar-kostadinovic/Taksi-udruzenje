using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TaksiUdruzenjeLibrary;
using TaksiUdruzenjeLibrary.DTOs;


namespace TaksiUdruzenje.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class KoristiController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiKoristi")]
        public IActionResult GetKoristi()
        {
            try
            {
                return new JsonResult(DataProvider.vratiSveKoristi());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiSvaVozilaKoriscenaOdVozaca/{jmbg}")]
        public IActionResult GetSvaVozilaKoristi(long jmbg)
        {
            try
            {
                return new JsonResult(DataProvider.vratiSvaVozilaKojaJeKoristioVozac(jmbg));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet]
        [Route("PreuzmiSveVozaceKojiSuKoristiliVozilo/{id}")]
        public IActionResult GetSvaVozilaKoristi(int id)
        {
            try
            {
                return new JsonResult(DataProvider.vratiSveVozaceKojiSuKoristiliVozilo(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajKoristi")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddKoristi([FromBody] KoristiView p)
        {
            try
            {
                DataProvider.dodajKoristi(p);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniKoristi")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangeKoristi([FromBody] KoristiView p)
        {
            try
            {
                DataProvider.azurirajKoristi(p);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiKoristi/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteKoristi(int id)
        {
            try
            {
                DataProvider.obrisiKoristi(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
