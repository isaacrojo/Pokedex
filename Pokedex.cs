using System;
using System.Collections.Generic;


namespace PracticaPokemon
{
    class Pokedex {

       //HashSet = no se repiten
       HashSet<Pokemon> pokedexRegistry = new HashSet<Pokemon>();

        public Pokedex(){
            Pokemon chespin = new Pokemon("Chespin", 650);
            Pokemon charmeleon = new Pokemon("Charmeleon", 5);
            Pokemon squirtle = new Pokemon("Squirtle", 7);
            Pokemon beedrill = new Pokemon("Beedrill", 15);
            Pokemon rattata = new Pokemon("Rattata", 19);
            Pokemon pikachu = new Pokemon("Pikachu", 25);
            Pokemon vulpix = new Pokemon("Vulpix", 37);
            Pokemon diglett = new Pokemon("Diglett", 50);
            Pokemon Psyduck = new Pokemon("Psyduck", 54);
            Pokemon bellsprout = new Pokemon("Bellsprout", 69); 
           
           //este registro se pudo haber hecho con un foreach?
            pokedexRegistry.Add(chespin);
            pokedexRegistry.Add(pikachu);
            pokedexRegistry.Add(charmeleon);
            pokedexRegistry.Add(squirtle);
            pokedexRegistry.Add(beedrill);
            pokedexRegistry.Add(rattata);
            pokedexRegistry.Add(vulpix);
            pokedexRegistry.Add(diglett);
            pokedexRegistry.Add(Psyduck);
            pokedexRegistry.Add(bellsprout);
            
            
        }

        public Pokemon FindPokemonByName(string name) {

            foreach (var pokemon in pokedexRegistry)
            {
                if(name == pokemon.name) {
                    //Resultado de búsqueda encontrado!

                    //Devolver variable y finaliza método
                    return pokemon;
                }
            }

            //No se encontro un pokemon para esa busqueda
            return new Pokemon("MissingNo.", 0);
        }

        //duplicado, cambiando name por id
        public Pokemon FindPokemonById(int id) {

            
            foreach (var pokemon in pokedexRegistry)
            {
                if (id == pokemon.id) {
                    //Resultado de búsqueda encontrado!

                    //Devolver variable y finaliza método
                    return pokemon;
                }
            }

            //No se encontró un Pokemon para esa búsqueda
            return new Pokemon("MissingNo.", 0);
        }

        public void PrintPokedex() {
            System.Console.WriteLine("Pokedex Entries:");
            foreach (var pokemon in pokedexRegistry)
            {
                //pokemon
                System.Console.WriteLine(pokemon);
            }
        }

    }
}