using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DisplayNameAndNameAttributes
{
    public class Person
    {
        public Person()
        {
            FirstName = "Carl";
            LastName = "Johnson";
            Age = 30;
            Mobile = 91983467382;
            Email = "carljohnson@gta.com";
            ID = "0005A";
            DOB = new DateTime(1987, 10, 16);           
            Designation = "Team Lead";
        }
        
        [Display(Name = "Email ID")]
        public string Email
        {
            get;

            set;
        }

        [Display(Name = "First Name")]
        public string FirstName
        {
            get;

            set;
        }
        
        public string Designation
        {
            get;

            set;
        }


        [Display(Name = "Last Name")]
        public string LastName
        {
            get;

            set;
        }

        [DisplayNameAttribute("Employee ID")]
        public string ID
        {
            get;

            set;
        }


        [DisplayNameAttribute("Date of Birth")]
        public DateTime DOB
        {
            get;

            set;
        }


        [DisplayNameAttribute("Mobile Number")]
        public long Mobile
        {
            get;

            set;
        }

        public int Age
        {
            get;

            set;
        }        
    }
}
