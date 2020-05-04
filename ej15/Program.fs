//linux fsharpc Program.fs && ./a.out

open System

let rec rep i nom=
    match i with
        | 11 -> nom
        | _ ->
            printf "SUE: "
            let sue = Convert.ToInt32(Console.ReadLine())
            rep (i + 1)(nom + sue)

let prnt ()=
    let res = rep 1 0
    printfn "%A" res

prnt()

let tmp = Console.Read()