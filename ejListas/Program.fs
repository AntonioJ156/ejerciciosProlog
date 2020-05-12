//Insertar en el medio de la lista

let rec fnContar (lista:int list) (listaAnt:int list) mid cont=
    match cont with
    | cont when cont >= mid -> listaAnt
    | _ -> 
        let item = lista.Item(cont)::[]
        let listaRes = listaAnt @ item
        fnContar lista listaRes mid (cont+1) 

(*let fnLista (lista:int list) elemento =
    let largo = lista.Length
    let mid = largo/2
    let primeraMitad = fnContar lista [] mid 0
    let segundaMitad = fnContar lista [] largo mid
    let listaRes = primeraMitad @ elemento::[] @segundaMitad
    listaRes*)

//Insertar dependiendo del orden

let rec cmp (lista:int list) elemento cont=
    if elemento > lista.Item(cont) then
        cmp lista elemento (cont+1)
    else
        cont

let rec fnLista (lista:int list) elemento =
    let largo = lista.Length
    let mid = cmp lista elemento 0    
    let primeraMitad = fnContar lista [] mid 0
    let segundaMitad = fnContar lista [] largo mid
    let listaRes = primeraMitad @ elemento::[] @segundaMitad
    listaRes

let lis = [6;13;546;123]
let lista = fnLista [1;2;4;5;7] (lis.Item(0))
printfn "%A" lista