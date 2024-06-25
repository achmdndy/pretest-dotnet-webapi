namespace LockerFloorFinder.Services
{
    public static class LockerService
    {
        public static int GetFloor(int lockerNumber)
        {
            int floor = 0;
            int lockersPerFloor = 5;
            int lockerCount = 0;

            while (lockerCount < lockerNumber)
            {
                floor++;
                lockerCount += lockersPerFloor;

                // Rotate between 5, 6, and 7 lockers per floor
                if (lockersPerFloor == 5)
                {
                    lockersPerFloor = 6;
                }
                else if (lockersPerFloor == 6)
                {
                    lockersPerFloor = 7;
                }
                else
                {
                    lockersPerFloor = 5;
                }
            }

            return floor;
        }
    }
}
