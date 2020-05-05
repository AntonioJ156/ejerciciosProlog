//linux fsharpc Program.fs && ./a.out

open System

let input () =
    printf "num: "
    let num = Convert.ToDouble(Console.ReadLine())
    num

let filter ()=
    let compra = input()
    match compra with
        | compra when compra < 500.0 -> compra
        | compra when compra <= 1000.0 -> compra - (compra * 0.05)
        | compra when compra <= 7000.0 -> compra - (compra * 0.11)
        | compra when compra <= 15000.0 -> compra - (compra * 0.18)
        | compra when compra > 15000.0 -> compra - (compra * 0.25)

let prnt ()=
    let pagar = filter()
    printfn "%A" pagar

prnt()
let tmp = Console.Read()