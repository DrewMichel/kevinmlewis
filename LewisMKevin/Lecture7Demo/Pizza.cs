using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture7Demo
{
    public enum Size { Small, Medium, Large};

    public class Pizza
    {
        public const int TOPPING_COST = 2;
        public const int SMALL_PIZZA = 10;
        public const int MEDIUM_PIZZA = 12;
        public const int LARGE_PIZZA = 14;


        private Size size;
        private int cheese;
        private int ham;
        private int pepperoni;

        public Pizza()
        {
            size = Size.Small;
            cheese = 1;
            ham = 0;
            pepperoni = 0;
        }

        public Pizza(Size size, int cheese, int pepperoni, int ham) : this()
        {
            this.size = size;
            SetCheese(cheese);
            SetPepperoni(pepperoni);
            SetHam(ham);
        }

        public Size GetSize()
        {
            return this.size;
        }

        public int GetCheese()
        {
            return this.cheese;
        }

        public int GetHam()
        {
            return this.ham;
        }

        public int GetPepperoni()
        {
            return this.pepperoni;
        }

        public void SetSize(Size size)
        {
            this.size = size;
        }

        public void SetCheese(int cheese)
        {
            if(cheese >= 0)
            {
                this.cheese = cheese;
            }
        }

        public void SetHam(int ham)
        {
            if (ham >= 0)
            {
                this.ham = ham;
            }
        }

        public void SetPepperoni(int pepperoni)
        {
            if (pepperoni >= 0)
            {
                this.pepperoni = pepperoni;
            }
        }

        public double CalculateCost()
        {
            double price = 0.0;
            price = (GetHam() + GetCheese() + GetPepperoni()) * TOPPING_COST;

            if(GetSize() == Size.Small)
            {
                price += SMALL_PIZZA;
            }
            else if (GetSize() == Size.Medium)
            {
                price += MEDIUM_PIZZA;
            }
            else //assume large
            {
                price += LARGE_PIZZA;
            }
            return price;
        }

        public override string ToString()
        {
            return String.Format("Pizza [size: {0}, cheese: {1}, ham: {2}, pepperoni: {3}, cost: {4:C}]",
                this.size, GetCheese(), GetHam(), GetPepperoni(), CalculateCost());
        }
    }
}
