using LombaStore.Domain.StoreContext.ValueObjects;
using System;

namespace LombaStore.Domain.StoreContext.Entities
{

   public class Customer
   {
        public Customer(
         Name name,
         string document,
         string email,
         string phone,
         string address )
      {
         Name = name;
         Document = document;
         Email = email;
         Phone = phone;
         Address = address; 
         
      }


      public Name Name  { get; private set; }
      public string Document { get; private set; }

      public string Email { get; private set; }

      public string Phone { get; private set; }

      public string Address { get; private set; }

      public override string ToString()
      {
         return Name.ToString();
      }
    
   }

}






