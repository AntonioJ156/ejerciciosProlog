// Learn more about F# at http://fsharp.org

open System

let input () =
    let n = Convert.ToInt32(Console.ReadLine())
    n
    
let res can1 can2 can3 can4 =
    let sumV = can1 + can2 + can3 + can4
    let por1 = (can1/sumV)*100
    let por2 = (can2/sumV)*100
    let por3 = (can3/sumV)*100
    let por4 = (can4/sumV)*100
    printfn "Voto cantidato 1: %A Procentaje: %A" can1 por1
    printfn "Voto cantidato 2: %A Procentaje: %A" can2 por2
    printfn "Voto cantidato 3: %A Procentaje: %A" can3 por3
    printfn "Voto cantidato 4: %A Procentaje: %A" can4 por4
    printfn "Cantidad votantes: %A" sumV
    
let rec rep can1 can2 can3 can4 =
    let voto = input()
    match voto with
    | 0 -> res can1 can2 can3 can4
    | 1 -> rep (can1+1) can2 can3 can4
    | 2 -> rep can1 (can2+1) can3 can4
    | 3 -> rep can1 can2 (can3+1) can4
    | 4 -> rep can1 can2 can3 (can4+1)
    | _ -> printfn "Candidato no válido"

rep 0 0 0 0

let tmp = Console.ReadLine()