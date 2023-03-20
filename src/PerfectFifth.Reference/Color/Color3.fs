module P5Reference.Color.Color3

open P5.Core
open P5.Color
open P5.Shape

let draw p5 =
    // Example of hex color codes
    noStroke p5
    let c = color p5 (Name "#0f0")
    fill p5 (P5Color c)
    rect p5 0 10 45 80
    fill p5 (Name "#00ff00")
    rect p5 55 10 45 80

let run node = display node draw
