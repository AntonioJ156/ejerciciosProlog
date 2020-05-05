//linux fsharpc Program.fs && ./a.out

open System

let input () =
    printf "SUE: "
    let sue = Convert.ToInt32(Console.ReadLine())
    printf "CATE: "
    let cate = Convert.ToInt32(Console.ReadLine())
    printf "HE: "
    let he = Convert.ToInt32(Console.ReadLine())
    (sue,cate,he)

let filter ()=
    let (sue, cate, he) = input()
    match cate with
        | 1 -> (sue, 30, he)
        | 2 -> (sue, 38, he)
        | 3 -> (sue, 50, he)
        | 4 -> (sue, 70, he)
        | _ -> (sue, 0, he)

let comp ()=
    let (sue, phe, he) = filter()
    if he > 30
        then sue + (30 * phe)
    else sue + (he * phe)

let prnt ()=
    let costo = comp
    printfn "%A" costo

prnt()
let tmp = Console.Read()