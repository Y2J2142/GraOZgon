module GraOZgon
open Player
open System
open Score


[<EntryPoint>]
let main argv =
    let numberOfPlayers = int argv.Length
    let mutable players = argv |> Array.map (fun n -> {Name = n; Hand = [||]})
    players <- players |> Array.map RollAndSort
    players |> Array.map (fun p -> (printfn "%s %s" (Print p)  (PrintScore p))) |> ignore
    0 // return an integer exit code
