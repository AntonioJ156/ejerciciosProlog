// Learn more about F# at http://fsharp.org

open System

let input () =
    let n = Convert.ToInt32(Console.ReadLine())
    n
    
let cmp num =
    if pown num -1 > 0
        then num / 2
    else (num*3) + 1
    
let rec rep num =
    match num with
    //| num when num <> -1 -> printf "%A" num
    | -1 -> printf "%A" num
    | _ ->
        printf "%A" num
        rep (cmp num)

let cmp2 num =
    if num > 0
        then rep num
    else printf "NUM tiene que ser un entero positivo"
    
let num = input()
cmp2 num