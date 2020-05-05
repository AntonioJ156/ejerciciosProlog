//linux fsharpc Program.fs && ./a.out

open System

let input () =
    printfn "Opcion:"
    let op = Console.ReadLine()
    printfn "su opción es: "
    op

let filter ()=
    let op = input()
    match op with
        | "a" -> "Android"
        | "i" -> "iOS"
        | _ -> "inválida"

let prnt ()=
    let op = filter()
    printfn "%A" op

prnt()

let tmp = Console.Read()