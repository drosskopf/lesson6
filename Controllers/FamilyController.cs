using Microsoft.Extensions.Options;

namespace webapp{
    public class FamilyController{
        private IOptions<Family> _family {get;set;}

        public FamilyController(IOptions<Family> family){
                _family=family;
        }
        public Family Get(){
             return _family.Value;
        }
        public Family Error(){
            throw new System.Exception("Doh");
        }
    }
}