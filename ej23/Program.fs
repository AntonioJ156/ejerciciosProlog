// Learn more about F# at http://fsharp.org

open System

let input () =
    let n = Convert.ToInt32(Console.ReadLine())
    n

let cmp num =
    if num > 0
        then (num, 0, 1)
    else (0, num, 0)

let res sumOtr sumPos cuePos n =
    let proGen = (sumPos+sumOtr)/n
    let proPos = sumPos/cuePos
    printf "%A, %A, %A" cuePos proPos proGen
    
let rec rep sumOtr sumPos cuePos i n =
    match i with
    | i when i > n -> res sumOtr sumPos cuePos n
    | _ ->
        let num = input()
        let (nSumPos, nSumOtr, nCuePos) = cmp num
        rep (sumOtr+nSumOtr) (sumPos+nSumPos) (cuePos+nCuePos) (i+1) n
        
let n = input()
rep 0 0 0 1 n