// Learn more about F# at http://fsharp.org

open System

let cmp v =
    match v with
    | v when v <= 200 -> (1,0,0)
    | v when v < 400 -> (0,1,0)
    | _ -> (0,0,1)
    
let rec rep pri seg sigi i =
    match i with
    | 181 -> printf "%A" sigi
    | _ ->
        let sigiDos = pri+seg
        printfn "%A" sigiDos
        let priDos = seg
        let segDos = sigi
        rep seg sigi (pri+seg) (i+1)

rep 0 1 1 3

let tmp = Console.ReadLine()