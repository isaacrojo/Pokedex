using System;
using System.Collections.Generic;


namespace PracticaPokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokedex pokedex = new Pokedex();

            //Generar Party de 6 Pokemoncon List = puede repetir
            List<PokemonInParty> party = new List<PokemonInParty>();


            //Consultar Pokemon por nombre
            Pokemon pikachu = pokedex.FindPokemonByName("Pikachu");
            Pokemon notExistantPokemon = pokedex.FindPokemonByName("Agumon");

            System.Console.WriteLine(pikachu);
            System.Console.WriteLine(notExistantPokemon);
            
            PokemonInParty Psyduck = new PokemonInParty(Psyduck, Gender.MALE);
            PokemonInParty charmeleon = new PokemonInParty(charmeleon, Gender.FEMALE);
            PokemonInParty squirtle = new PokemonInParty(squirtle, Gender.FEMALE);
            PokemonInParty beedrill = new PokemonInParty(beedrill, Gender.MALE);
            PokemonInParty rattata = new PokemonInParty(rattata, Gender.FEMALE);
            PokemonInParty pikachu = new PokemonInParty(pikachu, Gender.MALE);

            party.Add(Psyduck);
            

            System.Console.WriteLine(party.Count);

            //print party6
            foreach (var pokemon in party)
            {
                System.Console.WriteLine(pokemon);
            }

            //print pokedex
            pokedex.PrintPokedex();

            PokemonTeam team = new PokemonTeam(Psyduck, squirtle, pikachu);

        }
    }
}
