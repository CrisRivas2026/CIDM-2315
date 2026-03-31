namespace Homework8;

class Program
{
    static void Main(string[] args)
    {
         // Please use following code to create Customer objects and customer_list
    Customer cus1 = new Customer(customerName:"Alice", customerAge:33, customerCity:"Amarillo", customerCredit:198.5);
    Customer cus2 = new Customer(customerName:"Bob", customerAge:23, customerCity:"Amarillo", customerCredit:226);
    Customer cus3 = new Customer(customerName:"Cathy", customerAge:45, customerCity:"Amarillo", customerCredit:89.0);
    Customer cus4 = new Customer(customerName:"David", customerAge:58, customerCity:"Amarillo", customerCredit:198.5);
    Customer cus5 = new Customer(customerName:"Jack", customerAge:28, customerCity:"Canyon", customerCredit:561.6);
    Customer cus6 = new Customer(customerName:"Tom", customerAge:36, customerCity:"Canyon", customerCredit:98.4);
    Customer cus7 = new Customer(customerName:"Tony", customerAge:24, customerCity:"Canyon", customerCredit:18.5);
    Customer cus8 = new Customer(customerName:"Sam", customerAge:35, customerCity:"Canyon", customerCredit:228.3);

    Customer[] customer_list = {cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8};  
    }

}


class Customer
    {
        public string Customername = string.Empty;
        public int Customerage = 0;
        public string Customercity = string.Empty;
        public double Customercredit = 0;
    }
    
    public Customer(string customerName, int customerAge, string customerCity, double customerCredit)
    {
        Customername = customerName;
        Customerage = customerAge;
        Customercity = customerCity;
        Customercredit = customerCredit;
    }