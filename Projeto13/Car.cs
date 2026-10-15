namespace Projeto13
{
    //It's internal, which means that it can only be accessed from within the same assembly
    internal class Car
    {
        //member variable is a field inside this class
        private string _model = ""; //private hides the variable from other classes 
        private string _brand = "";

        private bool _isLuxury; //is it a luxury car?

        //property - Servem para permitir o acesso controlado a uma variável privada da classe.

        //get returns the value of the variable and set gets a value and keeps it on the variable
        public string Model{get=>_model;set=>_model=value;} //se quiseres fazer sem o field e só com a property, neste caso, dá. public string Model{get;set;}
        public string Brand{
            get
            {
                if(_isLuxury) //se quisessemos a property sem o backing field aqui estaria a property (IsLuxury)
                return _brand+" - Luxury Edition";

                else
                return _brand;
            }
        
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    System.Console.WriteLine("You entered NOTHING!");
                    _brand="DEFAULTVALUE";
                }
                else //if you didn't give an empty string I am going to assign that value to our string
                {
                    _brand=value;
                }
                
                //_brand=value;} //se quiseres mudar o valor tens de seguir esta lógica que eu estabeleci dentro de {}
            }
        }
        public bool IsLuxury{get=>_isLuxury;set=>_isLuxury=value;}


        //constuctor
        public Car(string model, string brand, bool isLuxury)
        {
            Model = model;
            Brand = brand;
            IsLuxury = isLuxury;
            System.Console.WriteLine( _brand + " of the model " + _model + " has been created!"); //bran or _brand works the same
        }
    }
}