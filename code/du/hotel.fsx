type RoomName = 
    | Name of string
    | Number of int
let room5 = Number 5
let theGrandSuite = Name "The Grand Suite"
let printRoomName roomName =
    match roomName with
    | Number number -> printfn "Room - %i" number
    | Name name     -> printfn "Room - %s" name

printRoomName room5
// Room - 5

printRoomName theGrandSuite
// Room - The Grand Suite
