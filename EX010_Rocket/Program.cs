Console.WriteLine("Введите сокрость ракеты на момент выхода за пределы атмосферы земли");
            string speed = Console.ReadLine()!;
            double rocketSpeed = Convert.ToDouble(speed);


Console.WriteLine("Your speed is " + rocketSpeed);
            if (rocketSpeed < 7.5)
            {
                Console.WriteLine(" The Rocket will fall down. Back to earth!");
            }
            if (rocketSpeed < 11.2 & rocketSpeed >= 7.5)
            {
                Console.WriteLine(" The Rocket will remain on the orbit");

            }
            if (rocketSpeed < 16.4 & rocketSpeed >= 11.2 )
            {
                Console.WriteLine(" The Rocket will travel to the space but not far. The sun gravity is still here");
            }
            if (rocketSpeed >= 16.4 )
            {
                Console.WriteLine(" Woo-hoo! let's travel around the space");
            }
            Console.WriteLine("!");
            Console.ReadKey();