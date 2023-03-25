module P5Reference.Structure.Remove

open P5.Core
open P5.Shape

let draw p5 _ = circle p5 50 50 10

let eventHandler p5 event s =
    match event with
    | MousePressed _ -> remove p5
    | _ -> ()

    s

let run node =
    play node noSetup noUpdate draw eventHandler
