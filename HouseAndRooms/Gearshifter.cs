namespace HouseAndRooms
{
    internal class Gearshifter
    {
        private string _gears;
        private char _currentGear;

        public Gearshifter()
        {
            _currentGear = 'N';
            _gears = "RN123456";
        }

        public void GoTo(char gear)
        {
            if (CompareChar(1, gear) || CompareChar(-1, gear))
            {
                _currentGear = gear;
            }
            Console.WriteLine($"Prøver å gå til {gear}. Er nå i {_currentGear}");
        }

        private bool CompareChar(int offset, int character)
        {
            var index = _gears.IndexOf(_currentGear);
            var lookupIndex = index + offset;
            if (lookupIndex < 0 || lookupIndex > _gears.Length - 1) return false;
            return _gears[lookupIndex] == character;
        }
    }
}
