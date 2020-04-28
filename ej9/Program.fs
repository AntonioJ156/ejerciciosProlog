//linux fsharpc Program.fs && ./a.out

open System

let input () =
    printf "pruebas: "
    let pruebas = Convert.ToDouble(Console.ReadLine())
    pruebas

let filter ()=
    let pruebas = input()
    match pruebas with
        | pruebas when pruebas > 500.0 -> (pruebas, 20.0 * 0.3 + (pruebas - 40.0) * 0.5 )
        | pruebas when pruebas > 40.0 -> (pruebas, 20.0 * 0.3 + (pruebas - 40.0) * 0.4)
        | pruebas when pruebas > 20.0 -> (pruebas, (pruebas - 20.0) * 0.3)
        | pruebas when pruebas <= 20.0 -> (pruebas, 0.0)

let prnt ()=
    let (pruebas, imp) = filter()
    printfn "%A %A" pruebas (pruebas + imp)

prnt()
let tmp = Console.Read()