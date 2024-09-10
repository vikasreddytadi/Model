using System;
using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using model.Models;
using model.Data;
using Microsoft.Extensions.Configuration;

namespace model
{
    public class System
    {
        // When we create a property, it will automatically create a private field like _processor
        static void Main(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appSettings.json")
                .Build();

            // DapperMapper dapper = new DapperMapper();

            // DateTime result = dapper.SingleRow<DateTime>(@"Select GETDATE()");

            // Console.WriteLine(result);

            //To Insert into table

            // int final = dapper.ExecuteQuery(@"insert into dateEntries values('2023-12-31')");

            // Console.WriteLine(final); //returns number of rows effected



            // IEnumerable<num> finalFectch = dapper.MultiRow<num>(@"Select * from num");

            // foreach (num mynum in finalFectch)
            // {
            //     Console.WriteLine(mynum.id + " , " + mynum.name);
            // }

            EntityFramework ef = new EntityFramework(config);

            num nums = new num() { name = "b" };

            ef.Add(nums);
            ef.SaveChanges();

            IEnumerable<num>? num1 = ef.num?.ToList<num>();
            foreach (num SingleNum in num1)
            {
                Console.WriteLine(SingleNum.name);
            }

            Computer myComputer = new Computer() { Processor = "Intel I7", Ram = 8 };
            // Console.WriteLine(myComputer.Processor);
        }
    }
}
