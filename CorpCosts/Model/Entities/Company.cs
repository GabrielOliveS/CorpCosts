namespace CorpCosts.Model.Entities
{
    public class Company : BaseEntity
    {
        public string? RazaoSocial { get; set ;}
        public string? Cnpj { get; set;}
        public string? NomeFantasia { get; set;}
    }
}
