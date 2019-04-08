module Dice
open System

let mutable rng = Random() 

type Dice = First = 1 
            | Second = 2 
            | Third = 3 
            | Fourth = 4 
            | Fifth = 5
            | Sixth = 6


let roll = (fun () -> rng.Next (1, Enum.GetNames(typedefof<Dice>).Length + 1) )
   
let diceRoll = (fun () -> enum<Dice> (roll ()))
