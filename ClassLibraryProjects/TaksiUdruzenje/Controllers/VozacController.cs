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
    public class VozacController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiVozace")]
        public IActionResult GetVozace()
        {
            try
            {
                return new JsonResult(DataProvider.vratiSveVozace());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiVozaca/{id}")]
        public IActionResult GetVozaca(int id)
        {
            try
            {
                return new JsonResult(DataProvider.vratiVozaca(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajVozaca")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddVozac([FromBody] VozacView p)
        {
            try
            {
                DataProvider.dodajVozaca(p);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniVozaca")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangeVozac([FromBody] VozacView p)
        {
            try
            {
                DataProvider.azurirajVozaca(p);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiVozaca/{jmbg}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteVozac(long jmbg)
        {
            try
            {
                DataProvider.obrisiVozaca(jmbg);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
