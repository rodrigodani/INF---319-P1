// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.
open System;

[<EntryPoint>]
let main argv = 
    printfn "Hola mundo" 
    let a = 5;
    let b = 5;
    let rec mult a b : int= 
       if a = 0 then 0 else b + mult (a-1) b    
    
    let result=mult 20 2  
        
    printf "\n%A" result



    Console.ReadKey() |> ignore
    0 // devolver un código de salida entero
