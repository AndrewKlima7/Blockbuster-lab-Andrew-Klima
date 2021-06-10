using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster_Lab_Andrew_Klima
{
    public class VHS : Movie
    {
        public int CurrentTime { get; set; } = 0;

        public VHS(string title, Genre category, int runtime, List<string> scenes) 
        {
            
        }
        public override void Play()
        {
            string scene = Scenes[CurrentTime];
            Console.WriteLine(scene);
            CurrentTime++;
        }

        public void Rewind()
        {
            CurrentTime = 0;
        }
    }
}
