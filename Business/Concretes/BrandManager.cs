using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responces;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class BrandManager : IBrandService
{
    private readonly IBrandDal _brandDal;
    public BrandManager(IBrandDal brandDal)
    {
        _brandDal = brandDal;
    }
    public CreatedBrandResponse Add(CreateBrandRequest createBrandRequest)
    {
        //business rules
        // mapping-->automapper
        Brand brand = new();
        brand.Name = createBrandRequest.Name;
        brand.CreatedDate=DateTime.Now;

        _brandDal.Add(brand);
        
        //mapping
        CreatedBrandResponse createdBrandResponce = new CreatedBrandResponse();
        createdBrandResponce.CreatedDate = DateTime.Now;
        createdBrandResponce.Id = 4;
        createdBrandResponce.Name=createBrandRequest.Name;

        return createdBrandResponce;
    }

    public List<GetAllBrandResponse> GetAll()
    {
        List<Brand> brands = _brandDal.GetAll();

        List<GetAllBrandResponse> gelAllBrandResponces= new List<GetAllBrandResponse>();

        foreach(Brand brand in brands)
        {
            GetAllBrandResponse getAllBrandResponse = new GetAllBrandResponse();
            getAllBrandResponse.Id = brand.Id;
            getAllBrandResponse.Name = brand.Name;
            getAllBrandResponse.CreatedDate = DateTime.Now;
            gelAllBrandResponces.Add(getAllBrandResponse);
        }

        return gelAllBrandResponces;
    }
}
