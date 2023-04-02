module P5Reference.Events.PRotationY

open P5.Core
open P5.Events
open P5.Environment

let draw p5 _ =
    let rY = rotationY p5 + 180.0
    let pRY = pRotationY p5 + 180.0

    let direction =
        match rY - pRY with
        | x when x > 0 && x < 270 -> "clockwise"
        | x when x < -270 -> "clockwise"
        | x when x < 0 || x > 270 -> "counter-clockwise"
        | _ -> "clockwise"

    print p5 direction

let run node = animate node noSetup draw
