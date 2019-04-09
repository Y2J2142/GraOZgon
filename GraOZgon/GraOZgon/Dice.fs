module Dice
open System

let mutable rng = Random() 

let Roll = fun () -> rng.Next (1, 6) 

