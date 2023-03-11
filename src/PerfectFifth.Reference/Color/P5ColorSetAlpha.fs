module P5Reference.Color.P5ColorSetAlpha

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape

let draw p5 t =
    let t' = float t / 1000.0
    let width = width p5 |> float
    let height = height p5 |> float

    clear p5
    background p5 (Grayscale 200)

    let squareColor = color p5 (RGB(100, 50, 100))
    squareColor.setAlpha (128.0 + 128.0 * sin t')
    fill p5 (P5Color squareColor)

    rect p5 13 13 (width - 26.0) (height - 26.0)
    describe p5 "canvas with gradually changing opacity on a gray background"

let run node = animate node noSetup draw
