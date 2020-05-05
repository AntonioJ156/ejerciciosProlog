//linux fsharpc Program.fs && ./a.out

open System

let compCalor ()=
    printfn "¿Hace calor?"
    let r1 = Console.ReadLine()
    if r1 = "si"
        then
            printfn "Vestir ropa deportiva"
            printfn "Ir al parque"
    else
        printfn "Vestir informalmente"
        printfn "Ir al cine"

let compCompañia ()=
    printfn "¿tengo comañía?"
    let r2 = Console.ReadLine()
    if r2 = "si"
        then printfn "Usar el carro"
    else printfn "Usar transporte público"

compCalor()
compCompañia()

let tmp = Console.Read()