using System;
using System.Collections.Generic;

namespace PracticaPokemon
{
    public class PokemonTeam {
        HashSet<Pokemon> team = new HashSet<Pokemon>();

        //contructor vacio
        public PokemonTeam(Pokemon p1, Pokemon p2, Pokemon p3) {
            bool isDuplicated = false; 
            if(p1.id == p2.id) {
                //repetido
                isDuplicated = true;
            } else if (p2.id == p3.id) {
                isDuplicated = true;
            } else if(p1.id == p3.id) {
                isDuplicated = true;
            }

            if(isDuplicated) {
                System.Console.WriteLine("Equipo contiene jugadores duplicados");
            }

            team.Add(p1);
            team.Add(p2);
            team.Add(p3);
        }
    }
}