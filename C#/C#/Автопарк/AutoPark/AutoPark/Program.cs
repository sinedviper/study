using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark {
    //Class Park
    abstract class autoPark {
        //Realization get and set
        private string name;
        public string Name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }
        private int vechicals;
        public int Vechicals {
            get {
                return vechicals;
            }
            set {
                vechicals = value;
            }
        }

        public autoPark(string name, int vechicals) {
            Vechicals = vechicals;
            Name = name;
        }
    }
    class logisticAutoPark : autoPark {
        private int maxWeight;
        public int MaxWeight {
            get {
                return maxWeight;
            }
            set {
                maxWeight = value;
            }
        }

        public logisticAutoPark (string Name, int maxWeight, int Vechicals) : base(Name, Vechicals) {
            MaxWeight = maxWeight;
        }
    }
    class publicAutoPark : autoPark {
        private int maxPasseng;
        public int MaxPasseng {
            get {
                return maxPasseng;
            }
            set {
                maxPasseng = value;
            }
        }

        public publicAutoPark (string Name, int maxPasseng, int  Vechicals) : base(Name, Vechicals)
        {
            MaxPasseng = maxPasseng;
        }
    }
    //Class Transport
    abstract class transportVehicle {
        //Realization get and set
        private int power;
        public int Power {
            get {
                return power;
            }
            set {
                power = value;
            }
        }
        private int maxPasseng;
        public int MaxPasseng {
            get {
                return maxPasseng;
            }
            set {
                maxPasseng = value;
            }
        }
        private int maxWeight;
        public int MaxWeight {
            get {
                return maxWeight;
            }
            set {
                maxWeight = value;
            }
        }

        public transportVehicle(int power, int maxPasseng, int maxWeight) {
            Power = power;
            MaxPasseng = maxPasseng;
            MaxWeight = maxWeight;
        }
    }
    class motorVechicale : transportVehicle {
        public motorVechicale(int power, int maxPasseng, int maxWeight) : base(power, maxPasseng, maxWeight) {
        }
    }
    class van : transportVehicle {
        public  van(int power, int maxPasseng, int maxWeight) : base(power, maxPasseng, maxWeight) {
        }
    }
    class car : transportVehicle {
        public car(int power, int maxPasseng, int maxWeight) : base(power, maxPasseng, maxWeight) {
        }
    }
    class bus : transportVehicle {
        public bus(int power, int maxPasseng, int maxWeight) : base(power, maxPasseng, maxWeight) {
        }
    }
    class Program {
        static void Main(string[] args) {
            //Logistic Park
            int maxWeight0 = 0;
            int maxVechicals0 = 0;
            logisticAutoPark lPark0 = new logisticAutoPark("Travel", maxWeight0, maxVechicals0);
            int maxWeight1 = 0;
            int maxVechicals1 = 0;
            logisticAutoPark lPark1 = new logisticAutoPark("BigFoot", maxWeight1, maxVechicals1);
            int maxWeight2 = 0;
            int maxVechicals2 = 0;
            logisticAutoPark lPark2 = new logisticAutoPark("KoolWeight", maxWeight2, maxVechicals2);
            //Public Park
            int maxPasseng0 = 0;
            int maxVechical0 = 0;
            publicAutoPark pPark0 = new publicAutoPark("PublicAuto",maxPasseng0,maxVechical0);
            int maxPasseng1 = 0;
            int maxVechical1 = 0;
            publicAutoPark pPark1 = new publicAutoPark("AutoParcking", maxPasseng1, maxVechical1);
            int maxPasseng2 = 0;
            int maxVechical2 = 0;
            publicAutoPark pPark2 = new publicAutoPark("MoonPark", maxPasseng2, maxVechical2);
            //Arrays
            motorVechicale[] vech = { new motorVechicale(255, 2, 230), new motorVechicale(200, 2, 210), new motorVechicale(270, 2, 235), new motorVechicale(300, 1, 200), new motorVechicale(140, 3, 300) };
            van[] vans = { new van(400, 5, 2000), new van(200, 3, 1000), new van(500, 4, 3000) };
            car[] cars = { new car(1000, 2, 300), new car(600, 4, 700), new car(200, 5, 800), new car(150, 2, 300), new car(700, 6, 900), new car(400, 4, 800) };
            bus[] bus = { new bus(600, 38, 3000), new bus(700, 45, 4000), new bus(700, 50, 5000) };
            //Calculation of cargo, number of people and machines
            for (int i = 0; i < cars.Length; i++) {
                maxWeight0 += cars[i].MaxWeight;
                maxVechicals0 ++;

                maxPasseng0 += cars[i].MaxPasseng;
                maxVechical0++;

                maxPasseng2 += cars[i].MaxPasseng;
                maxVechical2++;
                if (i < 5) {
                    maxPasseng1 = maxPasseng1 + vech[i].MaxPasseng + cars[i].MaxPasseng;
                    maxVechical1+=2;
                    if (i < 4) {
                        maxPasseng2 += vech[i].MaxPasseng;
                        maxVechical2++;
                        if (i < 3) {
                            maxWeight0 += vans[i].MaxWeight;
                            maxVechicals0++;

                            maxWeight1 += cars[i].MaxWeight;
                            maxVechicals1++;

                            maxWeight2 += vans[i].MaxWeight;
                            maxVechicals2++;

                            maxPasseng0 += vech[i].MaxPasseng;
                            maxVechical0++;

                            maxPasseng2 += bus[i].MaxPasseng;
                            maxVechical2++;
                            if (i < 2) {
                                maxWeight1 += vans[i].MaxWeight;
                                maxVechicals1++;

                                maxWeight2 += cars[i].MaxWeight;
                                maxVechicals2++;

                                maxPasseng1 += bus[i].MaxPasseng;
                                maxVechical1++;

                                maxPasseng0 += bus[i].MaxPasseng;
                                maxVechical0++;
                            }
                        }
                    }
                }
            }
            //Blocks calculation
            try {
            M:    
            Console.WriteLine("What kind of autopark you choose?" + '\n' + "1- Logistic autopark," + '\n' + "2- Public autopark." + '\n' + "0- Exit");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 0) {
                    return;
                } else if (num == 1) {
                C:
                    Console.WriteLine("Select the auto park to display information- " + '\n' + "1- " + lPark0.Name + '\n' + "2- " + lPark1.Name + '\n' + "3- " + lPark2.Name);
                    Console.WriteLine("0- Exit to start menu");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    switch (num1) {
                        case 0:
                            goto M;
                        case 1:
                            Console.WriteLine("Information about the auto park- " + lPark0.Name + ":" + '\n' + "Maximum weight- " + maxWeight0 + " kg," + '\n' + "Maximum number of machines- " + maxVechicals0 + ".");
                            Console.WriteLine("Press any button to continue...");
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.WriteLine("Information about the auto park- " + lPark1.Name + ":" + '\n' + "Maximum weight- " + maxWeight1 + " kg," + '\n' + "Maximum number of machines- " + maxVechicals1 + ".");
                            Console.WriteLine("Press any button to continue...");
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.WriteLine("Information about the auto park- " + lPark2.Name + ":" + '\n' + "Maximum weight- " + maxWeight2 + " kg," + '\n' + "Maximum number of machines- " + maxVechicals2 + ".");
                            Console.WriteLine("Press any button to continue...");
                            Console.ReadKey();
                            break;  
                        default:
                            Console.WriteLine("You have entered an incorrect number" + '\n');
                            break;
                    }
                goto C;
            } else if (num == 2) {
                C:
                    Console.WriteLine("Select the auto park to display information- " + '\n' + "1- " + pPark0.Name + '\n' + "2- " + pPark1.Name + '\n' + "3- " + pPark2.Name);
                    Console.WriteLine("0- Exit to start menu");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    switch (num1) {
                        case 0:
                            goto M;
                        case 1:
                            Console.WriteLine("Information about the auto park- " + pPark0.Name + ":" + '\n' + "Maximum number of passengers- " + maxPasseng0 + "," + '\n' + "Maximum number of machines- " + maxVechical0 + ".");
                            Console.WriteLine("Press any button to continue...");
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.WriteLine("Information about the auto park- " + pPark1.Name + ":" + '\n' + "Maximum number of passengers- " + maxPasseng1 + "," + '\n' + "Maximum number of machines- " + maxVechical1 + ".");
                            Console.WriteLine("Press any button to continue...");
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.WriteLine("Information about the auto park- " + pPark2.Name + ":" + '\n' + "Maximum number of passengers- " + maxPasseng2 + "," + '\n' + "Maximum number of machines- " + maxVechical2 + ".");
                            Console.WriteLine("Press any button to continue...");
                            Console.ReadKey();
                            break;
                        default:
                            Console.WriteLine("You have entered an incorrect number" + '\n');
                            break;
                    }
                    goto C;
                } else if (num != 1 || num != 2 || num !=0) {
                    Console.WriteLine("You have entered an incorrect number" + '\n');
                    goto M;
            }
            } catch (FormatException) {
                Console.WriteLine("Incorrect format" + '\n'+ "To end the program, press any button");
                Console.ReadKey();
            } 
        }
    }
}