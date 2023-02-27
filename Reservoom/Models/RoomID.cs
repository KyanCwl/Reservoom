using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservoom.Models
{
    public class RoomID
    {
        public int FloorNumber { get; }
        public int RoomNumber { get; }

        public RoomID(int floorNumber, int roomNumber)
        {
            FloorNumber = floorNumber;
            RoomNumber = roomNumber;
        }

        public bool IsSameRoom(RoomID roomID)
        {
            return FloorNumber == roomID.FloorNumber &&
                RoomNumber == roomID.RoomNumber;
        }

        public override string ToString()
        {
            return $"{FloorNumber}{RoomNumber}";
        }

        //public override bool Equals(object obj)
        //{
        //    return obj is RoomID roomID &&
        //        FloorNumber == roomID.FloorNumber &&
        //        RoomNumber == RoomID.RoomNumber;
        //}

        //public override int GetHashCode()
        //{
        //    return H
        //}
    }
}
