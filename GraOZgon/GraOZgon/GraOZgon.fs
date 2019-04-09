module GraOZgon
open Player
open System

[<EntryPoint>]
let main argv =
    let numberOfPlayers = int argv.Length
    let mutable players = argv |> Array.map (fun n -> {Name = n; Hand = [||]})
    players <- players |> Array.map RollAndSort
    0 // return an integer exit code
