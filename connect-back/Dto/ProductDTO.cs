namespace connect_back.Dto{
    //DTO del producto- en este caso es igual a la entidad
    //pero dependiendo del caso podria cambiar mas.
    public class ProductDTO{
        public int ProductId {get;set;}
        public string Code {get;set;}
        public string Name {get;set;}
        public string Description {get;set;}
        public float Price{get;set;}
    }
}