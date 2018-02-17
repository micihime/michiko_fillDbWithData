using System.Data.Entity;
using Haiku.DataAccessLayer.Data;

namespace Haiku.DataAccessLayer.DBAccess
{
    /// <summary>
    /// haiku database context
    /// </summary>
    public class HaikuContext : DbContext
    {
        private static string connectionString = "";
        
        /// <summary>
        /// Initializes a new instance of the <see cref="HaikuContext"/> class.
        /// </summary>
        public HaikuContext() : base(connectionString)
        { }
        
        /// <summary>
        /// Gets or sets the models - represents the entity to query and save
        /// </summary>
        /// <value>
        /// The models.
        /// </value>
        public DbSet<HaikuModel> Models { get; set; }

        /// <summary>
        /// Gets or sets the words - represents the entity to query and save
        /// </summary>
        /// <value>
        /// The words.
        /// </value>
        public DbSet<HaikuWord> Words { get; set; }
    }
}
