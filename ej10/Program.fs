//linux fsharpc Program.fs && ./a.out

open System

let input () =
    printf "clave: "
    let clave = Convert.ToInt32(Console.ReadLine())
    printf "numin: "
    let numin = Convert.ToDouble(Console.ReadLine())
    (clave,numin)

let filter ()=
    let (a, b) = input()
    match a with
        | 12 -> b * 2.0
        | 15 -> b * 2.2
        | 18 -> b * 4.5
        | 19 -> b * 5.5
        | a when a = 23 || a = 25 -> b * 6.0
        | 29 -> b * 5.0

let prnt ()=
    let costo = filter()
    printfn "Costo total de la llamada %A" costo

prnt()
let tmp = Console.Read()