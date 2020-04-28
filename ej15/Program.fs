//linux fsharpc Program.fs && ./a.out

open System

let rec rep cont acu=
    match cont with
        | 11 -> acu
        | _ ->
            printf "SUE: "
            let sue = Convert.ToInt32(Console.ReadLine())
            rep (cont + 1)(acu + sue)

let prnt ()=
    let res = rep 1 0
    printfn "%A" res

prnt()

let tmp = Console.Read()