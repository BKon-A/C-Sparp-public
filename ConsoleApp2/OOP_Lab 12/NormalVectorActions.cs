using System;

namespace OOP_Lab_12
{
    sealed class NormalVectorActions : NormalVector
    {
        public NormalVectorActions() : base()
        {

        }
        public NormalVectorActions(double coordinateX, double coordinateY) : base(coordinateX, coordinateY)
        {
            if (((coordinateX != 0.0) && (coordinateY != 1.0)) || ((coordinateX != 1.0) &&
                (coordinateY != 0.0)))
            {
                UnitVector = Math.Sqrt(Math.Pow(coordinateX, 2) + Math.Pow(coordinateY, 2));

                CoordinateX = coordinateX / UnitVector;
                CoordinateY = coordinateY / UnitVector;
            }
            else
            {
                CoordinateX = coordinateX;
                CoordinateY = coordinateY;
            }
        }

        public override string ToString()
        {
            return "X = " + CoordinateX + " | Y = " + CoordinateY;
        }

        public static NormalVectorActions operator *(NormalVectorActions v1, NormalVectorActions v2)
        {
            //Algebraistic interpretation: new vector = vX(new x) * vY(new Y)
            double scalarProduct;
            NormalVectorActions newVector = new NormalVectorActions();

            scalarProduct = v1.CoordinateX + v2.CoordinateX * v1.CoordinateY + v2.CoordinateY;
            newVector.CoordinateX = (v1.CoordinateX + v2.CoordinateX) * scalarProduct;
            newVector.CoordinateY = (v1.CoordinateY + v2.CoordinateY) * scalarProduct;

            return newVector;
        }

        ~NormalVectorActions() { }
    }
}
