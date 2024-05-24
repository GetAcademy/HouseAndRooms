namespace HouseAndRooms
{
    internal class House
    {
        private string[] _rooms;
        private string _currentRoom;

        public House()
        {
            _currentRoom = "Ute";
            _rooms = new[] { "Ute", "Bad", "Gang", "Stue/kjk", "Sov" };
        }

        public void GoTo(string room)
        {
            if (_currentRoom == "Ute" && room == "Gang"
            || _currentRoom == "Gang" && room == "Bad"
            || _currentRoom == "Gang" && room == "Stue/kjk"
            || _currentRoom == "Stue/kjk" && room == "Sov"
            || _currentRoom == "Gang" && room == "Ute"
            || _currentRoom == "Bad" && room == "Gang"
            || _currentRoom == "Stue/kjk" && room == "Gang"
            || _currentRoom == "Sov" && room == "Stue/kjk"
            )
            {
                _currentRoom = room;
            }

            Console.WriteLine($"Prøver å gå til {room}. Er nå i {_currentRoom}");
        }
    }
}
