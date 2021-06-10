using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster_Lab_Andrew_Klima
{
    public class DVD : Movie
    { 
        public DVD(string title, Genre category, int runtime, List<string> scenes) 
        {

        }
        public override void Play()
        {
            Console.WriteLine("What scene would you like to watch?");
            PrintScenes();
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Scenes[num]);
        }

    }
}
