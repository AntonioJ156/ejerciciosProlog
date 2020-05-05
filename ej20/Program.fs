// Learn more about F# at http://fsharp.org

open System
        
let cmp band =
    if band = "T"
        then ("F", 3)
    else ("T", 2)

let rec rep band sumser i =
    match i with
    | 1801 -> printfn "%A" sumser
    | _ ->
        printf "I: "
        let I = Convert.ToInt32(Console.ReadLine())
        let (nBand, ni) = cmp band
        rep nBand (sumser+i) (I+ni)

rep "T" 0 2