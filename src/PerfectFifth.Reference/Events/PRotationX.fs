module P5Reference.Events.PRotationX

open P5.Core
open P5.Events
open P5.Environment

let draw p5 _ =
    let rX = rotationX p5 + 180.0
    let pRX = pRotationX p5 + 180.0

    let direction =
        match rX - pRX with
        | x when x > 0 && x < 270 -> "clockwise"
        | x when x < -270 -> "clockwise"
        | x when x < 0 || x > 270 -> "counter-clockwise"
        | _ -> "clockwise"

    print p5 direction

let run node = animate node noSetup draw
