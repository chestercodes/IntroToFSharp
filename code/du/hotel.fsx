// define type
type RoomName =         // type TypeName =
    | Number of int     //     | case-identifier1 of type1
    | Name of string    //     | case-identifier2 of type2

// construct values
let room5 = Number 5                 // let typeVal1 = case-identifier1 value1
let grandSuite = Name "Grand Suite"  // let typeVal2 = case-identifier2 value2

let printRoomName roomName =
    match roomName with
    | Number number -> printfn "Room - %i" number
    | Name name     -> printfn "Room - %s" name

printRoomName room5       // prints "Room - 5"
printRoomName grandSuite  // prints "Room - Grand Suite"
