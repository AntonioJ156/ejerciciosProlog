// Learn more about F# at http://fsharp.org

open System

let input () =
    printf "N: "
    let n = Convert.ToInt32(Console.ReadLine())
    n
    
let cmp (band, i) =
    if band = "T"
        then ("F", 1/i)
    else ("T", -1/i)

let rec rep band serie i n =
    match i with
    | i when i > n -> printfn "%A" serie
    | _ ->
        let (nBand, ni) = cmp (band, i)
        rep nBand (serie+ni) (i+1) n

let n = input()
rep "T" 0 1 n