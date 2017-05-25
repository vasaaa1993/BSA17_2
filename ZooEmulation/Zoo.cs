using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ZooEmulation
{
    class Zoo
    {
		// commands
		// add, (kind of animal, Alias)
		// feed (alias)
		// treat (alias)
		// delete (alias)
		// show (-all/alias)
        private List<Animal> _aAnimals; 
        public Zoo()
        {
		    Timer timer;
            SetTimer(out timer);

            Loop();
			Console.WriteLine("Closed");
            timer.Stop();
            timer.Dispose();
        }

        private void Loop()
        {
            while(true)
            {
				string str = Console.ReadLine();
				
                ; // do nothing
            }
        }
        private void SetTimer(out Timer timer)
        {
            timer = new Timer(5000);
            timer.Elapsed += OnTimerTick;
            timer.AutoReset = true;
            timer.Enabled = true;
        }
        private void OnTimerTick(Object source, ElapsedEventArgs e)
        {

        }

    }
}
