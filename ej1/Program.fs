//linux fsharpc Program.fs && ./a.out
module ej1

open System

let input () =
    printf "Primer valor: "
    let n1 = Convert.ToInt64(Console.ReadLine())
    printf "Segundo valor: "
    let n2 = Convert.ToInt64(Console.ReadLine())
    (n1, n2)

(*let comp2 ()=
    let tuple = input()
    match tuple with
        | (a, b) when a > b -> (a, b, a)
        | (a, b) -> (a, b, b)
*)

let comp ()=
    let (a, b) = input()
    if a > b
        then (a, b, a)
    else (a, b, b)
 

let mayor () =
    let (a, b, c) = comp()
    printfn "El mayor entre %i y %i" a b
    printfn "es %i" c

mayor()
let tmp = Console.Read()