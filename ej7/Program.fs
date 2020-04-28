//linux fsharpc Program.fs && ./a.out

open System

let input () =
    printf "A: "
    let a = Convert.ToInt32(Console.ReadLine())
    printf "B: "
    let b = Convert.ToInt32(Console.ReadLine())
    printf "C: "
    let c = Convert.ToInt32(Console.ReadLine())
    (a,b,c)

let filter ()=
    let (a,b,c) = input()
    if a < b
        then if b < c
                then printfn "Los números están en orden creciente"
             else printfn "Los números no están en orden creciente"
    else printfn "Los números no están en orden creciente"

filter()
let tmp = Console.Read()