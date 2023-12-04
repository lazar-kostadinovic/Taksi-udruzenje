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
    public class MusterijaController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiMusterije")]
        public IActionResult GetMusterije()
        {
            try
            {
                return new JsonResult(DataProvider.vratiSveMusterije());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiMusteriju/{id}")]
        public IActionResult GetMusterija(int id)
        {
            try
            {
                return new JsonResult(DataProvider.vratiMusteriju(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajMusteriju")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddMusterija([FromBody] MusterijaView p)
        {
            try
            {
                DataProvider.dodajMusteriju(p);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniMusteriju")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangeMusterija([FromBody] MusterijaView p)
        {
            try
            {
                DataProvider.azurirajMusteriju(p);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiMusteriju/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteMusterija(int id)
        {
            try
            {
                DataProvider.obrisiMusteriju(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
