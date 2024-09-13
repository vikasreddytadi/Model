using System;
using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;
using model.Models;
using model.Data;
using Microsoft.Extensions.Configuration;
using System.Text.Json;
using AutoMapper;
using AutoMapper.Execution;

namespace model
{
    public class System
    {
        // When we create a property, it will automatically create a private field like _processor
        public async static Task asyncFunction(int delay, string name){
                Console.WriteLine(name + "started");
                await Task.Delay(delay);
                Console.WriteLine(name + "completed");
            }
        static async Task Main(string[] args)
        {
            // IConfiguration config = new ConfigurationBuilder()
            //     .AddJsonFile("appSettings.json")
            //     .Build();

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

            // EntityFramework ef = new EntityFramework(config);

            // num nums = new num() { name = "b" };

            // ef.Add(nums);
            // ef.SaveChanges();

            // IEnumerable<num>? num1 = ef.num?.ToList<num>();
            // foreach (num SingleNum in num1)
            // {
            //     Console.WriteLine(SingleNum.name);
            // }

            // Computer myComputer = new Computer() { Processor = "Intel I7", Ram = 8 };
            // Console.WriteLine(myComputer.Processor);

            // string tempJson = File.ReadAllText("temp.json");

            // Console.WriteLine(tempJson);

            // JsonSerializerOptions options = new JsonSerializerOptions()
            // {
            //     PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            // };

            // IEnumerable<numDto>? loadData = JsonSerializer.Deserialize<IEnumerable<numDto>>(
            //     tempJson,
            //     options
            // );

            // We need to set up mapper configuration
            // var config1 = new MapperConfiguration(
            //     (cfg) =>
            //     {
            //         cfg.CreateMap<numDto, num>()
            //             .ForMember(dest => dest.name, opt => opt.MapFrom(src => src.name));
            //     }
            // );

            // create mapper with above config
            // IMapper mapper = config1.CreateMapper();

            // here we will map two objects
            // IEnumerable<num> mappedData = mapper.Map<IEnumerable<num>>(loadData);

            // foreach (num mynum in mappedData)
            // {
            //     Console.WriteLine(mynum.name);
            // }

            // if (loadData != null)
            // {
            //     foreach (num nums in loadData)
            //     {
            //         // Console.WriteLine("insert into num values(" + nums.name + ")");
            //         dapper.ExecuteQuery(@"insert into num values('" + nums.name + "')");
            //     }
            // }

            // string serializedJson = JsonSerializer.Serialize(loadData,options);

            // File.WriteAllText("serializedJson.txt",serializedJson);

            // ---------- Async and Await ---------------
            Task task1 = asyncFunction(100,"task1");
            Task task2 = asyncFunction(300,"task2");
            Task task3 = asyncFunction(50,"task3");
            Task task4 = asyncFunction(50,"task4");

            await task1;
            await task2;
            await task3;
            await task4;            
        }
    }
}
