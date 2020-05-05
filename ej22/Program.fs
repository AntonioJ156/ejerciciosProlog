// Learn more about F# at http://fsharp.org

open System

let input () =
    printf "SUE: "
    let n = Convert.ToDouble(Console.ReadLine())
    n
    
let cmp sue =
    if sue < 1000.0
        then sue*1.15
    else sue*1.12

let rec rep nom =
    let sue = input()
    match sue with
    //| sue when sue <> -1.0 -> printfn "%A" nom
    | -1.0 -> printfn "%A" nom
    | _ ->
        let NSUE = cmp sue
        printf "NSUE: %A" NSUE
        rep (nom+NSUE)

rep 0.0