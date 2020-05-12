// Learn more about F# at http://fsharp.org

open System

let input () =
    let n = Convert.ToInt32(Console.ReadLine())
    n

let cmp arsu arno arce =
    if arno > arce then
        if arno > arsu then
            printfn "La region con mayor lluvia es la region norte."
        else
            printfn "La region con mayor lluvia es la region sur."
    else
        if arce > arsu then
            printfn "La region con mayor lluvia es la region centro."
        else
            printfn "La region con mayor lluvia es la region sur."
            
let res arsu arno mersu arce mes =
    let prorce = arce / 12
    printfn "Promedio Region Centro %A" prorce
    printfn "Mes con menor lluvia Reg Sur %A" mes
    printfn "Registro del mes %A" mersu
    cmp arsu arno arce

let rec rep arsu arno mersu arce mes i =
    match i with
    | 13 -> res arsu arno mersu arce mes
    | _ ->
        let rno = input()
        let rce = input()
        let rsu = input()
        
        if rsu < mersu then
            rep (arsu+rsu) (arno+rno) rsu (arce+rce) i (i+1)
        else
            rep (arsu+rsu) (arno+rno) mersu (arce+rce) mes (i+1)

rep 0 0 50000 0 0 0

let tmp = Console.ReadLine()