using System.Linq;
using Haiku.DataAccessLayer.Data;

namespace Haiku.DataAccessLayer.DBAccess
{
    /// <summary>
    /// class that accesses Haiku database
    /// </summary>
    public static class HaikuDBAccess
    {
        /// <summary>
        /// The database
        /// </summary>
        private static HaikuContext db = new HaikuContext();


        /// <summary>
        /// Saves the haiku.
        /// </summary>
        /// <param name="haikuWord">The haiku word.</param>
        public static void SaveHaikuWord(HaikuWord haikuWord)
        {
            db.Words.Add(haikuWord);
            db.SaveChanges();
        }

        /// <summary>
        /// Determines whether [is already in database] [the specified word].
        /// </summary>
        /// <param name="word">The word.</param>
        /// <returns>
        ///   <c>true</c> if [is already in database] [the specified word]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsAlreadyInDatabase(string word)
        {
            var result = from wordDBTable in db.Words
                        where wordDBTable.WordString == word
                        select wordDBTable;
            return (result.SingleOrDefault() == null) ? false : true;
        }

        /// <summary>
        /// Saves the haiku word.
        /// </summary>
        /// <param name="haikuWord">The haiku word.</param>
        public static void SaveHaikuModel(HaikuModel haikuModel)
        {
            db.Models.Add(haikuModel);
            db.SaveChanges();
        }
    }
}