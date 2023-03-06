module P5Reference.Environment.FrameCount

open P5.Core
open P5.Environment
open P5.Typography
open P5.Color

let setup p5 =
    setFrameRate p5 30
    setTextSize p5 30
    setTextAlign p5 { defaultTextAlign with horizontal = HorizontalAlign.Center }

let draw p5 _ =
    let width = width p5 |> float
    let height = height p5 |> float

    background p5 (Grayscale 200)
    text p5 (frameCount p5 |> string) (width / 2.0) (height / 2.0)


let run node = animate node setup draw
