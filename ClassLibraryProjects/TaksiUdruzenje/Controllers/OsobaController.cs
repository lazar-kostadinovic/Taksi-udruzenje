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
    public class OsobaController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiOsobe")]
        public IActionResult GetOsobe()
        {
            try
            {
                return new JsonResult(DataProvider.vratiSveOsobe());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiOsobu/{jmbg}")]
        public IActionResult GetOsobu(long jmbg)
        {
            try
            {
                return new JsonResult(DataProvider.vratiOsobu(jmbg));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajOsobu")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddOsoba([FromBody] OsobaView p)
        {
            try
            {
                DataProvider.dodajOsobu(p);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniOsobu")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangeOsoba([FromBody] OsobaView p)
        {
            try
            {
                DataProvider.azurirajOsobu(p);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiOsobu/{jmbg}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteOsoba(long jmbg)
        {
            try
            {
                DataProvider.obrisiOsobu(jmbg);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
