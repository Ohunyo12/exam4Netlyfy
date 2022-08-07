namespace smartwallet1.web.Data.Entities
{
    public abstract class BaseEntity<Tkey>
    {
        public Tkey Id { get; set; }  
    }
}
