namespace Homework8;

class Program
{
    static void Main(string[] args)
    {// Please use following code to create Customer objects and customer_list
    Customer cus1 = new Customer(customerName:"Alice", customerAge:33, customerCity:"Amarillo", customerCredit:198.5);
    Customer cus2 = new Customer(customerName:"Bob", customerAge:23, customerCity:"Amarillo", customerCredit:226);
    Customer cus3 = new Customer(customerName:"Cathy", customerAge:45, customerCity:"Amarillo", customerCredit:89.0);
    Customer cus4 = new Customer(customerName:"David", customerAge:58, customerCity:"Amarillo", customerCredit:198.5);
    Customer cus5 = new Customer(customerName:"Jack", customerAge:28, customerCity:"Canyon", customerCredit:561.6);
    Customer cus6 = new Customer(customerName:"Tom", customerAge:36, customerCity:"Canyon", customerCredit:98.4);
    Customer cus7 = new Customer(customerName:"Tony", customerAge:24, customerCity:"Canyon", customerCredit:18.5);
    Customer cus8 = new Customer(customerName:"Sam", customerAge:35, customerCity:"Canyon", customerCredit:228.3);

     Customer[] customer_list = {cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8};
     
     //Q1
     TotalCredits(customer_list);

     //Q2
     AmarilloAverageAge(customer_list);

     //Q3
     CanyonAge(customer_list);

        
    }

    public static void TotalCredits(Customer[] customer_list)
    {
        double totalCredits = 0;
        foreach(Customer customerName in customer_list)
        {
            totalCredits += customerName.customerCredit;
        }

        Console.WriteLine("Q1: The total credits: {0}", totalCredits);
    }

    public static void AmarilloAverageAge(Customer [] customer_list)
    {
        double totalAge = 0; 
        int countCustomer = 0;
        foreach(var customerName in customer_list)
        {
            totalAge += customerName.customerAge;
            countCustomer++;
        }
        if (countCustomer > 0)
        {
            double averageAge = totalAge / countCustomer;
            Console.WriteLine("Q2: the average age of customer in Amarillo are: {0}", averageAge);
        }
    }

    public static void CanyonAge(Customer[] customer_list)
    {
       int count = 0;
       string [] Customer_name = new string [5] ;  

        foreach (Customer customerName in customer_list)
        {
            if (customerName.customerAge > 30)
            {
                Console.WriteLine("Q3: Customers who live in Canyon and over 30 years old: {0}", customerName.customerName);
            }
        
        }
        
        
    }


}

//Q0
class Customer{
    
        public string customerName {get;set;} = string.Empty;
        public int customerAge {get;set;} = 0;
        public string customerCity {get;set;} = string.Empty;
        public double customerCredit {get;set;} = 0;
    
    
    public Customer(string customerName, int customerAge, string customerCity, double customerCredit)
    {
        this.customerName = customerName;
        this.customerAge = customerAge;
        this.customerCity = customerCity;
        this.customerCredit = customerCredit;
    }
    }
