using System.Security.Cryptography.X509Certificates;

namespace Projeto21
{
    internal class Program
    {

        static void Main(string[] args)
        {
            BaseClass baseClass = new();
            DerivedClass derivedClass = new();

            baseClass.ShowFields(); //precisas de um objeto para usar o método

            derivedClass.Access();
            derivedClass.ShowFields();

        }
    }

    class BaseClass
    {
        //access modifiers
        public int publicField;
        protected int protectedField;
        private int privateField;

        public void ShowFields()
        {
            Console.WriteLine($"Public: {publicField}, Protected: {protectedField}, Private: {privateField}");
        }
    }

    class DerivedClass : BaseClass
    {
        public void Access()
        {
            publicField = 1;
            protectedField = 2; //accessible only for the class or derived classes
            // privateField = 3; ERRO! you can not override a private field outside its classe
        }

    }
}
