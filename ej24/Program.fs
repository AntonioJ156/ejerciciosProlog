// Learn more about F# at http://fsharp.org

open System

let input () =
    let n = Convert.ToInt32(Console.ReadLine())
    n

let cmp v =
    match v with
    | v when v <= 200 -> (1,0,0)
    | v when v < 400 -> (0,1,0)
    | _ -> (0,0,1)
    
let rec rep chi med gra i n =
    match i with
    | i when i > n -> printf "%A, %A, %A" chi med gra
    | _ ->
        let v = input()
        let (sChi, sMed, sGra) = cmp v
        rep (chi+sChi) (med+sMed) (gra+sGra) (i+1) n
        
let n = input()
rep 0 0 0 1 n