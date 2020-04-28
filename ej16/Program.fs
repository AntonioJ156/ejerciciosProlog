//linux fsharpc Program.fs && ./a.out

open System
open System

let input ()=
    printf "IN: "
    let n = Convert.ToInt32(Console.ReadLine())
    n

let rec rep cont acu n=
    match cont with
        | cont when cont <= n -> acu
        | _ ->
            let num = input()
            if num = 0
                then rep (cont + 1)(acu + 1) n
            else rep (cont + 1) acu n

let prnt ()=
    let n =  input()
    let res = rep 1 0 n
    printfn "%A" res

prnt()

let tmp = Console.Read()