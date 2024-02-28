using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        IBrandService _brandservice;

        public BrandsController(IBrandService brandservice)
        {
            _brandservice = brandservice;
        }

        [HttpPost]
        public IActionResult Add(CreateBrandRequest createBrandRequest)
        {
            CreatedBrandResponse createdBrandResponse=_brandservice.Add(createBrandRequest);

            return Ok(createdBrandResponse);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_brandservice.GetAll());
        }
    }
}
