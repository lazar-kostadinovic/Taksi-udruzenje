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
    public class VoziloTaksiSluzbeController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiVozilaTaksiSluzbe")]
        public IActionResult GetVozilaTaksiSluzbe()
        {
            try
            {
                return new JsonResult(DataProvider.vratiSvaVozilaTaksiSluzbe());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet]
        [Route("PreuzmiVoziloTaksiSluzbe/{id}")]
        public IActionResult GetVoziloTaksiSluzbe(int id)
        {
            try
            {
                return new JsonResult(DataProvider.vratiVoziloTaksiSluzbe(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajVoziloTaksiSluzbe")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddVoziloTaksiSluzbe([FromBody] VoziloTaksiSluzbeView p)
        {
            try
            {
                DataProvider.dodajVoziloTaksiSluzbe(p);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniVoziloTaksiSluzbe")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangeVoziloTaksiSluzbe([FromBody] VoziloTaksiSluzbeView p)
        {
            try
            {
                DataProvider.izmeniVoziloTaksiSluzbe(p);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiVoziloTaksiSluzbe/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteVoziloTaksiSluzbe(int id)
        {
            try
            {
                DataProvider.obrisiVoziloTaksiSluzbe(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
