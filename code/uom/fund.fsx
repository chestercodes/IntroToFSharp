[<Measure>] type GBP
[<Measure>] type fundUnit
let alreadyOwns = 10.4<fundUnit>
let fundPrice = 2.4<GBP/fundUnit>
let availableCash = 14.0<GBP>

let maxCanBuy cash price =
    match cash, price with
    | c, p when c < 0.0<GBP> || p <= 0.0<GBP/fundUnit> -> 0.0<fundUnit>
    | _ -> cash / price

let total = alreadyOwns + maxCanBuy availableCash fundPrice