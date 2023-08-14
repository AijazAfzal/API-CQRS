namespace DDD.Prac.Model.Response
{
    public class CapitalListResponse
    {
        public IList<Capital> Capitals { get; set; }    
    }

    public class Capital
    {
        public int Id { get;  set; }

        public string Name { get;  set; }

        public  int Country_Id { get; set; } 
    }
}
