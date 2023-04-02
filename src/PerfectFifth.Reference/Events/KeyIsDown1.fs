module P5Reference.Events.KeyIsDown1

open P5.Core
open P5.Color
open P5.Shape
open P5.Rendering
open P5.Events

let setup p5 =
    createCanvas p5 512 512
    50

let update p5 d =
    match d with
    | d when keyIsDown p5 107 -> d + 1
    | d when keyIsDown p5 187 -> d + 1
    | d when keyIsDown p5 109 -> d - 1
    | d when keyIsDown p5 189 -> d - 1
    | d -> d

let draw p5 d =
    clear p5
    fill p5 (RGB(255, 0, 0))
    circle p5 50 50 (float d)

let run node = simulate node setup update draw
