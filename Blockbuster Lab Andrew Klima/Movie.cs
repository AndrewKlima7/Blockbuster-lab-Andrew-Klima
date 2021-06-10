using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster_Lab_Andrew_Klima
{
    public enum Genre
    {
        Drama,
        Comedy,
        Horror,
        Romance,
        Action
    }
    public abstract class Movie
    {
        public string Title { get; set; }
        public Genre Category { get; set; }
        public int Runtime { get; set; }
        public List<string> Scenes { get; set; }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Title: {Title} Genre: {Category} Runtime: {Runtime}");
        }

        public void PrintScenes()
        {
            Console.WriteLine("Scenes: ");
            for (int i = 0; i < Scenes.Count; i++)
            {
                String scene = Scenes[i];
                string movScene = scene.ToString();
                Console.WriteLine($"{i} : {movScene}");

                //or this?
                    /* Console.WriteLine("Scenes: " );
                    foreach(string scene in Scenes)
                    {
                            Console.WriteLine(scene);
                    }*/
            }
        }

        public abstract void Play();

        
    }
}
