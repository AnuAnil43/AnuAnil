using System;
using System.Collections.Generic;
using System.IO;

namespace ClassesOOP
{
    class Square
    {
        public int numberOfSides;
        double area;
        double perimeter;
        double sideLength; 

        public Square()
        {
            this.numberOfSides = 4;
            this.sideLength = 1;
            setCalcPerimeter(this.numberOfSides, this.sideLength);
            setCalcArea(this.sideLength);
        }
        void setCalcPerimeter(int Sides, double Length)
        {
            this.perimeter = ( Sides * Length );
        }
        
        void  setCalcArea(double length)
        {
            this.area = ( length * length );
        }
        public double getPerimeter()
        {
              return this.perimeter;
        }
        public void setPerimeter(double Perimeter)
        {
            
        }
        
    }
}

