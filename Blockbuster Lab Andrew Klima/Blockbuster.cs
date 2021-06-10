using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster_Lab_Andrew_Klima
{
    class Blockbuster : Movie
    {

        public List<Movie> movies { get; set; } = new List<Movie>();
        public Blockbuster()
        {
            List<string> chuckyScenes = new List<string>() { "scene1", "scene2", "scene3" };
            List<string> bttfScenes = new List<string>() { "scene1", "scene2", "scene3" };
            List<string> mommaScenes = new List<string>() { "scene1", "scene2", "scene3" };
            List<string> spiritedScenes = new List<string>() { "scene1", "scene2", "scene3" };
            List<string> FridayScenes = new List<string>() { "scene1", "scene2", "scene3" };
            List<string> starWarsScenes = new List<string>() { "scene1", "scene2", "scene3" };

            VHS v1 = new VHS("Chucky", Genre.Horror, 120, chuckyScenes);
            VHS v2 = new VHS("Back to the Future", Genre.Action, 115, bttfScenes);
            VHS v3 = new VHS("Momma Mia", Genre.Drama, 115, mommaScenes);
            DVD d1 = new DVD("Spirited Away", Genre.Drama, 125, spiritedScenes);
            DVD d2 = new DVD("Friday the 13th", Genre.Horror, 98, FridayScenes);
            DVD d3 = new DVD("Star Wars", Genre.Action, 136, starWarsScenes);

            movies.Add(v1);
            movies.Add(v2);
            movies.Add(v3);
            movies.Add(d1);
            movies.Add(d2);
            movies.Add(d3);
        }
        public override void Play()
        {
            throw new NotImplementedException(); //this appeared beacuse i made this a child of abstract movie
        }
        public void PrintMovies()
        {
            for (int i = 0; i < movies.Count; i++)
            {
                Movie move = movies[i];
                string mov = move.ToString(); //for some reason its returning "Blockbuster" rather than the movie in movies[i]
                Console.WriteLine($"{i} : {mov[i]}"); //can't get mov[i] to show the name of the movie!!
            }
        }

        public Movie CheckOut()
        {
            PrintMovies();
            Console.WriteLine("Please select a movie 0-5");
            int num = int.Parse(Console.ReadLine());
            PrintInfo(); //this doesnt work as it doesnt take in the index from the user, dont know how to do that
            return movies[num]; //cant use printinfo since it is not a child so made it a child
        }
    } }
       
    
     


