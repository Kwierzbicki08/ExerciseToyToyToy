using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseToyToyToy
{
    class Car : ISpeed
    {
        static int counter = 1;
        private int speed = 0;
        private string name;

        public Car(string __name = "")
        {
            if (__name == "")
            {
                name = "Car " + counter.ToString();
                counter++;
            }
            else
                name = __name;

        }
        public int GetCurrentSpeed()
        {
            return speed;
        }
        public int ChangeSpeed(int change)
        {
            return speed = change;
        }
        public int IncSpeed()
        {
            speed += 1;
            if (speed > 300)
            {
                speed = 300;
            }

            return speed;
        }
        public int DecSpeed()
        {
            speed -= 1;
            if (speed < 0)
            {
                speed = 0;
            }
            return speed;
        }
        public override string ToString()
        {
            return name;
        }

    }
    class Submarine : ISpeed, IDepth
    {
        static int counter = 1;
        private int speed = 0;
        private int altitute = 0;
        private int depth = 0;
        private string name;
        public Submarine(string __name = "")
        {
            if (__name == "")
            {
                name = "Submarine " + counter.ToString();
                counter++;
            }
            else
                name = __name;
        }
        public int GetCurrentSpeed()
        {
            return speed;
        }
        public int ChangeSpeed(int change)
        {
            return speed = change;
        }
        public int IncSpeed()
        {
            return speed += 1;
        }
        public int DecSpeed()
        {
            speed -= 1;
            if (speed < 0)
            {
                speed = 0;
            }
            return speed;
        }
        
        public int GetCurrentDepth()
        {
            return depth;
        }
        public int ChangeDepth(int change)
        {
            return depth = change;
        }
        public int IncDepth()
        {
            depth += 1;
            if (depth > 100)
            {
                depth = 100;
            }
            return depth;
        }
        public int DecDepth()
        {
            depth -= 1;
            if (depth < -1000)
            {
                depth = -1000;
            }
            return depth;
        }
        public override string ToString()
        {
            return name;
        }
    }

    class Plane : ISpeed, IAltitute
    {
        static int counter = 1;
        private int speed = 0;
        private int altitute = 0;
        private string name;
        public Plane(string __name = "")
        {
            if (__name == "")
            {
                name = "Plane " + counter.ToString();
                counter++;
            }
            else
                name = __name;
        }
        public int GetCurrentSpeed()
        {
            return speed;
        }
        public int ChangeSpeed(int change)
        {
            return speed = change;
        }
        public int IncSpeed()
        {
            return speed += 1;
        }
        public int DecSpeed()
        {
            speed -= 1;
            if (speed < 0)
            {
                speed = 0;
            }
            return speed;
        }
        public int GetCurrentAltitute()
        {
            return altitute;
        }
        public int ChangeAltitute(int change)
        {
            return altitute = change;
        }
        public int IncAltitute()
        {
            return altitute += 1;
        }
        public int DecAltitute()
        {
            altitute -= 1;
            if (altitute < 0)
            {
                altitute = 0;
            }
            return altitute;
        }
        public override string ToString()
        {
            return name;
        }
    }
    class Computer
    {
        static int counter = 1;
        private string name;

        public Computer(string __name = "")
        {
            if (__name == "")
            {
                name = "Computer " + counter.ToString();
                counter++;
            }
            else
                name = __name;
        }
        public override string ToString()
        {
            return name;
        }
    }
}
