﻿namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// The players unique identification.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The players first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The players last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The players email address.
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// The players cell phone number.
        /// </summary>
        public string CellphoneNumber { get; set; }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

    }
}