using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using MyAdultList.Data;

namespace MyAdultListServerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdultController:ControllerBase
    {
        private IFileReader fileReader ;

        public AdultController(IFileReader fileReader) {
            this.fileReader = fileReader;
        }

        [HttpGet]
        public async Task<ActionResult<IList<Adult>>> GetAdults() {
           
            try {
                IList<Adult> adults = fileReader.GetAdults();
                return Ok(JsonSerializer.Serialize(adults));
            } 
            catch (Exception e) 
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}