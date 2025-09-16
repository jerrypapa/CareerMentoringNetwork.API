
using CareerMentoringNetwork.API.Models;

namespace CareerMentoringNetwork.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            Student student = new Student();

            
            student.FirstName = "John"; //using the getter property
            student.LastName = "Doe";

            Console.WriteLine(student.Fullname); //using the getter property


         //  Student.CreateStudent()

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
