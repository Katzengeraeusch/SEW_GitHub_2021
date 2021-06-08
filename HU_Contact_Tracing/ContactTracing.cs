using System;
using System.Collections.Generic;
using System.Text;

namespace HU_Contact_Tracing
{
    class ContactTracing
    {
        private int personCount;
        private string firstName;
        private string lastName;

        public ContactTracing()
        {

        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                this.lastName = value;
            }
        }

        public int PersonCount 
        {
            get
            {
                return this.personCount;
            }

            set
            {
                this.personCount = value;
            }
        }

        public void addPerson()
        {
            this.personCount++;
        }
    }
}
