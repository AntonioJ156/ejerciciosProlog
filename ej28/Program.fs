// Learn more about F# at http://fsharp.org

open System

let input () =
    let n = Convert.ToInt32(Console.ReadLine())
    n
    
let cmp numemp sue masue manum =
    if sue > masue
        then (sue, numemp)
    else (masue, manum)        
    
let rec rep masue manum i n =
    match i with
    | i when i > n -> printf "%A %A" manum masue
    | _ ->
        let numemp = input()
        let sue = input()
        let (p1, p2) = cmp numemp sue masue manum 
        rep p1 p2 (i+1) n
        
let n = input()
rep 0 0 1 n