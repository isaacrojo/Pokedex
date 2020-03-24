using System;

namespace PracticaPokemon
{
    public class Pokemon
    {
        public string name;
        public int id;        

        public Pokemon(string name, int id) {
            this.name = name;
            this.id = id;
        }

        //sobreescribir el metodo ToString para que los pokemon se impriman correctamente
        public override string ToString() {
            //return this.name;
            
            return $"No. {this.id} - {this.name}";
        }
    }
}