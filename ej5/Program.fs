//linux fsharpc Program.fs && ./a.out

open System

let input () =
    printfn "nota:"
    let nota = Convert.ToDouble(Console.ReadLine())
    printfn "su nota es: "
    nota

let filter ()=
    let nota = input()
    match nota with
        | nota when nota < 3.0 -> "Insuficiente"
        | nota when nota <= 3.5 -> "Aceptable"
        | nota when nota <= 4.0 -> "Sobresaliente"
        | nota when nota > 4.0 -> "Excelente"

let prnt ()=
    let op = filter()
    printfn "%A" op

prnt()
let tmp = Console.Read()