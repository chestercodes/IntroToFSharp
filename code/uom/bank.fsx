[<Measure>] type percent
[<Measure>] type GBP
[<Measure>] type year

let csv = """
Bank,Apr(%),WelcomeGift
1,3.1,200
2,4.2,100
3,5.3,0
"""

type BankInfo = {Bank: int; Apr: float<percent/year>; Gift: float<GBP>}
let tryFloat (s: string) = try Some (float (s.Trim())) with | _ -> None
let tryInt (s: string) = try Some (int (s.Trim())) with | _ -> None

let csvLineToBankInfo (csvLine: string) =
    match csvLine.Split ',' with
    | [|c1; c2; c3|] -> 
        match tryInt c1, tryFloat c2, tryFloat c3 with
        | None, _, _  | _, None, _ | _, _, None -> None
        | Some bank, Some apr, Some gift -> 
            Some { Bank = bank
                   Apr = apr * 1.0<percent/year>
                   Gift = gift * 1.0<GBP> }
    | _ -> None            

let bankInfos = 
    csv.Split('\n')
    |> Array.toList
    |> List.choose csvLineToBankInfo

let fromPercentage (percentage: float<percent>): float =
    float percentage / 100.0
let toPercentage (whole: float): float<percent> =
    whole * 100.0<percent>
let compoundInterestOverYears (rate: float<percent/year>) (years: float<year>): float<percent> =
    // 5% over 2 years is 10.25% increase- (1.05 ^ 2) * 100%
    let percentIncrease = 100.0<percent> + (rate * 1.0<year>)
    (fromPercentage percentIncrease) ** (float years) |> toPercentage
let calculateAmountAfterYears initialBalance bankInfo years: float<GBP> =
    let interestMultiplier = fromPercentage (compoundInterestOverYears bankInfo.Apr years)
    (initialBalance + bankInfo.Gift) * interestMultiplier

let initialBalance = 1000.0<GBP>
let numberOfYears = 10.0<year>
let amountsAfter10Years = 
    bankInfos
    |> List.map (fun x -> x, calculateAmountAfterYears initialBalance x numberOfYears)
    |> List.sortBy snd

for am in amountsAfter10Years do
    let bank = (fst am).Bank
    let amount = (snd am)
    printfn "Bank %i amount %f " bank amount
