module P5Reference.Math.NoiseSeed

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Math

let setup p5 =
    noiseSeed p5 99
    stroke p5 (GrayscaleA(0, 10))

    0.0

let update _ xoff = xoff + 0.01

let draw p5 xoff =
    let n = (noise p5 xoff) * (width p5 |> float)
    line p5 n 0 n (height p5 |> float)

let run node = simulate node setup update draw
