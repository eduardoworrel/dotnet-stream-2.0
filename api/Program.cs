var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", async (HttpContext context) => {
    // paradigma sob demanda ou streaming de dados

        var array = new List<byte[]>();
        try
        {
            while (true)
            {
                array.Add(new byte[10 * 1024 * 1024]);
                var totalSizeMB = array.Count * 10;
                Console.WriteLine($"Current array size: {totalSizeMB} MB");
            }
        }
        catch (OutOfMemoryException ex)
        {
            var totalSizeMB = array.Count * 10;
            Console.WriteLine($"Current array size: {totalSizeMB} MB");
            throw;
        }
});

app.Run();
