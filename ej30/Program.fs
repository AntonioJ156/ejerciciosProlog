// Learn more about F# at http://fsharp.org

open System

let input (tag:string) =
    printf "%s: " tag
    let n = Convert.ToInt32(Console.ReadLine())
    n

let p1 = input "P1"
let p2 = input "P2"
let p3 = input "P3"
let p4 = input "P4"
let p5 = input "P5"
printfn ""

let res ap1 ap2 ap3 ap4 ap5 recau =
    printfn "Cantidad de boletos tipo 1: %A" ap1
    printfn "Cantidad de boletos tipo 2: %A" ap2
    printfn "Cantidad de boletos tipo 3: %A" ap3
    printfn "Cantidad de boletos tipo 4: %A" ap4
    printfn "Cantidad de boletos tipo 5: %A" ap5
    printfn "Recaudacion del estado: %A" recau
    
let rec rep ap1 ap2 ap3 ap4 ap5 recau =
    let clave = input "Clave"
    let cant = input "Cant"
    printfn ""
    if clave <> -1 && cant <> -1 then
        match clave with
        | 1 ->
            let pre = p1 * cant
            printfn "%A, %A, %A" clave cant pre
            rep (ap1+cant) ap2 ap3 ap4 ap5 (recau+pre)
        | 2 ->
            let pre = p2 * cant
            printfn "%A, %A, %A" clave cant pre
            rep ap1 (ap2+cant) ap3 ap4 ap5 (recau+pre)
        | 3 ->
            let pre = p3 * cant
            printfn "%A, %A, %A" clave cant pre
            rep ap1 ap2 (ap3+cant) ap4 ap5 (recau+pre)
        | 4 ->
            let pre = p4 * cant
            printfn "%A, %A, %A" clave cant pre
            rep ap1 ap2 ap3 (ap4+cant) ap5 (recau+pre)
        | 5 ->
            let pre = p5 * cant
            printfn "%A, %A, %A" clave cant pre
            rep ap1 ap2 ap3 ap4 (ap5+cant) (recau+pre)
    else
        res ap1 ap2 ap3 ap4 ap5 recau

rep 0 0 0 0 0 0

let tmp = Console.ReadLine()