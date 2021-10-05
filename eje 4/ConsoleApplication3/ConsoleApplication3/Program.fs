// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.
open System

[<EntryPoint>]
let main argv = 
    printfn "Hola mundo" 
    let sampleNumbers = [ 1 .. 10 ]
    let par= sampleNumbers |> List.filter (fun x -> x%2=0)
    let imp= sampleNumbers |> List.filter (fun x -> x%2<>0)
    printf "\n%A" sampleNumbers
    printf "\n%A" par
    printf "\n%A" imp
    
    

    Console.ReadKey() |> ignore
    0 // devolver un código de salida entero
