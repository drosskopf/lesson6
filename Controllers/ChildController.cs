using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
namespace webapp{
    [Route("/api/child")]
    public class ChildController:Controller{
        private static IList<Child> _children {get;set;}
        public ChildController(){
            _children = new List<Child>(){
                new Child(1,"Alex",15),
                new Child(2,"Brad",11),
                new Child(3,"Summer",10),
                new Child(4,"Jeremy",7)
            };
        }
        [HttpGet()]
        public IEnumerable<Child> Get(){
            return _children;
        }
        [HttpGet("{id:int}")]
        public Child Get(int id){

            return _children.Where(c=>c.Id ==id).First();
        }
        [HttpPost()]
        public IActionResult Create([FromBody] Child child){
            if(!ModelState.IsValid){
                return BadRequest(ModelState);
            }
            var nextId = _children.Max(c=>c.Id)+1;
            child.Id = nextId;
           _children.Add(child);
           return CreatedAtAction("Get",new {id=child.Id},child);
        }
    }
}

