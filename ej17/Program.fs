//linux fsharpc Program.fs && ./a.out

open System

let input () =
    printf "gasto: "
    let n = Convert.ToInt32(Console.ReadLine())
    n

let rec rep sumGas=
    let gasto = input()
    match gasto with
        | gasto when gasto <> -1 -> sumGas
        | _ ->
            printf "SUE: "
            let sue = Convert.ToInt32(Console.ReadLine())
            rep (sumGas + gasto)

let prnt ()=
    let res = rep 0
    printfn "%A" res

prnt()

let tmp = Console.Read()
