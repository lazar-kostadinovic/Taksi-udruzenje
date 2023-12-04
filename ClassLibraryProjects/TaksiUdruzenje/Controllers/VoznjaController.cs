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
    public class VoznjeController : ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiVoznje")]
        public IActionResult GetVoznje()
        {
            try
            {
                return new JsonResult(DataProvider.vratiSveVoznje());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet]
        [Route("PreuzmiVoznju/{id}")]
        public IActionResult GetVoznju(int id)
        {
            try
            {
                return new JsonResult(DataProvider.VratiVoznju(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiSveVoznjeVozaca/{jmbg}")]
        public IActionResult GetSveVoznjeVozaca(long jmbg)
        {
            try
            {
                return new JsonResult(DataProvider.vratiSveVoznjeVozaca(jmbg));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet]
        [Route("PreuzmiSveVoznjeAdmOsoblja/{jmbg}")]
        public IActionResult GetSveVoznjeAdmOsoblja(long jmbg)
        {
            try
            {
                return new JsonResult(DataProvider.vratiSveVoznjeAdmOsoblja(jmbg));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        [HttpGet]
        [Route("PreuzmiSveVoznjeMusterije/{id}")]
        public IActionResult GetSveVoznjeMusterije(int id)
        {
            try
            {
                return new JsonResult(DataProvider.vratiSveVoznjeMusterije(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajVoznju")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddVoznja([FromBody] VoznjaView p)
        {
            try
            {
                DataProvider.dodajVoznju(p);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniVoznju")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangeVoznja([FromBody] VoznjaView p)
        {
            try
            {
                DataProvider.izmeniVoznju(p);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("IzbrisiVoznju/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteVoznju(int id)
        {
            try
            {
                DataProvider.obrisiVoznju(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
