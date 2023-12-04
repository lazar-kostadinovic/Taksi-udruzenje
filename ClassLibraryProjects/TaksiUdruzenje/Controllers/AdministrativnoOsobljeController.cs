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
    public class AdministrativnoOsobljeController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiAdministrativnoOsoblje")]
        public IActionResult GetAdministrativnoOsoblje()
        {
            try
            {
                return new JsonResult(DataProvider.vratiSvoAdministrativnoOsoblje());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiAdministrativnuOsobu/{jmbg}")]
        public IActionResult GetAdministrativnuOsobu(long jmbg)
        {
            try
            {
                return new JsonResult(DataProvider.vratiAdministrativnoOsoblje(jmbg));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajAdministrativnoOsoblje")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddAdministrativnoOsoblje([FromBody] AdministrativnoOsobljeView p)
        {
            try
            {
                DataProvider.dodajAdministrativnoOsoblje(p);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniAdministrativnoOsoblje")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangeAdministrativnoOsoblje([FromBody] AdministrativnoOsobljeView p)
        {
            try
            {
                DataProvider.azurirajAdministrativnoOsoblje(p);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiAdministrativnoOsoblje/{jmbg}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteAdministrativnoOsoblje(long jmbg)
        {
            try
            {
                DataProvider.obrisiAdministrativnoOsoblje(jmbg);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
