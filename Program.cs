using System;

class Vehicle  // base class (parent)
{
  public string brand = "Ferrari";  // Vehicle field
}

 class Car : Vehicle {     // Car Extends Vehicle
    double hour = 0.0;
    public Car(double hour){
        this.hour = hour;
    }
    public double calculateParking()  {

            double charge = 4.0;

            if (hour > 3)

            {

                hour = Math.Ceiling(hour - 3);

                charge += hour * 1.0;

            }

 

            if (charge > 20.0)

            {

                charge = 20.0;
            }
                return charge;

        }
}


 class Bike :  Vehicle {
    double hour = 0.0;
    public Bike(double hour){
        this.hour = hour;
    }
    public double calculateParking()  {
     double charge = 2.0;
            if (hour > 3)

            {

                hour = Math.Ceiling(hour - 3);

                charge += hour * 0.5;

            }

 

            if (charge > 10.0)

            {

                charge = 10.0;
            }
                return charge;

        }
}

 class Buss:  Vehicle {
    double hour = 0.0;
    public Buss(double hour){
        this.hour = hour;
    }
    public double calculateParking()  {

            double charge = 6.0;

            if (hour > 3)

            {

                hour = Math.Ceiling(hour - 3);

                charge += hour * 1.5;

            }

 

            if (charge > 30.0)

            {

                charge = 30.0;
            }
                return charge;

        }
}

public class Parking
{
   

    public static void Main(string[] args)
    {

            double hours;
            double carCharges;
            double bikeCharges;
            double bussCharges;
;


        Console.Write("Enter the number of hours :");

        hours = Math.Ceiling(Convert.ToDouble(Console.ReadLine()));

                if (hours < 1 || hours >24)

                {

                  Console.WriteLine("Invalid Entry - try again: ");

                }

                else

                {

                    Bike bike = new Bike(hours);
                    bikeCharges = bike.calculateParking();
                   
                    Car car = new Car(hours);
                    carCharges = car.calculateParking();

                    Buss buss = new Buss(hours);
                    bussCharges = buss.calculateParking();
                   

                    Console.WriteLine(bike.brand + " Bike Parking charges for the customer: {0:C}", bikeCharges);
                   
                    Console.WriteLine(car.brand + " Car Parking charges for the customer: {0:C}", carCharges);
                   
                    Console.WriteLine(buss.brand + " Buss Parking charges for the customer: {0:C}", bussCharges);
                   
                }
           
    }
}
