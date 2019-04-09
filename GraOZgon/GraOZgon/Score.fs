module Score

open Player

let Score p = 
    let counts = p.Hand |> Array.countBy id |> Array.sortBy (fun x -> snd x, fst x) |> Array.rev
    match counts with
    | [|(_, 5)|]  -> "Poker"
    | [|(_,4); _|] -> "Kareta"
    | [|(_,3); (_,2)|] -> "Full"
    | [|(_,3); (_,1); (_,1)|] -> "Trójka"
    | [|(_,2); (_,2); _|] -> "Dwie pary"
    | [|(_,2); _; _|] -> "Para"
    | [|(_,1); _; _; _;_|] -> "Gówno"
    | failwith -> "Coś sie jebło"



let PrintScore p =  Score p