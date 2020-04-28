//linux fsharpc Program.fs && ./a.out

open System

let rec rep acu sum=
    match gasto with
        | gasto when gasto <> -1 -> acu
        | _ ->
            printf "SUE: "
            let sue = Convert.ToInt32(Console.ReadLine())
            rep (sum + gasto) gasto

let prnt ()=
    let gasto = Convert.ToInt32(Console.ReadLine())
    let res = rep 0 gasto
    printfn "%A" res

prnt()

let tmp = Console.Read()
