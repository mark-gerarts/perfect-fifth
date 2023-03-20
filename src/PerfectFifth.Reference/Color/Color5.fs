module P5Reference.Color.Color5

open P5.Core
open P5.Color
open P5.Shape

let draw p5 =
    // HSL color can also be specified by value
    let c = color p5 (Name "hsl(160, 100%, 50%)")
    noStroke p5
    fill p5 (P5Color c)
    rect p5 0 10 45 80

    fill p5 (Name "hsla(160, 100%, 50%, 0.5)")
    rect p5 55 10 45 80

let run node = display node draw
