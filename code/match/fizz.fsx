let fizzbuzz n =
  match n with
  | x when x % 15 = 0 -> "FizzBuzz"
  | x when x % 3  = 0 -> "Fizz"
  | x when x % 5  = 0 -> "Buzz"
  | x                 -> x.ToString()

let (|DividesBy3|DividesBy5|DividesBy15|Other|) n = 
  match n with
  | x when x % 15 = 0 -> DividesBy15
  | x when x % 3  = 0 -> DividesBy3
  | x when x % 5  = 0 -> DividesBy5
  | _                 -> Other

let fizzbuzz2 n = 
  match n with
  | DividesBy15 -> "FizzBuzz"
  | DividesBy3  -> "Fizz"
  | DividesBy5  -> "Buzz"
  | x           -> x.ToString()

let (|DividesBy|_|) modN n = if n % modN = 0 then Some n else None 
let fizzbuzz3 n = 
  match n with
  | DividesBy 15 _ -> "FizzBuzz"
  | DividesBy 3  _ -> "Fizz"
  | DividesBy 5  _ -> "Buzz"
  | x              -> x.ToString()