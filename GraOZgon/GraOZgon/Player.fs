module Player
open System

[<Struct>]
type Player = {Name:string; Hand:int array}

let Print p = p.Name + " [" + String.Join(",", p.Hand) + "]"

let RollHand p: Player = {p with Hand = [|for _ in 1..5 do yield Dice.Roll ()|]}

let SortHand p = 
    let counts = p.Hand |> Array.countBy id 
                        |> Array.sortBy (fun x -> snd x, fst x) 
                        |> Array.rev 
    let hand = counts |> Array.collect (fun x -> [| for _ in 1..snd x do yield fst x|])
    {p with Hand = hand}


let RollAndSort = RollHand >> SortHand