// Learn more about F# at http://fsharp.org

open System
        
let cmp (sumPar:int, sumImp:int, cuePar:int) (num:int)=
    if pown num -1 > 0
        then (sumPar+num, sumImp, cuePar+num)
    else (sumPar, sumImp+num, cuePar)
    
let res sumPar cuePar =
    let proPar = sumPar/cuePar
    printfn "%A" proPar

let rec rep (sumPar, sumImp, cuePar) i =
    match i with
    | 271 -> res sumPar cuePar
    | _ ->
        let num = Convert.ToInt32(Console.ReadLine())
        if num <> 0
            then
                let newLst = cmp (sumPar, sumImp, cuePar) num
                rep newLst (i+1)
        else rep (sumPar, sumImp, cuePar) (i+1)

rep (0, 0, 0) 1