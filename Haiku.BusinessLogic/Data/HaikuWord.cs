using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Haiku.DataAccessLayer.Data
{
    /// <summary>
    /// Class that represents haiku-specific word
    /// </summary>
    [Table("HaikuWords")]
    public class HaikuWord
    {
        #region Fields
        
        private int id;

        private string wordString;

        private string partOfSpeech;
        private Int16 numberOfSyllables;
        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [Key]
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// The word
        /// </summary>
        public string WordString
        {
            get { return wordString; }
            set { wordString = value; }
        }

        /// <summary>
        /// The part of speech
        /// </summary>
        public string WordPartOfSpeech
        {
            get { return partOfSpeech; }
            set { partOfSpeech = value; }
        }

        /// <summary>
        /// The syllable count
        /// </summary>
        public Int16 NumberOfSyllables
        {
            get { return numberOfSyllables; }
            set { numberOfSyllables = value; }
        }
        #endregion
    }
}