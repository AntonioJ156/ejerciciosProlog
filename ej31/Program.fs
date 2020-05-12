// Learn more about F# at http://fsharp.org

open System

let input (tag:string) =
    printf "%s: " tag
    let n = Convert.ToInt32(Console.ReadLine())
    n

let res tipo1 tipo2 tipo3 tipo4 tipo5 mctipo2 año =
    printfn "total tipo 1: %A" tipo1
    printfn "total tipo 2: %A" tipo2
    printfn "total tipo 3: %A" tipo3
    printfn "total tipo 4: %A" tipo4
    printfn "total tipo 5: %A" tipo5
    printfn "Año en que se produjo mayor cantidad vino tipo 2: %A, Litros: %A" año mctipo2
    
let rec rep2 tipo1 tipo2 tipo3 tipo4 tipo5 mctipo2 j totvim año i =

    match j with
    | 6 ->
        printfn "Total de litros producidos %A" totvim
        (tipo1, tipo2, tipo3, tipo4, tipo5, mctipo2, año)
    | _ ->
        let v = input "V"
        printfn ""
        match j with
        | 1 -> rep2 (tipo1+v) tipo2 tipo3 tipo4 tipo5 mctipo2 (j+1) (totvim+v) año i
        | 2 ->
            if v > mctipo2 then
                rep2 tipo1 (tipo2+v) tipo3 tipo4 tipo5 v (j+1) (totvim+v) i i
            else
                rep2 tipo1 (tipo2+v) tipo3 tipo4 tipo5 mctipo2 (j+1) (totvim+v) año i
        | 3 ->
            if v = 0 then
                printfn "El año %A no se produjo tipo 3" i
            rep2 tipo1 tipo2 (tipo3+v) tipo4 tipo5 mctipo2 (j+1) (totvim+v) año i
        | 4 -> rep2 tipo1 tipo2 tipo3 (tipo4+v) tipo5 mctipo2 (j+1) (totvim+v) año i
        | 5 -> rep2 tipo1 tipo2 tipo3 tipo4 (tipo5+v) mctipo2 (j+1) (totvim+v) año i

let rec rep tipo1 tipo2 tipo3 tipo4 tipo5 mctipo2 año i n =
    if i > n then
        res tipo1 tipo2 tipo3 tipo4 tipo5 mctipo2 año
    else
        let (tipo1, tipo2, tipo3, tipo4, tipo5, mctipo2, año) = rep2 tipo1 tipo2 tipo3 tipo4 tipo5 0 1 0 año i
        rep tipo1 tipo2 tipo3 tipo4 tipo5 mctipo2 año (i+1) n

let n = input "N"
rep 0 0 0 0 0 0 0 0 n

let tmp = Console.ReadLine()