using System;

namespace OOPDZexe4
{
    class Cars
    {
        public string name { get; set; }
        public string type { get; set; }
        public int  year { get; set; }  
        public string country { get; set; }
             public Cars(string name, string type, int year, string country)

        {
            this.name = name;
            this.type = type;
            this.year=year;
            this.country=country;
        }
                public void informate()
        {
            Console.WriteLine($" NameOfcars:{name}, TypeofCars:{type}, Firstyearcars:{year}, Countryofcar:{country}");    
        }
        static void Main(string[] args)
        {
            
        }  
    }
}

