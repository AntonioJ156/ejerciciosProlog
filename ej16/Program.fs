//linux fsharpc Program.fs && ./a.out

open System
open System

let input ()=
    printf "IN: "
    let n = Convert.ToInt32(Console.ReadLine())
    n

let rec rep i cuecer n=
    match i with
        | cont when cont <= n -> cuecer
        | _ ->
            let num = input()
            if num = 0
                then rep (i + 1)(cuecer + 1) n
            else rep (i + 1) cuecer n

let prnt ()=
    let n =  input()
    let res = rep 1 0 n
    printfn "%A" res

prnt()

let tmp = Console.Read()