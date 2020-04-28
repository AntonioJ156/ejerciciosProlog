//linux fsharpc Program.fs && ./a.out

open System

let input () =
    printf "MAT: "
    let mat = Console.ReadLine()
    printf "CARR: "
    let carr = Console.ReadLine()
    printf "SEM: "
    let sem = Convert.ToInt32(Console.ReadLine())
    printf "PROM: "
    let prom = Convert.ToDouble(Console.ReadLine())
    (mat,carr,sem,prom)

let compEco (mat, carr, sem, prom) compS compP=
    if sem >= compS && prom >= compP
        then printfn "%A %A Aceptado" mat carr

let compGen (mat, carr, sem, prom) compS compP=
    if sem > compS && prom > compP
        then printfn "%A %A Aceptado" mat carr

let filter ()=
    let (mat,carr,sem,prom) = input()
    match carr with
        | "Economia" -> compEco (mat,carr,sem,prom) 6 8.8
        | "Computacion" -> compGen (mat,carr,sem,prom) 6 8.5
        | carr when carr = "Contabilidad" || carr = "Administracion" -> compGen (mat,carr,sem,prom) 5 8.5

filter()

let tmp = Console.Read()