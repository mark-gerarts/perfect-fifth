module P5Reference.Structure.Draw

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape

let setup p5 =
    setFrameRate p5 30
    0

let update p5 yPos =
    match yPos - 1 with
    | yPos when yPos < 0 -> height p5
    | yPos -> yPos

let draw p5 yPos =
    let width = width p5 |> float
    background p5 (Grayscale 204)
    line p5 0 (float yPos) width (float yPos)

let run node = simulate node setup update draw
