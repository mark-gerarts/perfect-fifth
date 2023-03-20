module P5Reference.Environment.Describe1

open P5.Core
open P5.Shape
open P5.Environment
open P5.Color

let setup p5 =
    fill p5 (RGB(0, 255, 0))
    0.0

let update _ x = if x > 100.0 then 0.0 else x + 0.1

let draw (p5: P5) x =
    background p5 (Grayscale 220)
    circle p5 x 50 40
    describe p5 (sprintf "green circle at x pos %A moving to the right" x)

let run node = simulate node setup update draw
