using PetaPoco;
using System;

namespace PizzaShop.Repository.Entities
{
    [TableName("Persons")]
    [PrimaryKey("person_id")]
    public class Person
    {

        public int person_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public DateTime dob { get; set; }
        [ResultColumn]
        public string full_name { get; set; }
    }
}