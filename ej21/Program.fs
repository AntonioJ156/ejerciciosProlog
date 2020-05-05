// Learn more about F# at http://fsharp.org

open System

let input () =
    printf "N: "
    let n = Convert.ToDouble(Console.ReadLine())
    n
    
let cmp (band, i:float) =
    if band = "T"
        then ("F", 1.0/i)
    else ("T", -1.0/i)

let rec rep band serie (i:float) n =
    match i with
    | i when i > n -> printfn "%A" serie
    | _ ->
        let (nBand, ni) = cmp (band, i)
        rep nBand (serie+ni) (i+1.0) n

let n = input()
rep "T" 0.0 1.0 n


let tmp = Console.ReadLine()