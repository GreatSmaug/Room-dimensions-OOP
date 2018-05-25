using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room_dimensions__OOP_
{
    public class Room
    {
        // Functions

        public float CalcVolume(float x, float y, float z)
        {
            // Calculates volume
            return (x * y * z);
        }

        public float CalcWallArea(float x, float y, float z)
        {
            // Calculates wall area
            return ((2 * z) * (x + y));
        }

        public float CalcFloorArea(float x, float y, float z)
        {
            // Calculates floor area 
            return (x * y);
        }

        public float volume;
        public float wallArea;
        public float floorArea;

        // Constructor
        public Room()
        {
            Length = 0;
            Width = 0;
            Height = 0;
        }

        // Constructor taking an argument
        public Room(float length, float width, float height)
        {
            Length = length;
            Width = width;
            Height = height;

            volume = CalcVolume(length, width, height);
            wallArea = CalcWallArea(length, width, height);
            floorArea = CalcFloorArea(length, width, height);

        }

        public float Length { get; }
        public float Width { get; }
        public float Height { get; }


        public override string ToString()
        {
            return base.ToString();
        }

    }
}
