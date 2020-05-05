//linux fsharpc Program.fs && ./a.out

open System

let rec rep ()=
    let num = Convert.ToInt32(Console.ReadLine())
    match num with
        //| num when num <> -1 -> ()
        | -1 -> ()
        | _ ->
            let CUB = pown num 3
            printfn "%A" CUB
            rep ()

rep()

let tmp = Console.Read()
