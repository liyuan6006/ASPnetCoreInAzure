using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AspnetCoreinAzure.Models;
using Microsoft.Extensions.Configuration;

namespace AspnetCoreinAzure.Controllers
{
    [Produces("application/json")]
    [Route("api/AddressLabels")]
    public class AddressLabelsController : Controller
    {

        IConfiguration _configuration;

        public AddressLabelsController(IConfiguration configuration)
        {
            _configuration = configuration;
           
        }
        // GET: api/AddressLabels
        [HttpGet]
        public IEnumerable<AddressLabel> Get()
        {

            DataLayerClasses.DataLayer dataLayer = new DataLayerClasses.DataLayer(_configuration);
            return dataLayer.getAddressLable(0);


           // return new AddressLabel[] { addressLabel1};
        }

        // GET: api/AddressLabels/5
        [HttpGet("{id}", Name = "GetAddresLabel")]
        public AddressLabel Get(int id)
        {
            AddressLabel addressLabel1 = new AddressLabel(1, "title1", "Tom", "", "");
            return addressLabel1;
        }
        
        // POST: api/AddressLabels
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/AddressLabels/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
