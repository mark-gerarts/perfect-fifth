module P5Reference.Environment.PixelDensity0

open P5.Core
open P5.Shape
open P5.Environment

let draw p5 =
    let width = width p5 |> float
    let height = height p5 |> float

    setPixelDensity p5 1
    circle p5 (width / 2.0) (height / 2.0) 50

let run node = display node draw
