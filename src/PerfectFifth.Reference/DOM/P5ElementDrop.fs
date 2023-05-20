module P5Reference.DOM.P5ElementDrop

open P5.Core
open P5.Color
open P5.Environment
open P5.Shape
open P5.Rendering
open P5.DOM
open P5.Typography
open Browser.Types

let gotFile p5 (file: File) =
    background p5 (Grayscale 200)
    text p5 "received file:" (width p5 / 2 |> float) (height p5 / 2 |> float)
    text p5 file.name (width p5 / 2 |> float) (height p5 / 2 + 50 |> float)

let setup p5 =
    let c = createCanvasAndReturn p5 100 100
    let c' = unbox<P5Element<Unit>> c
    background p5 (Grayscale 200)
    setTextAlign p5 { defaultTextAlign with horizontal = HorizontalAlign.Center }
    text p5 "drop file" (width p5 / 2 |> float) (height p5 / 2 |> float)

    c'.drop (gotFile p5)

let draw p5 _ = ()

let run node = animate node setup draw
