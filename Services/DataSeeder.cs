using dsd603Vm2025StudentVersion.Data;
using dsd603Vm2025StudentVersion.Models;

namespace dsd603Vm2025StudentVersion.Services
{
    /// <summary>
    ///     Provides functionality to seed initial data into the database.
    /// </summary>
    /// <remarks>This class is responsible for populating the database with predefined data if certain
    /// conditions are met, such as when specific tables are empty. It is typically used during application startup to
    /// ensure the database contains the necessary initial data for the application to function correctly.</remarks>
    public class DataSeeder : IDataSeeder
    {


        //Used DI to inject in the database context
        private readonly ApplicationDbContext _context;
        public DataSeeder(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }
        //https://medium.com/executeautomation/seeding-data-using-ef-core-in-asp-net-core-6-0-minimal-api-d5f6ecdb350c




        /// <summary>
        /// Seeds the database with initial data for the <see cref="StaffNames"/> table if it is empty.
        /// </summary>
        /// <remarks>This method checks whether the <see cref="StaffNames"/> table contains any records. 
        /// If the table is empty, it populates it with a predefined list of staff members and saves the changes to the
        /// database.</remarks>
        /// <returns>A task that represents the asynchronous operation.</returns>
        public async Task SeedAsync()
        {
            //if there are no fields in the StaffNames db
            if (!_context.StaffNames.Any())
            {
                var staff = new List<StaffNames>
                {
                    new StaffNames()
{Id = Guid.NewGuid(), Name = "Dwain Henson", Department ="Counselling", VisitorCount = 2},
                    new StaffNames()
{Id = Guid.NewGuid(), Name = "Ciara Head", Department ="Counselling", VisitorCount = 2},
                    new StaffNames()
{Id = Guid.NewGuid(), Name = "Dwain Henson", Department ="Web Design", VisitorCount = 2},
                    new StaffNames()
{Id = Guid.NewGuid(), Name = "Quentin Thwaite", Department ="NZ Bat", VisitorCount = 2},
                    new StaffNames()
{Id = Guid.NewGuid(), Name = "Madhav Benn", Department ="Web Design", VisitorCount = 2},
                    new StaffNames()
{Id = Guid.NewGuid(), Name = "Suniti Lood", Department ="Early Childhood", VisitorCount = 2},
                    new StaffNames()
{Id = Guid.NewGuid(), Name = "Susie Tyrrell", Department ="Early Childhood", VisitorCount = 2},
                    new StaffNames()
{Id = Guid.NewGuid(), Name = "Jie Roy", Department ="Web Design", VisitorCount = 2},
                    new StaffNames()
{Id = Guid.NewGuid(), Name = "Shobha Carpenter", Department ="Software", VisitorCount = 2},
                    new StaffNames()
{Id = Guid.NewGuid(), Name = "Merletta Winton", Department ="Ultimate", VisitorCount = 2}
                };
                _context.StaffNames.AddRange(staff);
                await _context.SaveChangesAsync();
            }
        }
    }

}

