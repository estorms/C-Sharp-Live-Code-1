using System;

namespace ConsoleApplication

{
        public class Payment {
        
        public decimal Amount{get;set;}

//virtual = CAN BE OVERRIDDEN by derived classes later
//void/string/etc specifies return type for method
    public virtual string MakePayment() {
        //hit the payment processing API

        return $"You paid ${this.Amount} in Cash ";
    }

    }
}