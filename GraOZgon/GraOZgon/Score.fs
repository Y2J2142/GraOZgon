module Score

open Player

let Score p = 
    let counts = p.Hand |> Array.countBy id |> Array.sortBy (fun x -> snd x, fst x) |> Array.rev 
    match counts with
    | [|(_, 5)|]  -> "Poker"
    | [|(_,4); _|] -> "Kareta"
    | [|(6,1); (5,1); (4,1); (3,1); (2,1)|] -> "Duży Strit"
    | [|(_,3); (_,2)|] -> "Full"
    | [|(5,1); (4,1); (3,1); (2,1); (1,1)|] -> "Gówno Strit"
    | [|(_,3); (_,1); (_,1)|] -> "Trójka"
    | [|(_,2); (_,2); _|] -> "Dwie pary"
    | [|(_,2); _ ; _ ; _|] -> "Para"
    | [|(_,1); _ ; _ ; _ ; _|] -> "Gówno"
    | failwith -> "Somethings Fucky"



let PrintScore p =  Score p