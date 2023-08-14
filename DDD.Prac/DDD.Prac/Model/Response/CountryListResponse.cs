namespace DDD.Prac.Model.Response
{
    public class CountryLCountryistResponse
    {
        public IList<Country> Countries { get; set; }
    }

    public class Country 
    {
        public int Id { get;  set; }

        public string Country_Name { get;  set; }

        public string Country_code { get;  set; } 
    }
}
