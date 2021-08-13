using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoktorsController : ControllerBase
    {
        IDoktorService _doktorService;

        public DoktorsController(IDoktorService doktorService)
        {
            _doktorService = doktorService;
        }


        [HttpGet("getall")]

        public IActionResult GetAll()
        {


            var result = _doktorService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbyıd")]

        public IActionResult GetById(int id)
        {
            var result = _doktorService.GetByID(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbybirim")]

        public IActionResult GetByBirim(int birimId)
        {
            var result = _doktorService.GetAllByTibbiBirimId(birimId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Doktor doktor)
        {

            var result = _doktorService.Add(doktor);
            var a = result;
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]

        public IActionResult Update(Doktor doktor)
        {
            var result = _doktorService.Update(doktor);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]

        public IActionResult Delete(Doktor doktor)
        {
            var result = _doktorService.Delete(doktor);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getdoktordetails")]
        public IActionResult GetDoktorDetails()
        {
            var result = _doktorService.GetDoktorDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getdoktordetailsbyId")]
        public IActionResult GetDoktorDetailsById(int doktorId)
        {
            var result = _doktorService.GetDoktorDetailsById(doktorId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }

}
