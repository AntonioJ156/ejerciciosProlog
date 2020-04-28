//linux fsharpc Program.fs && ./a.out

open System

let input () =
    printfn "a:"
    let a = Convert.ToDouble(Console.ReadLine())
    a
(*
let filter2 ()=
    let a = input()
    match a with
        | a when a = 0.0 -> printfn "NULO"
        | _ ->
            if -1.0**a > 0.0
                then printfn "PAR"
            else printfn "IMPAR"
*)
            
let filter ()=
    let a = input()
    if a = 0.0
        then printfn "NULO"
    elif -1.0**a > 0.0
        then printfn "PAR"
    else printfn "IMPAR"

filter()
let tmp = Console.Read()