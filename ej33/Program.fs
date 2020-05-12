// Learn more about F# at http://fsharp.org

open System
    
let rec rep2 band j i =
    if j < (i/2) && band = "V"
        then
            if i%j = 0
                then rep2 "F" (j+2) i
            else rep2 band (j+2) i
    else
        if band = "V"
            then
                printfn "Numero Primo %A" i
                (2, 1)
        else (2, 0)
        
let res (sp:int) (m:int) =
    printf "entre 1 y %i hay %i numeros primos" m sp
    
let rec rep (i:int) (sp) m =
    match i with
    | i when i > m -> res sp m
    | _ ->
        let (ni, nsp) = rep2 "V" 3 i
        rep (i+ni) (sp+nsp) m

let cmp i sp m =
    if m >= 1
        then
            printfn "Numero primo %A" (sp+1)
            if m >= 2
                then
                    printfn "Numero primo %A" (sp+2)
                    rep i (sp+2) m
            else
                rep i (sp+1) m
    else rep i sp m

let m = Convert.ToInt32(Console.ReadLine())
cmp 3 0 m

let tmp = Console.ReadLine()