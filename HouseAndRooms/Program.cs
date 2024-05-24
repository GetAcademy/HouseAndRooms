using HouseAndRooms;

//var house = new House();
////house._currentRoom = "Ute";
////house._currentRoom = "Sov";
////house._currentRoom = "Terje";
//house.GoTo("Ute");
//house.GoTo("Sov");
//house.GoTo("Terje");
//house.GoTo("Gang");
//house.GoTo("Stue/kjk");
//house.GoTo("Sov");

var gearshifter = new Gearshifter();
gearshifter.GoTo('1');
gearshifter.GoTo('2');
gearshifter.GoTo('R');
gearshifter.GoTo('1');
/*
  Ulovlig: 
   - rom som ikke finnes
   - dører som ikke finnes
 */