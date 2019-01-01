[<Measure>] type GBP
[<Measure>] type Q
let alreadyOwns = 10.4<Q>  // float<Q>
let fundPrice = 2.4<GBP/Q> // float<GBP/Q>
let availableCash = 14.0<GBP>     // float<GBP>

//            <GBP> -> <GBP/Q> -> <Q>
let maxCanBuy cash     price =  
    match cash, price with
    | c, p when c < 0.0<GBP> || p <= 0.0<GBP/Q> -> 0.0<Q>
    | _ -> cash / price

let total = alreadyOwns + maxCanBuy availableCash fundPrice  // float<Q>