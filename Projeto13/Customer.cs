using System.Dynamic;

namespace Projeto13;
class Customer
{
    //properties
    public string Name{get; set;}
    public string Adress{get; set;}
    public string ContactNumber{get; set;} //CADA PROPERTY PODE SER UMA COLUNA NA NOSSA base de dados

    //custom constructor
    public Customer(string name, string adress, string contactNumber)
    {
        Name=name;
        Adress=adress;
        ContactNumber=contactNumber;

    }

    public Customer(string name)
    {
        Name=name;
    }
}