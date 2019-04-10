module GraOZgon
open Player
open System
open Score

[<EntryPoint>]
let main argv =
    let mutable players = argv |> Array.map (fun n -> {Name = n; Hand = [||]})
    while players.Length > 1 do
        players <- players |> Array.map RollAndSort
        players |> Array.map (fun p -> (printfn "%s %s"(Print p)  (PrintScore p))) |> ignore
        let playerToRemove = Console.ReadLine ()
        players <- players |> Array.filter (fun p -> p.Name <> playerToRemove) 
        Console.Clear()
        if players.Length = 1 then printfn "Ostatni na placu boju : %s" players.[0].Name
    0 // return an integer exit code
