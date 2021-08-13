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
    public class TibbiBirimController : ControllerBase
    {
        ITibbiBirimService _birimService;

        public TibbiBirimController(ITibbiBirimService birimService)
        {
            _birimService = birimService;
        }

        [HttpPost("add")]
        public IActionResult Add(TibbiBirim birim)
        {

            var result = _birimService.Add(birim);
            var a = result;
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]

        public IActionResult Update(TibbiBirim birim)
        {
            var result = _birimService.Update(birim);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]

        public IActionResult Delete(TibbiBirim birim)
        {
            var result = _birimService.Delete(birim);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]

        public IActionResult Get()
        {


            var result = _birimService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbyıd")]

        public IActionResult GetById(int id)
        {
            var result = _birimService.GetByID(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }

}
