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
    public class SopstvenoVoziloController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiSopstvenaVozila")]
        public IActionResult GetSopstvenaVozila()
        {
            try
            {
                return new JsonResult(DataProvider.vratiSvaSopstvenaVozila());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiSopstvenoVozilo/{id}")]
        public IActionResult GetSopstvenoVozila(int id)
        {
            try
            {
                return new JsonResult(DataProvider.vratiSopstvenoVozilo(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajSopstvenoVozilo")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddSopstvenoVozilo([FromBody] SopstvenoVoziloView p)
        {
            try
            {
                DataProvider.dodajSopstvenoVozilo(p);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniSopstvenoVozilo")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangeSopstvenoVozilo([FromBody] SopstvenoVoziloView p)
        {
            try
            {
                DataProvider.izmeniSopstvenoVozilo(p);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiSopstvenoVozilo/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteSopstvenoVozilo(int id)
        {
            try
            {
                DataProvider.obrisiSopstvenoVozilo(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
