//linux fsharpc Program.fs && ./a.out

open System

let input () =
    printf "TIPOENF: "
    let tipoenf = Convert.ToInt32(Console.ReadLine())
    printf "EDAD: "
    let edad = Convert.ToInt32(Console.ReadLine())
    printf "DIAS: "
    let dias = Convert.ToDouble(Console.ReadLine())
    (tipoenf,edad,dias)

let filter ()=
    let (tipoenf,edad,dias) = input()
    match tipoenf with
        | 1 -> (edad, dias * 25.0)
        | 2 -> (edad, dias * 16.0)
        | 3 -> (edad, dias * 20.0)
        | 4 -> (edad, dias * 32.0)

let comp () =
    let (edad, costo) = filter()
    if edad >= 14 && edad <= 22
        then costo * 1.1
    else costo

let prnt () =
    let costo = comp()
    printfn "Costo total %A" costo

prnt()

let tmp = Console.Read()